using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNota;
        public DateTime DataEmissao;
        public string Cliente;
        public decimal ValorTotal;
        public bool EstaCancelada;

        public void EmitirNotaFiscal()
        {
            Console.WriteLine("Nota fiscal emitida com sucesso.");
        }

        public void CancelarNotaFiscal()
        {
            EstaCancelada = true;
            Console.WriteLine("Nota fiscal cancelada.");
        }

        public void CancelarProduto()
        {
            Console.WriteLine("Produto cancelado da nota fiscal.");
        }

        public void AdicionarProduto(string produto, int quantidade, decimal precoUnitario)
        {
            Console.WriteLine($"{quantidade}x {produto} adicionado à nota fiscal.");
            ValorTotal += quantidade * precoUnitario;
        }

        public void ImprimirDetalhesNota()
        {
            Console.WriteLine($"Número da Nota: {NumeroNota}");
            Console.WriteLine($"Data de Emissão: {DataEmissao}");
            Console.WriteLine($"Cliente: {Cliente}");
            Console.WriteLine($"Valor Total: R$ {ValorTotal}");
            Console.WriteLine($"Status: {(EstaCancelada ? "Cancelada" : "Ativa")}");
        }
    }

}

