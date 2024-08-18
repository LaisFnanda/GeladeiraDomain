using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geladeira2
{
    public class Andar:Geladeira
    {

        //No maximo 3 andares (0, 1, 2)

        /*List<Floor> list = new();
        list.Add(andar1);
        3X
        ou if list.Count == 3 { faz a logica
            }
        if list.count != 3 {throw Exception("Quantidades de andares invalida")}*/

        public static List<int> ListAndar()
        {
            List<int> andar = new List<int>();
            andar.Add(0);
            andar.Add(1);
            andar.Add(2);

            if (andar.Count != 3)
            {
                throw new ArgumentException("Número de andares inválidos!");
            }
           
            return andar;
        }

    }
}
