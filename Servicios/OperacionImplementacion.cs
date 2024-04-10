using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using edu.PR.Ejercicio1GLOBAL._0104.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Servicios
{
    internal class OperacionImplementacion
    {
        
        
        public void darAltaLibro(List<LibroDto> listaAntiguaLibros)
        {
           LibroDto nuevoLibro = new LibroDto();

            
            Console.WriteLine("introduzca titulo de libro");
            nuevoLibro.Titulo = Console.ReadLine();
            Console.WriteLine("introduzca  subtitulo libro");
            nuevoLibro.Subtitulo = Console.ReadLine();
            Console.WriteLine("introduzca el autor");
            nuevoLibro.Autor = Console.ReadLine();
            Console.WriteLine("introduzca ISBN");
            nuevoLibro.ISBN1 = Console.ReadLine();
            Console.WriteLine("introduzca el nuemero de la edición");
            nuevoLibro.NumEdicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduzca el nombre el editorial");
            nuevoLibro.Editorial = Console.ReadLine();
            Console.WriteLine("introduzca el stock");
            nuevoLibro.Stock = Convert.ToInt32(Console.ReadLine());

            listaAntiguaLibros.Add(nuevoLibro);

        }

        public void darAltaBiblioteca(List<BibliotecaDto> listaAntiguaBiblioteca)
        {
          BibliotecaDto nuevaBiblioteca = new BibliotecaDto();


            Console.WriteLine("introduzca nombre bliblioteca");
            nuevaBiblioteca.Nombre = Console.ReadLine();
            Console.WriteLine("introduzca  direccion");
            nuevaBiblioteca.Direccion = Console.ReadLine();
            

           listaAntiguaBiblioteca.Add(nuevaBiblioteca);

        }

        public ClienteDto darAltaCliente(List<ClienteDto> listaAntiguaCLiente)
        {


            long idCliente = 
            Console.WriteLine("introduzca nombre cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("introduzca  apellidos");
            string apellidos = Console.ReadLine();
            Console.WriteLine("introduzca fecha de nacimiento");
            string fechaNac= Console.ReadLine();
            Console.WriteLine("introduzca DNI");
            string DNI = Console.ReadLine();
            Console.WriteLine("introduzca correo electronico");
            string correo = Console.ReadLine();

            DateTime fechaNacimiento = Convert.ToDateTime(fechaNac);


            return ClienteDto = new ClienteDto(idCliente, nombre, apellidos, fechaNacimiento, DNI, correo);

        }

    }
}
