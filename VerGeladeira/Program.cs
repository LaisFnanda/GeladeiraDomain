using Geladeira2;
using System.ComponentModel.Design;

Geladeira objAndar = new Andar();
Geladeira objContainer = new Container();
Geladeira objProdutos = new Produtos();
var andar = Andar.ListAndar;
var produtos = new List<string>();



Console.WriteLine("Bem-vindo(a) a Geladeira! \nPoderá escolher duas opções: Adicionar ou Remover.");
Console.Write("Digite a opção: ");
string decisao = Console.ReadLine();

switch(decisao)
{
    case "Adicionar":
        Console.WriteLine("teste adicionar");
        break;
    case "Remover":
        Console.WriteLine("teste remover");
        break;
    default:
        Console.WriteLine("Opção Inválida");
        break;

}
//return decisao;