using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Venta
    {

        private int idventa_P;
        private int ticket_P;
        private DateTime fecha_P;
        private double total_P; 
        private bool bajalog_P;

        public int idventa
        {
            get { return idventa_P; }
            set { idventa_P = value; }
        }

        public int ticket
        {
            get { return ticket_P; }
            set { ticket_P = value; }
        }

        public DateTime fecha
        {
            get { return fecha_P; }
            set { fecha_P = value; }
        }

        public double total {
            get { return total_P; }
            set { total_P = value; }
        }

        public bool bajalog
        {
            get { return bajalog_P; }
            set { bajalog_P = value; }
        }

        public Venta(int xticket, DateTime xfecha, double xtotal, bool xbaja)
        {

            ticket_P = xticket;
            fecha_P = xfecha;
            total_P = xtotal;
            bajalog_P = xbaja;

        }

        public Venta() { }
    }
}
