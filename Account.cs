using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    public class Account
    {
        public string Login { get; init; }

        public string Password { get; set; }

        public bool IsActive { get; init; }

        public Account(string login, string password)
        {
            login = Login;
            password = Password;
            IsActive = true;
        }
        public void JoinInAcc(string pass)
        {
            if (pass == Password)
            {
                InputConsoleHelper.PrintLine("вход выполнен", ConsoleColor.Green);
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadFileAsync(new Uri("https://www.google.com/search?sxsrf=AB5stBgl4imX5nbO-WFh3B04u1tMUK4lYA:1689253431097&q=%D0%BA%D0%BE%D1%82%D0%B8%D0%BA%D0%B8&tbm=isch&sa=X&ved=2ahUKEwiMwMi134uAAxWuFBAIHbn9CosQ0pQJegQIDBAB&biw=1920&bih=947&dpr=1#imgrc=c6SaZH5czd1bQM"), "C:\\Users\\Asus\\OneDrive\\Рабочий стол\\1.jpeg");
                }

            }
            else
                InputConsoleHelper.PrintLine("пароль неверный", ConsoleColor.Red);
        }
        public void ChangePassword(string pass)
        {
            Password= pass;
        }

    }
}
