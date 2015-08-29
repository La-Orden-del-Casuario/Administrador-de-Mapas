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
using System.Collections;

namespace UI.PantallasUsuarios
{
    public partial class AdminUsuarios : DevExpress.XtraEditors.XtraForm
    {

        private GestorUsuarios gestor = new GestorUsuarios();


        public AdminUsuarios()
        {
            InitializeComponent();
            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {

            try
            {

                IEnumerable lstUsuarios = gestor.consultarUsuarios();
                dgvUsuarios.Rows.Clear();

                foreach (Usuario usuario in lstUsuarios)
                {

                    dgvUsuarios.Rows.Add(usuario.Id, usuario.Nombre, usuario.Email, usuario.FechaRegistro);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error.");

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuario usuarios = new frmUsuario { isCreate = true};
            this.Hide();
            usuarios.ShowDialog(this);
            this.Show();
            actualizarDatagrid();
        }


    }
}