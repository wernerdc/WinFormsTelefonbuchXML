using System.Xml;
using System.Xml.Serialization;

namespace WinFormsTelefonbuchXML
{
    public partial class WindowsFormsTelefonbuch : Form
    {
        //private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<Person>));
        private string _xmlPath = "persons.xml";
        private List<Person> _persons = new List<Person>();

        public WindowsFormsTelefonbuch()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPersonsFromXml();
            ShowPersons();
        }

        private void WindowsFormsTelefonbuch_FormClosing(object sender, FormClosingEventArgs e)
        {
            StorePersonsToXml();
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

        private void StorePersonsToXml()
        {
            try
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(_xmlPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                    xmlSerializer.Serialize(xmlWriter, _persons);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void LoadPersonsFromXml()
        {
            if (!File.Exists(_xmlPath))
            {
                return;
            }

            try
            {
                using (XmlReader xmlReader = XmlReader.Create(_xmlPath))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));
                    _persons.Clear();
                    _persons = xmlSerializer.Deserialize(xmlReader) as List<Person>;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Person person = dataGridView1.CurrentRow.DataBoundItem as Person;
            if (person == null)
            {
                return;
            }
            ShowSelectedPerson(person);
        }

        private void ShowSelectedPerson(Person person)
        {
            textBoxForename.Text = person.Forename;
            textBoxName.Text = person.Name;
            textBoxPhone.Text = person.Phone;
            textBoxEmail.Text = person.Email;
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            // reference to selected person in datagridview
            Person person = dataGridView1.CurrentRow.DataBoundItem as Person;
            if (person == null)
            {
                return;
            }
            _persons.Remove(person);
            ShowPersons();
        }
    }
}
