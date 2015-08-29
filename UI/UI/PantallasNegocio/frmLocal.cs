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
using System.Text.RegularExpressions;
using BLL;
using System.Data.SqlClient;
using Entities;

namespace UI.Pantallas
{
    public partial class frmLocal : DevExpress.XtraEditors.XtraForm
    {
        public bool IsCreate { get; set; }
        public int  localID { get; set; }


        private String query = "https://www.google.com/maps/place/Costa+Rica/&output=embed";
        private GestorLocales gestor = new GestorLocales();

        private bool validName;
        private bool validTel;
        private bool validUrl;
        public frmLocal()
        {
            InitializeComponent();
        }

        /**
         *  Metodo que al cargar el formulario de agregar se encarga de desplegar Google Maps
         *  
         * */

        private void AgregarLocal_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'pM_DataSet.Preferencias' table. You can move, or remove it, as needed.
            this.preferenciasTableAdapter.Fill(this.pM_DataSet.Preferencias);
            // TODO: This line of code loads data into the 'pM_DataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.pM_DataSet.Provincias);
            // TODO: This line of code loads data into the 'pM_DataSet.Provincias' table. You can move, or remove it, as needed.
            this.provinciasTableAdapter.Fill(this.pM_DataSet.Provincias);

            if (!IsCreate) {

                getLocal();

            }

            loadMap();



        }

        private void getLocal()
        {
            try{

                Local local = gestor.consultarLocalById(localID);

                txtNombre.Text = local.Name.Trim();
                txtTel.Text    = local.Tel.Trim();
                cmbPref.SelectedValue = local.Preferencia;
                cmbProv.SelectedValue = local.Provincia;
                txtURL.Text = local.Url.Trim();
                txtDescrip.Text = local.Descrip.Trim();
                query = local.Url;

            }catch (Exception ex){

                MessageBox.Show(ex.Message, "Buscar local", MessageBoxButtons.OK);

            }
        }



        private void loadMap()  {


                try{

                    wbGMap.Dock = DockStyle.Fill;

                    StringBuilder queryAddress = new StringBuilder();

                    queryAddress.Append(query);

                    wbGMap.Navigate(queryAddress.ToString());


                }catch (Exception ex){

                    MessageBox.Show(ex.ToString(), "Error.");

                }

            }


        private void btnGetCoord_Click(object sender, EventArgs e) {


            try
            {

                txtURL.Clear();
                txtURL.Text = wbGMap.Url.ToString();
                Clipboard.SetText(txtURL.Text);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error.");

            }



        }

        private void btnAgregar_Click(object sender, EventArgs e) {

            validateData();

            if (validName && validUrl && validTel) {


                if (IsCreate)
                {
                    agregarLocal();
                }
                else {
                    modificarLocal();
                }
                
            
            }

        }





        private void validateData() {

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


            if (txtURL.Text == "")
            {
                errorURL.SetError(txtURL, "Debe ingresar una URL valida.");
                validUrl = false;
            }
            else
            {
                errorURL.Clear();
                validUrl = true;
            }


            if (txtTel.Text == "" || (System.Text.RegularExpressions.Regex.IsMatch(txtTel.Text, "[^0-9]")) )
            {
                errorTel.SetError(txtTel, "Debe ingresar un telefono valido.");
                validTel = false;
            }
            else
            {
                errorTel.Clear();
                validTel = true;
            }

        
      }



        private void agregarLocal() {


            String nombre      = txtNombre.Text.Trim();
            String telefono    = txtTel.Text.Trim();
            int preferencia    = Convert.ToInt32(cmbPref.SelectedValue);
            int provincia      = Convert.ToInt32(cmbProv.SelectedValue);
            String url         = txtURL.Text.Trim();
            String descripcion = txtDescrip.Text.Trim();

            try { 
                
                gestor.agregarLocal(nombre, telefono, preferencia, provincia, url, descripcion);
                MessageBox.Show("Se ha agregado un nuevo local", "Agregar local", MessageBoxButtons.OK);
                cleanInput();
            
            } catch(Exception ex) {

                MessageBox.Show(ex.Message, "Agregar local", MessageBoxButtons.OK);
            
            }

       
        }

        private void modificarLocal()
        {
            String nombre = txtNombre.Text.Trim();
            String telefono = txtTel.Text.Trim();
            int preferencia = Convert.ToInt32(cmbPref.SelectedValue);
            int provincia = Convert.ToInt32(cmbProv.SelectedValue);
            String url = txtURL.Text.Trim();
            String descripcion = txtDescrip.Text.Trim();

            query = txtURL.Text;

            try
            {

                gestor.editarLocal(localID, nombre, telefono, preferencia, provincia, url, descripcion);
                loadMap();
             
                MessageBox.Show("Se ha modificado el local " + nombre, "Agregar local", MessageBoxButtons.OK);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Modificar local", MessageBoxButtons.OK);

            }
        }



        private void cleanInput()
        {
            txtNombre.Clear();
            txtTel.Clear();
            txtURL.Clear();
            txtDescrip.ResetText();

        }


        private void txtTel_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtTel.Text, "[^0-9]"))
            {
                //txtTel.Clear();
                //errorTel.SetError(txtTel, "Debe ingresar un telefono.");
                 validTel = false;
            }
            else
            {
                errorTel.Clear();
                validTel = true;
            }
        }



    } //Fin Clase

} //Fin namespace