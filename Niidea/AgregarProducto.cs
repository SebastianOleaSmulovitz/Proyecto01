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
    public partial class AgregarProducto : Form
    {

        MySqlConnection connectionBD = new MySqlConnection(
           "server=127.0.0.1;port=3306;user=root;password=;database=app;"
       );


        public AgregarProducto()
        {
            InitializeComponent();


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                int Precio = Convert.ToInt32(InputPrecio.Text);
                int Stock = Convert.ToInt32(AddStock.Text);
                string Categoria = BoxCategoria.Text;
                string Nombre = AddNombre.Text;

                connectionBD.Open();

                string query = @"INSERT INTO catalogo
                        (Categoria, Stock, Nombre, Precio)
                        VALUES
                        (@Categoria, @Stock, @Nombre, @Precio)";

                MySqlCommand cmd = new MySqlCommand(query, connectionBD);

                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@Stock", Stock);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Precio", Precio);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Producto agregado correctamente.");

                connectionBD.Close();

               
                AddNombre.Clear();
                AddStock.Clear();
                InputPrecio.Clear();
                BoxCategoria.Text = "";

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                }

            
        }
        



        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
    }

