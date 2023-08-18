namespace PayCheck
{
    partial class UserSettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Korisnici = new Label();
            edit = new Button();
            save1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 70);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(161, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(161, 167);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 70);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 118);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 167);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "Role";
            // 
            // Korisnici
            // 
            Korisnici.AutoSize = true;
            Korisnici.Location = new Point(163, 31);
            Korisnici.Name = "Korisnici";
            Korisnici.Size = new Size(52, 15);
            Korisnici.TabIndex = 2;
            Korisnici.Text = "Korisnici";
            // 
            // edit
            // 
            edit.Location = new Point(74, 296);
            edit.Name = "edit";
            edit.Size = new Size(82, 33);
            edit.TabIndex = 3;
            edit.Text = "Izmeni";
            edit.UseVisualStyleBackColor = true;
            edit.Click += Edit_Click;
            // 
            // save1
            // 
            save1.Location = new Point(206, 296);
            save1.Name = "save1";
            save1.Size = new Size(82, 33);
            save1.TabIndex = 3;
            save1.Text = "Sacuvaj";
            save1.UseVisualStyleBackColor = true;
            save1.Click += Save_Click;
            // 
            // UserSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(save1);
            Controls.Add(edit);
            Controls.Add(Korisnici);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UserSettingsControl";
            Size = new Size(362, 389);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label Korisnici;
        private Button edit;
        private Button save1;
    }
}
