//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalTek.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalles
    {
        public int idDetalle { get; set; }
        public int idFactura { get; set; }
        public int idProducto { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
    
        public virtual facturas facturas { get; set; }
        public virtual productos productos { get; set; }
    }
}