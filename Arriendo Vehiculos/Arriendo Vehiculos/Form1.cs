using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Arriendo_Vehiculos
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer(50);
        System.Timers.Timer timer2 = new System.Timers.Timer(50);
        int intentos = 0;
        conexion c = new conexion();
        int altura;        

        public Form1()
        {
            InitializeComponent();
            timer.AutoReset = true;
            timer.SynchronizingObject = this;
            timer.Elapsed += timer_Elapsed;
            timer2.AutoReset = true;
            timer2.SynchronizingObject = this;
            timer2.Elapsed += timer_Elapsed2;
            fecha.Width = this.Width / 2;
            hora.Width = this.Width / 3;
            altura = this.Height;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams miCP = base.CreateParams;
                miCP.ClassStyle = miCP.ClassStyle | CP_NOCLOSE_BUTTON;
                return miCP;
            }
        }

        public void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.Height > label1.Bottom + label1.Height + statusStrip1.Height)
            {                
                timer.Stop();                
            }
            else
            {
                this.Height += 5;
            }            
        }

        public void timer_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.Height < altura)
            {
                timer2.Stop();
            }
            else
            {
                this.Height -= 5;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ignacio Reginato Giglio.\nSebastian Araya Torres.", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: admin\nPassword: 123456\n\n\nUsuario: notadmin\nPassword: 654321", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void irAArriendoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.RefToForm1 = this;
            F2.usuario = txtusuario.Text.Trim();
            this.Visible = false;
            F2.Show();
        }

        private void irAListadoYBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.RefToForm1 = this;
            F3.usuario = txtusuario.Text.Trim();
            this.Visible = false;
            F3.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer2.Start();
                label1.Text = "BIENVENIDO:";
                txtusuario.Text = "";
                txtpass.Text = "";
                txtusuario.Enabled = true;
                txtusuario.Focus();
                archivoToolStripMenuItem.Enabled = false;
                cerrar.Enabled = false;
                label6.Text = "0";
            }
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = System.DateTime.Now.ToString("h:mm:ss tt.", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string a = System.DateTime.Now.ToString("dddd-dd-MMMM-yyyy");
            fecha.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a.ToLower());             
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar == 11)) || (e.KeyChar == 27))
            {
                MessageBox.Show("No puede saltarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (e.KeyChar == 13)
                {
                    if (txtusuario.Text.Trim() != "")
                    {
                        txtusuario.Focus();
                        txtusuario.Enabled = false;
                        txtpass.Enabled = true;
                        txtpass.Focus();
                    }
                    else
                    {
                        txtusuario.Text = "";
                        txtusuario.Focus();
                        MessageBox.Show("No puede dejar espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtpass.Text.Trim() != "")
                {
                    string usu = txtusuario.Text.Trim();
                    string pass = txtpass.Text.Trim();
                    if (c.logearusuario(usu, pass) == true)
                    {
                        MessageBox.Show("Usuario autorizado.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtpass.Enabled = false;
                        archivoToolStripMenuItem.Enabled = true;
                        label1.Text = label1.Text + "  " + txtusuario.Text.Trim();
                        timer.Start();                        
                        cerrar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Error, usuario no autorizado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtusuario.Text = "";
                        txtpass.Text = "";                        
                        txtpass.Enabled = false;
                        txtusuario.Enabled = true;
                        txtusuario.Focus();
                        intentos = intentos + 1;
                        label6.Text = intentos.ToString();
                        if (intentos > 3)
                        {
                            MessageBox.Show("No hay mas intentos.\nEl programa se cerrara.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    txtpass.Text = "";
                    MessageBox.Show("No puede dejar espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpass.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            master.test();                        
        }

        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.crearBD();
            groupBox1.Enabled = true;
            ingresoToolStripMenuItem.Enabled = false;
            txtusuario.Focus();            
        }
    }
}
