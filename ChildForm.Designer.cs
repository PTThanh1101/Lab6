namespace Lab6
{
    partial class ChildForm
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
            Welcomelabel = new Label();
            LastNametextBox = new TextBox();
            FirstNametextBox = new TextBox();
            LastNamelabel = new Label();
            FirstNamelabel = new Label();
            Submitbutton1 = new Button();
            SuspendLayout();
            // 
            // Welcomelabel
            // 
            Welcomelabel.AutoSize = true;
            Welcomelabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Welcomelabel.Location = new Point(309, 22);
            Welcomelabel.Name = "Welcomelabel";
            Welcomelabel.Size = new Size(145, 38);
            Welcomelabel.TabIndex = 0;
            Welcomelabel.Text = "WELCOME";
            // 
            // LastNametextBox
            // 
            LastNametextBox.Location = new Point(309, 173);
            LastNametextBox.Name = "LastNametextBox";
            LastNametextBox.Size = new Size(234, 27);
            LastNametextBox.TabIndex = 7;
            // 
            // FirstNametextBox
            // 
            FirstNametextBox.Location = new Point(309, 112);
            FirstNametextBox.Name = "FirstNametextBox";
            FirstNametextBox.Size = new Size(234, 27);
            FirstNametextBox.TabIndex = 6;
            // 
            // LastNamelabel
            // 
            LastNamelabel.AutoSize = true;
            LastNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNamelabel.Location = new Point(171, 169);
            LastNamelabel.Name = "LastNamelabel";
            LastNamelabel.Size = new Size(103, 28);
            LastNamelabel.TabIndex = 5;
            LastNamelabel.Text = "Last Name";
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNamelabel.Location = new Point(171, 108);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.Size = new Size(106, 28);
            FirstNamelabel.TabIndex = 4;
            FirstNamelabel.Text = "First Name";
            // 
            // Submitbutton1
            // 
            Submitbutton1.Location = new Point(223, 300);
            Submitbutton1.Name = "Submitbutton1";
            Submitbutton1.Size = new Size(336, 59);
            Submitbutton1.TabIndex = 8;
            Submitbutton1.Text = "Submit";
            Submitbutton1.UseVisualStyleBackColor = true;
            Submitbutton1.Click += Submitbutton1_Click;
            // 
            // ChildForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Submitbutton1);
            Controls.Add(LastNametextBox);
            Controls.Add(FirstNametextBox);
            Controls.Add(LastNamelabel);
            Controls.Add(FirstNamelabel);
            Controls.Add(Welcomelabel);
            Name = "ChildForm";
            Text = "Win App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcomelabel;
        private TextBox LastNametextBox;
        private TextBox FirstNametextBox;
        private Label LastNamelabel;
        private Label FirstNamelabel;
        private Button Submitbutton1;
    }
}