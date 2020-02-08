using Comun.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGROHerramientas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbContraseña_MouseHover(object sender, EventArgs e)
        {
        }

        private void pbContraseña_MouseLeave(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
                pbContraseña.Image = Properties.Resources.iconfinder_invisible_82734;
            else
                pbContraseña.Image = Properties.Resources.iconfinder_visible_83082;
        }

        private void pbContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = !txtContraseña.UseSystemPasswordChar;
            if (txtContraseña.UseSystemPasswordChar)
                pbContraseña.Image = Properties.Resources.iconfinder_invisible_82734;
            else
                pbContraseña.Image = Properties.Resources.iconfinder_visible_83082;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void pbContraseña_MouseEnter(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
                pbContraseña.Image = Properties.Resources.iconfinder_visible_83082;
            else
                pbContraseña.Image = Properties.Resources.iconfinder_invisible_82734;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = Log_In.Usuario(txtUsuario.Text, txtContraseña.Text);
                if (Nombre == "")
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos", "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                this.Hide();
                Principal p = new Principal();
                UsuarioIniciado.Usuario = txtUsuario.Text;
                UsuarioIniciado.Contraseña = txtContraseña.Text;
                UsuarioIniciado.Nombre = Nombre;
                UsuarioIniciado.Almacen = cmbAlmacen.SelectedValue.ToString();
                DataTable dt = Log_In.UsuarioValores(txtUsuario.Text);
                UsuarioIniciado.Estacion = int.Parse(dt.Rows[0]["Estacion"].ToString());
                FuncionesComunes.modificarAppSetting("Usuario", txtUsuario.Text);
                FuncionesComunes.modificarAppSetting("Almacen", cmbAlmacen.SelectedValue.ToString());
                DataTable dt2 = Log_In.UsuarioPermisos(txtUsuario.Text);
                UsuarioIniciado.Permisos = dt2.AsEnumerable().Select(r => r.Field<string>("Permiso")).ToList();
                p.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                cmbAlmacen.DataSource = Log_In.Almacenes();
                cmbAlmacen.ValueMember = "Almacen";
                cmbAlmacen.DisplayMember = "Nombre";

                txtUsuario.Text = FuncionesComunes.getAppSetting("Usuario");
                cmbAlmacen.SelectedValue = FuncionesComunes.getAppSetting("Almacen");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio el siguiente problema: " + ex.Message, "Log In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnIniciar_Click(btnIniciar, new EventArgs());
        }
    }
}
