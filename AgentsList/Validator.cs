using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AgentsList
{
    class Validator
    {

        public static string NamePattern = @"^[А-Я][а-я]+(-[А-Я][а-я] +)?$";
        public static string PhonePattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
        public static string EmailPattern = @"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)";

        /// <summary>
        /// Метод, проверяющий конкретную строку на соответствие регулярному выражению
        /// </summary>
        /// <param name="ValidatableStr">Строка, которую необходимо проверить</param>
        /// <param name="ValidatePattern">Регулярное выражение, по которому осуществляется проверка</param>
        /// <returns>True или False в зависимости от результата проверки</returns>
        public static bool ValidateStr(string ValidatableStr, string ValidatePattern)
        {
            if (!string.IsNullOrEmpty(ValidatableStr))
            {
                if (!string.IsNullOrEmpty(ValidatePattern))
                {
                    Regex RegularExp = new Regex($@"{ValidatePattern}");
                    Match Valid = RegularExp.Match(ValidatableStr);

                    if (Valid.Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new ArgumentException("Паттерн по которому происходит валидация не может быть пустым!");
                }
            }
            else
            {
                throw new ArgumentException("Валидируемая строка не может быть пустой");
            }
        }

        /// <summary>
        /// Метод, проверяющий список строк на соответствие регулярному выражению
        /// </summary>
        /// <param name="StrList">Список строк, которые необходимо проверить</param>
        /// <param name="ValidatePattern">Регулярное выражение, по которому осуществляется проверка</param>
        /// <returns>Список тех строк, которые прошли проверку</returns>
        public static List<string> ValidateStr(List<string> StrList, string ValidatePattern)
        {
            if (!string.IsNullOrEmpty(StrList.ToString()))
            {
                if (!string.IsNullOrEmpty(ValidatePattern))
                {
                    Regex Pattern = new Regex(ValidatePattern);

                    List<string> ValidStrings = new List<string>();

                    for (int i = 0; i < StrList.Count; i++)
                    {
                        Match NamesMatch = Pattern.Match(StrList[i]);

                        if (NamesMatch.Success)
                        {
                            ValidStrings.Add(StrList[i]);
                        }
                        else
                        {
                            continue;
                        }
                    }

                    return ValidStrings;
                }
                else
                {
                    throw new ArgumentException("ValidatePattern не может быть пустым!");
                }
            }
            else
            {
                throw new ArgumentException("Список с именами для проверки не может бысть пустым!");
            }
        }
    }
}
