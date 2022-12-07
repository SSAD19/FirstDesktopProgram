namespace SSILVA_log
{
    partial class imprimirReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(imprimirReporte));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Factura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AlmacenFactura = new SSILVA_log.AlmacenFactura();
            this.vistaVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaVentasTableAdapter = new SSILVA_log.AlmacenFacturaTableAdapters.vistaVentasTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.ventasToolStripMenuItem.Text = "Ventas Inicio";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // Factura
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaVentasBindingSource;
            this.Factura.LocalReport.DataSources.Add(reportDataSource1);
            this.Factura.LocalReport.ReportEmbeddedResource = "SSILVA_log.Factura.rdlc";
            this.Factura.Location = new System.Drawing.Point(12, 27);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(688, 419);
            this.Factura.TabIndex = 4;
            // 
            // AlmacenFactura
            // 
            this.AlmacenFactura.DataSetName = "AlmacenFactura";
            this.AlmacenFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaVentasBindingSource
            // 
            this.vistaVentasBindingSource.DataMember = "vistaVentas";
            this.vistaVentasBindingSource.DataSource = this.AlmacenFactura;
            // 
            // vistaVentasTableAdapter
            // 
            this.vistaVentasTableAdapter.ClearBeforeFill = true;
            // 
            // imprimirReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(712, 458);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "imprimirReporte";
            this.Text = "Almacen - Factura";
            this.Load += new System.EventHandler(this.imprimirReporte_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaVentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer Factura;
        private System.Windows.Forms.BindingSource vistaVentasBindingSource;
        private AlmacenFactura AlmacenFactura;
        private AlmacenFacturaTableAdapters.vistaVentasTableAdapter vistaVentasTableAdapter;
    }
}