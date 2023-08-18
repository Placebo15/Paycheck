using System.Configuration;
using System.Data.SqlClient;

namespace PayCheck
{
    public partial class UserSettingsControl : UserControl
    {
        // Store the user's original information (username, password, role)
        private string originalUsername;
        private string originalPassword;
        private string originalRole;

        public UserSettingsControl(string username, string password, string role)
        {
            InitializeComponent();

            // Set the original values
            originalUsername = username;
            originalPassword = password;
            originalRole = role;

            // Initialize the textboxes with the original values
            textBox1.Text = originalUsername;
            textBox2.Text = originalPassword;
            textBox3.Text = originalRole;

            // Attach event handlers to the buttons
            edit.Click += Edit_Click;
            save1.Click += Save_Click;
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            textBox2.Enabled = true;

            if (originalRole == "NotAdmin")
            {
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Disable editing of textboxes
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            // Get the new values from textboxes
            string newUsername = textBox1.Text;
            string newPassword = textBox2.Text;
            string newRole = textBox3.Text;

            try
            {
                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["pay"].ConnectionString))
                {
                    connection.Open();

                    // Update the user's password and role in the database
                    string updateQuery = "UPDATE Korisnici SET Password = @NewPassword, UserRole = @NewRole WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NewPassword", newPassword);
                        command.Parameters.AddWithValue("@NewRole", newRole);
                        command.Parameters.AddWithValue("@Username", originalUsername);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {


                            originalUsername = newUsername;
                            originalPassword = newPassword;
                            originalRole = newRole;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user settings.");
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating user settings: " + ex.Message);
            }
        }

    }
}
