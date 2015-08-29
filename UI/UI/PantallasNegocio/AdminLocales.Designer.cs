namespace UI.Pantallas
{
    partial class AdminLocales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLocales));
            this.plHead = new System.Windows.Forms.Panel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.dgvLocales = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPreferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plFooter = new System.Windows.Forms.Panel();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.plHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).BeginInit();
            this.plFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // plHead
            // 
            this.plHead.Controls.Add(this.txtFiltrar);
            this.plHead.Location = new System.Drawing.Point(1, 1);
            this.plHead.Name = "plHead";
            this.plHead.Size = new System.Drawing.Size(1180, 70);
            this.plHead.TabIndex = 0;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(43, 24);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(188, 21);
            this.txtFiltrar.TabIndex = 3;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvLocales
            // 
            this.dgvLocales.AllowUserToAddRows = false;
            this.dgvLocales.AllowUserToDeleteRows = false;
            this.dgvLocales.AllowUserToOrderColumns = true;
            this.dgvLocales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNombre,
            this.ColTel,
            this.ColPreferencia,
            this.ColProvincia,
            this.ColDes,
            this.ColURL});
            this.dgvLocales.Location = new System.Drawing.Point(22, 77);
            this.dgvLocales.Name = "dgvLocales";
            this.dgvLocales.ReadOnly = true;
            this.dgvLocales.Size = new System.Drawing.Size(1169, 375);
            this.dgvLocales.TabIndex = 3;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColTel
            // 
            this.ColTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTel.HeaderText = "Teléfono";
            this.ColTel.Name = "ColTel";
            this.ColTel.ReadOnly = true;
            // 
            // ColPreferencia
            // 
            this.ColPreferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPreferencia.HeaderText = "Preferencia";
            this.ColPreferencia.Name = "ColPreferencia";
            this.ColPreferencia.ReadOnly = true;
            // 
            // ColProvincia
            // 
            this.ColProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColProvincia.HeaderText = "Provincia";
            this.ColProvincia.Name = "ColProvincia";
            this.ColProvincia.ReadOnly = true;
            // 
            // ColDes
            // 
            this.ColDes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDes.HeaderText = "Descripcion";
            this.ColDes.Name = "ColDes";
            this.ColDes.ReadOnly = true;
            // 
            // ColURL
            // 
            this.ColURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColURL.HeaderText = "Mapa";
            this.ColURL.Name = "ColURL";
            this.ColURL.ReadOnly = true;
            // 
            // plFooter
            // 
            this.plFooter.Controls.Add(this.btnAgregar);
            this.plFooter.Controls.Add(this.btnEliminar);
            this.plFooter.Controls.Add(this.btnEditar);
            this.plFooter.Location = new System.Drawing.Point(1, 458);
            this.plFooter.Name = "plFooter";
            this.plFooter.Size = new System.Drawing.Size(1180, 81);
            this.plFooter.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(211, 30);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(406, 30);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 30);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AdminLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 539);
            this.Controls.Add(this.dgvLocales);
            this.Controls.Add(this.plFooter);
            this.Controls.Add(this.plHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLocales";
            this.Text = "Administrar";
            this.plHead.ResumeLayout(false);
            this.plHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocales)).EndInit();
            this.plFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plHead;
        internal System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dgvLocales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPreferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColURL;
        private System.Windows.Forms.Panel plFooter;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;

    }
}