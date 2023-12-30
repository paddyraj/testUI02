using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUI02
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
         public Dashboard()
        {
            InitializeComponent();

            UpdateBind();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(LastNameText.Text);
            UpdateBind();
        }

        private void UpdateBind() {

            PeopleFoundListBox.DataSource = people;
            PeopleFoundListBox.DisplayMember = "FullInfo";

        }
        private void PeopleFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
