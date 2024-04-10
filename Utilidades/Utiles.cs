using edu.PR.Ejercicio1GLOBAL._0104.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.PR.Ejercicio1GLOBAL._0104.Utilidades
{
    public class Utiles
    {
        static public long autoincrementarID(List<ClienteDto> lista)
        {
            long nuevoId;
            int tamanioLista = lista.Count;
            if (tamanioLista > 0)
            {
                nuevoId = lista[tamanioLista - 1].IdCliente + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }
    }
}
