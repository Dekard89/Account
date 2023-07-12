using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DZ3
{
    public class AccBD
    {
       private List<Account> accounts;

        public delegate void InputHandler(string messege);

        public event InputHandler MessegeHandler;

        public AccBD()
        {
            accounts = new List<Account>();
        }
       public void AddNewAcc(string login, string password)
        {
            foreach (var account in accounts)
            {
                if(account.Login != login)
                {
                    accounts.Add(new Account(login,password));
                }
            }
        }
        public Account? FindAcc(string login)
        {
            var acc=accounts.FirstOrDefault(x=>x.Login==login);
            
            return acc;
        }
        public void WriteToJSON(string path)
        {
            var listJSON = JsonSerializer.Serialize(accounts);
            File.WriteAllText(path,listJSON);
        }
        public void ReadOnJSON(string path)
        {
            var text = File.ReadAllText(path);
            var newList=JsonSerializer.Deserialize<List<Account>>(text);
    
            accounts.AddRange(newList);
            accounts.Distinct();
        }

    }
}
