using edu.PR.Ejercicio1GLOBAL._0104.Controladores;
using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Servicios
{
    public class ClienteImplementacion : Operativa
    {

        public void darAlta()
        {


            long idCliente = nuevoId();
            Console.WriteLine("introduzca nombre cliente");
            string nombre = Console.ReadLine();
            Console.WriteLine("introduzca  apellidos");
            string apellidos = Console.ReadLine();
            Console.WriteLine("introduzca fecha de nacimiento");
            string fechaNac = Console.ReadLine();
            Console.WriteLine("introduzca DNI");
            string DNI = Console.ReadLine();
            Console.WriteLine("introduzca correo electronico");
            string correo = Console.ReadLine();

            DateTime fechaNacimiento = Convert.ToDateTime(fechaNac);


            ClienteDto nuevoCliente = new ClienteDto(idCliente, nombre, apellidos, fechaNacimiento, DNI, correo);
            Program.listaClientes.add(nuevoCliente);

        }
        private long nuevoId()
        {
            long nuevoId = 0;
            int tamanioLista = Program.listaClientes.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaClientes[tamanioLista - 1].id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }
    }
}
