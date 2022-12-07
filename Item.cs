using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Item
    {
        private int iditem_P;
        private int idventa_P;
        private int idproducto_P;
        private int cantidad_P;
        private double subtotal_P;
        private bool bajalog_P;

        public int iditem
        {
            get { return iditem_P; }
            set { iditem_P = value; }
        }
        public int idventa
        {
            get { return idventa_P; }
            set { idventa_P = value; }
        }
        public int idproduto
        {
            get {return idproducto_P;}
            set { idproducto_P = value;}
        }
        public int cantidad
        {
            get { return cantidad_P; }
            set { cantidad_P = value; }
        }

        public double subtotal
        {
            get { return subtotal_P; }
            set { subtotal_P = value; }
        }
        public bool bajalog
        {
            get { return bajalog_P; }
            set { bajalog_P = value; }
        }

        public Item(int xidven, int xidpro, int xcant, double xsubt, bool xbaja)
        {
            idventa_P = xidven;
            idproducto_P = xidpro;
            cantidad_P = xcant;
            subtotal_P = xsubt;
            bajalog_P = xbaja;
        }

        public Item() 
        { 
        }
    }
}

