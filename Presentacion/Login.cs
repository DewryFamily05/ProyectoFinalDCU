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
using Dominio;

namespace Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {

            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAccerder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO") {
                if (txtPass.Text != "CONTRASEÑA") {
                    DominioUsuario usuario = new DominioUsuario();
                    var validarLogin = usuario.LoginUser(txtUsuario.Text, txtPass.Text);

                    if (validarLogin == true) {

                        FormPrincipal menuPrinpipal = new FormPrincipal();
                        menuPrinpipal.Show();
                        menuPrinpipal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        mjError("Nombre de Usuario o Contraseña incorrecta. \n       Por Favor, verificar que los datos sean correctos");
                        txtPass.Text = "CONTRASEÑA";
                        txtUsuario.Focus();
                    }
                }
                else mjError("Ingrese su Contraseña.");
            }
            else mjError("Ingrese su nombre de Usuario.");
        }

        public void mjError(string mj)
        {
            lblMensajeError.Text = "        " + mj;
            lblMensajeError.Visible = true;

        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensajeError.Visible = false;
            this.Show();
            //txtUsuario.Focus();
        }
    }
}
