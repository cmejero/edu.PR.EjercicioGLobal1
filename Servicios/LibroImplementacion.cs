using edu.PR.Ejercicio1GLOBAL._0104.Controladores;
using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using edu.PR.Ejercicio1GLOBAL._0104.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Servicios
{
    internal class LibroImplementacion : Operativa
    {
        
        
        public void darAlta()
        {
           
            Long idLibro = nuevoId();
            Console.WriteLine("introduzca titulo de libro");
            string nombreLibro = Console.ReadLine();
            Console.WriteLine("introduzca  subtitulo libro");
            string subtituloLibro = Console.ReadLine();
            Console.WriteLine("introduzca el autor");
            string autorLibro = Console.ReadLine();
            Console.WriteLine("introduzca ISBN");
            string ISBN = Console.ReadLine();
            Console.WriteLine("introduzca el nuemero de la edición");
            int numEdicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca el nombre el editorial");
            string nombreEditorial = Console.ReadLine();
            Console.WriteLine("introduzca el stock");
            int stockLibro = Convert.ToInt32(Console.ReadLine());

            LibroDto nuevoLibro = new LibroDto(idLibro, nombreLibro, subtituloLibro, autorLibro, ISBN, numEdicion, nombreEditorial, stockLibro );

            Program.listaLibros.add(nuevoLibro);

        }


        private long nuevoId()
        {
            long nuevoId = 0;
            int tamanioLista = Program.listaLibros.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listalibros[tamanioLista - 1].id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }


        

    }
}
