﻿using Caja_Tienda.DataSet1TableAdapters;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
                InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.FacturaP' Puede moverla o quitarla según sea necesario.
            this.facturaPTableAdapter.Fill(this.dataSet1.FacturaP);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSet1.Producto);
            timer1.Start();

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductoTableAdapter producto = new ProductoTableAdapter();
            try
            {
                foreach (var item in producto.GetData().Where(c => c.Id == int.Parse(listBox2.Text)))
                {
                    textBox1.Text = item.Producto;
                }
            }
            catch (Exception)
            {

                
            }
           
          
        }

        public void refreshR()
        {
            FacturaPTableAdapter adapter = new FacturaPTableAdapter();
            dataGridView2.DataSource = adapter.GetData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FacturaPTableAdapter adapter = new FacturaPTableAdapter();
            ProductoTableAdapter producto = new ProductoTableAdapter();
            foreach (var item in producto.GetData().Where(c=> c.Producto == textBox1.Text))
            {
                adapter.Cantidad(item.Producto,item.Precio,item.Itbis,item.Id,true);
                label9.Text = Convert.ToString(item.Precio + item.Itbis);
            }
            dataGridView2.DataSource = adapter.GetData();
            dataGridView2.Refresh();
            label11.Text = Convert.ToString(adapter.GetData().Sum(c => c.Total));

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAGAR pagar = new PAGAR();
            pagar.Show();
        }

        private void eliminarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaPTableAdapter adapter = new FacturaPTableAdapter();
            ProductoTableAdapter producto = new ProductoTableAdapter();
            foreach (var item in producto.GetData().Where(c => c.Producto == textBox1.Text))
            {
                adapter.Cantidad(item.Producto, item.Precio, item.Itbis, item.Id, false);
            }
            dataGridView2.Refresh();
            label11.Text = Convert.ToString(adapter.GetData().Sum(c => c.Total));
        }
            
        private void cancelarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaPTableAdapter adapter = new FacturaPTableAdapter();
            ProductoTableAdapter producto = new ProductoTableAdapter();
            foreach (var item in producto.GetData().Where(c => c.Producto == textBox1.Text))
            {
                
            }
            dataGridView2.Refresh();
            label11.Text = Convert.ToString(adapter.GetData().Sum(c => c.Total));
        }

        private void cerrarSeccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            
               LOGINTableAdapter adapter = new LOGINTableAdapter();
                adapter.Update(true, 1, true);
                Close();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshR();
            timer1.Start();
        }

        private void cancelarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturaPTableAdapter facturaP = new FacturaPTableAdapter();
            facturaP.Cancel(1);
            MessageBox.Show("Venta Canceladad");
        }

        private void registroDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productos registro = new productos();
            registro.Show();
        }
    }
}
