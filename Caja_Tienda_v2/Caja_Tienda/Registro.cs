using Caja_Tienda.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_Tienda
{
    public partial class Registro : Form
    {
        public Registro()
        {

            InitializeComponent();
        }



        private void Registro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.dataSet1.Factura);



        }
    }
}
