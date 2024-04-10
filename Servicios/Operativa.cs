using edu.PR.Ejercicio1GLOBAL._0104.Controladores;
using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Servicios
{
    internal abstract class Operativa
    {
        public abstract void darAlta();

        public void accederBiblioteca()
        {
            foreach(BibliotecaDto bibliotecas in Program.listaBiblioteca)
            {
                Console.WriteLine("Nombre Biblioteca: " + bibliotecas.Nombre + " | " + "ID biblioteca: " + bibliotecas.IdBiblioteca);
            }

            Console.WriteLine("Introduce el ID de la Biblioteca");
            long IdIntroducido = Console.ReadLine();

            foreach(BibliotecaDto bibliotecas in Program.listaBiblioteca)
            {
                if(IdIntroducido == bibliotecas.IdBiblioteca)
                {
                    
                }
                else
                {
                    Console.wWriteLine("El ID introducido es incorrecto");
                }
            }

        }
    }
}
