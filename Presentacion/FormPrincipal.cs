using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaComun.Cache;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void CargarDatosUsuario()
        {
            lblNombre.Text = Cache_de_Inicio_de_sesion.Nombre+" "+Cache_de_Inicio_de_sesion.Apellido;
            lblPuesto.Text = Cache_de_Inicio_de_sesion.Posision;
            lblEmail.Text = Cache_de_Inicio_de_sesion.Imail;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            CerrarAplicacion();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barra_de_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = true;
        }

        private void btnrptVentas_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible=false;
        }

        private void btnrptCompras_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void btnrptPagos_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void AbrirFormsHijo(object formsHijo)
        {
            if(this.lblPosicion.Controls.Count > 0)
                this.lblPosicion.Controls.RemoveAt(0);
            Form fh = formsHijo as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            this.lblPosicion.Controls.Add(fh);
            this.lblPosicion.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormsHijo(new Doctores());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormsHijo(new Inicio());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
            CargarDatosUsuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(menuVertical.Width == 252)
            {
                menuVertical.Width = 67;
            }
            else
            {
                menuVertical.Width = 252;
            }
        }

        private void barra_de_titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CerrarAplicacion()
        {
            if(MessageBox.Show("¿Estás seguro de cerrar la aplicación?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar la sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormsHijo(new Pacientes());
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormsHijo(new Consultas());
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AbrirFormsHijo(new Inicio());
        }
    }
}
