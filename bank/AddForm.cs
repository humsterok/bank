using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bank
{
    public partial class AddForm : Form
    {
        CollectionOfClients collectionOfClients { set; get; }
        public AddForm()
        {
            InitializeComponent();
            collectionOfClients = new CollectionOfClients();
            textBox1.Text = "будь-якє";
            textBox2.Text = "ціле число";
            textBox3.Text = "дд.мм.рррр";
            textBox4.Text = "ціле число";
        }

        private void MakeAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            if (!int.TryParse(textBox2.Text, out int balance))
            {
                MessageBox.Show("Баланс повинен бути цілочисельним");
                textBox2.Clear();
                return;
            }

            if (!DateTime.TryParseExact(textBox3.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime registrationDate))
            {
                MessageBox.Show("Дата повинна бути у форматі дд.мм.рррр");
                textBox3.Clear();
                return;
            }

            if (!int.TryParse(textBox4.Text, out int age))
            {
                MessageBox.Show("Вік повинен бути цілочисельним");
                textBox4.Clear();
                return;
            }
            

            int ID = collectionOfClients.collectionOfClients.Count + 1;
            string Name = textBox1.Text;
            Client newClient = new Client(ID, Name, registrationDate.ToString("dd.MM.yyyy"), balance, age);

            if (collectionOfClients.AddClient(newClient))
            {
                MessageBox.Show("Клієнта успішно додано");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Помилка при додаванні клієнта");
            }
        }

        private void AddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
