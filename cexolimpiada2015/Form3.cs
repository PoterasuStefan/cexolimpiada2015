using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cexolimpiada2015
{
    public partial class Form3 : Form
    {
        private readonly string _connectionString;
        Form4 form4 = new Form4();
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Stefan\\source\\repos\\cexolimpiada2015\\cexolimpiada2015\\DBTimpSpatiu.mdf;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
            _connectionString = connectionString;

        }
        bool CapturingMouse = false;
        int PortCurent=1;
        int[,] XYvalues = new int[13, 2];
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializareBtn_Click(object sender, EventArgs e)
        {
            CapturingMouse=true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CapturingMouse)
            {
                MouseEventArgs mouseEvent = (MouseEventArgs)e;
                int mouseX = mouseEvent.X;
                int mouseY = mouseEvent.Y;
                for(PortCurent=0;PortCurent<13;PortCurent++)
                {
                    XYvalues[PortCurent, 0] = mouseX;
                    XYvalues[PortCurent, 1] = mouseY;
                }
                

            }
           
        }

       

        private void SalvareCoordonateBtn_Click(object sender, EventArgs e)
        {
            if (CapturingMouse)
            {// SQL UPDATE statement
                string query =" ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        for (int i = 0; i < PortCurent; i++)
                        {
                            query += $"UPDATE [Porturi] " +
                                     $"SET [Pozitie_X] = @Pozitie_X{i}, [Pozitie_Y] = @Pozitie_Y{i} " +
                                     $"WHERE [ID_Port] = @ID_Port{i};";

                            command.Parameters.AddWithValue($"@ID_Port{i}", i);
                            command.Parameters.AddWithValue($"@Pozitie_X{i}", XYvalues[i, 0]);
                            command.Parameters.AddWithValue($"@Pozitie_Y{i}", XYvalues[i, 1]);
                        }



                        // Open the connection and execute the command
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                CapturingMouse = false;
            }
            else
            {
                // Show an informative message if no ports were captured
                MessageBox.Show("No ports have been captured yet. Please click on the picture box to capture positions before saving.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizareDistanteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Read the text file
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Stefan\source\repos\cexolimpiada2015\cexolimpiada2015\Resources\Harta_Distantelor.txt");

                // Connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Prepare the SQL statement
                    string query = "INSERT INTO Distante (ID_Port_Destinatie, Distanta) VALUES (@ID_Port_Destinatie, @Distanta)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters
                      //  command.Parameters.AddWithValue("@ID_Port", 0); // Initialize parameter
                        command.Parameters.AddWithValue("@ID_Port_Destinatie", 0); // Initialize parameter
                        command.Parameters.AddWithValue("@Distanta", 0); // Initialize parameter

                        // Open the connection
                        connection.Open();

                        // Loop through each line in the file
                        foreach (string line in lines)
                        {
                            string[] values = line.Split(' '); // Split line by spaces

                            // Update parameter values for each row
                           // command.Parameters["@ID_Port"].Value = int.Parse(values[0]);
                            command.Parameters["@ID_Port_Destinatie"].Value = int.Parse(values[1]);

                            // Loop through remaining values as distance for each destination port
                            for (int i = 2; i < values.Length; i++)
                            {
                                command.Parameters["@Distanta"].Value = int.Parse(values[i]);
                                command.ExecuteNonQuery(); // Execute insert for each destination port
                            }
                        }
                    }
                }

                // Success message
                MessageBox.Show("Distante actualizate din fisier cu succes!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Error handling
                MessageBox.Show($"Eroare la actualizarea distantelor: {ex.Message}", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerareCroaziereBtn_Click(object sender, EventArgs e)
        {
            // Choose a random data type (3, 5, or 7)
            int n = new Random().Next(3) + 3;

            // Generate a list of n+2 random city IDs (excluding Constanta)
            List<int> cityIDs = new List<int>();
            string[] availableCities = new string[] { "Varna", "Burgas", "Khagithane", "Kozlu", "Samsun",
                                             "Batumi", "Sokhumi", "Sochi", "Anapa", "Yalta",
                                             "Sevastopol", "Odessa" };
            Random random = new Random();
            for (int i = 0; i < n + 2; i++)
            {
                int cityID = random.Next(1, availableCities.Length) + 1; // Assuming IDs start from 1
                if (cityID != 1) // Constanta's ID is 1
                {
                    cityIDs.Add(cityID);
                }
            }

            // Insert Constanta at the beginning and end based on its ID
            cityIDs.Insert(0, 1);
            cityIDs.Add(1);

            // Create a comma-separated list of city IDs
            string cityList = string.Join(",", cityIDs.Select(id => id.ToString()));

            // Update the code to use city IDs and handle potential errors
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string sql = "INSERT INTO dbo.Croaziere (Tip_Croaziera, Lista_Porturi, Data_Start, Data_Final, Pret, Nr_Pasageri) VALUES (@tip, @cities, GETDATE(), DATEADD(day, @n - 1, GETDATE()), NULL, NULL)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Add the line to declare and assign the value of '@n'
                    command.Parameters.AddWithValue("@n", n);
                    command.Parameters.AddWithValue("@tip", n);

                    command.Parameters.AddWithValue("@cities", cityList);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Croaziera generata cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Eroare la generarea croazierei: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ListaCroaziereBtn_Click(object sender, EventArgs e)
        {
            form4.Show();
            this.Hide();
        }
    }
}
