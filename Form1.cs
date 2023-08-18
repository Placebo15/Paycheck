using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Net;
using System.Net.Mail;

namespace PayCheck
{
    public partial class Form1 : Form
    {
        private string pdfFolderPath = "C:\\Users\\theew\\Desktop\\paycheck";
        private string pdfFolderPathOutput = "C:\\Users\\theew\\Desktop\\paycheck\\poslati";

        private PrintDocument printDocument = new PrintDocument();
        private PrintDialog printDialog = new PrintDialog();

        private bool stopSending = false;
        private List<string> successfullySentEmails = new List<string>();

        private string userRole;
        private string username;
        private string password;

        public Form1(string role, string userName, string pass)
        {
            InitializeComponent();

            foreach (TabPage tabPage in tabControl1.TabPages)
            {
                closedTabPages.Add(tabPage);
            }

            tabControl1.TabPages.Clear();
            tabControl1.Visible = false;





            userRole = role;
            username = userName;
            password = pass;

            listView1.View = View.Details;
            listView1.Columns.Add("Ime", 300);
            listView1.Columns.Add("Prezime", 300);
            listView1.Columns.Add("Email", 300);
            listView1.Columns.Add("ID", 300);

            LoadEmailTemplates();


            dataGridView1.ReadOnly = true;


            dataGridView2.Columns.Add("LogTime", "Time");
            dataGridView2.Columns.Add("LogMessage", "Log Message");


            button11.Text = userName.ToString();

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (userRole == "NotAdmin")
            {
                button5.Visible = false;
                button6.Visible = false;
                button4.Visible = false;
                tabPage2.Parent = null;
                tabPage3.Parent = null;
                tabPage4.Parent = null;
                tabPage5.Parent = null;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTextBox.Text.ToLower();

            listView1.BeginUpdate();

            foreach (ListViewItem item in listView1.Items)
            {
                bool matchFound = false;

                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(searchTerm))
                    {
                        matchFound = true;
                        break;
                    }
                }

                if (matchFound)
                {
                    item.ForeColor = SystemColors.WindowText;
                    item.BackColor = SystemColors.Window;
                }
                else
                {
                    listView1.Items.Remove(item);
                }
            }

            listView1.EndUpdate();
        }


        private void PrintButton_Click(object sender, EventArgs e)
        {

            PrintTabPageContent(tabControl1.SelectedTab);


        }

        private void PrintTabPageContent(TabPage tabPage)
        {
            if (tabPage == tabPage1)
            {
                PrintContent(listView1);
            }
            else if (tabPage == tabPage2)
            {
                PrintContent(tabPage2);
            }
            else if (tabPage == tabPage3)
            {
                PrintContent(dataGridView2);
            }
            else
                PrintContent(dataGridView1);

        }

        private void PrintContent(Control controlToPrint)
        {
            printDocument.PrintPage += (s, e) =>
            {
                int totalWidth = controlToPrint.Width;
                int totalHeight = controlToPrint.Height;

                using (Bitmap bmp = new Bitmap(totalWidth, totalHeight))
                {
                    controlToPrint.DrawToBitmap(bmp, new Rectangle(0, 0, totalWidth, totalHeight));
                    e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top);
                }
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void Settings(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            if (closedTabPages.Contains(tabPage4))
            {
                tabPage4.Controls.Add(Izmeni);
                tabPage4.Controls.Add(button9);
                tabPage4.Controls.Add(dataGridView1);
                tabPage4.Location = new Point(4, 24);
                tabPage4.Name = "tabPage4";
                tabPage4.Padding = new Padding(3);
                tabPage4.Size = new Size(1002, 654);
                tabPage4.TabIndex = 3;
                tabPage4.Text = "Podesavanja";
                tabPage4.UseVisualStyleBackColor = true;
                tabControl1.TabPages.Add(tabPage4);

                closedTabPages.Remove(tabPage4);
            }

            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add("attachmentPath", "Attachment Path", pdfFolderPath);
            dataGridView1.Rows.Add("SSL", "Enable SSL", "True");
            dataGridView1.Rows.Add("attachmentOutput", "Attachment Output Path", pdfFolderPathOutput);
            dataGridView1.Rows.Add("smtpPort", "SMTP Port", "587");
            dataGridView1.Rows.Add("senderEmail", "Sender Email", "project4442@hotmail.com");
            dataGridView1.Rows.Add("emailSubject", "Email Subject", "Platni listic");
            dataGridView1.Rows.Add("emailBody", "Email Body", "Platni listic za period:");
            dataGridView1.Rows.Add("senderName", "Sender Name", "Aleksandar");
            dataGridView1.Rows.Add("senderPassword", "password", "project112233");

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            tabControl1.SelectedTab = tabPage4;
        }

        private void saveParametersButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell paramNameCell = row.Cells["dataGridViewTextBoxColumn1"];
                DataGridViewCell paramValueCell = row.Cells["dataGridViewTextBoxColumn3"];
                if (paramNameCell != null && paramValueCell != null)
                {
                    string paramName = paramNameCell.Value?.ToString();
                    string paramValue = paramValueCell.Value?.ToString();

                    switch (paramName)
                    {
                        case "attachmentPath":
                            pdfFolderPath = paramValue;
                            break;
                        case "SSL":
                            SSL.Text = paramValue;
                            break;
                        case "attachmentOutput":
                            pdfFolderPathOutput = paramValue;
                            break;
                        case "smtpPort":
                            smtpPort.Text = paramValue;
                            break;
                        case "senderEmail":
                            senderEmail.Text = paramValue;
                            break;
                        case "emailSubject":
                            emailSubject.Text = paramValue;
                            break;
                        case "emailBody":
                            emailBody.Text = paramValue;
                            break;
                        case "senderName":
                            senderName.Text = paramValue;
                            break;
                    }
                }
            }
            dataGridView1.ReadOnly = true;
            MessageBox.Show("Parameteri sacuvani.");
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            loadingLabel.Visible = true;


            await LoadListViewDataAsync();

            tabControl1.Visible = true;
            loadingLabel.Visible = false;

            if (closedTabPages.Contains(tabPage1))
            {

                tabPage1 = new TabPage();
                tabPage1.Controls.Add(loadingLabel);
                tabPage1.Controls.Add(listView1);
                tabPage1.Controls.Add(searchTextBox);
                tabPage1.Controls.Add(SearchButton);
                tabPage1.Location = new Point(4, 24);
                tabPage1.Name = "tabPage1";
                tabPage1.Padding = new Padding(3);
                tabPage1.Size = new Size(1002, 654);
                tabPage1.TabIndex = 0;
                tabPage1.Text = "Lista Zaposlenih";
                tabPage1.UseVisualStyleBackColor = true;


                tabControl1.TabPages.Add(tabPage1);

                closedTabPages.Remove(tabPage1);

            }




        }

        private async Task LoadListViewDataAsync()
        {
            await Task.Delay(1000);

            string connectionString = ConfigurationManager.ConnectionStrings["pay"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Ime, Prezime, Email, id FROM Zaposleni";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        listView1.Items.Clear();
                        while (reader.Read())
                        {
                            string ime = reader["Ime"].ToString();
                            string prezime = reader["Prezime"].ToString();
                            string email = reader["Email"].ToString();
                            string id = reader["id"].ToString();

                            ListViewItem item = new ListViewItem(new[] { ime, prezime, email, id });
                            listView1.Items.Add(item);

                            LogAction($"Added user: {ime} {prezime}, Email: {email}");
                        }
                        tabControl1.SelectedTab = tabPage1;
                    }
                }
            }
        }


        private int lastSentEmailIndex = 0;

        private async void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(attachmentPath.Text) || string.IsNullOrWhiteSpace(SMTP.Text) ||
                string.IsNullOrWhiteSpace(smtpPort.Text) || string.IsNullOrWhiteSpace(senderEmail.Text) ||
                string.IsNullOrWhiteSpace(emailSubject.Text) || string.IsNullOrWhiteSpace(emailBody.Text) ||
                string.IsNullOrWhiteSpace(senderName.Text))
            {
                MessageBox.Show("Popunite prazna polja.");
                return;
            }

            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            string subFolderPath = Path.Combine(attachmentOutput.Text, currentDate);

            if (!Directory.Exists(subFolderPath))
            {
                Directory.CreateDirectory(subFolderPath);
            }

            int batchSize = 10;
            int maxConcurrentTasks = 2;

            int totalEmails = listView1.Items.Count;

            emailProgressBar.Maximum = totalEmails;
            progressLabel.Text = $"0 / {totalEmails} emails sent";

            for (int i = lastSentEmailIndex; i < totalEmails; i += batchSize)
            {
                if (stopSending)
                {
                    stopSending = false;
                    break;
                }

                var batchTasks = new List<Task>();

                for (int j = i; j < Math.Min(i + batchSize, totalEmails); j++)
                {
                    if (batchTasks.Count >= maxConcurrentTasks)
                    {
                        await Task.WhenAny(batchTasks);
                        batchTasks.RemoveAll(task => task.IsCompleted);
                    }

                    ListViewItem item = listView1.Items[j];
                    string recipient = item.SubItems[2].Text;
                    string employeeName = item.SubItems[0].Text;
                    string employeeLastName = item.SubItems[1].Text;

                    string pdfFileName = $"{employeeName}_{employeeLastName}_Plata.pdf";
                    string sourceFilePath = Path.Combine(attachmentPath.Text, pdfFileName);

                    if (!File.Exists(sourceFilePath))
                    {
                        DialogResult result = MessageBox.Show($"Attachment not found for {employeeName} {employeeLastName}. Continue sending without the attachment?", "Attachment Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            continue;
                        }
                        else
                        {
                            stopSending = true;
                            break;
                        }
                    }

                    var task = SendEmailAsync(recipient, employeeName, employeeLastName, pdfFileName, sourceFilePath, subFolderPath);
                    batchTasks.Add(task);
                }

                await Task.WhenAll(batchTasks);

                lastSentEmailIndex = Math.Min(i + batchSize, totalEmails);

                // Update progress bar and label
                emailProgressBar.Value = lastSentEmailIndex;
                progressLabel.Text = $"{lastSentEmailIndex} / {totalEmails} emails sent";

                Application.DoEvents();
            }

            if (successfullySentEmails.Count > 0)
            {
                string successMessage = "Uspesno poslati :\n\n";
                foreach (string email in successfullySentEmails)
                {
                    successMessage += email + "\n";
                }
                MessageBox.Show(successMessage);
                LogAction(successMessage);
            }
            else
            {
                MessageBox.Show("Nista nije poslato.");
            }
        }


        private async void SendGroupEmailsButton_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = employeeListBox.CheckedItems.Count;
            progressBar1.Value = 0;
            progressBar1.Step = 1;

            string senderNameValue = senderName.Text; // Get senderName value
            string emailSubjectValue = emailSubject.Text; // Get emailSubject value
            string emailBodyValue = emailBody.Text; // Get emailBody value

            foreach (object checkedItem in employeeListBox.CheckedItems)
            {
                string[] employeeFullName = checkedItem.ToString().Split(' ');
                string firstName = employeeFullName[0];
                string lastName = employeeFullName[1];

                string pdfFileName = $"{firstName}_{lastName}_Plata.pdf";
                string sourceFilePath = Path.Combine(attachmentPath.Text, pdfFileName);
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string subFolderPath = Path.Combine(attachmentOutput.Text, currentDate);

                ListViewItem selectedEmployeeItem = null;
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[0].Text == firstName && item.SubItems[1].Text == lastName)
                    {
                        selectedEmployeeItem = item;
                        break;
                    }
                }

                if (selectedEmployeeItem != null)
                {
                    string recipient = selectedEmployeeItem.SubItems[2].Text;
                    await SendEmailAsync(recipient, firstName, lastName, pdfFileName, sourceFilePath, subFolderPath);
                }

                progressBar1.PerformStep();
            }

            LogAction($"Uspesno poslato. Ukupno {employeeListBox.CheckedItems.Count} primaocima.");
            MessageBox.Show($"Uspesno dostavljeno. Ukupan broj primaoca je {employeeListBox.CheckedItems.Count}.", "Email Campaign Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private async Task SendEmailAsync(string recipient, string employeeName, string employeeLastName, string pdfFileName, string sourceFilePath, string subFolderPath)
        {
            bool isConnected = await IsInternetConnectedAsync();

            if (!isConnected)
            {
                MessageBox.Show("No internet connection available. Please check your internet connection and try again.", "No Internet Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SmtpClient smtpClient = new SmtpClient(SMTP.Text, int.Parse(smtpPort.Text)))
            {
                smtpClient.EnableSsl = bool.Parse(SSL.Text);
                smtpClient.Credentials = new NetworkCredential(senderEmail.Text, "project112233");

                using (MailMessage mail = new MailMessage(senderEmail.Text, recipient))
                {
                    mail.Subject = emailSubject.Text;
                    mail.Body = emailBody.Text;

                    string selectedTemplate = emailTemplateComboBox.SelectedItem as string;

                    Attachment attachment = new Attachment(sourceFilePath);
                    mail.Attachments.Add(attachment);

                    try
                    {
                        await smtpClient.SendMailAsync(mail);

                        successfullySentEmails.Add(recipient);
                        attachment.Dispose();

                        string destinationFilePath = Path.Combine(subFolderPath, pdfFileName);
                        File.Move(sourceFilePath, destinationFilePath);
                        LogAction($"Sent email to: {recipient}, Attachment: {pdfFileName}");
                        emailProgressBar.Value += 1;
                    }
                    catch (SmtpException ex)
                    {
                        LogAction($"SMTP Error: {ex.StatusCode}");

                        if (ex.StatusCode == SmtpStatusCode.MailboxBusy || ex.StatusCode == SmtpStatusCode.MailboxUnavailable)
                        {
                            int delay = 30;
                            await Task.Delay(delay * 1000);
                            await SendEmailAsync(recipient, employeeName, employeeLastName, pdfFileName, sourceFilePath, subFolderPath); // Retry sending
                        }
                        else
                        {

                            LogAction($"Error sending email to: {recipient}, Error: {ex.Message}");
                        }
                    }
                }
            }
        }

        private async Task<bool> IsInternetConnectedAsync()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = await client.OpenReadTaskAsync("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        private void ListView1_ItemActivate(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int getID = Int32.Parse(selectedItem.SubItems[3].Text);
                string name = selectedItem.SubItems[0].Text;
                string lastname = selectedItem.SubItems[1].Text;
                OpenEmployeeDashboard(getID, name, lastname);
            }
        }
        private void OpenEmployeeDashboard(int getID, string name, string lastname)
        {

            int employeeId = getID;

            if (employeeId > 0)
            {
                EmployeeDashboardControl dashboard = new EmployeeDashboardControl();

                TabPage tabPage = new TabPage(name + " " + lastname);
                tabPage.Controls.Add(dashboard);
                tabControl1.TabPages.Add(tabPage);
                tabControl1.SelectedTab = tabPage;
                dashboard.LoadDataAsync(employeeId);

            }
        }



        private void StopSending(object sender, EventArgs e)
        {
            stopSending = true;
        }

        private void LogButton(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            if (closedTabPages.Contains(tabPage3))
            {
                tabPage3.Controls.Add(dataGridView2);
                tabPage3.Location = new Point(4, 24);
                tabPage3.Name = "tabPage3";
                tabPage3.Padding = new Padding(3);
                tabPage3.Size = new Size(1002, 654);
                tabPage3.TabIndex = 2;
                tabPage3.Text = "Log";
                tabPage3.UseVisualStyleBackColor = true;
                tabControl1.TabPages.Add(tabPage3);

                closedTabPages.Remove(tabPage3);
            }
            tabControl1.SelectedIndex = 2;
        }

        private void editParametersButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void LogAction(string message)
        {
            string logTime = DateTime.Now.ToString();
            dataGridView2.Rows.Add(logTime, message);

        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            if (closedTabPages.Contains(tabPage2))
            {
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
                tabPage2.Size = new Size(1002, 654);
                tabPage2.TabIndex = 1;
                tabPage2.Text = "Slanje";
                tabControl1.TabPages.Add(tabPage2);

                closedTabPages.Remove(tabPage2);
            }

            attachmentPath.Text = pdfFolderPath;
            SMTP.Text = "smtp-mail.outlook.com";
            SSL.Text = "True";
            attachmentOutput.Text = pdfFolderPathOutput;
            smtpPort.Text = "587";
            senderEmail.Text = "project4442@hotmail.com";
            textBox4.Text = senderEmail.Text;
            emailSubject.Text = "Platni listic";
            textBox2.Text = emailSubject.Text;

            emailBody.Text = "Platni listic za period:";
            richTextBox1.Text = emailBody.Text;
            senderName.Text = "Aleksandar";
            textBox3.Text = senderName.Text;

            tabControl1.SelectedTab = tabPage2;

        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Dictionary<string, string> emailTemplatesDictionary = new Dictionary<string, string>();
        private void LoadEmailTemplates()
        {
            // Define your email templates here

            emailTemplatesDictionary.Add("Bonus Program", $"Poštovane kolege,\r\n\r\nObaveštavamo vas sa zadovoljstvom da će se ove godine sprovesti godišnji bonus program kao deo naše poslovne politike nagrađivanja izuzetnih rezultata i doprinosa. Ovaj bonus je zaslužena nagrada za vaš trud, predanost i ostvarene ciljeve tokom protekle godine.\r\n\r\nGodišnji bonus će biti isplaćen u skladu sa vašim postignućima i radnim uspehom, kao i sa ukupnim rezultatima kompanije. Detalji o iznosima bonusa i datumu isplate biće vam dostavljeni u narednim nedeljama.\r\n\r\nJoš jednom, čestitamo vam na vašem doprinosu i hvala vam na kontinuiranom zalaganju za uspeh naše kompanije.\r\n\r\nSrdačan pozdrav,\r\n\r\n\r\n[Uloga/Poslovi]\r\n[Kompanija]\r\n[Kontakt informacije]");
            emailTemplatesDictionary.Add("Neradni dani", $"Poštovane kolege,\r\n\r\nŽelimo da vas obavestimo o predstojećem prazniku i neradnom danu u našoj kompaniji. Naime, u skladu sa kalendarom praznika, želimo da vas informišemo da će [datum] biti označen kao neradni dan.\r\n\r\nMolimo vas da unapred planirate svoje aktivnosti i obaveze kako biste se pravilno organizovali tokom ovog perioda. Ovo je takođe prilika da se odmorite i obnovite svoje energije kako biste se vratili sa još većim entuzijazmom i produktivnošću.\r\n\r\nUkoliko imate bilo kakvih pitanja ili nedoumica u vezi sa organizacijom rada tokom ovog perioda, slobodno se obratite vašem nadređenom ili službi za ljudske resurse.\r\n\r\nHvala vam na razumevanju i saradnji.\r\n\r\nSrdačan pozdrav,\r\n\r\n{senderName}\r\n[Uloga/Poslovi]\r\n[Kompanija]\r\n[Kontakt informacije]");
            emailTemplatesDictionary.Add("Mesečni Obračun", $"Poštovani zaposleni,\r\n\r\nŽelimo da vas obavestimo da će se mesečni obračun platnih listića za tekući mesec sprovesti prema ustaljenom rasporedu. Platni listići će biti dostupni za pregled i preuzimanje putem našeg sistema za upravljanje zaposlenima (ili drugog relevantnog sistema) od [datum dostupnosti].\r\n\r\nMolimo vas da pažljivo pregledate svoj platni listić kako biste se uverili da su svi podaci tačni i da nema eventualnih nepravilnosti. Ukoliko primetite bilo kakve nesuglasice ili imate dodatnih pitanja u vezi sa svojim platnim listićem, ljubazno vas molimo da se obratite službi za ljudske resurse najkasnije do [rok za prijavu eventualnih nesuglasica].\r\n\r\nPodsećamo vas da su vaša bezbednost i povjerljivost podataka od suštinskog značaja. Molimo vas da pažljivo čuvate svoje pristupne informacije za sistem za upravljanje zaposlenima i da ne delite ove informacije sa drugima.\r\n\r\nZahvaljujemo vam na vašem profesionalizmu i saradnji. Ukoliko imate bilo kakvih nedoumica ili trebate dodatne informacije, slobodno nas kontaktirajte.\r\n\r\nSrdačan pozdrav,\r\n\r\n{senderName}\r\n[Uloga/Poslovi]\r\n[Kompanija]\r\n[Kontakt informacije]\r\n\r\n\r\n\r\n\r\n\r\n");

            // Load template names into the ComboBox
            emailTemplateComboBox.Items.AddRange(emailTemplatesDictionary.Keys.ToArray());
            comboBox1.Items.AddRange(emailTemplatesDictionary.Keys.ToArray());

        }



        private void EmailTemplateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTemplate = emailTemplateComboBox.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedTemplate))
            {

                emailBody.Text = emailTemplatesDictionary[selectedTemplate];

            }
            else
            {

                emailBody.Clear();


            }
        }
        private void EmailTemplateComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTemplate = comboBox1.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedTemplate))
            {


                richTextBox1.Text = emailTemplatesDictionary[selectedTemplate];
            }
            else
            {


                richTextBox1.Clear();

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            UserSettingsControl userSettingsControl = new UserSettingsControl(username, password, userRole);

            TabPage tabPage = new TabPage("User Settings");
            tabPage.Controls.Add(userSettingsControl);
            tabControl1.TabPages.Add(tabPage);
            tabControl1.SelectedTab = tabPage;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (closedTabPages.Contains(tabPage5))
            {

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
                tabPage5.Size = new Size(1002, 654);
                tabPage5.TabIndex = 4;
                tabPage5.Text = "Grupno slanje";
                tabPage5.UseVisualStyleBackColor = true;
                tabControl1.TabPages.Add(tabPage5);

                closedTabPages.Remove(tabPage5);
            }

            tabControl1.SelectedTab = tabPage5;


            foreach (ListViewItem item in listView1.Items)
            {
                string employeeFullName = $"{item.SubItems[0].Text} {item.SubItems[1].Text}";
                employeeListBox.Items.Add(employeeFullName, false);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            senderEmail.Text = textBox4.Text;

            emailSubject.Text = textBox2.Text;


            emailBody.Text = richTextBox1.Text;

            senderName.Text = textBox3.Text;
        }
        private void SearchButton1_Click(object sender, EventArgs e)
        {

            string searchTerm = textBox1.Text.ToLower();


            employeeListBox.Items.Clear();


            foreach (ListViewItem item in listView1.Items)
            {
                string employeeFullName = $"{item.SubItems[0].Text} {item.SubItems[1].Text}";


                if (employeeFullName.ToLower().Contains(searchTerm))
                {

                    employeeListBox.Items.Add(employeeFullName, false);
                }
            }
        }
        private void SelectAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ((CheckBox)sender).Checked;

            for (int i = 0; i < employeeListBox.Items.Count; i++)
            {
                employeeListBox.SetItemChecked(i, isChecked);
            }
        }


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private List<TabPage> closedTabPages = new List<TabPage>();

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    TabPage tabPageToRemove = tabControl1.TabPages[i];
                    if (tabPageToRemove != null)
                    {
                        tabControl1.TabPages.Remove(tabPageToRemove);
                        closedTabPages.Add(tabPageToRemove);

                        break;
                    }
                }
            }
        }


        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage thisTab = tabControl1.TabPages[e.Index];
            string tabTitle = thisTab.Text;

            // Draw Close button
            Point closeLoc = new Point(15, 5);
            Rectangle closeButtonBounds = new Rectangle(
                e.Bounds.Right - closeLoc.X, e.Bounds.Top + closeLoc.Y, 10, 12);

            // Clear the background of the "x" button area
            e.Graphics.FillRectangle(Brushes.Transparent, closeButtonBounds);

            // Draw the "x" button
            e.Graphics.DrawString("x", e.Font, Brushes.Black,
                e.Bounds.Right - (closeLoc.X), e.Bounds.Top + closeLoc.Y - 2);

            // Draw String of Caption
            e.Graphics.DrawString(tabTitle, e.Font, Brushes.Black, e.Bounds.Left + 28, e.Bounds.Top + 4);


        }


    }

}