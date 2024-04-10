using edu.PR.Ejercicio1GLOBAL._0104.Controladores;
using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Servicios
{
    public class BibliotecaImplementacion : Operativa
    {
       public void darAlta()
       {

            long idBiblioteca = nuevoId();
            Console.WriteLine("Introduzca el nombre de la biblioteca");
            string nombreBiblioteca = Console.ReadLine();
            Console.WriteLine("Introduzca la direccion");
            string direccionBiblioteca = Console.ReadLine();

            BibliotecaDto nuevaBiblioteca = new BibliotecaDto(idBiblioteca, nombreBiblioteca, direccionBiblioteca);

            Program.listaBiblioteca.(nuevaBiblioteca);

        }

        private long nuevoId()
        {
            long nuevoId = 0;
            int tamanioLista = Program.listaBiblioteca.Count;

            if(tamanioLista > 0)
            {
                nuevoId = Program.listaBiblioteca[tamanioLista - 1].id + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;
        }

    }
}
