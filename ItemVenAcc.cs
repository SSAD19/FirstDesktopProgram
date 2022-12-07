using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Acciones
{
    public class ItemVenAcc
    {
        public void crearItem(Entidades.Item item, int xidventa, int xidprod, int xcant, double xsubt, bool xbaja)
        {
            item.idventa = xidventa;
            item.idproduto = xidprod;
            item.cantidad = xcant;
            item.subtotal = xsubt;
            item.bajalog = xbaja;

        }

        public List<Entidades.Item> traerItem(string comando)
        {
            AccesoDatos.BaseDatos traerDato = new AccesoDatos.BaseDatos();
            DataTable TablaDatos = new DataTable();
            List<Entidades.Item> lista = new List<Entidades.Item>();

            TablaDatos = traerDato.recuperarDB(comando);

            Entidades.Item nueva;

            foreach (DataRow fila in TablaDatos.Rows)
            {
                nueva = new Entidades.Item();
                nueva.iditem = int.Parse(fila[0].ToString());
                nueva.idventa = int.Parse(fila[1].ToString());
                nueva.idproduto = int.Parse(fila[2].ToString());
                nueva.cantidad = int.Parse(fila[3].ToString());
                nueva.subtotal = double.Parse(fila[4].ToString());
                nueva.bajalog = Convert.ToBoolean(fila[5].ToString());

                lista.Add(nueva);
            }

            return lista;
        }

        public void accionVenta(string comando)
        {
            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void crearVenta(Entidades.Venta nueva, int xticket, string xfecha,double xtotal, bool xbaja)
        {
            nueva.ticket = xticket;
            nueva.fecha = xfecha;
            nueva.total = xtotal;
            nueva.bajalog = xbaja;
        }

        public List<Entidades.Venta> traerVentas(string comando)
        {
            AccesoDatos.BaseDatos traerDato = new AccesoDatos.BaseDatos();
            DataTable TablaDatos = new DataTable();
            List<Entidades.Venta> lista = new List<Entidades.Venta>();

            TablaDatos = traerDato.recuperarDB(comando);

            Entidades.Venta nueva;

            foreach (DataRow fila in TablaDatos.Rows)
            {
                nueva = new Entidades.Venta();

                nueva.idventa = int.Parse(fila[0].ToString());
                nueva.ticket = int.Parse(fila[1].ToString());
                nueva.fecha = fila[2].ToString();
                nueva.total = double.Parse(fila[4].ToString());
                nueva.bajalog = Convert.ToBoolean(fila[3].ToString());

                lista.Add(nueva);
            }

            return lista;
        }

        public int maxId(string xentidad)
        {
            AccesoDatos.BaseDatos idMax = new AccesoDatos.BaseDatos();

            int id = idMax.idMax(xentidad);
            return id;
        }


        public void altaVenta(Entidades.Venta nueva)
        {
            
            string comando = @"INSERT INTO ventas (ticket, fecha, bajalog, total) 
        VALUES ('" + nueva.ticket + "','" + nueva.fecha + "','" + nueva.bajalog + "','" + nueva.total + "')";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void ModifVenta(Entidades.Venta nueva)
        {
            string comando = @"UPDATE ventas SET  total='" + nueva.total + "'WHERE ticket='" + nueva.ticket + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void bajaVenta(Entidades.Venta nueva)
        {
            string comando = @"UPDATE ventas SET  bajalog='" + nueva.bajalog + "'  WHERE ticket ='" + nueva.ticket + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }



        //ITEMS VENTAS  

        public void altaItem(Entidades.Item nueva)
        {

            string comando = @"INSERT INTO items (idventa, idproducto, cantidad, subtotal, bajalog) 
        VALUES ('" + nueva.idventa + "','" + nueva.idproduto+ "','" + nueva.cantidad + "','" + nueva.subtotal + "','" + nueva.bajalog + "')";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void ModifItem(Entidades.Item nueva)
        {
            string comando = @"UPDATE items SET  idproducto='" + nueva.idproduto + "', cantidad='" + nueva.cantidad + "', subtotal='" + nueva.subtotal + "'WHERE iditem='" + nueva.iditem + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void bajaItem(Entidades.Item nueva, int xid)
        {
            string comando = @"UPDATE items SET  bajalog='" + nueva.bajalog + "'WHERE iditem='" + xid + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }


    }
}