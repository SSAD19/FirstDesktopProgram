using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic; 

namespace SSILVA_log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selecFecha.Hide();
            groupAlta.Hide();
            txtbuscar.Enabled = true;
            btnModifItem.Hide();
            btnbajaVen.Hide();

        }
        private void actualizarGrila()
        {

            string comando = @"SELECT dbo.ventas.ticket, dbo.ventas.fecha, dbo.items.iditem, 
                            dbo.productos.Nombre, dbo.items.cantidad, dbo.productos.preciounit, 
                           dbo.items.subtotal, dbo.ventas.total
                         FROM            dbo.items INNER JOIN
                         dbo.productos ON dbo.items.idproducto = dbo.productos.idproducto INNER JOIN
                         dbo.ventas ON dbo.items.idventa = dbo.ventas.idventa
                          WHERE items.bajalog='true' and ventas.bajalog='true'";
            cargarGrilla(comando);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            actualizarGrila();

            string comando = @"Select idproducto, Nombre from productos";
            DataTable productos = accionTraer.traerDatos(comando);
            cboxProd.DataSource = productos;
            cboxProd.DisplayMember = "Nombre";
            cboxProd.ValueMember = "idproducto";

        }

        public void cargarGrilla(string xcomando)
        {

            DataTable tabla = accionTraer.traerDatos(xcomando);

            if (tabla == null)
            {
                button1.Focus();
                txtbuscar.Enabled = false;
            }

            else
            {
                grillaVenta.DataSource = null;
                grillaVenta.AutoGenerateColumns = true;
                grillaVenta.DataSource = tabla;
                grillaVenta.ReadOnly = true;

                selecFecha.Show();
            }
        }

        Entidades.Venta nuevaVenta = new Entidades.Venta();
        Entidades.Item nuevoItem = new Entidades.Item();
        Acciones.ItemVenAcc accionVenta = new Acciones.ItemVenAcc();
        Acciones.general accionTraer = new Acciones.general();

        //producto Datos 
        Entidades.Producto regProducto = new Entidades.Producto();
        Acciones.ProdAcc datosProducto = new Acciones.ProdAcc();

        List<Entidades.Venta> listVenta = new List<Entidades.Venta>();

        double subtotal;
        double total;
        int idProd;
        int cant;
        bool caso = false;
        int comparacion;
        
        private void actListVenta()
        {

            string comando = @"Select* from ventas";
            listVenta = accionVenta.traerVentas(comando);
        }


        string buscar;
        int factNum = 00000; //factura no es venta, es ticket 

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subtotal = 0;
            total = 0;
            groupAlta.Show();
            button1.Hide();

            actListVenta();
            int c = listVenta.Count - 1;

            MessageBox.Show(" numero" + listVenta[c].idventa);

            if (listVenta.Count > 0)
            {
                factNum = listVenta[c].ticket + 1;
                nuevoItem.idventa = listVenta[c].idventa + 1;

            }
            else
            {
                factNum = 1;
                nuevoItem.idventa = 1;
            }

            lblFactura.Text = ("Factura:  FAC-" + factNum);

            nuevaVenta.bajalog = true;
            DateTime ahora = DateTime.Now;
            nuevaVenta.fecha = ahora.ToString("yyyy-MM-dd HH:mm:ss");
            nuevaVenta.total = 0;
            nuevaVenta.ticket = factNum;

            accionVenta.altaVenta(nuevaVenta);

        }

        private void selecFecha_ValueChanged(object sender, EventArgs e)
        {
            string buscarFe = selecFecha.Value.ToString("yyyy-MM-dd");

            DateTime buscarFecha = Convert.ToDateTime(buscarFe);

            string comando = @"SELECT        dbo.ventas.ticket, dbo.ventas.fecha, dbo.items.iditem, dbo.productos.Nombre, dbo.items.cantidad, dbo.productos.preciounit, dbo.items.subtotal, dbo.ventas.total
                         FROM            dbo.items INNER JOIN
                         dbo.productos ON dbo.items.idproducto = dbo.productos.idproducto INNER JOIN
                         dbo.ventas ON dbo.items.idventa = dbo.ventas.idventa
                          WHERE ventas.fecha='" + buscarFecha + "'"; ;
            accionVenta.accionVenta(comando);

            cargarGrilla(comando);
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            buscar = txtbuscar.Text;

            string comando = @"SELECT        dbo.ventas.ticket, dbo.ventas.fecha, dbo.items.iditem, dbo.productos.Nombre, dbo.items.cantidad, dbo.productos.preciounit, dbo.items.subtotal, dbo.ventas.total
                         FROM            dbo.items INNER JOIN
                         dbo.productos ON dbo.items.idproducto = dbo.productos.idproducto INNER JOIN
                         dbo.ventas ON dbo.items.idventa = dbo.ventas.idventa
            WHERE ventas.ticket like '" + buscar + "%' OR productos.Nombre like '" + buscar + "%'";
            cargarGrilla(comando);

        }



        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            actTxt(cant);

            nuevoItem.bajalog = true;
            accionVenta.altaItem(nuevoItem);

            Restablecer();

        }

        private Entidades.Producto rescatarProd(int idp)
        {

            string comando = @"Select* from productos WHERE idproducto='" + idp + "'";
            DataTable datos = accionTraer.traerDatos(comando);

            Entidades.Producto prod = new Entidades.Producto();
            List<Entidades.Producto> listado = new List<Entidades.Producto>();
            listado = datosProducto.traerBD(comando);


            prod.idproducto = idp;
            prod.nombre = listado[0].nombre;
            prod.preciounit = listado[0].preciounit;
            prod.stock = listado[0].stock;
            prod.bajalog = listado[0].bajalog;

            return prod;
        }

        private void cboxProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProd = Convert.ToInt16(cboxProd.SelectedValue);
            regProducto = rescatarProd(idProd);
            nuevoItem.idproduto = regProducto.idproducto;
            label3.Text = ("Precio Unitario: $ " + regProducto.preciounit);
            txtCantidad.Clear();
            txtCantidad.Select();

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            actTxt(cant);


            DateTime ahora = DateTime.Now;
            nuevaVenta.fecha = ahora.ToString("yyyy-MM-dd HH:mm:ss");
            nuevoItem.bajalog = true;
            accionVenta.altaItem(nuevoItem);

            nuevaVenta.total = total;
            nuevaVenta.bajalog = true;

            int c = nuevaVenta.idventa;

            accionVenta.ModifVenta(nuevaVenta);

            Restablecer();
            lblFactura.Text = ("Factura:");
            groupAlta.Hide();
            button1.Show();
            actualizarGrila();

            subtotal = 0;
        }


        private void Restablecer()
        {

            txtCantidad.Text = "";
            label3.Text = ("Precio Unitario: ");
            label5.Text = ("Subtotal:");

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

            string texto = txtCantidad.Text;

            if (txtCantidad.Text != "")
            {

                cant = int.Parse(txtCantidad.Text);
                actTxt(cant);
            }
        }

        private void actTxt(int xcant)
        {
            int d = xcant;
            if (caso == false)
            {

                if (d > regProducto.stock)
                {
                    MessageBox.Show("No hay suficiente stock, quedan " + regProducto.stock + " unidades");
                    txtCantidad.Clear();
                    xcant = 0;
                    txtCantidad.Select();
                }

                else
                {
                    
                    int stock = regProducto.stock - d;
                    datosProducto.ModifStock(stock, idProd);

                    subtotal = (regProducto.preciounit * Convert.ToDouble(d));
                    total = total + subtotal;
                   
                    label5.Text = ("Subtotal: $ " + subtotal);

                    nuevoItem.cantidad = d;
                    nuevoItem.subtotal = subtotal;
                   

                }
            }
            else
            {
                //MODIFICABLE 
                total = (modificarVenta.total) - modificarItem.subtotal;

                if (d > comparacion && d > regProducto.stock)
                {
                    MessageBox.Show("No hay suficiente stock, quedan " + regProducto.stock + " unidades");
                    txtCantidad.Clear();
                    xcant = 0;
                    txtCantidad.Select();
                }

                else if (d > comparacion && d < regProducto.stock)
                {

                    int stock = regProducto.stock - d;
                    datosProducto.ModifStock(stock, idProd);

                    subtotal = (regProducto.preciounit * Convert.ToDouble(d));
                    regProducto.stock = stock;
                    datosProducto.ModifStock(stock,idProd);
                    total = total + subtotal;
                    label5.Text = ("Subtotal: $ " + subtotal);


                    modificarItem.cantidad = d;
                    modificarItem.subtotal = subtotal;


                    modificarVenta.total = (modificarVenta.total) + subtotal;

                }
                else
                {
                    int stock = regProducto.stock + d;
                    datosProducto.ModifStock(stock, idProd);

                    subtotal = (regProducto.preciounit * Convert.ToDouble(d));
                    total = total + subtotal;
                    label5.Text = ("Subtotal: $ " + subtotal);


                    modificarItem.cantidad = d;
                    modificarItem.subtotal = subtotal;


                    modificarVenta.total = (modificarVenta.total) + subtotal;
                }
            }
        }

        //SEGUNDA PARTE - BAJAS Y MODIFICAR  

        int ticketModif;

        Entidades.Venta modificarVenta = new Entidades.Venta();
        Entidades.Item modificarItem = new Entidades.Item();


        private void btnbajaVen_Click(object sender, EventArgs e)
        {
            modificarVenta.bajalog = false;
            accionVenta.bajaVenta(modificarVenta);
            groupAlta.Hide();

            actualizarGrila();
        }

        private void btnBajaIten_Click(object sender, EventArgs e)
        {
      
            modificarItem.idproduto = Convert.ToInt16(cboxProd.SelectedValue);
           
            caso = false;

            actTxt(cant);

            accionVenta.ModifItem(modificarItem);
            Restablecer();
            groupAlta.Hide();

            accionVenta.ModifVenta(modificarVenta); //solo modifica total* si es que se logra

            actualizarGrila();
            subtotal = 0;
            total = 0;
        }

        private void grillaVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Restablecer();

            int indx = grillaVenta.CurrentCell.RowIndex;
            caso = true;

            btnbajaVen.Show();
            btnModifItem.Show();
            btnProducto.Hide();
            btnVenta.Hide();
            groupAlta.Show();

            
            idProd = cboxProd.FindString(grillaVenta.Rows[indx].Cells[3].Value.ToString());
            cboxProd.SelectedIndex = idProd;

            txtCantidad.Text = grillaVenta.Rows[indx].Cells[4].Value.ToString();

            comparacion = int.Parse(grillaVenta.Rows[indx].Cells[4].Value.ToString());

            label3.Text = ("Precio unitario: $ " + grillaVenta.Rows[indx].Cells[5].Value.ToString());

            label5.Text = ("Subtotal : $ " + grillaVenta.Rows[indx].Cells[6].Value.ToString());

            modificarItem.subtotal = double.Parse(grillaVenta.Rows[indx].Cells[6].Value.ToString());

            ticketModif = int.Parse(grillaVenta.Rows[indx].Cells[0].Value.ToString());
            modificarVenta.ticket = ticketModif;
            lblFactura.Text = ("Factura:  FAC-" + ticketModif);

            modificarItem.iditem = int.Parse(grillaVenta.Rows[indx].Cells[2].Value.ToString());

        }

        private void impirmirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            imprimirReporte form3 = new imprimirReporte();
            form3.Show();

            //    var resultado = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de  ticket de compra que desea imprimir", "Factura", "Ticket", 100,0); 

            //    MessageBox.Show("" + resultado, "se imprimirá la factura", MessageBoxButtons.OK);
            //    imprimirReporte.Tickets ticket = new imprimirReporte.Tickets(); 
            //    ticket.ticket = int.Parse(resultado);
            //}
        }


    }
}

