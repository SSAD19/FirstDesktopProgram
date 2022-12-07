using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
   public  class Producto
    {
        private int idproducto_P;
        private string nombre_P;
        private double preciounit_P;
        private int stock_P;
        private bool bajalog_P;

        public int idproducto
        {
            get { return idproducto_P; }
            set { idproducto_P = value; }
        }
        public string nombre
        {
            get { return nombre_P; }
            set { nombre_P = value; }
        }

        public double preciounit
        {
            get { return preciounit_P; }
            set { preciounit_P = value; }
        }

        public int stock
        {
            get { return stock_P; }
            set { stock_P = value; }
        }

        public bool bajalog
        {
            get { return bajalog_P; }
            set { bajalog_P = value; }
        }

        public Producto(string xnom, double xpre, int xstock, bool xbaja)
        {
            nombre_P = xnom;
            preciounit_P = xpre;
            stock_P = xstock;
            bajalog_P = xbaja;

        }

        public Producto()
        {
        }
    }
}
