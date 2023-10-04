using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class UserForm : Form
    {


        public UserForm()
        {
            InitializeComponent();
            
            dataGridView1.Columns.Add("CountryColumn", "Country");

            
            dataGridView1.Columns.Add("StateColumn", "State");

            
            dataGridView1.Columns.Add("PostalMailColumn", "Postal Mail");

            
            dataGridView1.Columns.Add("EmailColumn", "E-mail");

            
            dataGridView1.Columns.Add("SexColumn", "Gender");

        }


        private void Addbutton_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrWhiteSpace(EnterCountrytextBox.Text) || string.IsNullOrWhiteSpace(EntertextBox.Text))
            {
                MessageBox.Show("Please enter Country và State.");
                return;
            }

            
            if (!MaleradioButton.Checked && !FemaleradioButton.Checked)
            {
                MessageBox.Show("Please chosse a gender (Male hoặc Female).");
                return;
            }

            
            dataGridView1.Rows.Add(
                EnterCountrytextBox.Text,
                EntertextBox.Text,
                PostalMailcheckBox.Checked ? "Yes" : "No",
                EmailcheckBox.Checked ? "Yes" : "No",
                MaleradioButton.Checked ? "Male" : "Female"
            );

            
            EnterCountrytextBox.Clear();
            EntertextBox.Clear();
            PostalMailcheckBox.Checked = false;
            EmailcheckBox.Checked = false;
            MaleradioButton.Checked = false;
            FemaleradioButton.Checked = false;
        }

        private void RemoveCountrybutton_Click(object sender, EventArgs e)
        {
            string countryToRemove = RemoveCountrytextBox.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["CountryColumn"].Value != null && row.Cells["CountryColumn"].Value.ToString() == countryToRemove)
                {
                    
                    dataGridView1.Rows.Remove(row);
                    RemoveCountrytextBox.Clear();
                    return;
                }
            }

            RemoveCountrytextBox.Clear();
        }

        private void RemoveStatebutton_Click(object sender, EventArgs e)
        {
            string stateToRemove = RemoveStatetextBox.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["StateColumn"].Value != null && row.Cells["StateColumn"].Value.ToString() == stateToRemove)
                {
                    
                    dataGridView1.Rows.Remove(row);
                    RemoveStatetextBox.Clear();
                    return;
                }
            }

            RemoveStatetextBox.Clear();
        }

        private void ShowDetailbutton_Click(object sender, EventArgs e)
        {
            
            dataGridView1.EndEdit();

            
            EnterCountrytextBox.Clear();
            EntertextBox.Clear();
            PostalMailcheckBox.Checked = false;
            EmailcheckBox.Checked = false;
            MaleradioButton.Checked = false;
            FemaleradioButton.Checked = false;
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count ==  1)
            {
                MessageBox.Show("No row to delete.");
                
            }
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.Clear();

            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
