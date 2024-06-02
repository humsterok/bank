using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bank
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string RegistrationDate { get; set; }
        public int Balance { get; set; }
        public int Age { get; set; }
        public int Deposit { get; set; }
        public string DateOfLastAction { get; set; }
        public int YearForDeposit { get; set; }
        public string History {  get; set; }
        public string DateOfDeposit { get; set; }
        public string LastAction {  get; set; }


        public Client(int id, string name, string registrationDate, int balance, int age)
        {
            ID = id;
            Name = name;
            RegistrationDate = registrationDate;
            Balance = balance;
            Age = age;
            Deposit = 0;
            DateOfLastAction = registrationDate;
            YearForDeposit = 0;
            History = $"..\\..\\..\\histories\\history{id}";
            DateOfDeposit = "";
            LastAction = $"Створено акаунт: {registrationDate}";

        }
        public void MakeInvoice(string pathForInvoice)
        {
            using (var writer = new StreamWriter(pathForInvoice))
            {
                writer.WriteLine(this.ID);
                writer.WriteLine(this.Name);
                writer.WriteLine(this.LastAction);
            }
        }
    }
}
