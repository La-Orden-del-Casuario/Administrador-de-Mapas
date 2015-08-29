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
using System.Collections;
using BLL;
using Entities;


namespace UI.Pantallas
{
    public partial class AdminLocales : DevExpress.XtraEditors.XtraForm
    {

        GestorLocales gestor = new GestorLocales();

        int row;
        int id;

        DialogResult result;
        String nombre;


        public AdminLocales()
        {
            InitializeComponent();
            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {

            try
            {

                IEnumerable lstLocales = gestor.consultarLocales();
                dgvLocales.Rows.Clear();

                foreach (Local local in lstLocales)
                {
                    string provincia = getProvincia(local.Provincia);
                    string preferencia = getPreferencia(local.Preferencia);

                    dgvLocales.Rows.Add(local.Id, local.Name, local.Tel, preferencia, provincia, local.Descrip, local.Url);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error.");

            }
        }


        private void btnEliminar_Click(object sender, EventArgs e){

            try
            {

               if( id > 0){

                   result = MessageBox.Show("¿Realmente desea borrar este local?", "Borrar Local", MessageBoxButtons.YesNo);

                   if(result == DialogResult.Yes){

                    row = dgvLocales.CurrentRow.Index;
                    gestor.eliminarLocal((int)dgvLocales[0, row].Value);
                    actualizarDatagrid();

                   }


               }else{


                   MessageBox.Show("Por favor seleccione un local primero", "Locales", MessageBoxButtons.OK);
               }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error.");

            }

        }






        private string getPreferencia(int p)
        {
            string pref;

            switch (p)
            {
                case Constants.MF:

                    pref = "M/F";
                    break;

                case Constants.MM:

                    pref = "M/M";
                    break;

                case Constants.FF:
                    pref = "F/F";
                    break;

                default:
                    pref = "No disponible";
                    break;
            }

            return pref;
        }

        private string getProvincia(int p)
        {

            string provincia;

            switch (p)
            {
                case Constants.SJ:

                    provincia = "San Jose";
                    break;

                case Constants.CA:

                    provincia = "Cartago";
                    break;

                case Constants.AL:
                    provincia = "Alajuela";
                    break;

                case Constants.HE:

                    provincia = "Heredia";
                    break;

                case Constants.LI:
                    provincia = "Limon";
                    break;

                case Constants.PU:

                    provincia = "Puntarenas";
                    break;

                case Constants.GU:

                    provincia = "Guanacaste";
                    break;


                default:
                    provincia = "No disponible";
                    break;
            }

            return provincia;
        }

        private void btnAgregar_Click(object sender, EventArgs e) {


            frmLocal frmAgregar = new frmLocal { IsCreate = true };
            this.Hide();
            frmAgregar.ShowDialog(this);
            this.Show();
            actualizarDatagrid();

        }



        private void btnEditar_Click(object sender, EventArgs e){


            if (id > 0)
            {


                frmLocal frmActualizar = new frmLocal { IsCreate = false, localID = id };
                this.Hide();
                frmActualizar.ShowDialog(this);
                this.Show();
                actualizarDatagrid();

            }
            else
            {


                MessageBox.Show("Por favor seleccione un local primero", "Locales", MessageBoxButtons.OK);
            }


        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e){

            String nombre = txtFiltrar.Text;

            if(txtFiltrar.Text == ""){

                actualizarDatagrid();

            }else{

                try
                {

                    IEnumerable lstLocales = gestor.buscarLocal(nombre);
                    dgvLocales.Rows.Clear();

                    foreach (Local local in lstLocales)
                    {
                        string provincia = getProvincia(local.Provincia);
                        string preferencia = getPreferencia(local.Preferencia);

                        dgvLocales.Rows.Add(local.Id, local.Name, local.Tel, preferencia, provincia, local.Descrip, local.Url);

                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "Error.");

                }
            }

        }

        private void dgvLocales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            row = dgvLocales.CurrentRow.Index;
            id = (int)dgvLocales[0, row].Value;
            nombre = (string)dgvLocales[1, row].Value;

        }





    }
}