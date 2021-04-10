
namespace Sistema_Nominas
{
    partial class FrmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrada));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Usuario:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(105, 13);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(161, 20);
            this.TxtUsuario.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Contraseña";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnAceptar.Location = new System.Drawing.Point(12, 89);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(100, 36);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(186, 89);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 36);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Location = new System.Drawing.Point(105, 40);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(161, 21);
            this.TxtContraseña.TabIndex = 2;
            this.TxtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtContraseña_KeyDown);
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 146);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmEntrada.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsuario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnAceptar;
        private DevExpress.XtraEditors.SimpleButton BtnCancelar;
        private System.Windows.Forms.TextBox TxtContraseña;
    }
}