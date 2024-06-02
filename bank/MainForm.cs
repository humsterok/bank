namespace bank
{
    public partial class MainForm : Form
    {
        CollectionOfClients collectionOfClients { set; get; }
        public MainForm()
        {
            InitializeComponent();
            collectionOfClients = new CollectionOfClients();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            this.Hide();
            addForm.Show();
        }

        private void ClientsBox_DoubleClick(object sender, EventArgs e)
        {
            if (ClientsBox.SelectedItem == null)
            {
                MessageBox.Show("Оберіть клієнта");
                return;
            }

            Client selectedClient = (Client)ClientsBox.SelectedItem;
            EditClientForm editForm = new EditClientForm(selectedClient, collectionOfClients);
            this.Hide();
            editForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var result = collectionOfClients.Search(SearchBox.Text.ToLower(), collectionOfClients.collectionOfClients);
            if (result.Count > 0)
            {
                ClientsBox.DataSource = result;
                ClientsBox.DisplayMember = "Name";
                ClientsBox.ValueMember = "ID";
            }
            else
            {
                MessageBox.Show("Не знайдено жодного клієнта");
                ClientsBox.DataSource = null;
                SearchBox.Clear();
            }
        }
    }
}
