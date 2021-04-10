
namespace Sistema_Nominas
{
    partial class FrmListaCompañia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCompañia));
            this.listBoxCompañia = new DevExpress.XtraEditors.ListBoxControl();
            this.BtnSeleccionar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCompañia)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCompañia
            // 
            this.listBoxCompañia.Location = new System.Drawing.Point(12, 12);
            this.listBoxCompañia.Name = "listBoxCompañia";
            this.listBoxCompañia.Size = new System.Drawing.Size(332, 285);
            this.listBoxCompañia.TabIndex = 0;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.ImageOptions.Image")));
            this.BtnSeleccionar.Location = new System.Drawing.Point(13, 304);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(96, 39);
            this.BtnSeleccionar.TabIndex = 1;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.ImageOptions.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(247, 304);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(97, 39);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmListaCompañia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 358);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.listBoxCompañia);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmListaCompañia.IconOptions.LargeImage")));
            this.Name = "FrmListaCompañia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Compañias";
            this.Load += new System.EventHandler(this.FrmListaCompañia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxCompañia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxCompañia;
        private DevExpress.XtraEditors.SimpleButton BtnSeleccionar;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
    }
}