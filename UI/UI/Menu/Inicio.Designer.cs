namespace UI
{
    partial class frmInicio
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.ControlMenu = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.btnAdd = new DevExpress.XtraEditors.TileItem();
            this.btnAdmin = new DevExpress.XtraEditors.TileItem();
            this.btnPerfil = new DevExpress.XtraEditors.TileItem();
            this.btnUsuarios = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // ControlMenu
            // 
            this.ControlMenu.AppearanceItem.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlMenu.AppearanceItem.Hovered.Options.UseFont = true;
            this.ControlMenu.AppearanceItem.Normal.BackColor = System.Drawing.Color.Silver;
            this.ControlMenu.AppearanceItem.Normal.Options.UseBackColor = true;
            this.ControlMenu.AppearanceText.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlMenu.AppearanceText.Options.UseFont = true;
            this.ControlMenu.BackgroundImage = global::UI.Properties.Resources.fuch;
            this.ControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlMenu.DragSize = new System.Drawing.Size(0, 0);
            this.ControlMenu.Groups.Add(this.tileGroup1);
            this.ControlMenu.Location = new System.Drawing.Point(0, 0);
            this.ControlMenu.MaxId = 30;
            this.ControlMenu.Name = "ControlMenu";
            this.ControlMenu.Size = new System.Drawing.Size(624, 503);
            this.ControlMenu.TabIndex = 0;
            this.ControlMenu.Text = "tileControl1";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.btnAdd);
            this.tileGroup1.Items.Add(this.btnAdmin);
            this.tileGroup1.Items.Add(this.btnPerfil);
            this.tileGroup1.Items.Add(this.btnUsuarios);
            this.tileGroup1.Name = "tileGroup1";
            // 
            // btnAdd
            // 
            this.btnAdd.AppearanceItem.Normal.BackColor = System.Drawing.Color.HotPink;
            this.btnAdd.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.HotPink;
            this.btnAdd.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnAdd.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement1.Image = global::UI.Properties.Resources.pin2;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement1.Text = "Agregar";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.btnAdd.Elements.Add(tileItemElement1);
            this.btnAdd.Id = 7;
            this.btnAdd.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.btnAdd.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnAdmin
            // 
            this.btnAdmin.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdmin.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.btnAdmin.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnAdmin.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement2.Image = global::UI.Properties.Resources.gears;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement2.Text = "Administrar ";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.btnAdmin.Elements.Add(tileItemElement2);
            this.btnAdmin.Id = 8;
            this.btnAdmin.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.btnAdmin.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnAdmin_ItemClick);
            // 
            // btnPerfil
            // 
            this.btnPerfil.AppearanceItem.Normal.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPerfil.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.btnPerfil.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnPerfil.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement3.Image = global::UI.Properties.Resources.User_profile1;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement3.Text = "Perfil";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.btnPerfil.Elements.Add(tileItemElement3);
            this.btnPerfil.Id = 24;
            this.btnPerfil.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.btnPerfil.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnPerfil_ItemClick);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AppearanceItem.Normal.BackColor = System.Drawing.Color.LightSalmon;
            this.btnUsuarios.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.btnUsuarios.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnUsuarios.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement4.Image = global::UI.Properties.Resources.users;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement4.Text = "Usuarios";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.btnUsuarios.Elements.Add(tileItemElement4);
            this.btnUsuarios.Id = 29;
            this.btnUsuarios.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            this.btnUsuarios.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnUsuarios_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.HotPink;
            this.tileItem1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.HotPink;
            this.tileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseBorderColor = true;
            tileItemElement5.Image = global::UI.Properties.Resources.pin2;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            tileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileItemElement5.Text = "Agregar";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItem1.Elements.Add(tileItemElement5);
            this.tileItem1.Id = 7;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 503);
            this.Controls.Add(this.ControlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.Text = "Panel de Control";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl ControlMenu;
        private DevExpress.XtraEditors.TileItem btnAdd;
        private DevExpress.XtraEditors.TileItem btnAdmin;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem btnPerfil;
        private DevExpress.XtraEditors.TileItem btnUsuarios;

    }
}

