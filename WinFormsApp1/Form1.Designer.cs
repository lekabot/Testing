namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            label2 = new Label();
            Gender = new TextBox();
            label3 = new Label();
            Email = new TextBox();
            label4 = new Label();
            Save = new Button();
            ErrorMessage = new Label();
            label5 = new Label();
            PlaceOfResidence = new TextBox();
            label6 = new Label();
            Phone = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // FirstName
            // 
            FirstName.Location = new Point(56, 107);
            FirstName.Margin = new Padding(2);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(420, 39);
            FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            LastName.Location = new Point(56, 230);
            LastName.Margin = new Padding(2);
            LastName.Name = "LastName";
            LastName.Size = new Size(420, 39);
            LastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 183);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // Gender
            // 
            Gender.Location = new Point(58, 613);
            Gender.Margin = new Padding(2);
            Gender.Name = "Gender";
            Gender.Size = new Size(420, 39);
            Gender.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 566);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 32);
            label3.TabIndex = 6;
            label3.Text = "Gender";
            // 
            // Email
            // 
            Email.Location = new Point(56, 356);
            Email.Margin = new Padding(2);
            Email.Name = "Email";
            Email.Size = new Size(420, 39);
            Email.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 309);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 32);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // Save
            // 
            Save.Location = new Point(648, 407);
            Save.Margin = new Padding(2);
            Save.Name = "Save";
            Save.Size = new Size(143, 45);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // ErrorMessage
            // 
            ErrorMessage.AutoSize = true;
            ErrorMessage.ForeColor = Color.Red;
            ErrorMessage.Location = new Point(56, 800);
            ErrorMessage.Margin = new Padding(2, 0, 2, 0);
            ErrorMessage.Name = "ErrorMessage";
            ErrorMessage.Size = new Size(0, 32);
            ErrorMessage.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(56, 488);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 12;
            // 
            // PlaceOfResidence
            // 
            PlaceOfResidence.Location = new Point(58, 487);
            PlaceOfResidence.Margin = new Padding(2);
            PlaceOfResidence.Name = "PlaceOfResidence";
            PlaceOfResidence.Size = new Size(420, 39);
            PlaceOfResidence.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 440);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 32);
            label6.TabIndex = 10;
            label6.Text = "Place of residence";
            // 
            // Phone
            // 
            Phone.Location = new Point(56, 734);
            Phone.Margin = new Padding(2);
            Phone.Name = "Phone";
            Phone.Size = new Size(420, 39);
            Phone.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(56, 687);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(82, 32);
            label7.TabIndex = 13;
            label7.Text = "Phone";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 1104);
            Controls.Add(Phone);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(PlaceOfResidence);
            Controls.Add(label6);
            Controls.Add(ErrorMessage);
            Controls.Add(Save);
            Controls.Add(Gender);
            Controls.Add(label3);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(LastName);
            Controls.Add(label2);
            Controls.Add(FirstName);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox FirstName;
        private TextBox LastName;
        private Label label2;
        private TextBox Gender;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private Button Save;
        private Label ErrorMessage;
        private Label label5;
        private TextBox PlaceOfResidence;
        private Label label6;
        private TextBox Phone;
        private Label label7;
    }
}