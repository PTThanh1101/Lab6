namespace Lab6
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnterCountrylabel = new Label();
            EnterStateelabel = new Label();
            EnterCountrytextBox = new TextBox();
            EntertextBox = new TextBox();
            PostalMailcheckBox = new CheckBox();
            EmailcheckBox = new CheckBox();
            MaleradioButton = new RadioButton();
            FemaleradioButton = new RadioButton();
            Addbutton = new Button();
            RemoveCountrybutton = new Button();
            RemoveStatebutton = new Button();
            dataGridView1 = new DataGridView();
            RemoveCountrytextBox = new TextBox();
            RemoveStatetextBox = new TextBox();
            Deletebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // EnterCountrylabel
            // 
            EnterCountrylabel.AutoSize = true;
            EnterCountrylabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterCountrylabel.Location = new Point(12, 9);
            EnterCountrylabel.Name = "EnterCountrylabel";
            EnterCountrylabel.Size = new Size(132, 28);
            EnterCountrylabel.TabIndex = 0;
            EnterCountrylabel.Text = "Enter Country";
            // 
            // EnterStateelabel
            // 
            EnterStateelabel.AutoSize = true;
            EnterStateelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterStateelabel.Location = new Point(12, 70);
            EnterStateelabel.Name = "EnterStateelabel";
            EnterStateelabel.Size = new Size(106, 28);
            EnterStateelabel.TabIndex = 1;
            EnterStateelabel.Text = "Enter State";
            // 
            // EnterCountrytextBox
            // 
            EnterCountrytextBox.Location = new Point(150, 13);
            EnterCountrytextBox.Name = "EnterCountrytextBox";
            EnterCountrytextBox.Size = new Size(234, 27);
            EnterCountrytextBox.TabIndex = 2;
            // 
            // EntertextBox
            // 
            EntertextBox.Location = new Point(150, 74);
            EntertextBox.Name = "EntertextBox";
            EntertextBox.Size = new Size(234, 27);
            EntertextBox.TabIndex = 3;
            // 
            // PostalMailcheckBox
            // 
            PostalMailcheckBox.AutoSize = true;
            PostalMailcheckBox.Location = new Point(14, 154);
            PostalMailcheckBox.Name = "PostalMailcheckBox";
            PostalMailcheckBox.Size = new Size(103, 24);
            PostalMailcheckBox.TabIndex = 4;
            PostalMailcheckBox.Text = "Postal Mail";
            PostalMailcheckBox.UseVisualStyleBackColor = true;
            // 
            // EmailcheckBox
            // 
            EmailcheckBox.AutoSize = true;
            EmailcheckBox.Location = new Point(12, 209);
            EmailcheckBox.Name = "EmailcheckBox";
            EmailcheckBox.Size = new Size(74, 24);
            EmailcheckBox.TabIndex = 5;
            EmailcheckBox.Text = "E-mail";
            EmailcheckBox.UseVisualStyleBackColor = true;
            // 
            // MaleradioButton
            // 
            MaleradioButton.AutoSize = true;
            MaleradioButton.Location = new Point(234, 153);
            MaleradioButton.Name = "MaleradioButton";
            MaleradioButton.Size = new Size(63, 24);
            MaleradioButton.TabIndex = 6;
            MaleradioButton.TabStop = true;
            MaleradioButton.Text = "Male";
            MaleradioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleradioButton
            // 
            FemaleradioButton.AutoSize = true;
            FemaleradioButton.Location = new Point(234, 208);
            FemaleradioButton.Name = "FemaleradioButton";
            FemaleradioButton.Size = new Size(78, 24);
            FemaleradioButton.TabIndex = 7;
            FemaleradioButton.TabStop = true;
            FemaleradioButton.Text = "Female";
            FemaleradioButton.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            Addbutton.Location = new Point(23, 386);
            Addbutton.Name = "Addbutton";
            Addbutton.Size = new Size(126, 49);
            Addbutton.TabIndex = 8;
            Addbutton.Text = "ADD";
            Addbutton.UseVisualStyleBackColor = true;
            Addbutton.Click += Addbutton_Click;
            // 
            // RemoveCountrybutton
            // 
            RemoveCountrybutton.Location = new Point(197, 386);
            RemoveCountrybutton.Name = "RemoveCountrybutton";
            RemoveCountrybutton.Size = new Size(126, 49);
            RemoveCountrybutton.TabIndex = 9;
            RemoveCountrybutton.Text = "Remove Country";
            RemoveCountrybutton.UseVisualStyleBackColor = true;
            RemoveCountrybutton.Click += RemoveCountrybutton_Click;
            // 
            // RemoveStatebutton
            // 
            RemoveStatebutton.Location = new Point(389, 386);
            RemoveStatebutton.Name = "RemoveStatebutton";
            RemoveStatebutton.Size = new Size(126, 49);
            RemoveStatebutton.TabIndex = 10;
            RemoveStatebutton.Text = "Remove State";
            RemoveStatebutton.UseVisualStyleBackColor = true;
            RemoveStatebutton.Click += RemoveStatebutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(448, 9);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(883, 338);
            dataGridView1.TabIndex = 12;
            // 
            // RemoveCountrytextBox
            // 
            RemoveCountrytextBox.Location = new Point(198, 465);
            RemoveCountrytextBox.Name = "RemoveCountrytextBox";
            RemoveCountrytextBox.Size = new Size(125, 27);
            RemoveCountrytextBox.TabIndex = 13;
            // 
            // RemoveStatetextBox
            // 
            RemoveStatetextBox.Location = new Point(389, 465);
            RemoveStatetextBox.Name = "RemoveStatetextBox";
            RemoveStatetextBox.Size = new Size(125, 27);
            RemoveStatetextBox.TabIndex = 14;
            // 
            // Deletebutton
            // 
            Deletebutton.Location = new Point(620, 386);
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Size = new Size(126, 49);
            Deletebutton.TabIndex = 15;
            Deletebutton.Text = "Delete";
            Deletebutton.UseVisualStyleBackColor = true;
            Deletebutton.Click += Deletebutton_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1325, 603);
            Controls.Add(Deletebutton);
            Controls.Add(RemoveStatetextBox);
            Controls.Add(RemoveCountrytextBox);
            Controls.Add(dataGridView1);
            Controls.Add(RemoveStatebutton);
            Controls.Add(RemoveCountrybutton);
            Controls.Add(Addbutton);
            Controls.Add(FemaleradioButton);
            Controls.Add(MaleradioButton);
            Controls.Add(EmailcheckBox);
            Controls.Add(PostalMailcheckBox);
            Controls.Add(EntertextBox);
            Controls.Add(EnterCountrytextBox);
            Controls.Add(EnterStateelabel);
            Controls.Add(EnterCountrylabel);
            Name = "UserForm";
            Text = "User Information";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EnterCountrylabel;
        private Label EnterStateelabel;
        private TextBox EnterCountrytextBox;
        private TextBox EntertextBox;
        private CheckBox PostalMailcheckBox;
        private CheckBox EmailcheckBox;
        private RadioButton MaleradioButton;
        private RadioButton FemaleradioButton;
        private Button Addbutton;
        private Button RemoveCountrybutton;
        private Button RemoveStatebutton;
        private DataGridView dataGridView1;
        private TextBox RemoveCountrytextBox;
        private TextBox RemoveStatetextBox;
        private Button Deletebutton;
    }
}