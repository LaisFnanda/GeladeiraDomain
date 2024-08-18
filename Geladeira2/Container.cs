using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Geladeira2
{
    public class Container:Geladeira
    {       
        public static  List<string> ListContainer()
        {
            /*string[] Ar = new string[4];
            List<string> Posicoes = new List<string>(Ar);
            
             List<container>
            if lstContainer.count != 2 {throw new Exception(...)}*/

            //container = new List<int>();

            //container.Add(0);
            // container.Add(1);

            List<int> posicao = new List<int>();
            List<string> container = new List<string>();

            posicao.Add(0);
            posicao.Add(1);
            posicao.Add(2);
            posicao.Add(3);

            if (container.Count != 2)
            {
                throw new ArgumentException("Container inválido!");
            }
            else
            {
                if (posicao.Count != 4)
                {
                    throw new ArgumentException("Número de posicoes inválida!");
                }   
            }
            return container;
        }
        
        public override List<string> AddItem(List<int> item, int posicao, List<string> container)
        {            
            return AddItem (item, posicao, container);
        
        }
        public override List<string> AddAll(List<string> container, List<int> posicao, List<int> item)
        {
            return AddAll(container, posicao, item);
        }
        public override List<int> RemoveItem(List<int> item, int posicao)
        {
            return RemoveItem(item, posicao);
        }

        public override List<int> RemoveAll(List<int> item, int posicao)
        {
            return RemoveAll(item, posicao);
        }



    }
}
