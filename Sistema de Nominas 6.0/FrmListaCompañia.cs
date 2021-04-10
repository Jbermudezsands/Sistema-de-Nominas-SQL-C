using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Sistema_Nominas
{
    public partial class FrmListaCompañia : DevExpress.XtraEditors.XtraForm
    {
        //EntCompañias EntCompañia = new EntCompañias();
        ConexionSQLNeg ConexionAccess = new ConexionSQLNeg();
        ConexionSQLNeg ConexionSQL = new ConexionSQLNeg();
        FrmEntrada FrmEntrada = new FrmEntrada();


        public FrmListaCompañia()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListaCompañia_Load(object sender, EventArgs e)
        {
            listBoxCompañia.DisplayMember = "NombreBD";
            listBoxCompañia.DataSource = ConexionAccess.ListadoCompañia();

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
             
            string CadenaConexionSQL = "";
            EntCompañias.Nombre_Compañia = listBoxCompañia.Text; 

             //***************************************************************************************************************
             //BUSCO SI LA COMPAÑIA EXISTE ************************************************
             //***************************************************************************************************************
             CadenaConexionSQL = ConexionSQL.BuscaCompañia(EntCompañias.Nombre_Compañia);
            if (CadenaConexionSQL == "")
            {
                MessageBox.Show("Error al intentar Conectarse","Zeus Nominas", MessageBoxButtons.OK);
            }
            else
            {
                string sss = EntCompañias.Nombre_Compañia;
                EntCompañias.Cadena = CadenaConexionSQL;
                if (ConexionSQL.CantUsuario() == 0) 
                {
                    MessageBox.Show("No Existen usuarios", "Zeus Nominas", MessageBoxButtons.OK );

                }
                else
                {
                    this.Hide();
                    FrmEntrada.ShowDialog();
                    this.Close();


                }

            }
        }
    }
}