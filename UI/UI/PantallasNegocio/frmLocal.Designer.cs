namespace UI.Pantallas
{
    partial class frmLocal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocal));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.provinciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pM_DataSet = new UI.BaseLocal.PM_DataSet();
            this.cmbPref = new System.Windows.Forms.ComboBox();
            this.preferenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescrip = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lblDescrip = new DevExpress.XtraEditors.LabelControl();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblLat = new DevExpress.XtraEditors.LabelControl();
            this.btnGetCoord = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProv = new DevExpress.XtraEditors.LabelControl();
            this.lblPref = new DevExpress.XtraEditors.LabelControl();
            this.lblTel = new DevExpress.XtraEditors.LabelControl();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.wbGMap = new WebKit.WebKitBrowser();
            this.provinciasTableAdapter = new UI.BaseLocal.PM_DataSetTableAdapters.ProvinciasTableAdapter();
            this.preferenciasTableAdapter = new UI.BaseLocal.PM_DataSetTableAdapters.PreferenciasTableAdapter();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorURL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTel = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pM_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.txtTel);
            this.splitContainer1.Panel1.Controls.Add(this.cmbProv);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPref);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescrip);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.lblDescrip);
            this.splitContainer1.Panel1.Controls.Add(this.txtURL);
            this.splitContainer1.Panel1.Controls.Add(this.lblLat);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetCoord);
            this.splitContainer1.Panel1.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel1.Controls.Add(this.lblProv);
            this.splitContainer1.Panel1.Controls.Add(this.lblPref);
            this.splitContainer1.Panel1.Controls.Add(this.lblTel);
            this.splitContainer1.Panel1.Controls.Add(this.lblNombre);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.wbGMap);
            this.splitContainer1.Size = new System.Drawing.Size(1109, 582);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 26;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(116, 108);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(132, 21);
            this.txtTel.TabIndex = 51;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // cmbProv
            // 
            this.cmbProv.DataSource = this.provinciasBindingSource;
            this.cmbProv.DisplayMember = "prv_nombre";
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Location = new System.Drawing.Point(116, 242);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(132, 21);
            this.cmbProv.TabIndex = 50;
            this.cmbProv.ValueMember = "prv_id";
            // 
            // provinciasBindingSource
            // 
            this.provinciasBindingSource.DataMember = "Provincias";
            this.provinciasBindingSource.DataSource = this.pM_DataSet;
            // 
            // pM_DataSet
            // 
            this.pM_DataSet.DataSetName = "PM_DataSet";
            this.pM_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPref
            // 
            this.cmbPref.DataSource = this.preferenciasBindingSource;
            this.cmbPref.DisplayMember = "pref_categoria";
            this.cmbPref.FormattingEnabled = true;
            this.cmbPref.Location = new System.Drawing.Point(116, 178);
            this.cmbPref.Name = "cmbPref";
            this.cmbPref.Size = new System.Drawing.Size(132, 21);
            this.cmbPref.TabIndex = 48;
            this.cmbPref.ValueMember = "pref_id";
            // 
            // preferenciasBindingSource
            // 
            this.preferenciasBindingSource.DataMember = "Preferencias";
            this.preferenciasBindingSource.DataSource = this.pM_DataSet;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.Appearance.Options.UseForeColor = true;
            this.btnAgregar.BackgroundImage = global::UI.Properties.Resources.back;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.Location = new System.Drawing.Point(29, 527);
            this.btnAgregar.LookAndFeel.SkinName = "Money Twins";
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 31);
            this.btnAgregar.TabIndex = 47;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(116, 386);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.txtDescrip.Size = new System.Drawing.Size(226, 93);
            this.txtDescrip.TabIndex = 46;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(116, 434);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 19);
            this.labelControl5.TabIndex = 45;
            // 
            // lblDescrip
            // 
            this.lblDescrip.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrip.Location = new System.Drawing.Point(24, 384);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(58, 19);
            this.lblDescrip.TabIndex = 44;
            this.lblDescrip.Text = "Descrip:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(116, 306);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(226, 45);
            this.txtURL.TabIndex = 42;
            // 
            // lblLat
            // 
            this.lblLat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(25, 304);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(35, 19);
            this.lblLat.TabIndex = 40;
            this.lblLat.Text = "URL:";
            // 
            // btnGetCoord
            // 
            this.btnGetCoord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetCoord.Location = new System.Drawing.Point(240, 527);
            this.btnGetCoord.LookAndFeel.SkinName = "Money Twins";
            this.btnGetCoord.Name = "btnGetCoord";
            this.btnGetCoord.Size = new System.Drawing.Size(87, 31);
            this.btnGetCoord.TabIndex = 39;
            this.btnGetCoord.Text = "Get URL";
            this.btnGetCoord.Click += new System.EventHandler(this.btnGetCoord_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 43);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 21);
            this.txtNombre.TabIndex = 33;
            // 
            // lblProv
            // 
            this.lblProv.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(25, 240);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(70, 19);
            this.lblProv.TabIndex = 32;
            this.lblProv.Text = "Provincia:";
            // 
            // lblPref
            // 
            this.lblPref.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPref.Location = new System.Drawing.Point(25, 176);
            this.lblPref.Name = "lblPref";
            this.lblPref.Size = new System.Drawing.Size(84, 19);
            this.lblPref.TabIndex = 30;
            this.lblPref.Text = "Preferencia:";
            // 
            // lblTel
            // 
            this.lblTel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(24, 110);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(68, 19);
            this.lblTel.TabIndex = 27;
            this.lblTel.Text = "Telefono:";
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 19);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre: ";
            // 
            // wbGMap
            // 
            this.wbGMap.BackColor = System.Drawing.Color.White;
            this.wbGMap.Location = new System.Drawing.Point(3, 0);
            this.wbGMap.Name = "wbGMap";
            this.wbGMap.Size = new System.Drawing.Size(714, 579);
            this.wbGMap.TabIndex = 0;
            this.wbGMap.Url = null;
            // 
            // provinciasTableAdapter
            // 
            this.provinciasTableAdapter.ClearBeforeFill = true;
            // 
            // preferenciasTableAdapter
            // 
            this.preferenciasTableAdapter.ClearBeforeFill = true;
            // 
            // errorNombre
            // 
            this.errorNombre.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorNombre.ContainerControl = this;
            // 
            // errorURL
            // 
            this.errorURL.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorURL.ContainerControl = this;
            // 
            // errorTel
            // 
            this.errorTel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorTel.ContainerControl = this;
            // 
            // frmLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 582);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocal";
            this.Text = "Local";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AgregarLocal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.provinciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pM_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescrip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtNombre;
        private DevExpress.XtraEditors.LabelControl lblProv;
        private DevExpress.XtraEditors.LabelControl lblPref;
        private DevExpress.XtraEditors.LabelControl lblTel;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private System.Windows.Forms.TextBox txtURL;
        private DevExpress.XtraEditors.LabelControl lblLat;
        private DevExpress.XtraEditors.SimpleButton btnGetCoord;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.MemoEdit txtDescrip;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lblDescrip;
        private System.Windows.Forms.ComboBox cmbPref;
        private BaseLocal.PM_DataSet pM_DataSet;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.BindingSource provinciasBindingSource;
        private BaseLocal.PM_DataSetTableAdapters.ProvinciasTableAdapter provinciasTableAdapter;
        private System.Windows.Forms.BindingSource preferenciasBindingSource;
        private BaseLocal.PM_DataSetTableAdapters.PreferenciasTableAdapter preferenciasTableAdapter;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorURL;
        private System.Windows.Forms.ErrorProvider errorTel;
        private System.Windows.Forms.TextBox txtTel;
        private WebKit.WebKitBrowser wbGMap;

    }
}