namespace SSILVA_log
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupAlta = new System.Windows.Forms.GroupBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbBaja = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grillaProd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAlta
            // 
            this.groupAlta.Controls.Add(this.btnAlta);
            this.groupAlta.Controls.Add(this.btnactualizar);
            this.groupAlta.Controls.Add(this.txtstock);
            this.groupAlta.Controls.Add(this.txtPrecio);
            this.groupAlta.Controls.Add(this.txtNombre);
            this.groupAlta.Controls.Add(this.cbBaja);
            this.groupAlta.Controls.Add(this.label6);
            this.groupAlta.Controls.Add(this.label5);
            this.groupAlta.Controls.Add(this.label3);
            this.groupAlta.Location = new System.Drawing.Point(386, 27);
            this.groupAlta.Name = "groupAlta";
            this.groupAlta.Size = new System.Drawing.Size(291, 271);
            this.groupAlta.TabIndex = 17;
            this.groupAlta.TabStop = false;
            this.groupAlta.Text = "Producto detalle:";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(119, 216);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(56, 23);
            this.btnAlta.TabIndex = 10;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(109, 187);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(75, 23);
            this.btnactualizar.TabIndex = 9;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(57, 96);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 7;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(98, 65);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(64, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cbBaja
            // 
            this.cbBaja.AutoSize = true;
            this.cbBaja.Location = new System.Drawing.Point(84, 133);
            this.cbBaja.Name = "cbBaja";
            this.cbBaja.Size = new System.Drawing.Size(134, 17);
            this.cbBaja.TabIndex = 4;
            this.cbBaja.Text = "Producto en existencia";
            this.cbBaja.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio Unitario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre: ";
            // 
            // grillaProd
            // 
            this.grillaProd.AutoGenerateColumns = false;
            this.grillaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProd.DataSource = this.proveedorBindingSource;
            this.grillaProd.Location = new System.Drawing.Point(12, 77);
            this.grillaProd.Name = "grillaProd";
            this.grillaProd.Size = new System.Drawing.Size(345, 150);
            this.grillaProd.TabIndex = 16;
            this.grillaProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Registrar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "* Haga click sobre el registro para ver detalles, modificar o borrar";
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(13, 51);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(203, 20);
            this.txtBuscador.TabIndex = 12;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registro y Stock de productos: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ventasToolStripMenuItem.Text = "Ventas ";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Enabled = false;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(710, 320);
            this.Controls.Add(this.groupAlta);
            this.Controls.Add(this.grillaProd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Almacen - Productos";
            this.groupAlta.ResumeLayout(false);
            this.groupAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAlta;
        private System.Windows.Forms.DataGridView grillaProd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox cbBaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnactualizar;
    }
}