using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Arriendo_Vehiculos
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        conexion c = new conexion();
        string id;
        int cont2 = 0;
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

        private void button3_Click(object sender, EventArgs e)
        {
            c.Dset.Clear();
            c.Dr.Close();
            atras.Visible = false;
            adelante.Visible = false;
            limpiar();
            otro.Enabled = false;
            grabar.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            rut.Enabled = true;
            rut.Focus();
        }

        public void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (c.conectar1(contador) == true)
            {
                MessageBox.Show("Conexion establecida con exito.", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
                rut.Enabled = true;
                rut.Focus();
                menu.Enabled = true;
            }
            else
            {
                MessageBox.Show("No puede conectarse.\nLa database aun no ha sido creada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.cerrar();            
            desconectarToolStripMenuItem.Enabled = false;
            conectarToolStripMenuItem.Enabled = true;
            contador.Text = "0";
            atras.Visible = false;
            adelante.Visible = false;
            limpiar();
            otro.Enabled = false;
            menu.Enabled = false;
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            MessageBox.Show("Desconexion establecida con exito.", "Desconectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Form RefToForm1 { get; set; }


        private void rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                {
                    if (e.KeyChar == 13)
                    {
                        if (rut.Text != "")
                        {
                            if (rut.MaskFull == true)
                            {
                                try
                                {
                                    c.Dr.Close();
                                    c.Tabb = new SqlCommand("select * from Information_Schema.Tables where table_name='arriendo';", c.Conn);
                                    c.Dr = c.Tabb.ExecuteReader();
                                    if (c.Dr.Read() == true)
                                    {
                                        c.Dr.Close();
                                        int contador = 0;
                                        try
                                        {
                                            c.Tabb = new SqlCommand("select count(cliente.rut) from cliente,arriendo where arriendo.cliente=cliente.id and cliente.rut='" + rut.Text + "';", c.Conn);
                                            contador = (int)c.Tabb.ExecuteScalar();
                                        }
                                        catch (Exception RR)
                                        {
                                            MessageBox.Show(RR.Message);
                                        }
                                        if (contador == 1)
                                        {
                                            c.Dr.Close();
                                            if (usu == "admin")
                                            {
                                                mostrardatos();
                                            }
                                            else
                                            {
                                                rut.Enabled = false;
                                                cbotipo.Enabled = true;
                                                c.combo1(cbotipo);
                                            }
                                        }
                                        else if (contador > 1)
                                        {
                                            c.Dr.Close();                                            
                                            if (usu == "admin")
                                            {
                                                mostrardatos();
                                                atras.Visible = true;
                                                adelante.Visible = true;
                                            }
                                            else
                                            {
                                                rut.Enabled = false;
                                                cbotipo.Enabled = true;
                                                c.combo1(cbotipo);
                                            }
                                        }
                                        else
                                        {
                                            c.Dr.Close();
                                            rut.Enabled = false;
                                            cbotipo.Enabled = true;
                                            c.combo1(cbotipo);
                                        }
                                    }
                                    else
                                    {
                                        c.Dr.Close();
                                        rut.Enabled = false;
                                        cbotipo.Enabled = true;
                                        c.combo1(cbotipo);
                                    }
                                }
                                catch (Exception RR)
                                {
                                    MessageBox.Show(RR.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Error, ingrese la mascara completa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                rut.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            rut.Text = "";
                            rut.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede dejar espacios en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rut.Text = "";
                        rut.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, ingreso Incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                rut.Text = "";
                rut.Focus();
            }
        }

        private void mostrardatos()
        {
            c.Dr.Close();
            c.Tabb = new SqlCommand("select rut from cliente where rut='" + rut.Text + "';", c.Conn);
            c.Dr = c.Tabb.ExecuteReader();
            if (c.Dr.Read() == true)
            {
                c.Dset.Clear();
                c.Dr.Close();
                c.combo1(cbotipo);
                c.combo2(cbotipo, cbomarca);
                c.combo3(cbotipo, cbomarca, cbomodelo);
                c.Tabb = new SqlCommand("select arriendo.id,cliente.rut,tipovehiculo.tipo,marcavehiculo.marca,modelovehiculo.modelo,modelovehiculo.arancel,arriendo.dias,arriendo.totalpagar from arriendo,cliente,tipovehiculo,marcavehiculo,modelovehiculo where arriendo.cliente=cliente.id and tipovehiculo.id=marcavehiculo.tipo and marcavehiculo.id=modelovehiculo.marca and modelovehiculo.id=arriendo.vehiculo and cliente.rut='" + rut.Text + "';", c.Conn);
                c.Dadap.SelectCommand = c.Tabb;
                c.Dadap.Fill(c.Dset, "arriendo");
                c.Dadap.Fill(c.Dset, "tipovehiculo");
                c.Dadap.Fill(c.Dset, "marcavehiculo");
                c.Dadap.Fill(c.Dset, "modelovehiculo");
                id = c.Dset.Tables[0].Rows[0]["id"].ToString();
                cbotipo.DataBindings.Add("text", c.Dset, "tipovehiculo.tipo");
                cbomarca.DataBindings.Add("text", c.Dset, "marcavehiculo.marca");
                cbomodelo.DataBindings.Add("text", c.Dset, "modelovehiculo.modelo");
                arancel.DataBindings.Add("text", c.Dset, "modelovehiculo.arancel");
                arriendo.DataBindings.Add("text", c.Dset, "arriendo.dias");
                tpagar.DataBindings.Add("text", c.Dset, "arriendo.totalpagar");
                rut.Enabled = false;
                cbotipo.Enabled = true;
                cbomarca.Enabled = true;
                cbomodelo.Enabled = true;
                arriendo.Enabled = true;
                if (usu == "admin")
                {
                    eliminarToolStripMenuItem.Enabled = true;
                    modificarToolStripMenuItem.Enabled = true;
                }
            }
            else
            {
                c.Dr.Close();
                rut.Enabled = false;
                cbotipo.Enabled = true;
                c.combo1(cbotipo);
            }
        }

        private void limpiar()
        {
            id = null;
            cont2 = 0;
            cbotipo.DataBindings.Clear();
            cbomarca.DataBindings.Clear();
            cbomodelo.DataBindings.Clear();
            arancel.DataBindings.Clear();
            arriendo.DataBindings.Clear();
            tpagar.DataBindings.Clear();
            rut.Enabled = false;
            cbotipo.Enabled = false;
            cbomarca.Enabled = false;
            cbomodelo.Enabled = false;
            arancel.Enabled = false;
            arriendo.Enabled = false;
            tpagar.Enabled = false;
            grabar.Enabled = false;
            rut.Text = "";
            cbotipo.Items.Clear();
            cbomarca.Items.Clear();
            cbomodelo.Items.Clear();
            cbotipo.Text = "Seleccione";
            cbomarca.Text = "Seleccione";
            cbomodelo.Text = "Seleccione";
            arancel.Text = "";
            arriendo.Text = "";
            tpagar.Text = "";
        }

        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomarca.Items.Clear();
            cbomodelo.Items.Clear();
            c.combo2(cbotipo, cbomarca);
            cbotipo.Enabled = false;
            cbomarca.Enabled = true;
        }

        private void cbomarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbomodelo.Items.Clear();
            c.combo3(cbotipo, cbomarca, cbomodelo);
            cbotipo.Enabled = false;
            cbomarca.Enabled = false;
            cbomodelo.Enabled = true;
        }

        private void arriendo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                {
                    if (e.KeyChar == 13)
                    {
                        if (arriendo.Text != "" && cbotipo.Text != "" && cbomarca.Text != "" && cbomodelo.Text != "")
                        {
                            if (int.Parse(arriendo.Text) != 0)
                            {
                                MessageBox.Show("Ingreso correcto.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                arriendo.Enabled = false;
                                grabar.Enabled = true;
                                grabar.Focus();
                                tpagar.Text = ((int.Parse(arriendo.Text) * (int.Parse(arancel.Text)))).ToString();
                                cbotipo.Enabled = false;
                                cbomarca.Enabled = false;
                                cbomodelo.Enabled = false;
                                atras.Visible = false;
                                adelante.Visible = false;                                
                            }
                            else
                            {
                                MessageBox.Show("El valor no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                arriendo.Text = "";
                                arriendo.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puede dejar campos en vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (cbomarca.Text == "")
                            {
                                cbomarca.Focus();
                            }
                            else if (cbomodelo.Text == "")
                            {

                                cbomodelo.Focus();
                            }
                            else
                            {
                                arriendo.Focus();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                arriendo.Focus();
            }
        }

        private void cbomodelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbotipo.Enabled = false;
            cbomarca.Enabled = false;
            cbomodelo.Enabled = false;
            arriendo.Enabled = true;
            arriendo.Focus();
            string tipo = cbotipo.Text;
            string marca = cbomarca.Text;
            string modelo = cbomodelo.Text;
            c.Tabb = new SqlCommand("select modelovehiculo.arancel from modelovehiculo,marcavehiculo,tipovehiculo where modelovehiculo.marca=marcavehiculo.id and marcavehiculo.tipo=tipovehiculo.id and modelovehiculo.modelo='" + modelo + "' and marcavehiculo.marca='" + marca + "'  and tipovehiculo.tipo='" + tipo + "';", c.Conn);
            try
            {
                c.Dr = c.Tabb.ExecuteReader();
                c.Dr.Read();
                arancel.Text = c.Dr.GetValue(0).ToString();
                c.Dr.Close();
                c.Dr.Dispose();
            }
            catch (Exception RR)
            {
                throw RR;
            }
        }

        private void grabar_Click(object sender, EventArgs e)
        {
            id = null;
            cont2 = 0;
            cbotipo.DataBindings.Clear();
            cbomarca.DataBindings.Clear();
            cbomodelo.DataBindings.Clear();
            arancel.DataBindings.Clear();
            arriendo.DataBindings.Clear();
            tpagar.DataBindings.Clear();
            c.Dset.Clear();
            c.Dr.Close();
            atras.Visible = false;
            adelante.Visible = false;
            eliminarToolStripMenuItem.Enabled = false;
            modificarToolStripMenuItem.Enabled = false;
            try
            {
                c.Tabb = new SqlCommand("select * from Information_Schema.Tables where table_name='arriendo';", c.Conn);
                c.Dr = c.Tabb.ExecuteReader();
                if (c.Dr.Read() == false)
                {
                    DialogResult result = MessageBox.Show("Tablas no existentes\nDesea crearlas.", "Crear Tablas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        c.creartabla1();
                        grabardatos();
                        c.Dr.Close();
                        c.Dset.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se han podido guardar los datos.\nCree las tablas.", "Tablas no Creadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        c.Dr.Close();
                        c.Dset.Clear();
                    }
                }
                else
                {
                    c.Dset.Clear();
                    c.Dr.Close();
                    grabardatos();
                    c.Dr.Close();
                    c.Dset.Clear();
                }

            }
            catch (Exception RR)
            {
                MessageBox.Show(RR.Message);
            }
        }

        private void grabardatos()
        {
            c.Dset.Clear();
            c.Dr.Close();
            try
            {
                c.Tabb = new SqlCommand("select rut from cliente where cliente.rut='" + rut.Text + "';", c.Conn);
                c.Dr = c.Tabb.ExecuteReader();
                if (c.Dr.Read() == false)
                {
                    c.Dr.Dispose();
                    c.Dr.Close();
                    c.Tabb = new SqlCommand("insert into cliente values(@rut)", c.Conn);
                    c.Dadap.InsertCommand = c.Tabb;
                    c.Dadap.InsertCommand.Parameters.Add(new SqlParameter("@rut", SqlDbType.VarChar));
                    c.Dadap.InsertCommand.Parameters["@rut"].Value = rut.Text;
                    c.Dadap.InsertCommand.ExecuteNonQuery();
                    c.Dr.Close();
                }

            }
            catch (Exception RR)
            {
                MessageBox.Show(RR.Message);
            }
            try
            {
                c.Dr.Dispose();
                c.Dr.Close();
                string sql = "select cliente.id from cliente where cliente.rut='" + rut.Text + "'";
                string sql2 = "select modelovehiculo.id from modelovehiculo,marcavehiculo,tipovehiculo where modelovehiculo.marca=marcavehiculo.id and marcavehiculo.tipo=tipovehiculo.id and modelovehiculo.modelo='" + cbomodelo.Text + "' and marcavehiculo.marca='" + cbomarca.Text + "'  and tipovehiculo.tipo='" + cbotipo.Text + "';";
                c.Tabb = new SqlCommand("insert into arriendo values(@dias,@tpagar,@rut,@modelo)", c.Conn);
                c.Dadap.InsertCommand = c.Tabb;
                c.Dadap.InsertCommand.Parameters.Add(new SqlParameter("@rut", SqlDbType.Int));
                c.Dadap.InsertCommand.Parameters.Add(new SqlParameter("@modelo", SqlDbType.Int));
                c.Dadap.InsertCommand.Parameters.Add(new SqlParameter("@dias", SqlDbType.Int));
                c.Dadap.InsertCommand.Parameters.Add(new SqlParameter("@tpagar", SqlDbType.Int));
                c.Dadap.InsertCommand.Parameters["@rut"].Value = c.numero(sql);
                c.Dadap.InsertCommand.Parameters["@modelo"].Value = c.numero(sql2);
                c.Dadap.InsertCommand.Parameters["@dias"].Value = arriendo.Text;
                c.Dadap.InsertCommand.Parameters["@tpagar"].Value = tpagar.Text;
                c.Dadap.InsertCommand.ExecuteNonQuery();
                contador.Text = c.contarregistros().ToString();
                c.Dset.Dispose();
                MessageBox.Show("Datos guardados correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception RR)
            {
                MessageBox.Show(RR.Message);
            }
            grabar.Enabled = false;
            otro.Enabled = true;            
        }

        private void otro_Click(object sender, EventArgs e)
        {
            otro.Enabled = false;            
            limpiar();
            rut.Enabled = true;
            rut.Focus();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar los datos?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    c.Tabb = new SqlCommand("Delete from arriendo where id=@id", c.Conn);
                    c.Dadap.DeleteCommand = c.Tabb;
                    c.Dadap.DeleteCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    c.Dadap.DeleteCommand.Parameters["@id"].Value = int.Parse(id);
                    c.Dadap.DeleteCommand.ExecuteNonQuery();
                    int contador2 = 0;
                    try
                    {
                        c.Tabb = new SqlCommand("select count(cliente.rut) from cliente,arriendo where arriendo.cliente=cliente.id and cliente.rut='" + rut.Text + "';", c.Conn);
                        contador2 = (int)c.Tabb.ExecuteScalar();
                    }
                    catch (Exception RR)
                    {
                        MessageBox.Show(RR.Message);
                    }
                    if (contador2 == 0)
                    {
                        c.Tabb = new SqlCommand("Delete from cliente where rut=@rut;", c.Conn);
                        c.Dadap.DeleteCommand = c.Tabb;
                        c.Dadap.DeleteCommand.Parameters.Add(new SqlParameter("@rut", SqlDbType.VarChar));
                        c.Dadap.DeleteCommand.Parameters["@rut"].Value = rut.Text;
                        c.Dadap.DeleteCommand.ExecuteNonQuery();
                    }
                    contador.Text = c.contarregistros().ToString();
                    MessageBox.Show("Datos eliminados correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception zz)
                {
                    MessageBox.Show(zz.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiar();
                atras.Visible = false;
                adelante.Visible = false;
                rut.Enabled = true;
                rut.Focus();
                eliminarToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = false;
            }
            else
            {
                MessageBox.Show("Los datos no han sido eliminados.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void atras_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[c.Dset, "arriendo"];
            CurrencyManager cm2 = (CurrencyManager)this.BindingContext[c.Dset, "tipovehiculo"];
            CurrencyManager cm3 = (CurrencyManager)this.BindingContext[c.Dset, "marcavehiculo"];
            CurrencyManager cm4 = (CurrencyManager)this.BindingContext[c.Dset, "modelovehiculo"];
            if (c.Dset.Tables[0].Rows.Count >= cont2 && cont2 != 0)
            {
                cont2--;
                id = c.Dset.Tables[0].Rows[cont2]["id"].ToString();
            }
            cm.Position--;
            cm2.Position--;
            cm3.Position--;
            cm4.Position--;
            cbotipo.Enabled = true;
            cbomarca.Enabled = true;
            cbomodelo.Enabled = true;
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[c.Dset, "arriendo"];
            CurrencyManager cm2 = (CurrencyManager)this.BindingContext[c.Dset, "tipovehiculo"];
            CurrencyManager cm3 = (CurrencyManager)this.BindingContext[c.Dset, "marcavehiculo"];
            CurrencyManager cm4 = (CurrencyManager)this.BindingContext[c.Dset, "modelovehiculo"];
            if (cm.Position == cm.Count - 1 && cm2.Position == cm2.Count - 1 && cm3.Position == cm3.Count - 1 && cm4.Position == cm4.Count - 1)
            {

            }
            else
            {
                if (c.Dset.Tables[0].Rows.Count > cont2 && cont2 != c.Dset.Tables[0].Rows.Count)
                {
                    cont2++;
                    id = c.Dset.Tables[0].Rows[cont2]["id"].ToString();
                }
                cm.Position += 1;
                cm2.Position += 1;
                cm3.Position += 1;
                cm4.Position += 1;
            }
            cbotipo.Enabled = true;
            cbomarca.Enabled = true;
            cbomodelo.Enabled = true;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (arriendo.Text != "" && cbotipo.Text != "" && cbomarca.Text != "" && cbomodelo.Text != "")
            {
                if (int.Parse(arriendo.Text) != 0)
                {
                    DialogResult result = MessageBox.Show("Esta seguro que desea actualizar los datos?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql = "select modelovehiculo.id from modelovehiculo,marcavehiculo,tipovehiculo where modelovehiculo.marca=marcavehiculo.id and marcavehiculo.tipo=tipovehiculo.id and modelovehiculo.modelo='" + cbomodelo.Text + "' and marcavehiculo.marca='" + cbomarca.Text + "'  and tipovehiculo.tipo='" + cbotipo.Text + "';";
                        c.Tabb = new SqlCommand("update arriendo set dias=" + arriendo.Text + ",totalpagar=" + tpagar.Text + ",vehiculo=" + c.numero(sql) + " where id=" + int.Parse(id) + "", c.Conn);
                        c.Dadap.InsertCommand = c.Tabb;
                        c.Dadap.InsertCommand.ExecuteNonQuery();
                        c.Dset.Dispose();
                        MessageBox.Show("Datos actualizados correctamente.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        atras.Visible = false;
                        adelante.Visible = false;
                        rut.Enabled = true;
                        rut.Focus();
                        eliminarToolStripMenuItem.Enabled = false;
                        modificarToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Los datos no han sido actualizados.", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El valor no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    arriendo.Text = "";
                    arriendo.Focus();
                }
            }
            else
            {
                MessageBox.Show("No puede dejar campos vacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cbomarca.Text == "")
                {
                    cbomarca.Focus();
                }
                else if (cbomodelo.Text == "")
                {

                    cbomodelo.Focus();
                }
                else
                {
                    arriendo.Focus();
                }
            }
      }       

        private void Form2_Load(object sender, EventArgs e)
        {
            usulog.Text = usu;
            if (usu != "admin")
            {
                eliminarToolStripMenuItem.Visible = false;
                modificarToolStripMenuItem.Visible = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            hora.Text = System.DateTime.Now.ToString("h:mm:ss tt.", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            string a = System.DateTime.Now.ToString("dddd-dd-MMMM-yyyy");
            fecha.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(a.ToLower());             
        }
    }
}
