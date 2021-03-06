using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CineTeatroItalianoLobos.Entities
{
    public class Venta : ICloneable
    {
        public Venta()
        {
            //Tickets = new HashSet<Ticket>();
            VentasTickets = new HashSet<VentaTicket>();
        }
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
        public int EmpleadoId { get; set; }
        public virtual Empleado Empleado { get; set; }
        //public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<VentaTicket> VentasTickets { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
