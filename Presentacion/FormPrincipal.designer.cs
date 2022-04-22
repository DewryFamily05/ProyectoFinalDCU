namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.barra_de_titulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizarPrincipal = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrarPrincipal = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.subMenuReportes = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnrptConsultas = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnrptPaciente = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnrptMedicos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAlergias = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.lblPosicion = new System.Windows.Forms.Panel();
            this.barra_de_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPrincipal)).BeginInit();
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.subMenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_de_titulo
            // 
            this.barra_de_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(181)))));
            this.barra_de_titulo.Controls.Add(this.btnRestaurar);
            this.barra_de_titulo.Controls.Add(this.btnMinimizarPrincipal);
            this.barra_de_titulo.Controls.Add(this.btnMaximizar);
            this.barra_de_titulo.Controls.Add(this.btnCerrarPrincipal);
            this.barra_de_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_de_titulo.Location = new System.Drawing.Point(0, 0);
            this.barra_de_titulo.Name = "barra_de_titulo";
            this.barra_de_titulo.Size = new System.Drawing.Size(1300, 35);
            this.barra_de_titulo.TabIndex = 0;
            this.barra_de_titulo.Paint += new System.Windows.Forms.PaintEventHandler(this.barra_de_titulo_Paint);
            this.barra_de_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barra_de_titulo_MouseDown);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1223, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(34, 29);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizarPrincipal
            // 
            this.btnMinimizarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarPrincipal.Image")));
            this.btnMinimizarPrincipal.Location = new System.Drawing.Point(1183, 3);
            this.btnMinimizarPrincipal.Name = "btnMinimizarPrincipal";
            this.btnMinimizarPrincipal.Size = new System.Drawing.Size(34, 29);
            this.btnMinimizarPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarPrincipal.TabIndex = 2;
            this.btnMinimizarPrincipal.TabStop = false;
            this.btnMinimizarPrincipal.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1223, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 29);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrarPrincipal
            // 
            this.btnCerrarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarPrincipal.Image")));
            this.btnCerrarPrincipal.Location = new System.Drawing.Point(1263, 3);
            this.btnCerrarPrincipal.Name = "btnCerrarPrincipal";
            this.btnCerrarPrincipal.Size = new System.Drawing.Size(34, 29);
            this.btnCerrarPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarPrincipal.TabIndex = 0;
            this.btnCerrarPrincipal.TabStop = false;
            this.btnCerrarPrincipal.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.menuVertical.Controls.Add(this.lblEmail);
            this.menuVertical.Controls.Add(this.lblNombre);
            this.menuVertical.Controls.Add(this.lblPuesto);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Controls.Add(this.btnCerrarSesion);
            this.menuVertical.Controls.Add(this.subMenuReportes);
            this.menuVertical.Controls.Add(this.btnReporte);
            this.menuVertical.Controls.Add(this.btnAlergias);
            this.menuVertical.Controls.Add(this.btnConsulta);
            this.menuVertical.Controls.Add(this.btnPaciente);
            this.menuVertical.Controls.Add(this.btnMedico);
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 35);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(252, 703);
            this.menuVertical.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.lblEmail.Location = new System.Drawing.Point(95, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.lblNombre.Location = new System.Drawing.Point(95, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.lblPuesto.Location = new System.Drawing.Point(95, 18);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(69, 20);
            this.lblPuesto.TabIndex = 18;
            this.lblPuesto.Text = "Posición";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(3, 669);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(249, 31);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // subMenuReportes
            // 
            this.subMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.subMenuReportes.Controls.Add(this.panel11);
            this.subMenuReportes.Controls.Add(this.btnrptConsultas);
            this.subMenuReportes.Controls.Add(this.panel10);
            this.subMenuReportes.Controls.Add(this.btnrptPaciente);
            this.subMenuReportes.Controls.Add(this.panel9);
            this.subMenuReportes.Controls.Add(this.btnrptMedicos);
            this.subMenuReportes.Location = new System.Drawing.Point(52, 421);
            this.subMenuReportes.Name = "subMenuReportes";
            this.subMenuReportes.Size = new System.Drawing.Size(200, 102);
            this.subMenuReportes.TabIndex = 15;
            this.subMenuReportes.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(3, 70);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 19;
            // 
            // btnrptConsultas
            // 
            this.btnrptConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnrptConsultas.FlatAppearance.BorderSize = 0;
            this.btnrptConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptConsultas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptConsultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnrptConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptConsultas.Location = new System.Drawing.Point(3, 70);
            this.btnrptConsultas.Name = "btnrptConsultas";
            this.btnrptConsultas.Size = new System.Drawing.Size(191, 28);
            this.btnrptConsultas.TabIndex = 18;
            this.btnrptConsultas.Text = "Historial de Consultas";
            this.btnrptConsultas.UseVisualStyleBackColor = false;
            this.btnrptConsultas.Click += new System.EventHandler(this.btnrptPagos_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(3, 36);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 28);
            this.panel10.TabIndex = 17;
            // 
            // btnrptPaciente
            // 
            this.btnrptPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnrptPaciente.FlatAppearance.BorderSize = 0;
            this.btnrptPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptPaciente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnrptPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptPaciente.Location = new System.Drawing.Point(3, 36);
            this.btnrptPaciente.Name = "btnrptPaciente";
            this.btnrptPaciente.Size = new System.Drawing.Size(191, 28);
            this.btnrptPaciente.TabIndex = 16;
            this.btnrptPaciente.Text = "Lista Pacientes";
            this.btnrptPaciente.UseVisualStyleBackColor = false;
            this.btnrptPaciente.Click += new System.EventHandler(this.btnrptCompras_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 15;
            // 
            // btnrptMedicos
            // 
            this.btnrptMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnrptMedicos.FlatAppearance.BorderSize = 0;
            this.btnrptMedicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptMedicos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptMedicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnrptMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptMedicos.Location = new System.Drawing.Point(3, 3);
            this.btnrptMedicos.Name = "btnrptMedicos";
            this.btnrptMedicos.Size = new System.Drawing.Size(194, 28);
            this.btnrptMedicos.TabIndex = 12;
            this.btnrptMedicos.Text = "Lista Médicos";
            this.btnrptMedicos.UseVisualStyleBackColor = false;
            this.btnrptMedicos.Click += new System.EventHandler(this.btnrptVentas_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(3, 383);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(249, 32);
            this.btnReporte.TabIndex = 13;
            this.btnReporte.Text = "Historial de Registos";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAlergias
            // 
            this.btnAlergias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnAlergias.FlatAppearance.BorderSize = 0;
            this.btnAlergias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAlergias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlergias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlergias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnAlergias.Image = ((System.Drawing.Image)(resources.GetObject("btnAlergias.Image")));
            this.btnAlergias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlergias.Location = new System.Drawing.Point(3, 345);
            this.btnAlergias.Name = "btnAlergias";
            this.btnAlergias.Size = new System.Drawing.Size(249, 32);
            this.btnAlergias.TabIndex = 7;
            this.btnAlergias.Text = "Alergias";
            this.btnAlergias.UseVisualStyleBackColor = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(3, 291);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(249, 32);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnPaciente.Image")));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.Location = new System.Drawing.Point(3, 239);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(246, 32);
            this.btnPaciente.TabIndex = 3;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = false;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnMedico.Image = ((System.Drawing.Image)(resources.GetObject("btnMedico.Image")));
            this.btnMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.Location = new System.Drawing.Point(3, 187);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(249, 32);
            this.btnMedico.TabIndex = 1;
            this.btnMedico.Text = "Médico";
            this.btnMedico.UseVisualStyleBackColor = false;
            this.btnMedico.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(252, 164);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // lblPosicion
            // 
            this.lblPosicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.lblPosicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosicion.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblPosicion.Location = new System.Drawing.Point(252, 35);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(1048, 703);
            this.lblPosicion.TabIndex = 2;
            this.lblPosicion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 738);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barra_de_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barra_de_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPrincipal)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.subMenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barra_de_titulo;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox btnCerrarPrincipal;
        private System.Windows.Forms.Panel lblPosicion;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizarPrincipal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnAlergias;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel subMenuReportes;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnrptConsultas;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnrptPaciente;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnrptMedicos;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

