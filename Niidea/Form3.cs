using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niidea
{
    public partial class Form3 : Form
    {
        MySqlConnection connectionBD = new MySqlConnection(
            "server=127.0.0.1;port=3306;user=root;password=;database=app;"
        );

        private void CargarTabla()
        {
            try
            {
                connectionBD.Open();

                string query = "SELECT * FROM catalogo";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionBD);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

               
                dataGridView1.AutoGenerateColumns = false;

               
                Codigo.DataPropertyName = "idCodigo";
                Categoria.DataPropertyName = "Categoria";
                Stock.DataPropertyName = "Stock";
                Nombre.DataPropertyName = "Nombre";

                dataGridView1.DataSource = dt;

                connectionBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
