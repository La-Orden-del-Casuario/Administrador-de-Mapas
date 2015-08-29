using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Web.UI.WebControls;
using Entities;
using BLL;

namespace UI
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private bool ValidUser { get; set; }

        private bool validUser = false;
        private bool validPassword = false;
        private GestorUsuarios gestor = new GestorUsuarios();
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.txtUsuario.KeyDown += new KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtPass.KeyDown += new KeyEventHandler(this.txtUsuario_KeyDown);

        }

        private void chkContra_CheckedChanged(object sender, EventArgs e)
        {

            if (chkContra.Checked)
            {

                RecuperarContra recuperar = new RecuperarContra();
                this.Hide();
                recuperar.ShowDialog(this);
                this.Show();


            }

        }

        private void checkUserError()
        {

            if (txtUsuario.Text == "")
            {


                errorUsuario.SetError(txtUsuario, "Usuario Invalido");
                validUser = false;


            }
            else
            {

                errorUsuario.Clear();
                validUser = true;

            }

        }



        private void checkPasswordError()
        {


            if (txtPass.Text == "")
            {

                errorPassword.SetError(txtPass, "Contraseña Invalida");
                validPassword = false;


            }
            else
            {

                errorPassword.Clear();
                validPassword = true;

            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

            checkUserError();

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

            checkPasswordError();


        }


        void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                checkPasswordError();
                checkUserError();

                if (validPassword || validUser)
                {

                    Authenticate();
                }
            }
        }

        private void Authenticate()
        {
            try
            {

                string password = txtPass.Text;
                string correo = txtUsuario.Text;

                Usuario usuario = gestor.validarUsuario(correo);

                ValidUser = PasswordHash.ValidatePassword(password, usuario.Password);

                iniciarSesion(usuario);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al intentar iniciar sesion. ", "Error.");
                Console.WriteLine(ex.ToString());

            } 
        }

        private void iniciarSesion(Usuario _usuario)
        {
            if (ValidUser)
            {

                int _userID = _usuario.Id;
                String _user = _usuario.Nombre;

                frmInicio Inicio = new frmInicio {UserID = _userID, User = _user};
                this.Hide();
                Inicio.ShowDialog(this);
                this.Close();

            }
            else
            {


                MessageBox.Show("Error al intentar iniciar sesion: ", "Error.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            checkPasswordError();
            checkUserError();

            if (validPassword || validUser)
            {

                Authenticate();

            }
        }


    }
}