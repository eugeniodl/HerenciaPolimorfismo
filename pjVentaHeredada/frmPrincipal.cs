using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaHeredada
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnContado_Click(object sender, EventArgs e)
        {
            frmContado frmContado = new frmContado();
            frmContado.ShowDialog();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            frmCredito frmCredito = new frmCredito();
            frmCredito.ShowDialog();
        }
    }
}
