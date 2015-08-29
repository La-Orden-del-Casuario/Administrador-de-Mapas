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
using BLL;
using Entities;

namespace UI.PantallasUsuarios
{
    public partial class frmUsuario : DevExpress.XtraEditors.XtraForm
    {

        public int UserID { get; set; }
        public bool isCreate { get; set; }

        private String UserPass { get; set; }

        private bool validName;
        private bool validMail;
        private bool validPass;
        private bool isMatch;

        private GestorUsuarios gestor = new GestorUsuarios();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (!isCreate)
            {

                getUser();

            }
            else
            {
                txtVerificar.Hide();
                lblVerificar.Hide();

            }
        }

        private void getUser()
        {
            try
            {

                Usuario usuario = gestor.consultarUsuarioId(UserID);

                txtNombre.Text = usuario.Nombre.Trim();
                txtCorreo.Text = usuario.Email.Trim();
                txtPass.Text = usuario.Password.Trim();
                UserPass     = usuario.Password.Trim();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mi Perfil", MessageBoxButtons.OK);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            validateData();

            if (validName && validMail && validPass)
            {

                if (isCreate)
                {
                    guardarUsuario();
                }
                else
                {
                    validarUsuario();
                }
            }
        }


        private void guardarUsuario()
        {

            String nombre = txtNombre.Text.Trim();
            String password = txtPass.Text.Trim();
            String hashedPassword = PasswordHash.CreateHash(password);
            String correo = txtCorreo.Text.Trim();

            try
            {
                int[] resul = gestor.agregarUsuario(nombre, hashedPassword, correo);


                if (resul[0] >= 1)
                {
                    MessageBox.Show("Se ha agregado un nuevo usuario", "Agregar Usuario", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha habido un error al registrar este usuario", "Agregar Usuario", MessageBoxButtons.OK);

                }


                cleanInput();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Agregar Usuario", MessageBoxButtons.OK);

            }
        }

        private void cleanInput()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtPass.Clear();
        }

        private void validarUsuario()
        {
            
            string verificar = txtVerificar.Text.Trim();
            isMatch  = PasswordHash.ValidatePassword(verificar, UserPass);

            if(isMatch){

                try
                {

                    String nombre = txtNombre.Text.Trim();
                    String password = txtPass.Text.Trim();
                    String hashedPassword = PasswordHash.CreateHash(password);
                    String correo = txtCorreo.Text.Trim();

                    gestor.editarUsuario(UserID, nombre, hashedPassword, correo);
                    MessageBox.Show("Usuario modificado", "Modificar Usuario", MessageBoxButtons.OK);
                    getUser();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Modificar Usuario", MessageBoxButtons.OK);
                } 

            }else{
                MessageBox.Show("Verifique que ambas contraseñas sean iguales", "Modificar Usuario", MessageBoxButtons.OK);
            }

        }


        private void validateData()
        {

            if (txtNombre.Text == "")
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre valido.");
                validName = false;
            }
            else
            {
                errorNombre.Clear();
                validName = true;
            }

            if (txtCorreo.Text == "")
            {
                errorCorreo.SetError(txtCorreo, "Debe ingresar un correo valido.");
                validMail = false;
            }
            else
            {
                errorCorreo.Clear();
                validMail = true;
            }

            if (txtPass.Text == "")
            {
                errorContra.SetError(txtPass, "Debe ingresar una contraseña valida.");
                validPass = false;
            }
            else
            {
                errorContra.Clear();
                validPass = true;
            }
            
            if (!isCreate && txtVerificar.Text == "" )
            {
                errorVerificar.SetError(txtVerificar, "Debe ingresar una contraseña valida.");
                validPass = false;
            }
            else
            {
                errorVerificar.Clear();
                validPass = true;
            }



        }



    }
}