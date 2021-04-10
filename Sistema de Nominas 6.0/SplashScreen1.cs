using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace Sistema_Nominas
{
    public partial class SplashScreen1 : SplashScreen
    {

        ConexionSQLNeg ConexionAccess = new ConexionSQLNeg();

        private void SplashScreen1_Load(object sender, EventArgs e)
        {

        }


        public SplashScreen1()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1999 - " + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        private void timer_Tick(object sender, EventArgs e)
        {
            float iPosicionFila = 0;
            
            if (timer.Interval < 40)
            {
                timer.Interval = timer.Interval + 1;
            }
            else
            {
                if (ConexionAccess.ConsultaCompañia() > 1)

                {
                    timer.Enabled = false; 
                    FrmListaCompañia frmListaCompañias = new FrmListaCompañia();
                    this.Hide();
                    frmListaCompañias.ShowDialog();
                    this.Close();

                    //while (iPosicionFila < ConexionAccess.ConsultaCompañia())
                    //{
                        
                        
                    //    iPosicionFila = iPosicionFila + 1;
                    //}

                }
            }
     


        }
    }
}