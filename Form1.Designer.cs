using System.Windows.Forms;

namespace PayCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            button11 = new Button();
            button10 = new Button();
            button15 = new Button();
            button7 = new Button();
            searchTextBox1 = new TextBox();
            searchButton1 = new Button();
            sendGroupEmailButton = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            loadingLabel = new Label();
            listView1 = new ListView();
            searchTextBox = new TextBox();
            SearchButton = new Button();
            tabPage2 = new TabPage();
            emailTemplateComboBox = new ComboBox();
            emailBody = new RichTextBox();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            button12 = new Button();
            button8 = new Button();
            button3 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            progressLabel = new Label();
            label1 = new Label();
            emailSubject = new TextBox();
            senderName = new TextBox();
            senderEmail = new TextBox();
            SSL = new TextBox();
            smtpPort = new TextBox();
            SMTP = new TextBox();
            attachmentOutput = new TextBox();
            attachmentPath = new TextBox();
            emailProgressBar = new ProgressBar();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage4 = new TabPage();
            Izmeni = new Button();
            button9 = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            cb = new CheckBox();
            richTextBox1 = new RichTextBox();
            label15 = new Label();
            progressBar1 = new ProgressBar();
            comboBox1 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button14 = new Button();
            button13 = new Button();
            textBox1 = new TextBox();
            employeeListBox = new CheckedListBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(147, 122);
            button1.TabIndex = 1;
            button1.Text = "Lista zaposlenih";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 682);
            panel1.TabIndex = 7;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(0, 382);
            button6.Name = "button6";
            button6.Size = new Size(147, 122);
            button6.TabIndex = 4;
            button6.Text = "Podesavanja";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Settings;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(0, 128);
            button5.Name = "button5";
            button5.Size = new Size(147, 122);
            button5.TabIndex = 3;
            button5.Text = "Slanje";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            button5.Click += emailButton_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 254);
            button4.Name = "button4";
            button4.Size = new Size(147, 122);
            button4.TabIndex = 2;
            button4.Text = "Log";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = true;
            button4.Click += LogButton;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 50);
            panel2.TabIndex = 7;
            // 
            // button11
            // 
            button11.Cursor = Cursors.Hand;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = SystemColors.ControlDark;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.TopLeft;
            button11.Location = new Point(810, 7);
            button11.Name = "button11";
            button11.Size = new Size(153, 30);
            button11.TabIndex = 1;
            button11.Text = "User";
            button11.TextAlign = ContentAlignment.TopCenter;
            button11.TextImageRelation = TextImageRelation.ImageAboveText;
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(154, -2);
            button10.Name = "button10";
            button10.Size = new Size(52, 46);
            button10.TabIndex = 1;
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.TextImageRelation = TextImageRelation.ImageAboveText;
            button10.UseVisualStyleBackColor = true;
            button10.Click += PrintButton_Click;
            // 
            // button15
            // 
            button15.Cursor = Cursors.Hand;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button15.ForeColor = SystemColors.ButtonHighlight;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.Location = new Point(1077, 12);
            button15.Name = "button15";
            button15.Size = new Size(31, 25);
            button15.TabIndex = 5;
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.TextImageRelation = TextImageRelation.ImageAboveText;
            button15.UseVisualStyleBackColor = true;
            button15.Click += MinimizeButton_Click;
            // 
            // button7
            // 
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(1104, 12);
            button7.Name = "button7";
            button7.Size = new Size(31, 25);
            button7.TabIndex = 5;
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Exit;
            // 
            // searchTextBox1
            // 
            searchTextBox1.Location = new Point(0, 0);
            searchTextBox1.Name = "searchTextBox1";
            searchTextBox1.Size = new Size(150, 23);
            searchTextBox1.TabIndex = 0;
            // 
            // searchButton1
            // 
            searchButton1.Location = new Point(546, 10);
            searchButton1.Name = "searchButton1";
            searchButton1.Size = new Size(80, 25);
            searchButton1.TabIndex = 0;
            searchButton1.Text = "Search";
            searchButton1.Click += SearchButton1_Click;
            // 
            // sendGroupEmailButton
            // 
            sendGroupEmailButton.Location = new Point(0, 0);
            sendGroupEmailButton.Name = "sendGroupEmailButton";
            sendGroupEmailButton.Size = new Size(120, 25);
            sendGroupEmailButton.TabIndex = 0;
            sendGroupEmailButton.Text = "Send Group Email";
            sendGroupEmailButton.Click += SendGroupEmailsButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(150, 20);
            tabControl1.Location = new Point(144, 50);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1013, 682);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            tabControl1.DrawItem += tabControl1_DrawItem;
            tabControl1.MouseDown += tabControl1_MouseDown;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Controls.Add(loadingLabel);
            tabPage1.Controls.Add(listView1);
            tabPage1.Controls.Add(searchTextBox);
            tabPage1.Controls.Add(SearchButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1005, 654);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista Zaposlenih";
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loadingLabel.Location = new Point(362, 296);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(221, 30);
            loadingLabel.TabIndex = 2;
            loadingLabel.Text = "Ucitavanje podataka....";
            loadingLabel.Visible = false;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Dock = DockStyle.Fill;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(999, 648);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemActivate += ListView1_ItemActivate;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(390, 6);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(156, 23);
            searchTextBox.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.FlatAppearance.BorderColor = Color.Gray;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 128, 255);
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.ForeColor = SystemColors.ButtonHighlight;
            SearchButton.Image = (Image)resources.GetObject("SearchButton.Image");
            SearchButton.Location = new Point(552, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(31, 29);
            SearchButton.TabIndex = 1;
            SearchButton.TextAlign = ContentAlignment.BottomCenter;
            SearchButton.TextImageRelation = TextImageRelation.ImageAboveText;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightGray;
            tabPage2.Controls.Add(emailTemplateComboBox);
            tabPage2.Controls.Add(emailBody);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(button12);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(progressLabel);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(emailSubject);
            tabPage2.Controls.Add(senderName);
            tabPage2.Controls.Add(senderEmail);
            tabPage2.Controls.Add(SSL);
            tabPage2.Controls.Add(smtpPort);
            tabPage2.Controls.Add(SMTP);
            tabPage2.Controls.Add(attachmentOutput);
            tabPage2.Controls.Add(attachmentPath);
            tabPage2.Controls.Add(emailProgressBar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1005, 654);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Slanje";
            // 
            // emailTemplateComboBox
            // 
            emailTemplateComboBox.FormattingEnabled = true;
            emailTemplateComboBox.Location = new Point(316, 358);
            emailTemplateComboBox.Name = "emailTemplateComboBox";
            emailTemplateComboBox.Size = new Size(204, 23);
            emailTemplateComboBox.TabIndex = 20;
            emailTemplateComboBox.SelectedIndexChanged += EmailTemplateComboBox_SelectedIndexChanged;
            // 
            // emailBody
            // 
            emailBody.Location = new Point(316, 456);
            emailBody.Name = "emailBody";
            emailBody.Size = new Size(204, 180);
            emailBody.TabIndex = 18;
            emailBody.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(201, 456);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 17;
            label9.Text = "Poruka:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(208, 358);
            label10.Name = "label10";
            label10.Size = new Size(84, 15);
            label10.TabIndex = 16;
            label10.Text = "Sablon emaila:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 330);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 16;
            label8.Text = "Predmet poruke:";
            // 
            // button12
            // 
            button12.Location = new Point(688, 579);
            button12.Name = "button12";
            button12.Size = new Size(174, 44);
            button12.TabIndex = 3;
            button12.Text = "Posalji odredjenoj grupi";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button8
            // 
            button8.Location = new Point(571, 484);
            button8.Name = "button8";
            button8.Size = new Size(174, 44);
            button8.TabIndex = 3;
            button8.Text = "Prekini slanje";
            button8.UseVisualStyleBackColor = true;
            button8.Click += StopSending;
            // 
            // button3
            // 
            button3.Location = new Point(794, 484);
            button3.Name = "button3";
            button3.Size = new Size(174, 44);
            button3.TabIndex = 3;
            button3.Text = "Posalji e-mailove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(208, 291);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 15;
            label7.Text = "Ime posaljioca:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 244);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 14;
            label6.Text = "Email adresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(208, 205);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 13;
            label5.Text = "SSL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 161);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "SMT PORT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 121);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 11;
            label3.Text = "SMTP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 83);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 10;
            label2.Text = "Putanja poslatih:";
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(715, 456);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(0, 15);
            progressLabel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 51);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 9;
            label1.Text = "Putanja za slanje:";
            // 
            // emailSubject
            // 
            emailSubject.Location = new Point(316, 322);
            emailSubject.Name = "emailSubject";
            emailSubject.Size = new Size(204, 23);
            emailSubject.TabIndex = 7;
            // 
            // senderName
            // 
            senderName.Location = new Point(316, 283);
            senderName.Name = "senderName";
            senderName.Size = new Size(204, 23);
            senderName.TabIndex = 6;
            // 
            // senderEmail
            // 
            senderEmail.Location = new Point(316, 241);
            senderEmail.Name = "senderEmail";
            senderEmail.Size = new Size(204, 23);
            senderEmail.TabIndex = 5;
            // 
            // SSL
            // 
            SSL.Location = new Point(316, 202);
            SSL.Name = "SSL";
            SSL.Size = new Size(204, 23);
            SSL.TabIndex = 4;
            // 
            // smtpPort
            // 
            smtpPort.Location = new Point(316, 158);
            smtpPort.Name = "smtpPort";
            smtpPort.Size = new Size(204, 23);
            smtpPort.TabIndex = 3;
            // 
            // SMTP
            // 
            SMTP.Location = new Point(316, 118);
            SMTP.Name = "SMTP";
            SMTP.Size = new Size(204, 23);
            SMTP.TabIndex = 2;
            // 
            // attachmentOutput
            // 
            attachmentOutput.Location = new Point(316, 80);
            attachmentOutput.Name = "attachmentOutput";
            attachmentOutput.Size = new Size(204, 23);
            attachmentOutput.TabIndex = 1;
            // 
            // attachmentPath
            // 
            attachmentPath.Location = new Point(316, 51);
            attachmentPath.Name = "attachmentPath";
            attachmentPath.Size = new Size(204, 23);
            attachmentPath.TabIndex = 0;
            // 
            // emailProgressBar
            // 
            emailProgressBar.Location = new Point(571, 422);
            emailProgressBar.Name = "emailProgressBar";
            emailProgressBar.Size = new Size(397, 23);
            emailProgressBar.TabIndex = 19;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1005, 654);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Log";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.LightGray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(999, 648);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightGray;
            tabPage4.Controls.Add(Izmeni);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1005, 654);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Podesavanja";
            // 
            // Izmeni
            // 
            Izmeni.Location = new Point(354, 358);
            Izmeni.Name = "Izmeni";
            Izmeni.Size = new Size(102, 34);
            Izmeni.TabIndex = 1;
            Izmeni.Text = "Izmeni";
            Izmeni.UseVisualStyleBackColor = true;
            Izmeni.Click += editParametersButton_Click;
            // 
            // button9
            // 
            button9.Location = new Point(520, 358);
            button9.Name = "button9";
            button9.Size = new Size(102, 34);
            button9.TabIndex = 1;
            button9.Text = "Sacuvaj";
            button9.UseVisualStyleBackColor = true;
            button9.Click += saveParametersButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(999, 336);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ime parametra";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Opis parametra";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Vrednost parametra";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.LightGray;
            tabPage5.Controls.Add(cb);
            tabPage5.Controls.Add(richTextBox1);
            tabPage5.Controls.Add(label15);
            tabPage5.Controls.Add(progressBar1);
            tabPage5.Controls.Add(comboBox1);
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(label14);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(textBox3);
            tabPage5.Controls.Add(textBox4);
            tabPage5.Controls.Add(button14);
            tabPage5.Controls.Add(button13);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(employeeListBox);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1005, 654);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Grupno slanje";
            // 
            // cb
            // 
            cb.AutoSize = true;
            cb.Location = new Point(526, 406);
            cb.Name = "cb";
            cb.Size = new Size(87, 19);
            cb.TabIndex = 32;
            cb.Text = "Selektuj sve";
            cb.UseVisualStyleBackColor = true;
            cb.CheckedChanged += SelectAllCheckbox_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(159, 266);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(204, 329);
            richTextBox1.TabIndex = 30;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += textBox1_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(51, 266);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 29;
            label15.Text = "Poruka:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(462, 493);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(397, 23);
            progressBar1.TabIndex = 31;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 23);
            comboBox1.TabIndex = 28;
            comboBox1.SelectedIndexChanged += EmailTemplateComboBox1_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 171);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 26;
            label11.Text = "Sablon emaila:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 135);
            label12.Name = "label12";
            label12.Size = new Size(95, 15);
            label12.TabIndex = 27;
            label12.Text = "Predmet poruke:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(51, 96);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 25;
            label13.Text = "Ime posaljioca:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(51, 54);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 24;
            label14.Text = "Email adresa:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(159, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 23);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox1_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(159, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 23);
            textBox4.TabIndex = 21;
            textBox4.TextChanged += textBox1_TextChanged;
            // 
            // button14
            // 
            button14.Location = new Point(594, 431);
            button14.Name = "button14";
            button14.Size = new Size(136, 29);
            button14.TabIndex = 2;
            button14.Text = "Posalji";
            button14.UseVisualStyleBackColor = true;
            button14.Click += SendGroupEmailsButton_Click;
            // 
            // button13
            // 
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.Location = new Point(706, 19);
            button13.Name = "button13";
            button13.Size = new Size(35, 29);
            button13.TabIndex = 2;
            button13.UseVisualStyleBackColor = true;
            button13.Click += SearchButton1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(564, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "pretrazi...";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 1;
            // 
            // employeeListBox
            // 
            employeeListBox.CheckOnClick = true;
            employeeListBox.FormattingEnabled = true;
            employeeListBox.Location = new Point(526, 54);
            employeeListBox.Name = "employeeListBox";
            employeeListBox.Size = new Size(259, 346);
            employeeListBox.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1157, 732);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(148, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1009, 682);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 732);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel2;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button10;
        private Button button11;
        private TextBox searchTextBox1;
        private Button searchButton1;
        private Button sendGroupEmailButton;
        private Button button15;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label loadingLabel;
        private ListView listView1;
        private TextBox searchTextBox;
        private Button SearchButton;
        private TabPage tabPage2;
        private ComboBox emailTemplateComboBox;
        private RichTextBox emailBody;
        private Label label9;
        private Label label10;
        private Label label8;
        private Button button12;
        private Button button8;
        private Button button3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label progressLabel;
        private Label label1;
        private TextBox emailSubject;
        private TextBox senderName;
        private TextBox senderEmail;
        private TextBox SSL;
        private TextBox smtpPort;
        private TextBox SMTP;
        private TextBox attachmentOutput;
        private TextBox attachmentPath;
        private ProgressBar emailProgressBar;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private TabPage tabPage4;
        private Button Izmeni;
        private Button button9;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private TabPage tabPage5;
        private CheckBox cb;
        private RichTextBox richTextBox1;
        private Label label15;
        private ProgressBar progressBar1;
        private ComboBox comboBox1;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button14;
        private Button button13;
        private TextBox textBox1;
        private CheckedListBox employeeListBox;
        private PictureBox pictureBox1;
    }
}