using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentsList
{
    class Database
    {
        private static readonly string ConnStr = @"Data Source=DESKTOP-Q8AEUVR\SQLEXPRESS; Initial Catalog = AgentsList; Integrated Security=true";
        public static DataSet ds;
        private static SqlDataAdapter sqlad;
        private static SqlCommand comnd;

        /// <summary>
        /// Метод, возвращающий результат выполнения запроса. Подходит только для SELECT
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        /// <param name="Params">Список параметров. По умолчанию пустой. Параметры в запросе нумеруются от 0 до n. 
        /// Для выполнения без параметров передается null</param>
        /// <returns>Строки данных записанные в экземпляр класса Dataset объект ds</returns>
        public static object Select(string QueryString, List<string> Params = null)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();
                comnd = new SqlCommand(QueryString, sqlconn);
                sqlad = new SqlDataAdapter(QueryString, ConnStr);
                ds = new DataSet();

                if (Params != null)
                {
                    for (int i = 0; i < Params.Count; i++)
                    {
                        comnd.Parameters.AddWithValue($@"@{i}", Params[i]);
                    }

                    sqlad.SelectCommand = comnd;
                    sqlad.SelectCommand.ExecuteNonQuery();
                }
                else
                {
                    sqlad.SelectCommand = comnd;
                    sqlad.SelectCommand.ExecuteNonQuery();
                }

                sqlad.Fill(ds);
                sqlconn.Close();
                return ds.Tables[0];
            }
        }

        public static void ExecuteProcedure(string ProcedureName, List<string> ProcedureParameters = null)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();

                //Шаблон запроса
                string PreBuildedQuery = $@"execute {ProcedureName} ";
                
                //Готовый запрос
                string BuildedQuery;

                //Проверка на пустоты и null значение имени процедуры
                if (!ProcedureName.Equals("") && ProcedureName != null)
                {
                    //Проверка на количество параметров процедуры
                    if (ProcedureParameters.Count > 0)
                    {
                        //Построение запроса с специальными SQL метками
                        for (int i = 0; i < ProcedureParameters.Count; i++)
                        {
                            PreBuildedQuery += $@"@{i},";
                        }

                        //Удаление последней запятой из запроса, которая появляется из-за цикла
                        BuildedQuery = PreBuildedQuery.Substring(0, PreBuildedQuery.Length - 1);

                    }
                    else
                    {
                        BuildedQuery = PreBuildedQuery;
                    }

                   comnd = new SqlCommand(BuildedQuery, sqlconn);

                    //Передача параметров в подготовленный запрос
                    for (int i = 0; i < ProcedureParameters.Count; i++)
                    {
                        comnd.Parameters.AddWithValue($@"@{i}", ProcedureParameters[i]);
                    }

                    //Выполнение запроса и закрытие соединения к БД
                    comnd.ExecuteNonQuery();
                    sqlconn.Close();
                }
                else
                {
                    throw new ArgumentException("Имя процедуры не может быть пустым!");
                }

                
            }
        }

        public static void Insert(string TableName, List<string> FieldNames, List<string> FieldValues)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                //Проверка на пустоту и ненулевое количество Имен полей
                if (!FieldNames.Equals(null) && FieldNames.Count > 0)
                {
                    //Проверка на пустоту и ненулевое количество Значений полей
                    if (!FieldValues.Equals(null) && FieldValues.Count > 0)
                    {
                        //Проверка на совпадение количества элементов списков Имен полей и Значений полей
                        if (FieldNames.Count.Equals(FieldValues.Count))
                        {
                            sqlconn.Open();

                            //Шаблон запроса
                            string PreBuildedQuery = $@"insert into {TableName}(";

                            //Готовый запрос
                            string BuildedQuery;

                            //Начало построения запроса. Добавляем в строку все Имена полей через запятую
                            foreach (string fn in FieldNames)
                            {
                                PreBuildedQuery += fn + ",";
                            }

                            //Удаляем последнюю запятую, которая добавится из-за цикла
                            PreBuildedQuery = PreBuildedQuery.Substring(0, PreBuildedQuery.Length - 1);
                            PreBuildedQuery += ") values (";

                            //Добавляем специальные SQL метки для Значений полей
                            for (int i = 0; i < FieldValues.Count; i++)
                            {
                                PreBuildedQuery += $@"@{i},";
                            }

                            //Удаляем последнюю запятую, которая добавится из-за цикла
                            BuildedQuery = PreBuildedQuery.Substring(0, PreBuildedQuery.Length - 1);
                            BuildedQuery += ")";

                            comnd = new SqlCommand(BuildedQuery, sqlconn);

                            //Передаем Значения полей в запрос
                            for (int i = 0; i < FieldValues.Count; i++)
                            {
                                comnd.Parameters.AddWithValue($@"@{i}", FieldValues[i]);
                            }

                            //Выполнение запроса и закрытие соединения с БД
                            comnd.ExecuteNonQuery();
                            sqlconn.Close();
                        }
                        else
                        {
                            throw new Exception("Количество элементов в списке Имен полей и в списке Значений должно быть одинаковым");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Список с значениями полей не может быть null или содержать 0 значений");
                    }
                } 
                else
                {
                    throw new ArgumentException("Список с именами полей не может быть null или содержать 0 значений");
                }
            }
        }

        public void Update(string TableName, string Setter, string Value, string Condition)
        {
            throw new System.NotImplementedException();
        }


    }
}
