using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Sistema_Nominas
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Text = "Zeus Nominas Compañia: " + EntCompañias.Nombre_Compañia;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}