namespace SSILVA_log
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impirmirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.selecFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grillaVenta = new System.Windows.Forms.DataGridView();
            this.groupAlta = new System.Windows.Forms.GroupBox();
            this.btnModifItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxProd = new System.Windows.Forms.ComboBox();
            this.productosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.almacen1DataSet1 = new SSILVA_log.Almacen1DataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.productosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.almacen1DataSet = new SSILVA_log.Almacen1DataSet();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new SSILVA_log.Almacen1DataSetTableAdapters.productosTableAdapter();
            this.productosTableAdapter1 = new SSILVA_log.Almacen1DataSet1TableAdapters.productosTableAdapter();
            this.btnbajaVen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).BeginInit();
            this.groupAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacen1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacen1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.impirmirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Enabled = false;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ventasToolStripMenuItem.Text = "Ventas ";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // impirmirToolStripMenuItem
            // 
            this.impirmirToolStripMenuItem.Name = "impirmirToolStripMenuItem";
            this.impirmirToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.impirmirToolStripMenuItem.Text = "Imprimir";
            this.impirmirToolStripMenuItem.Click += new System.EventHandler(this.impirmirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de ventas: ";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(15, 69);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(203, 20);
            this.txtbuscar.TabIndex = 4;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // selecFecha
            // 
            this.selecFecha.Location = new System.Drawing.Point(495, 66);
            this.selecFecha.Name = "selecFecha";
            this.selecFecha.Size = new System.Drawing.Size(136, 20);
            this.selecFecha.TabIndex = 5;
            this.selecFecha.ValueChanged += new System.EventHandler(this.selecFecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "* Doble click sobre el registro para ver detalles, modificar o borrar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nueva Venta ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grillaVenta
            // 
            this.grillaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVenta.Location = new System.Drawing.Point(18, 95);
            this.grillaVenta.Name = "grillaVenta";
            this.grillaVenta.Size = new System.Drawing.Size(613, 150);
            this.grillaVenta.TabIndex = 8;
            this.grillaVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaVenta_CellDoubleClick);
            // 
            // groupAlta
            // 
            this.groupAlta.Controls.Add(this.btnModifItem);
            this.groupAlta.Controls.Add(this.label3);
            this.groupAlta.Controls.Add(this.btnVenta);
            this.groupAlta.Controls.Add(this.btnProducto);
            this.groupAlta.Controls.Add(this.txtCantidad);
            this.groupAlta.Controls.Add(this.label6);
            this.groupAlta.Controls.Add(this.label5);
            this.groupAlta.Controls.Add(this.cboxProd);
            this.groupAlta.Controls.Add(this.label4);
            this.groupAlta.Controls.Add(this.lblFactura);
            this.groupAlta.Location = new System.Drawing.Point(25, 302);
            this.groupAlta.Name = "groupAlta";
            this.groupAlta.Size = new System.Drawing.Size(591, 194);
            this.groupAlta.TabIndex = 9;
            this.groupAlta.TabStop = false;
            this.groupAlta.Text = "Venta";
            // 
            // btnModifItem
            // 
            this.btnModifItem.Location = new System.Drawing.Point(438, 131);
            this.btnModifItem.Name = "btnModifItem";
            this.btnModifItem.Size = new System.Drawing.Size(136, 23);
            this.btnModifItem.TabIndex = 11;
            this.btnModifItem.Text = "Modificar item";
            this.btnModifItem.UseVisualStyleBackColor = true;
            this.btnModifItem.Click += new System.EventHandler(this.btnBajaIten_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio unitario:";
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(267, 136);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(154, 23);
            this.btnVenta.TabIndex = 8;
            this.btnVenta.Text = "Finalizar Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(292, 106);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(129, 23);
            this.btnProducto.TabIndex = 7;
            this.btnProducto.Text = "Agregar producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(73, 82);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtotal:";
            // 
            // cboxProd
            // 
            this.cboxProd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource2, "idproducto", true));
            this.cboxProd.DataSource = this.productosBindingSource2;
            this.cboxProd.DisplayMember = "Nombre";
            this.cboxProd.FormattingEnabled = true;
            this.cboxProd.Location = new System.Drawing.Point(73, 55);
            this.cboxProd.Name = "cboxProd";
            this.cboxProd.Size = new System.Drawing.Size(121, 21);
            this.cboxProd.TabIndex = 3;
            this.cboxProd.ValueMember = "idproducto";
            this.cboxProd.SelectedIndexChanged += new System.EventHandler(this.cboxProd_SelectedIndexChanged);
            // 
            // productosBindingSource2
            // 
            this.productosBindingSource2.DataMember = "productos";
            this.productosBindingSource2.DataSource = this.almacen1DataSet1;
            // 
            // almacen1DataSet1
            // 
            this.almacen1DataSet1.DataSetName = "Almacen1DataSet1";
            this.almacen1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producto: ";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(7, 26);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(52, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura : ";
            // 
            // productosBindingSource1
            // 
            this.productosBindingSource1.DataMember = "productos";
            this.productosBindingSource1.DataSource = this.almacen1DataSet;
            // 
            // almacen1DataSet
            // 
            this.almacen1DataSet.DataSetName = "Almacen1DataSet";
            this.almacen1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.almacen1DataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter1
            // 
            this.productosTableAdapter1.ClearBeforeFill = true;
            // 
            // btnbajaVen
            // 
            this.btnbajaVen.Location = new System.Drawing.Point(495, 260);
            this.btnbajaVen.Name = "btnbajaVen";
            this.btnbajaVen.Size = new System.Drawing.Size(136, 23);
            this.btnbajaVen.TabIndex = 10;
            this.btnbajaVen.Text = "Baja venta";
            this.btnbajaVen.UseVisualStyleBackColor = true;
            this.btnbajaVen.Click += new System.EventHandler(this.btnbajaVen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 551);
            this.Controls.Add(this.btnbajaVen);
            this.Controls.Add(this.groupAlta);
            this.Controls.Add(this.grillaVenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selecFecha);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Almacen - Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVenta)).EndInit();
            this.groupAlta.ResumeLayout(false);
            this.groupAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacen1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacen1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DateTimePicker selecFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grillaVenta;
        private System.Windows.Forms.GroupBox groupAlta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxProd;
        private Almacen1DataSet almacen1DataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Almacen1DataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource1;
        private Almacen1DataSet1 almacen1DataSet1;
        private System.Windows.Forms.BindingSource productosBindingSource2;
        private Almacen1DataSet1TableAdapters.productosTableAdapter productosTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifItem;
        private System.Windows.Forms.Button btnbajaVen;
        private System.Windows.Forms.ToolStripMenuItem impirmirToolStripMenuItem;

    }
}

