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
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void Submitbutton1_Click(object sender, EventArgs e)
        {
            
            string firstName = FirstNametextBox.Text;
            string lastName = LastNametextBox.Text;

            
            this.Close();

            
            if (this.MdiParent is ParentForm parentForm)
            {
                parentForm.BringToFront();
            }
        }
    }
}
