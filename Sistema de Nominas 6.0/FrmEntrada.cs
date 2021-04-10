using System;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Sistema_Nominas
{
    public partial class FrmEntrada : DevExpress.XtraEditors.XtraForm
    {
        FrmMain FrmMain = new FrmMain();
        ConexionSQLNeg CCNegocios = new ConexionSQLNeg();

        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Necesita Digitar el Usuario", "Zeus Nominas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtContraseña.Text == "")
            {
                MessageBox.Show("Necesita Digitar una Contraseña", "Zeus Contable", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (CCNegocios.ContraseñaCorrecta (TxtUsuario.Text , TxtContraseña.Text)== true)
            {
                this.Hide();
                FrmMain.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Constraseña o Usuario Incorrecto!!", "Zeus Nominas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TxtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
            {
                BtnAceptar_Click(sender, e);
            }
        }
    }
}