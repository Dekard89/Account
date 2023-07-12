using DZ3;

AccBD accBD = new AccBD();
accBD.AddNewAcc("Dmitry", "123");
accBD.AddNewAcc("Vasya", "321");

bool exit = false;





while (exit = true)
{
    InputConsoleHelper.PrintMenu();
    int action = 5;

    switch (action)
    {
        case 0:
            exit=true; break;
        case 1:
            var acc=accBD.FindAcc(InputConsoleHelper.AccInput("логин"));
            acc.JoinInAcc(InputConsoleHelper.AccInput("пароль"));
            break;
        case 3:
          var acc1= accBD.FindAcc(InputConsoleHelper.AccInput("логин"));
            acc1.ChangePassword(InputConsoleHelper.AccInput("новый пароль"));
            break;
        case 2:
            string log = InputConsoleHelper.AccInput("логин");
            string pass = InputConsoleHelper.AccInput("пароль");
            accBD.AddNewAcc(log, pass);
            break;


    }
}
