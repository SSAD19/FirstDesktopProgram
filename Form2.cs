using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSILVA_log
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            groupAlta.Hide();
            btnactualizar.Hide();
            btnAlta.Hide();
            comando = @"Select* from productos";
            cargarGrilla(comando);

        }

        Acciones.ProdAcc acciones = new Acciones.ProdAcc();        
        Entidades.Producto producto = new Entidades.Producto();
        List<Entidades.Producto> Listado = new List<Entidades.Producto>();
        string comando;


        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupAlta.Show();
            btnAlta.Show();

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtstock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void regreso() {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtstock.Clear();
            txtBuscador.Clear();

            cbBaja.Checked = false;

            producto.idproducto =-1;
            producto.nombre = " ";
            producto.preciounit = -1;
            producto.stock = -1;

            comando = @"Select* from productos";
            cargarGrilla(comando);

            groupAlta.Hide();     
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(grillaProd.CurrentRow.Cells[0].Value);
            
            acciones.ModifProd(cargarDatos(), id); 

            comando = @"Select* from productos";
            cargarGrilla(comando);

            regreso();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            acciones.altaProd(cargarDatos());
            
            comando = @"Select* from productos";
            cargarGrilla(comando);

            regreso();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtBuscador.Text;
           string comando;

           if (txtBuscador.Text == "")
           {
               comando = @"Select* from productos";
               cargarGrilla(comando);
           }
           else
           {
               comando = @"Select* from productos where Nombre like '" + buscar + "%'";
               cargarGrilla(comando);
           }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            groupAlta.Show();

            int indx = grillaProd.CurrentRow.Index;

            txtNombre.Text = grillaProd.Rows[indx].Cells[1].Value.ToString();
            txtPrecio.Text = grillaProd.Rows[indx].Cells[2].Value.ToString();
            txtstock.Text = grillaProd.Rows[indx].Cells[3].Value.ToString();

            cbBaja.Checked = Convert.ToBoolean(grillaProd.Rows[indx].Cells[4].Value.ToString());
 
            btnactualizar.Show();

        }


        private Entidades.Producto cargarDatos() {
            bool check;

            if (cbBaja.Checked)
            {
                check = true;
            }
            else { check = false; }

            acciones.crearProd(producto, txtNombre.Text, double.Parse(txtPrecio.Text), int.Parse(txtstock.Text), check);
           return producto;
        }


        public void cargarGrilla(string xcommand) {

            List<Entidades.Producto> ver =  new List<Entidades.Producto>();
            ver = acciones.traerBD(xcommand);
           

            if (ver.Count > 0)
            {
                
                txtBuscador.Enabled = true;

                grillaProd.DataSource = null;
                grillaProd.AutoGenerateColumns = true;
                grillaProd.DataSource = ver;
                grillaProd.ReadOnly = true; 

            }
            else
            {
                button1.Focus();
                txtBuscador.Enabled = false;
            }
        }
    }
}
