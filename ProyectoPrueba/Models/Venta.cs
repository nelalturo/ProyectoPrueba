//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoPrueba.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnitario { get; set; }
        public int ValorTotal { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
