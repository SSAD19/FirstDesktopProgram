using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Acciones
{
    public class ProdAcc
    {

        public void crearProd(Entidades.Producto prod, string xnom, double xprecio, int xstock, bool xbaja)
        {

            prod.nombre = xnom;
            prod.preciounit = xprecio;
            prod.stock = xstock;
            prod.bajalog = xbaja;
        }

        public List<Entidades.Producto> traerBD(string xcomman)
        {
            AccesoDatos.BaseDatos traer = new AccesoDatos.BaseDatos();
            DataTable Tabla = new DataTable();
            Tabla = traer.recuperarDB(xcomman);

            List<Entidades.Producto> lista = new List<Entidades.Producto>();
            Entidades.Producto prod = new Entidades.Producto();

            foreach (DataRow fila in Tabla.Rows)
            {
                prod = new Entidades.Producto();
                prod.idproducto = int.Parse(fila[0].ToString());
                prod.nombre = fila[1].ToString();
                prod.preciounit = double.Parse(fila[2].ToString());
                prod.stock = int.Parse(fila[3].ToString());
                prod.bajalog = Convert.ToBoolean(fila[4].ToString());
                lista.Add(prod);
            }

            return lista;
        }

        public void altaProd(Entidades.Producto prod)
        {
            string comando = @"INSERT INTO productos (Nombre,  preciounit, stock, bajalog) 
        VALUES ('" + prod.nombre + "','" + prod.preciounit + "','" + prod.stock + "','" + prod.bajalog + "')";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void ModifProd(Entidades.Producto prod, int id)
        {
            string comando = @"UPDATE productos SET Nombre='" + prod.nombre + "', preciounit='" + prod.preciounit + "', stock='" + prod.stock + "', bajalog='" + prod.bajalog + "'WHERE idproducto ='" + id + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void bajaProd(Entidades.Producto prod, int xid)
        {
            string comando = @"UPDATE productos SET  bajalog='" + prod.bajalog + "'WHERE idproducto ='" + xid + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }

        public void ModifStock (int stock, int xid)
        {
            string comando = @"UPDATE productos SET stock='" + stock + "'WHERE idproducto ='" + xid + "'";

            AccesoDatos.BaseDatos darAlta = new AccesoDatos.BaseDatos();
            darAlta.conectarBD(comando);
        }
    }
}
