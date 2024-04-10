using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using edu.PR.Ejercicio1GLOBAL._0104.Servicios;
using System.ComponentModel.Design;

namespace edu.PR.Ejercicio1GLOBAL._0104.Controladores
{
    internal class Program
    {
        static public List<BibliotecaDto>  listaBiblioteca = new List<BibliotecaDto> ();
        static public List<LibroDto>  listaLibros = new List<LibroDto> ();
        static public List<ClienteDto>  listaClientes = new List<ClienteDto> ();
        static public List<PrestamoDto>  listaPrestamo = new List<PrestamoDto> ();
        static public long idBibliotecaActual = 0;

        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            List<LibroDto> listaLibros = new List<LibroDto>();
            List<BibliotecaDto> listaBiblioteca = new List<BibliotecaDto>();
            List <ClienteDto> listaCliente = new List<ClienteDto>();
            List <PrestamoDto> listaPrestamo = new List<PrestamoDto>();

            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                opcionUsuario = mi.menuYSeleccion();
                
                switch( opcionUsuario )
                {
                    case 0:
                        Console.WriteLine(" Has indicado cerrar aplicacion");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("Has Seleccionado dar alta a una nueva biblioteca");

                        break;

                    case 2:
                        Console.WriteLine("Has Seleccionado acceder a una biblioteca");
                        mi.acceso;
                        break;
           
                    default:
                        Console.WriteLine("La opcion seleccionada no corresponde con niguna");
                        break;
                }
            } while (!cerrarMenu);
        }
    }
}
