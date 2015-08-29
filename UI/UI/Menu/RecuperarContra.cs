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
using Entities;
using BLL;

namespace UI
{
    public partial class RecuperarContra : DevExpress.XtraEditors.XtraForm
    {

        GestorUsuarios gestor = new GestorUsuarios();
        public RecuperarContra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtCorreo.Text == "")
            {

                errorProvider1.SetError(txtCorreo, "Debe ingresar un correo valido.");

            }
            else {

                errorProvider1.Clear();
                enviarCorreo();
            
            }


        }

        private void enviarCorreo()
        {
            string random_String = getRandomPassword();
            string password = PasswordHash.CreateHash(random_String);
            string email = txtCorreo.Text;


            try
            {

                int result = gestor.recuperarPassword(email, password);

                if (result == 1)
                {

                    Cartero cartero = new Cartero { ReceiversAddress = email, subject = "Nueva Contraseña", body = "Su nueva contraseña es: " + random_String };
                    cartero.enviarCarta();
                    MessageBox.Show("Por favor revise su correo, se ha enviado una nueva contraseña ", "Recuperar Contraseña");
                }
                else
                {
                    MessageBox.Show("Correo invalido", "Error.");

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Recuperar Contraseña", MessageBoxButtons.OK);

            }






        }

        private string getRandomPassword()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }
    }
}