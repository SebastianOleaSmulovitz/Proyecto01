using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niidea
{
    public partial class Facturacion : Form
    {

        MySqlConnection connectionBD = new MySqlConnection(
           "server=127.0.0.1;port=3306;user=root;password=;database=app;"
       );



        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DNI_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(inputDni.Text, out int dni))
            {
                MessageBox.Show("Ingrese un DNI válido.");
                inputDni.Focus();
                return;
            }

            try
            {
                connectionBD.Open();

                string query = @"SELECT Nombre, Apellido, Correo, Celular
                         FROM clientes
                         WHERE Dni = @Dni";

                MySqlCommand cmd = new MySqlCommand(query, connectionBD);

                cmd.Parameters.AddWithValue("@Dni", dni);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    inputNombre.Text = reader["Nombre"].ToString();
                    inputApellido.Text = reader["Apellido"].ToString();
                    inputCorreo.Text = reader["Correo"].ToString();
                    inputCelular.Text = reader["Celular"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");

                    inputNombre.Clear();
                    inputApellido.Clear();
                    inputCorreo.Clear();
                    inputCelular.Clear();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
            finally
            {
                if (connectionBD.State == System.Data.ConnectionState.Open)
                {
                    connectionBD.Close();
                }
            }


        }

        private void inputDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

