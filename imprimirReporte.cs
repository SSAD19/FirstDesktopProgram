using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SSILVA_log
{
    public partial class imprimirReporte : Form
    {
           private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        int ticket; 

        public imprimirReporte()
        {
            InitializeComponent();
            var resultado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de  ticket de compra que desea imprimir", "Factura", "Ticket", 100, 0);

            MessageBox.Show("" + resultado, "se imprimirá la factura", MessageBoxButtons.OK);

            ticket = int.Parse(resultado);
        }
        
        public void imprimirReporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'AlmacenFactura.vistaVentas' Puede moverla o quitarla según sea necesario.
        
            this.vistaVentasTableAdapter.FillBy(this.AlmacenFactura.vistaVentas, ticket);
            List<ReportParameter> misParametros = new List<ReportParameter>();
            misParametros.Add(new ReportParameter("fecha", DateTime.Now.ToString("dd-MM-yy HH:mm")));
         
            Factura.LocalReport.SetParameters(misParametros);

            this.Factura.RefreshReport();
            this.Factura.RefreshReport();
        }

    }
}
