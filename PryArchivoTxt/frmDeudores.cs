using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryArchivoTxt
{
    public partial class frmDeudores : Form
    {
        public frmDeudores()
        {
            InitializeComponent();
        }

        clsArchivoClientes arc = new clsArchivoClientes();
        private void frmDeudores_Load(object sender, EventArgs e)
        {
            arc.Listar(dgvClientes);
            lblTotalDeuda.Text= "$" + arc.TotalDeuda().ToString();
            lblCantClient.Text = arc.CantDeudores().ToString();
            lblPromedio.Text = "$" + arc.PromedioDeuda().ToString();
        }
    }
}
