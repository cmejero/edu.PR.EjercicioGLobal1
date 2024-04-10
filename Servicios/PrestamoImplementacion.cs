using edu.PR.Ejercicio1GLOBAL._0104.Controladores;
using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Servicios
{
    internal class PrestamoImplementacion : Operativa
    {
        public void darAlta()
        {


            long idCliente = nuevoId();
            Console.WriteLine("introduzca el identificador del cliente");
            long identificadorCliente = Convert.ToInt64(Console.Readline());
            Console.WriteLine("introduzca el identificador del libro");
            long identificadorLibro = Convert.ToInt64(Console.Readline());
            Console.WriteLine("introduzca fecha de prestamo");
            string fechaPrestamo = Console.ReadLine();
            Console.WriteLine("introduzca fecha de entrega");
            string fechaEntrega = Console.ReadLine();
            bool libroPrestado = estadoPrestamo();

            DateTime fechaNacimiento = Convert.ToDateTime(fechaNac);




            PrestamoDto nuevoPrestamo = new PrestamoDto(idCliente,identificadorCliente, identificadorLibro, fechaPrestamo, fechaEntrega, libroPrestado);
            Program.listaPrestamo.add(nuevoPrestamo);

        }
        private long nuevoId()
        {
            long nuevoId = 0;
            int tamanioLista = Program.listaPrestamo.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaPrestamo[tamanioLista - 1].id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }


    }
}
