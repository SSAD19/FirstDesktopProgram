Public Class Class1

    Public Function traerDB() As List(


        'public List<Entidades.Producto> traerBD()
        '        {
        '            AccesoDatos.BaseDatos traer = new AccesoDatos.BaseDatos();
        '            string comando = @"Select* from productos";

        '            DataTable Tabla = new DataTable();
        '            Tabla = traer.recuperarDB(comando);

        '            List<Entidades.Producto> lista = ;
        '            Entidades.Producto prod = new Entidades.Producto();

        '            foreach (DataRow fila in Tabla.Rows)
        '            {

        '                prod.idproducto = int.Parse(fila["idproducto"].ToString());
        '                prod.nombre = fila["Nombre"].ToString();
        '                prod.preciounit = double.Parse(fila["preciounit"].ToString());
        '                prod.stock = int.Parse(fila["stock"].ToString());
        '                prod.bajalog = Convert.ToBoolean(fila["bajalog"].ToString());
        '                lista.Add(prod);
        '            }

        '            return lista;
        '        }

End Class
