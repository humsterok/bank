using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bank
{
    public class CollectionOfClients
    {
        private string Path = "..\\..\\..\\clients.txt";
        public List<Client> collectionOfClients { set; get; }
        public CollectionOfClients()
        {
            collectionOfClients = LoadClients();
        }

        public List<Client> Search(string criteria, List<Client> collection)
        {
            var result = new List<Client>();
            foreach (var cl in collection)
            {
                if (cl.Name.ToString().ToLower().Contains(criteria) ||
                    cl.RegistrationDate.ToString().ToLower().Contains(criteria) ||
                    cl.ID.ToString().ToLower().Contains(criteria) ||
                    cl.Balance.ToString().ToLower().Contains(criteria) ||
                    cl.Age.ToString().ToLower().Contains(criteria)
                ) 
                {
                    result.Add(cl);
                }

            }
            return result;
        }

        public List<Client> LoadClients()
        {
            if (!File.Exists(Path))
            {
                return new List<Client>();
            }

            try
            {
                string jsonData = File.ReadAllText(Path);
                if (string.IsNullOrWhiteSpace(jsonData))
                {
                    return new List<Client>();
                }
                return JsonSerializer.Deserialize<List<Client>>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при завантаженні клієнтів: {ex.Message}");
                return new List<Client>();
            }
        }

        public void SaveClients()
        {
            string jsonData = JsonSerializer.Serialize(collectionOfClients);
            File.WriteAllText(Path, jsonData);
        }


        public bool AddClient(Client newClient)
        {
            try
            {
                collectionOfClients.Add(newClient);
                SaveClients();

                using (var writer = new StreamWriter(newClient.History, true))
                {
                    writer.WriteLine($"Акаунт зареєстровано: {newClient.RegistrationDate}");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні клієнта: {ex.Message}");
                return false;
            }
        }
        public void AddToBalance (Client client, string addToBalance, string data)
        {
            client.Balance += Convert.ToInt32(addToBalance);
            client.DateOfLastAction = Convert.ToString(data);
            using (var writer = new StreamWriter(client.History, true))
            {
                writer.WriteLine($"Зачислено на баланс {addToBalance}: {data}");
            }
            client.LastAction = $"$Зачислено на баланс {addToBalance}: {data}";
            MessageBox.Show("Гроші успішно зачислені");
        }

        public void Withdraw (Client client, string withdraw, string data)
        {
            client.Balance -= Convert.ToInt32(withdraw);
            client.DateOfLastAction = data;
            using (var writer = new StreamWriter(client.History, true))
            {
                writer.WriteLine($"Знято з балансу {withdraw}: {data}");
            }
            client.LastAction = $"Знято з балансу {withdraw}: {data}";

            MessageBox.Show("Гроші успішно зняті");
        }
        public void TrasferToDeposit (Client client, string transferToDeposit, string data, string term)
        {
            client.Balance -= Convert.ToInt32(transferToDeposit);
            client.Deposit += Convert.ToInt32(transferToDeposit);
            client.DateOfLastAction = data;
            client.YearForDeposit = Convert.ToInt32(term);
            using (var writer = new StreamWriter(client.History, true))
            {
                writer.WriteLine($"Переведено з балансу на депозит {transferToDeposit}: {data}");
            }
            client.LastAction = $"Переведено з балансу на депозит {transferToDeposit}: {data}";

            MessageBox.Show("Гроші успішно переведені на депозит");
            DateTime.TryParseExact(data, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime Date);
            DateTime expectedCompletionDate = Date.AddYears(client.YearForDeposit);
            client.DateOfDeposit = expectedCompletionDate.ToString("dd.MM.yyyy");
        }
        public void AddDepositToBalance (Client client, string data)
        {
            int money = client.Deposit;
            for (int i = 1; i <= client.YearForDeposit; i++)
            {
                money = (int)Math.Round(money * 1.05);
            }
            client.Balance += Convert.ToInt32(money);
            using (var writer = new StreamWriter(client.History, true))
            {
                writer.WriteLine($"Отримано гроші з депозиту на баланс {money}: {data}");
            }
            client.Deposit = 0;
            client.YearForDeposit = 0;
            client.DateOfLastAction = data;
            client.DateOfDeposit = "";
            client.LastAction = $"Отримано гроші з депозиту на баланс {money}: {data}";
            MessageBox.Show("Гроші успішно отримані з депозиту");
        }
    }
}