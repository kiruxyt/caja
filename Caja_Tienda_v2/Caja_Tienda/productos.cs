﻿using System;
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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSet1.Producto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
