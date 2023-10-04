namespace Lab6
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void winsAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form ChildForm in MdiChildren)
            {
                if (ChildForm is ChildForm)
                {
                    ChildForm.BringToFront(); 
                    return;
                }
            }

            
            ChildForm childForm = new ChildForm();
            childForm.MdiParent = this; 
            childForm.Show(); 
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form UserForm in MdiChildren)
            {
                if (UserForm is ChildForm)
                {
                    UserForm.BringToFront();
                    return;
                }
            }

            
            UserForm userForm = new UserForm();
            userForm.MdiParent = this; 
            userForm.Show(); 
        }
    }
}