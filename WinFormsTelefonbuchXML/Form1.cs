namespace WinFormsTelefonbuchXML
{
    public partial class WindowsFormsTelefonbuch : Form
    {
        private List<Person> _persons = new List<Person>();

        public WindowsFormsTelefonbuch()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Person person = new Person(
                    textBoxForename.Text, 
                    textBoxName.Text, 
                    textBoxPhone.Text, 
                    textBoxEmail.Text);

            _persons.Add(person);

            ShowPersons();
        }

        private void ShowPersons()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _persons;
        }

        private void InitializeDataGrid()
        {
            // settings for dataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }
    }
}
