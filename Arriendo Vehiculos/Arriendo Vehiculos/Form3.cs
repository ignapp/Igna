using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Arriendo_Vehiculos
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        conexion c = new conexion();
        private string usu;

        public string usuario
        {
            get { return usu; }
            set { usu = value; }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RefToForm1 != null)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea volver al menu?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    c.cerrar();
                    this.Hide();
                    this.RefToForm1.Show();
                }
            }
            else
            {
                MessageBox.Show("No puede volver al menu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Form RefToForm1 { get; set; }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (c.conectar2() == false)
            {
                MessageBox.Show("No puede conectarse.\nDirijase a los formularios anteriores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Conexion establecida con exito.", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                groupBox3.Enabled = true;
                txtbuscar.Enabled = true;
                txtbuscar.Focus();
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.cerrar();
            MessageBox.Show("Desconexion establecida con exito.", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            desconectarToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
            groupBox3.Enabled = false;
            txtbuscar.Enabled = false;
            limpiar();
        }

        private void listardatabases_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            c.Tabb = new SqlCommand("select name,dbid FROM master..sysdatabases", c.Conn);
            try
            {
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "master");
                DataTable tabla;
                tabla = c.Dset.Tables["master"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString() + fila[1].ToString().PadLeft(10, ' '));
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "master";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            string text = txtbuscar.Text.Trim();
            try
            {
                c.Tabb = new SqlCommand("select arriendo.id,cliente.rut,tipovehiculo.tipo,marcavehiculo.marca,modelovehiculo.modelo,modelovehiculo.arancel,arriendo.dias,arriendo.totalpagar from arriendo,modelovehiculo,cliente,marcavehiculo,tipovehiculo where arriendo.vehiculo=modelovehiculo.id and modelovehiculo.marca=marcavehiculo.id and marcavehiculo.tipo=tipovehiculo.id and arriendo.cliente=cliente.id and (cliente.rut LIKE '" + text + "' or modelovehiculo.modelo LIKE '" + text + "%' or marcavehiculo.marca LIKE '" + text + "%' or tipovehiculo.tipo LIKE '" + text + "%') order by arriendo.id asc;", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "modelo2");
                DataTable tabla;
                tabla = c.Dset.Tables["modelo2"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString().PadRight(3, ' ') + fila[1].ToString().PadRight(14, ' ') + fila[2].ToString().PadRight(11, ' ') + fila[3].ToString().PadRight(14, ' ') + fila[4].ToString().PadRight(17, ' ') + fila[5].ToString().PadRight(7, ' ') + fila[6].ToString().PadRight(4, ' ') + fila[7].ToString());
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "modelo2";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
            if (txtbuscar.Text.Trim() == "")
            {
                listBox1.Items.Clear();
                dataGridView1.DataSource = null;
            }
        }

        private void listartablaarriendo_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            try
            {
                c.Tabb = new SqlCommand("select arriendo.id,cliente.rut,tipovehiculo.tipo,marcavehiculo.marca,modelovehiculo.modelo,modelovehiculo.arancel,arriendo.dias,arriendo.totalpagar from arriendo,cliente,tipovehiculo,marcavehiculo,modelovehiculo where arriendo.cliente=cliente.id and tipovehiculo.id=marcavehiculo.tipo and marcavehiculo.id=modelovehiculo.marca and modelovehiculo.id=arriendo.vehiculo order by arriendo.id asc;", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "vehiculo");
                DataTable tabla;
                tabla = c.Dset.Tables["vehiculo"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString().PadRight(3, ' ') + fila[1].ToString().PadRight(14, ' ') + fila[2].ToString().PadRight(11, ' ') + fila[3].ToString().PadRight(14, ' ') + fila[4].ToString().PadRight(17, ' ') + fila[5].ToString().PadRight(7, ' ') + fila[6].ToString().PadRight(4, ' ') + fila[7].ToString());
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "vehiculo";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        private void limpiar()
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
        }

        private void listar3columnas_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            try
            {
                c.Tabb = new SqlCommand("select arriendo.id,arriendo.dias,arriendo.totalpagar from arriendo order by arriendo.id asc;", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "arriendo2");
                DataTable tabla;
                tabla = c.Dset.Tables["arriendo2"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString().PadRight(15, ' ') + fila[1].ToString().PadRight(15, ' ') + fila[2].ToString());
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "arriendo2";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        private void listar2tablas_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            try
            {
                c.Tabb = new SqlCommand("select * from arriendo,cliente where arriendo.cliente=cliente.id order by arriendo.id asc;", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "arriendo");
                DataTable tabla;
                tabla = c.Dset.Tables["arriendo"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString().PadRight(5, ' ') + fila[1].ToString().PadRight(5, ' ') + fila[2].ToString().PadRight(10, ' ') + fila[3].ToString().PadRight(5, ' ') + fila[4].ToString().PadRight(5, ' ') + fila[5].ToString().PadRight(5, ' ') + fila[6].ToString());
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "arriendo";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        private void listarmodelos_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            try
            {
                c.Tabb = new SqlCommand("select modelovehiculo.modelo from modelovehiculo order by modelovehiculo.id asc;", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "modelo");
                DataTable tabla;
                tabla = c.Dset.Tables["modelo"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString());
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "modelo";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        private void listarusuarios_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
            c.Dset.Clear();
            try
            {
                c.Tabb = new SqlCommand("select * from usuario;", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "usuario");
                DataTable tabla;
                tabla = c.Dset.Tables["usuario"];
                foreach (DataRow fila in tabla.Rows)
                {
                    this.listBox1.Items.Add(fila[0].ToString() + fila[1].ToString().PadLeft(10, ' '));
                }
                dataGridView1.DataSource = c.Dset;
                dataGridView1.DataMember = "usuario";
                c.Dset.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }      

        private void Form3_Load(object sender, EventArgs e)
        {
            usulog.Text = usu;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            hora.Text = System.DateTime.Now.ToString("h:mm:ss tt.", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string a = System.DateTime.Now.ToString("dddd-dd-MMMM-yyyy");
            fecha.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a.ToLower());             
        }
    }
}
