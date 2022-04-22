namespace Presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.imagenLogoInicio = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccerder = new System.Windows.Forms.Button();
            this.linkPass = new System.Windows.Forms.LinkLabel();
            this.btnCerrarInicio = new System.Windows.Forms.PictureBox();
            this.btnMinimizarInicio = new System.Windows.Forms.PictureBox();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.panelLogo.Controls.Add(this.imagenLogoInicio);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 385);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // imagenLogoInicio
            // 
            this.imagenLogoInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(218)))), ((int)(((byte)(221)))));
            this.imagenLogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("imagenLogoInicio.Image")));
            this.imagenLogoInicio.Location = new System.Drawing.Point(-3, 79);
            this.imagenLogoInicio.Name = "imagenLogoInicio";
            this.imagenLogoInicio.Size = new System.Drawing.Size(250, 174);
            this.imagenLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenLogoInicio.TabIndex = 0;
            this.imagenLogoInicio.TabStop = false;
            this.imagenLogoInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(290, 114);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(443, 15);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(290, 97);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(443, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(290, 166);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(443, 21);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(290, 183);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(443, 15);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(317, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hospital Dr. Jorge Taveras Familia";
            // 
            // btnAccerder
            // 
            this.btnAccerder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnAccerder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccerder.FlatAppearance.BorderSize = 0;
            this.btnAccerder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAccerder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccerder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccerder.ForeColor = System.Drawing.Color.LightGray;
            this.btnAccerder.Location = new System.Drawing.Point(302, 283);
            this.btnAccerder.Name = "btnAccerder";
            this.btnAccerder.Size = new System.Drawing.Size(408, 40);
            this.btnAccerder.TabIndex = 3;
            this.btnAccerder.Text = "ACCEDER";
            this.btnAccerder.UseVisualStyleBackColor = false;
            this.btnAccerder.Click += new System.EventHandler(this.btnAccerder_Click);
            // 
            // linkPass
            // 
            this.linkPass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkPass.AutoSize = true;
            this.linkPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPass.ForeColor = System.Drawing.Color.DeepPink;
            this.linkPass.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkPass.Location = new System.Drawing.Point(403, 336);
            this.linkPass.Name = "linkPass";
            this.linkPass.Size = new System.Drawing.Size(203, 17);
            this.linkPass.TabIndex = 0;
            this.linkPass.TabStop = true;
            this.linkPass.Text = "¿Has olvidado la contraseña?";
            // 
            // btnCerrarInicio
            // 
            this.btnCerrarInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarInicio.Image")));
            this.btnCerrarInicio.Location = new System.Drawing.Point(764, 0);
            this.btnCerrarInicio.Name = "btnCerrarInicio";
            this.btnCerrarInicio.Size = new System.Drawing.Size(15, 15);
            this.btnCerrarInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarInicio.TabIndex = 8;
            this.btnCerrarInicio.TabStop = false;
            this.btnCerrarInicio.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizarInicio
            // 
            this.btnMinimizarInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarInicio.Image")));
            this.btnMinimizarInicio.Location = new System.Drawing.Point(743, 0);
            this.btnMinimizarInicio.Name = "btnMinimizarInicio";
            this.btnMinimizarInicio.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizarInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizarInicio.TabIndex = 9;
            this.btnMinimizarInicio.TabStop = false;
            this.btnMinimizarInicio.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeError.ForeColor = System.Drawing.Color.Silver;
            this.lblMensajeError.Image = ((System.Drawing.Image)(resources.GetObject("lblMensajeError.Image")));
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(299, 211);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(124, 19);
            this.lblMensajeError.TabIndex = 10;
            this.lblMensajeError.Text = "Mensaje de error";
            this.lblMensajeError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(83)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(780, 385);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.btnMinimizarInicio);
            this.Controls.Add(this.btnCerrarInicio);
            this.Controls.Add(this.linkPass);
            this.Controls.Add(this.btnAccerder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPrincipal_MouseDown);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenLogoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccerder;
        private System.Windows.Forms.LinkLabel linkPass;
        private System.Windows.Forms.PictureBox btnCerrarInicio;
        private System.Windows.Forms.PictureBox btnMinimizarInicio;
        private System.Windows.Forms.PictureBox imagenLogoInicio;
        private System.Windows.Forms.Label lblMensajeError;
    }
}

