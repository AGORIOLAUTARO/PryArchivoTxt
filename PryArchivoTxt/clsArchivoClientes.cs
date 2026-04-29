using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PryArchivoTxt
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";

        public void Grabar(string cod, string nom, string deu, string lim)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);
            

            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
               string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();


            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        

        }

        public Decimal TotalDeuda()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            decimal Total = 0;
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total += Convert.ToDecimal(VecDatos[2]);
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return Total;
        }
        public int CantDeudores()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            int Cant = 0;
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                {
                    Cant++;
                }
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return Cant;
        }
        public Decimal PromedioDeuda()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            decimal Total = 0;
            int Cant = 0;
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total += Convert.ToDecimal(VecDatos[2]);
                if (Convert.ToDecimal(VecDatos[2]) > 0)
                {
                    Cant++;
                }
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            if (Cant > 0)
            {
                return Total / Cant;
            }
            else
            {
                return 0;
            }
        }
        public Int32 CantClientes()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            int Cant = 0;
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Cant++;
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return Cant;
        }
        public Decimal PromedioLimite()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            decimal Total = 0;
            int Cant = 0;
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total += Convert.ToDecimal(VecDatos[3]);
                Cant++;
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            if (Cant > 0)
            {
                return Total / Cant;
            }
            else
            {
                return 0;
            }
        }
    }
}