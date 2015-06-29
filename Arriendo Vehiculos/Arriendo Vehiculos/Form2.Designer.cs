namespace Arriendo_Vehiculos
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grabar = new System.Windows.Forms.Button();
            this.otro = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.rut = new System.Windows.Forms.MaskedTextBox();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.cbomodelo = new System.Windows.Forms.ComboBox();
            this.arancel = new System.Windows.Forms.TextBox();
            this.arriendo = new System.Windows.Forms.TextBox();
            this.tpagar = new System.Windows.Forms.TextBox();
            this.adelante = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.usulog = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(515, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.conectarToolStripMenuItem.Text = "&Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Enabled = false;
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.desconectarToolStripMenuItem.Text = "&Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "&Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Enabled = false;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARRIENDO DE VEHICULOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° Registros BD:";
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.BackColor = System.Drawing.SystemColors.ControlDark;
            this.contador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contador.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador.Location = new System.Drawing.Point(342, 158);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(22, 24);
            this.contador.TabIndex = 3;
            this.contador.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rut Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo Vehiculo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Modelo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Arancel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "N° Dias de Arriendo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(97, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total Pagar:";
            // 
            // grabar
            // 
            this.grabar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grabar.Enabled = false;
            this.grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grabar.Location = new System.Drawing.Point(47, 618);
            this.grabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(132, 37);
            this.grabar.TabIndex = 11;
            this.grabar.Text = "Grabar";
            this.grabar.UseVisualStyleBackColor = false;
            this.grabar.Click += new System.EventHandler(this.grabar_Click);
            // 
            // otro
            // 
            this.otro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.otro.Enabled = false;
            this.otro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otro.Location = new System.Drawing.Point(189, 618);
            this.otro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.otro.Name = "otro";
            this.otro.Size = new System.Drawing.Size(132, 37);
            this.otro.TabIndex = 12;
            this.otro.Text = "Otro Ingreso";
            this.otro.UseVisualStyleBackColor = false;
            this.otro.Click += new System.EventHandler(this.otro_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menu.Enabled = false;
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(332, 618);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(132, 37);
            this.menu.TabIndex = 13;
            this.menu.Text = "Reestablecer";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.button3_Click);
            // 
            // rut
            // 
            this.rut.Enabled = false;
            this.rut.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rut.Location = new System.Drawing.Point(290, 207);
            this.rut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rut.Mask = "99,999,999-&";
            this.rut.Name = "rut";
            this.rut.Size = new System.Drawing.Size(122, 28);
            this.rut.TabIndex = 14;
            this.rut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rut_KeyPress);
            // 
            // cbotipo
            // 
            this.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipo.Enabled = false;
            this.cbotipo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Location = new System.Drawing.Point(290, 257);
            this.cbotipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(122, 29);
            this.cbotipo.TabIndex = 15;
            this.cbotipo.SelectedIndexChanged += new System.EventHandler(this.cbotipo_SelectedIndexChanged);
            // 
            // cbomarca
            // 
            this.cbomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomarca.Enabled = false;
            this.cbomarca.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(290, 308);
            this.cbomarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(122, 29);
            this.cbomarca.TabIndex = 16;
            this.cbomarca.SelectedIndexChanged += new System.EventHandler(this.cbomarca_SelectedIndexChanged);
            // 
            // cbomodelo
            // 
            this.cbomodelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomodelo.Enabled = false;
            this.cbomodelo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomodelo.FormattingEnabled = true;
            this.cbomodelo.Location = new System.Drawing.Point(290, 359);
            this.cbomodelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbomodelo.Name = "cbomodelo";
            this.cbomodelo.Size = new System.Drawing.Size(122, 29);
            this.cbomodelo.TabIndex = 17;
            this.cbomodelo.SelectedIndexChanged += new System.EventHandler(this.cbomodelo_SelectedIndexChanged);
            // 
            // arancel
            // 
            this.arancel.Enabled = false;
            this.arancel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arancel.Location = new System.Drawing.Point(290, 410);
            this.arancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arancel.Name = "arancel";
            this.arancel.Size = new System.Drawing.Size(122, 28);
            this.arancel.TabIndex = 18;
            // 
            // arriendo
            // 
            this.arriendo.Enabled = false;
            this.arriendo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arriendo.Location = new System.Drawing.Point(290, 460);
            this.arriendo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arriendo.MaxLength = 3;
            this.arriendo.Name = "arriendo";
            this.arriendo.Size = new System.Drawing.Size(122, 28);
            this.arriendo.TabIndex = 19;
            this.arriendo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arriendo_KeyPress);
            // 
            // tpagar
            // 
            this.tpagar.Enabled = false;
            this.tpagar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpagar.Location = new System.Drawing.Point(290, 510);
            this.tpagar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpagar.Name = "tpagar";
            this.tpagar.Size = new System.Drawing.Size(122, 28);
            this.tpagar.TabIndex = 20;
            // 
            // adelante
            // 
            this.adelante.BackColor = System.Drawing.SystemColors.Control;
            this.adelante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adelante.Image = global::Arriendo_Vehiculos.Properties.Resources.Rafiqul_Hassan_Blogger_Arrow_Next_3;
            this.adelante.Location = new System.Drawing.Point(274, 555);
            this.adelante.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adelante.Name = "adelante";
            this.adelante.Size = new System.Drawing.Size(47, 40);
            this.adelante.TabIndex = 23;
            this.adelante.UseVisualStyleBackColor = false;
            this.adelante.Visible = false;
            this.adelante.Click += new System.EventHandler(this.adelante_Click);
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.SystemColors.Control;
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Image = global::Arriendo_Vehiculos.Properties.Resources.Rafiqul_Hassan_Blogger_Arrow_Back_3;
            this.atras.Location = new System.Drawing.Point(189, 555);
            this.atras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(47, 40);
            this.atras.TabIndex = 22;
            this.atras.UseVisualStyleBackColor = false;
            this.atras.Visible = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecha,
            this.hora,
            this.toolStripStatusLabel1,
            this.usulog});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(515, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Margin = new System.Windows.Forms.Padding(2);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(0, 20);
            this.fecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Margin = new System.Windows.Forms.Padding(2);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 20);
            this.toolStripStatusLabel1.Text = "Usuario Logeado:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // usulog
            // 
            this.usulog.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usulog.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.usulog.Name = "usulog";
            this.usulog.Size = new System.Drawing.Size(35, 20);
            this.usulog.Text = "???";
            this.usulog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(515, 691);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.adelante);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.tpagar);
            this.Controls.Add(this.arriendo);
            this.Controls.Add(this.arancel);
            this.Controls.Add(this.cbomodelo);
            this.Controls.Add(this.cbomarca);
            this.Controls.Add(this.cbotipo);
            this.Controls.Add(this.rut);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.otro);
            this.Controls.Add(this.grabar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                          Arriendo de Vehiculos";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button otro;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.MaskedTextBox rut;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.ComboBox cbomodelo;
        private System.Windows.Forms.TextBox arancel;
        private System.Windows.Forms.TextBox arriendo;
        private System.Windows.Forms.TextBox tpagar;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button adelante;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fecha;
        private System.Windows.Forms.ToolStripStatusLabel hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel usulog;
    }
}