using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bank
{
    public partial class EditClientForm : Form
    {
        private Client client { set; get; }

        private CollectionOfClients collectionOfClients;

        public EditClientForm(Client cl, CollectionOfClients collection)
        {
            InitializeComponent();
            client = cl;
            collectionOfClients = collection;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }


        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Data.Text == "")
            {
                MessageBox.Show("Введіть дату");
                return;
            }
            if (!DateTime.TryParseExact(Data.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime Date))
            {
                MessageBox.Show("Дата повинна бути у форматі дд.мм.рррр");
                Data.Clear();
                return;
            }
            if (!DateTime.TryParseExact(client.DateOfLastAction, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime lastActionDate))
            {
                MessageBox.Show("Невірний формат дати останньої операції");
                return;
            }

            if (Date < lastActionDate)
            {
                MessageBox.Show("Дата не може бути раніше дати останньої операції");
                Data.Clear();
                return;
            }
            if (!int.TryParse(AddToBalance.Text, out int balance) && AddToBalance.Text != "")
            {
                MessageBox.Show("Покласти можна тільки цілу суму");
                AddToBalance.Clear();
                return;
            }

            if (!int.TryParse(Withdraw.Text, out int withdrawAmount) && Withdraw.Text != "")
            {
                MessageBox.Show("Зняти можна тільки цілу суму");
                Withdraw.Clear();
                return;
            }
            if (!int.TryParse(FromBalanceToDeposit.Text, out int transferAmount) && FromBalanceToDeposit.Text != "")
            {
                MessageBox.Show("Перевести на депозит можна тільки цілу суму");
                FromBalanceToDeposit.Clear();
                return;
            }

            if (AddToBalance.Text != "")
            {
                collectionOfClients.AddToBalance(client, AddToBalance.Text, Data.Text);
                AddToBalance.Clear();
            }
            if (Withdraw.Text != "")
            {
                if (Convert.ToInt32(Withdraw.Text) > client.Balance)
                {
                    MessageBox.Show("Недостатньо коштів на рахунку");
                    Withdraw.Clear();
                    return;
                }
                collectionOfClients.Withdraw(client, Withdraw.Text, Data.Text);
                Withdraw.Clear();
            }
            if (FromBalanceToDeposit.Text != "")
            {
                if (Term.Text == "")
                {
                    MessageBox.Show("Кількість років повинна бути вказана");
                    return;
                }
                if (!int.TryParse(Term.Text, out int termin))
                {
                    MessageBox.Show("Кількість років повинна бути цілочисельна");
                    Term.Clear();
                    return;
                }
                if (Convert.ToInt32(Term.Text) == 0)
                {
                    MessageBox.Show("Кількість років повинна бути не 0");
                    Term.Clear();
                    return;
                }
                if (Convert.ToInt32(FromBalanceToDeposit.Text) > client.Balance)
                {
                    MessageBox.Show("Недостатньо коштів на рахунку");
                    FromBalanceToDeposit.Clear();
                    return;
                }
                collectionOfClients.TrasferToDeposit(client, FromBalanceToDeposit.Text, Data.Text, Term.Text);

                Term.Clear();
                FromBalanceToDeposit.Clear();

            }
            Data.Clear();
            collectionOfClients.SaveClients();
        }

        private void UpdateDataOfClient_Click(object sender, EventArgs e)
        {
            dataBox.Items.Clear();
            dataBox.Items.Add("ID: " + Convert.ToString(client.ID));
            dataBox.Items.Add("Name: " + Convert.ToString(client.Name));
            dataBox.Items.Add("RegistrationDate: " + Convert.ToString(client.RegistrationDate));
            dataBox.Items.Add("Balance: " + Convert.ToString(client.Balance));
            dataBox.Items.Add("Age: " + Convert.ToString(client.Age));
            dataBox.Items.Add("Deposit: " + Convert.ToString(client.Deposit));
            dataBox.Items.Add("DateOfLastAction: " + Convert.ToString(client.DateOfLastAction));
            dataBox.Items.Add("YearForDeposit: " + Convert.ToString(client.YearForDeposit));
            dataBox.Items.Add("DateOfDeposit: " + Convert.ToString(client.DateOfDeposit));

        }

        private void CalculatePercent_Click(object sender, EventArgs e)
        {
            ListBoxForPercent.Items.Clear();
            int money = client.Deposit;
            for (int i = 1; i <= client.YearForDeposit; i++)
            {
                money = (int)Math.Round(money * 1.05);
            }
            ListBoxForPercent.Items.Add(Convert.ToString(money));
        }

        private void AddDepositToBalance_Click(object sender, EventArgs e)
        {
            if (Data.Text == "")
            {
                MessageBox.Show("Введіть дату");
                return;
            }
            if (!DateTime.TryParseExact(Data.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime currentDate))
            {
                MessageBox.Show("Дата повинна бути у форматі дд.мм.рррр");
                Data.Clear();
                return;
            }
            if (!DateTime.TryParseExact(client.DateOfLastAction, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime lastActionDate))
            {
                MessageBox.Show("Невірний формат дати останньої операції");
                return;
            }

            if (currentDate < lastActionDate)
            {
                MessageBox.Show("Дата не може бути раніше дати останньої операції");
                Data.Clear();
                return;
            }

            if (!DateTime.TryParseExact(client.DateOfDeposit, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime depositEndDate))
            {
                MessageBox.Show("Невірний формат дати завершення депозиту");
                return;
            }

            if (currentDate < depositEndDate)
            {
                MessageBox.Show("Термін вкладу ще не завершено");
                Data.Clear();
                return;
            }

            collectionOfClients.AddDepositToBalance(client, Data.Text);
            ListBoxForPercent.Items.Clear();
            Data.Clear();
            collectionOfClients.SaveClients();
        }

        private void EditClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowHistory_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(client.History);
            HistoryBox.Items.Clear();
            foreach (var line in lines)
            {
                HistoryBox.Items.Add(line);
            }
        }

        private void MakeInvoice_Click(object sender, EventArgs e)
        {
            string pathForInvoice = "..\\..\\..\\invoice.txt";
            client.MakeInvoice(pathForInvoice);
            
            var lines = File.ReadAllLines(pathForInvoice);
            HistoryBox.Items.Clear();
            foreach (var line in lines)
            {
                HistoryBox.Items.Add(line);
            }
        }
    }
}
