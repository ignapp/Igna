using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;


namespace Arriendo_Vehiculos
{
    class conexion
    {
        public SqlDataReader Dr;
        public SqlConnection Conn = new SqlConnection(); 
        public SqlCommand Tabb = new SqlCommand(); 
        public SqlDataAdapter Dadap = new SqlDataAdapter(); 
        public DataSet Dset = new DataSet();        

        public conexion(){
            try
            {
                //Conn.ConnectionString = "Initial Catalog=Vehiculos; " +
                //                        "Data Source=localhost;" +
                //                        "Integrated Security=SSPI";  
                ConnectionStringSettings conSettings = ConfigurationManager.ConnectionStrings["vehiculos"];
                string connectionString = conSettings.ConnectionString;
                Conn = new SqlConnection(connectionString);
            }
            catch (Exception RR)
            {                
                throw RR;
            }
        }        

        public void cerrar()
        {
            if (Dset != null)
            {
                Dset.Clear();
            }
            if (Dr != null)
            {
                Dr.Close();
            }
            Conn.Close();            
        }

        public void creartabla1()
        {
            Dset.Clear();
            Dr.Close();
            try
            {                
                Tabb = new SqlCommand("create table cliente(id int IDENTITY(1,1) primary key(id),rut varchar(12));", Conn);
                Dadap.SelectCommand = Tabb;
                Dadap.Fill(Dset, "Vehiculos");             
                Tabb = new SqlCommand("create table arriendo(id int IDENTITY(1,1) primary key(id),dias int,totalpagar int,cliente int foreign key references cliente(id),vehiculo int foreign key references modelovehiculo(id));", Conn);
                Dadap.SelectCommand = Tabb;
                Dadap.Fill(Dset, "Vehiculos");               
                Dset.Dispose();                
            }
            catch (Exception RR)
            {
                MessageBox.Show(RR.Message);
            }
        }

        public void creartabla2()
        {
            Dset.Clear();
            Dr.Close();
            Tabb = new SqlCommand("create table tipovehiculo(id int primary key(id),tipo varchar(20));", Conn);
            Dadap.SelectCommand = Tabb;
            Dadap.Fill(Dset, "Vehiculos");
            Tabb = new SqlCommand("create table marcavehiculo(id int IDENTITY(1,1) primary key(id),marca varchar(20),tipo int foreign key references tipovehiculo(id));", Conn);
            Dadap.SelectCommand = Tabb;
            Dadap.Fill(Dset, "Vehiculos");
            Tabb = new SqlCommand("create table modelovehiculo(id int IDENTITY(1,1) primary key(id),modelo varchar(20),tipo int foreign key references tipovehiculo(id),marca int foreign key references marcavehiculo(id),arancel int,);", Conn);
            Dadap.SelectCommand = Tabb;
            Dadap.Fill(Dset, "Vehiculos");
            Tabb = new SqlCommand("insert into tipovehiculo values(1,'Automovil');insert into tipovehiculo values(2,'Camioneta');insert into tipovehiculo values(3,'Jeep');insert into tipovehiculo values(4,'Motocicleta');", Conn);
            Dadap.SelectCommand = Tabb;
            Dadap.Fill(Dset, "Vehiculos");
            Tabb = new SqlCommand("insert into marcavehiculo values('Ford',1);insert into marcavehiculo values('Jaguar',1);insert into marcavehiculo values('BMW',1);insert into marcavehiculo values('Ferrari',1);insert into marcavehiculo values('Ford',2);insert into marcavehiculo values('Chevrolet',2);insert into marcavehiculo values('Nissan',2);insert into marcavehiculo values('Volkswagen',2);insert into marcavehiculo values('BMW',3);insert into marcavehiculo values('Mercedez Benz',3);insert into marcavehiculo values('Volkswagen',3);insert into marcavehiculo values('Range Rover',3);insert into marcavehiculo values('BMW',4);insert into marcavehiculo values('Guzzi',4);insert into marcavehiculo values('KTM',4);insert into marcavehiculo values('Honda',4);", Conn);
            Dadap.SelectCommand = Tabb;
            Dadap.Fill(Dset, "Vehiculos");
            Tabb = new SqlCommand("insert into modelovehiculo values('Fiesta',1,1,15000);insert into modelovehiculo values('Focus',1,1,25000);insert into modelovehiculo values('Mustang',1,1,40000);insert into modelovehiculo values('Taurus',1,1,40000);insert into modelovehiculo values('F-Type',1,2,50000);insert into modelovehiculo values('XE',1,2,60000);insert into modelovehiculo values('XF',1,2,60000);insert into modelovehiculo values('XJ',1,2,65000);insert into modelovehiculo values('Z4',1,3,40000);insert into modelovehiculo values('Serie 5 Sedan',1,3,40000);insert into modelovehiculo values('Serie 6 Sedan',1,3,50000);insert into modelovehiculo values('Serie 7 Sedan',1,3,60000);insert into modelovehiculo values('FF',1,4,60000);insert into modelovehiculo values('458 Spider',1,4,55000);insert into modelovehiculo values('LaFerrari',1,4,70000);insert into modelovehiculo values('Ferrari California T',1,4,65000);insert into modelovehiculo values('F-150',2,5,30000);insert into modelovehiculo values('Super Duty',2,5,35000);insert into modelovehiculo values('Raptor',2,5,40000);insert into modelovehiculo values('D-Max',2,6,25000);insert into modelovehiculo values('Silverado Simple',2,6,20000);insert into modelovehiculo values('Silverado Extendida',2,6,30000);insert into modelovehiculo values('Terrano',2,7,20000);insert into modelovehiculo values('Navara',2,7,25000);insert into modelovehiculo values('Navara HD',2,7,30000);insert into modelovehiculo values('Amarok',2,8,20000);insert into modelovehiculo values('Amarok Simple',2,8,15000);insert into modelovehiculo values('Amarok Highline',2,8,25000);insert into modelovehiculo values('X4',3,9,40000);insert into modelovehiculo values('X5',3,9,50000);insert into modelovehiculo values('X6',3,9,60000);insert into modelovehiculo values('G',3,10,40000);insert into modelovehiculo values('GL',3,10,50000);insert into modelovehiculo values('GLX',3,10,60000);insert into modelovehiculo values('Touareg',3,11,50000);insert into modelovehiculo values('Tiguan',3,11,35000);insert into modelovehiculo values('Defender',3,12,50000);insert into modelovehiculo values('Discovery',3,12,60000);insert into modelovehiculo values('Range Rover',3,12,65000);insert into modelovehiculo values('k 1600 GT',4,13,10000);insert into modelovehiculo values('k 1600 GTL',4,13,15000);insert into modelovehiculo values('k 1600 GT Exclusive',4,13,25000);insert into modelovehiculo values('Stelvio 1200 8V',4,14,10000);insert into modelovehiculo values('Stelvio 1200 8V NTX',4,14,20000);insert into modelovehiculo values('Norge 1200 GT',4,14,15000);insert into modelovehiculo values('1190 Adventure',4,15,10000);insert into modelovehiculo values('1190 Adventure',4,15,15000);insert into modelovehiculo values('1290 Super Adventure',4,15,20000);insert into modelovehiculo values('CBR 500RR',4,16,10000);insert into modelovehiculo values('CBR 600RR',4,16,15000);insert into modelovehiculo values('CBR 1000RR',4,16,20000);", Conn);
            Dadap.SelectCommand = Tabb;
            Dadap.Fill(Dset, "Vehiculos");
            Dset.Dispose();
        }

        public void creartablausu()
        {            
            try
            {
                Conn.Open();
                Tabb = new SqlCommand("create table usuario(id varchar(20),pass varchar(20))", Conn);
                Dadap.SelectCommand = Tabb;
                Dadap.Fill(Dset, "Vehiculos");
                Tabb = new SqlCommand("insert into usuario values('admin','123456');insert into usuario values('notadmin','654321');", Conn);
                Dadap.SelectCommand = Tabb;
                Dadap.Fill(Dset, "Vehiculos");
                Dset.Dispose();
                Conn.Close();
            }
            catch (Exception RR)
            {
                MessageBox.Show(RR.Message);
            }
        }

            public int contarregistros()
            {
                Dset.Clear();
                Dr.Close();
                int contador=0;
                try
                {                    
                    Tabb = new SqlCommand("select count(id) from arriendo", Conn);
                    contador = (int)Tabb.ExecuteScalar();
                }
                catch (Exception RR)
                {
                    MessageBox.Show(RR.Message);
                }
                return contador;
            }

            public void crearBD()
            {
                if (master.crearbd() == true)
                {
                    creartablausu();
                }                                         
            }

            public Boolean logearusuario(string usu, string pass)
            {
                Conn.Open();
                Tabb = new SqlCommand("select id,pass from usuario where id='" + usu + "' and pass='" + pass + "';", Conn);
                Dr = Tabb.ExecuteReader();
                if (Dr.Read() == true)
                {
                    Conn.Close();
                    return true;                    
                }
                else
                {
                    Conn.Close();
                    return false;                    
                }
            }

            public void combo1(ComboBox cbo)
            {
                try
                {
                    Tabb = new SqlCommand("select tipo from tipovehiculo;", Conn);
                    Dr = Tabb.ExecuteReader();
                    while (Dr.Read())
                    {
                        cbo.Items.Add(Dr["tipo"]);
                    }
                    Dr.Dispose();
                    Dr.Close();
                }
                catch (Exception RR)
                {
                    throw RR;
                }              
            }

            public void combo2(ComboBox cbo1,ComboBox cbo2)
            {
                string tipo = cbo1.Text;
                Tabb = new SqlCommand("select marcavehiculo.marca from marcavehiculo,tipovehiculo where marcavehiculo.tipo=tipovehiculo.id and tipovehiculo.tipo='" + tipo + "';", Conn);
                try
                {
                    Dr = Tabb.ExecuteReader();
                    while (Dr.Read())
                    {
                        cbo2.Items.Add(Dr["marca"]);
                    }
                    Dr.Close();
                    Dr.Dispose();
                }
                catch (Exception RR)
                {
                    throw RR;
                }            
            }

            public void combo3(ComboBox cbo1, ComboBox cbo2, ComboBox cbo3)
            {
                string tipo = cbo1.Text;
                string marca = cbo2.Text;
                Tabb = new SqlCommand("select * from modelovehiculo,marcavehiculo,tipovehiculo where modelovehiculo.marca=marcavehiculo.id and marcavehiculo.tipo=tipovehiculo.id and marcavehiculo.marca='" + marca + "'  and tipovehiculo.tipo='" + tipo + "';", Conn);
                try
                {
                    Dr = Tabb.ExecuteReader();
                    while (Dr.Read())
                    {
                        cbo3.Items.Add(Dr["modelo"]);
                    }
                    Dr.Close();
                    Dr.Dispose();
                }
                catch (Exception RR)
                {
                    throw RR;
                }
            }

            public Boolean conectar1(Label l)
            {
                try
                {                    
                    if (master.existebd() == false)
                    {                        
                        return false;
                    }
                    else
                    {                        
                        Conn.Open();
                        if (Dset != null)
                        {
                            Dset.Clear();
                        }
                        if (Dr != null)
                        {
                            Dr.Close();
                        }
                        Tabb = new SqlCommand("select * from Information_Schema.Tables where table_name='arriendo';", Conn);
                        Dr = Tabb.ExecuteReader();
                        if (Dr.Read() == true)
                        {
                            l.Text = contarregistros().ToString();
                            Dr.Close();
                        }
                        else
                        {
                            Dr.Close();
                        }
                        Dr.Close();
                        Tabb = new SqlCommand("select * from Information_Schema.Tables where table_name='tipovehiculo';", Conn);
                        Dr = Tabb.ExecuteReader();
                        if (Dr.Read() == false)
                        {
                            creartabla2();
                            Dr.Close();
                        }
                        else
                        {
                            Dr.Close();
                        }
                        Dr.Close();
                        return true;
                    }
                }
                catch (Exception RR)
                {
                    throw RR;
                }
            }

            public Boolean conectar2()
            {
                try
                {
                    if (master.existebd() == false)
                    {
                        return false;
                    }
                    else
                    {                        
                        try
                        {
                            Conn.Open();
                            Tabb = new SqlCommand("select * from Information_Schema.Tables where table_name='arriendo';", Conn);
                            Dr = Tabb.ExecuteReader();
                            if (Dr.Read() == false)
                            {
                                Conn.Close();
                                return false;
                            }
                            else
                            {
                                Dset.Clear();
                                Dr.Close();
                                return true;
                            }
                        }
                        catch (Exception RR)
                        {
                            MessageBox.Show(RR.Message);
                            return false;
                        }
                    }
                }
                catch (Exception RR)
                {
                    throw RR;
                }            
            }

            public string numero(string sql)
            {
                string numero;                
                Tabb = new SqlCommand(sql, Conn);
                try
                {
                    Dr = Tabb.ExecuteReader();
                    Dr.Read();
                    numero = Dr.GetValue(0).ToString();
                    Dr.Close();
                    Dr.Dispose();
                }
                catch (Exception RR)
                {
                    throw RR;
                }
                return numero;
            }            
        }                              
    }

