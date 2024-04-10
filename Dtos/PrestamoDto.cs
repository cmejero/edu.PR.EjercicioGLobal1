using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Dtos
{
    internal class PrestamoDto
    {
        long idPrestamo;
        long identificadorCliente;
        long identificadorLibro;
        string fechaPrestamo = "aaaaa";
        string fechaEntrega = "aaaaa";
        string estadoPrestamo = "aaaaa";

       

        public PrestamoDto()
        {

        }

        public PrestamoDto(global::System.Int64 idPrestamo, global::System.Int64 identificadorCliente, global::System.Int64 identificadorLibro, global::System.String fechaPrestamo, global::System.String fechaEntrega, global::System.String estadoPrestamo)
        {
            this.idPrestamo = idPrestamo;
            this.identificadorCliente = identificadorCliente;
            this.identificadorLibro = identificadorLibro;
            this.fechaPrestamo = fechaPrestamo;
            this.fechaEntrega = fechaEntrega;
            this.estadoPrestamo = estadoPrestamo;
        }

        public global::System.Int64 IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public global::System.Int64 IdentificadorCliente { get => identificadorCliente; set => identificadorCliente = value; }
        public global::System.Int64 IdentificadorLibro { get => identificadorLibro; set => identificadorLibro = value; }
        public global::System.String FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public global::System.String FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public global::System.String EstadoPrestamo { get => estadoPrestamo; set => estadoPrestamo = value; }
    }

}
