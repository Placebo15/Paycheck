using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace PayCheck
{
    public partial class EmployeeDashboardControl : UserControl
    {
        public EmployeeDashboardControl()
        {
            InitializeComponent();
            ApplyCircularPictureBoxShape(randomPictureBox);
        }



        public async Task LoadDataAsync(int employeeId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["pay"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string query = "SELECT Ime, Prezime, Email, DatumZaposlenja, Pozicija, Plata, PreostaliDaniOdmora, Slika FROM Zaposleni WHERE id = @employeeId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            DateTime employmentDate = (DateTime)reader["DatumZaposlenja"];
                            employmentDateLabel.Text = employmentDate.ToString("yyyy-MM-dd");
                            positionLabel.Text = reader["Pozicija"].ToString();
                            salaryLabel.Text = reader["Plata"].ToString();
                            remainingVacationLabel.Text = reader["PreostaliDaniOdmora"].ToString();
                            imeiprezime.Text = reader["Ime"].ToString() + " " + reader["Prezime"].ToString();

                            // Load and display the image asynchronously
                            byte[] imageBytes = (byte[])reader["Slika"];
                            await LoadAndDisplayImageAsync(imageBytes);
                        }
                    }
                }
            }
        }

        private async Task LoadAndDisplayImageAsync(byte[] imageBytes)
        {
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = await Task.Run(() => Image.FromStream(ms));
                    randomPictureBox.Image = image;
                }
            }
        }

        private void ApplyCircularPictureBoxShape(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);

            pictureBox.Region = new Region(path);
        }



    }
}
