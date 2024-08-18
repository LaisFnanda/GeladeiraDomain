using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geladeira2
{
    public class Produtos:Geladeira
    {
        //DESCREVER ITEM
        public static void ListProdutos()
        {
            var produtos = new List<string>();

            produtos.Add("Enlatados");
            produtos.Add("Mortadela");
            produtos.Add("Queijo");
            produtos.Add("Salsicha");
            produtos.Add("Alface");
            produtos.Add("Couve");
            produtos.Add("Maca");
            produtos.Add("Banana");
            produtos.Add("Contra-file");
            produtos.Add("Picanha");
            produtos.Add("Tomate");
        }
    }
}
