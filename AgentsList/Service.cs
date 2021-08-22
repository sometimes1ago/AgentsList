using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AgentsList
{
    class Service
    {
        private static string AuthorizedUser { get; set; }

        /// <summary>
        /// Метод, двигающий лейбл после авторизации пользователя
        /// </summary>
        /// <param name="UserLabel">Элемент управления, который необходимо передвинуть</param>
        public static void MoveUserLabel(Label UserLabel, double Multiplyer = 0.88)
        {
            int StartX = UserLabel.Location.X;
            int StartY = UserLabel.Location.Y;
            double LabelWidth = UserLabel.Width;
            double AddToWidth = LabelWidth * Multiplyer;
            int NewLocation = Convert.ToInt32(Math.Round(AddToWidth)) + Convert.ToInt32(LabelWidth);
            UserLabel.Location = new Point(StartX - NewLocation, StartY);
        }

        /// <summary>
        /// Метод, записывающий авторизовавшегося пользователя
        /// </summary>
        /// <param name="UserLogin">Логин пользователя, который авторизовался</param>
        public static void SetAuthorizedUser(string UserLogin)
        {
            AuthorizedUser = UserLogin;
        }

        public static string GetAuthorizedUser()
        {
            return AuthorizedUser;
        }

        /// <summary>
        /// Метод, проверяющий авторизован ли пользователь в приложении
        /// </summary>
        /// <returns>True или False в зависимости результата проверки</returns>
        public static bool IsAuthorized()
        {
            if (!string.IsNullOrEmpty(AuthorizedUser))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод, деактивирующий элементы управления, зависящие от авторизации пользователя
        /// </summary>
        /// <param name="ControlsList">Список элементов для деактивации</param>
        public static void DeactivateControlNoAuthUser(List<Control> ControlsList)
        {
            if (!IsAuthorized())
            {
                foreach (Control control in ControlsList)
                {
                    control.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Метод, записывающий в лейбл какой пользователь авторизовался для перехода в личный кабинет
        /// </summary>
        /// <param name="Label">Лейбл с ссылкой на авторизацию</param>
        /// <returns>Измененный лейбл, в зависимости от авторизованного пользователя</returns>
        public static object SetGreetingsLabel(string Label)
        {
            if (IsAuthorized())
            {
                string Query = "select * from Test";
                DataSet Result = (DataSet)Database.Select(Query);
                return Result;
                
            }
            else
            {
                return Label;
            }

        }



    }
}
