using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaFiscal notaFiscal = new NotaFiscal();

            notaFiscal.NumeroNota = 1260;
            notaFiscal.DataEmissao = DateTime.Now;
            notaFiscal.Cliente = "Cliente Jose Vanderley";

            notaFiscal.EmitirNotaFiscal();

            notaFiscal.AdicionarProduto("Produto1", 2, 10.50m);
            notaFiscal.AdicionarProduto("Produto2", 1, 5.75m);
            notaFiscal.AdicionarProduto("Produto3", 5, 8.55m);
            
            notaFiscal.CancelarProduto();

            notaFiscal.ImprimirDetalhesNota();

            notaFiscal.CancelarNotaFiscal();

            notaFiscal.ImprimirDetalhesNota();

            Console.ReadKey();
        }
    }
}
    
