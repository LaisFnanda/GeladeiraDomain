using System.Collections.Generic;

namespace Geladeira2
{
    public class Geladeira
    {
        public int andar { get; set; }
        public int container { get; set; }
        public int posicao { get; set; }
        public string produto { get; set; }


        //ADICIONAR ITEM
        public virtual List<string> AddItem(List<int> item, int posicao, List<string> container )
        {
            if (item.Contains(posicao))
            {
                Console.WriteLine("Todas as posições já estão preenchidas");
            }
            else
            {
                container.Add(item[posicao].ToString());
                Console.WriteLine($"O item foi adicionado na posição {posicao}"); 
            }            

            return container;
        }

        public virtual List<string> AddAll( List<string> container, List<int> posicao, List <int> item)
        {

            foreach (var p in posicao)
            {
                if (!string.IsNullOrEmpty(item[p].ToString()))
                    container.Add(item[p].ToString());
            }

            return container;
        }

        //REMOVER ITEM
        public virtual List<int> RemoveItem(List<int> item, int posicao)
        {           
            if (item.Contains(posicao))
            {
                item.RemoveAt(posicao);
                Console.WriteLine($"O item da posição {posicao} foi removido!");
            }
            else
            {                
                Console.WriteLine($"A posição {posicao} já está vazia!");
            }            

            return item;
        }

        public virtual List<int> RemoveAll(List<int> item, int posicao)
        {
            if (item.Contains(posicao))
            {

                while (item.Count != 0)
                {
                    item.Remove(item[0]);                    
                }
                Console.WriteLine("Todos os itens do container foram removidos");
            }
            else
            {
                Console.WriteLine("Não há itens nas posições");
            }

            return item;
        }
    }

    
}
