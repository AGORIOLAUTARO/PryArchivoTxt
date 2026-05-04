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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes x = new clsArchivoClientes();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(dgvClientes);
            lblResultadoTotalDeuda.Text = x.TotalDeuda().ToString();
            lblResultadoCantidadClientes.Text= x.CantClientes().ToString();
         
            lblResultadoPromedioDeuda.Text= x.PromedioDeuda().ToString();
             
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado con exito");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            x.Listar(dgvClientes);
            MessageBox.Show("Archivo Ordenado");
        }
    }
}
