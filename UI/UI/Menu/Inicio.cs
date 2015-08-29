using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UI.Pantallas;



namespace UI
{
    public partial class frmInicio : DevExpress.XtraEditors.XtraForm
    {
        public frmInicio()
        {
            InitializeComponent();
            btnPerfil.AppearanceItem.Normal.BorderColor = Color.Black;


        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            frmLocal frmAgregar = new frmLocal(){ IsCreate = true};
            this.Hide();
            frmAgregar.ShowDialog(this);
            this.Show();


        }

        private void btnAdmin_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            AdminLocales frmAdmin = new AdminLocales();
            this.Hide();
            frmAdmin.ShowDialog(this);
            this.Show();

        }

        private void btnPerfil_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }

        private void btnUsuarios_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }



    }
}
