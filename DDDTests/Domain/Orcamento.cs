using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDTests.Domain
{
    public class Orcamento
    {
        public int Id { get; private set; }

        public DateTime DataDeAbertura { get; private set; }

        public string Cliente { get; private set; }

        public DateTime? DataDeAprovacao { get; private set; }

        public int Validade { get; private set; }

        public decimal ValorTotal { get; private set; }

        public Orcamento(string cliente, decimal valorTotal, int validade)
        {
            if (string.IsNullOrEmpty(cliente))
                throw new Exception("Informe o cliente");

            if (valorTotal <= 0)
                throw new Exception("Informe o valor do orçamento");

            if (validade <= 0)
                throw new Exception("Validade em dias deve ser maior que 0");

            Id = 0;
            Cliente = cliente;
            ValorTotal = valorTotal;
            DataDeAbertura = DateTime.Now;
            Validade = validade;
        }

        private int GerarId()
        {
            return new Random().Next();
        }

        public void Fechar()
        {
            if (DataDeAprovacao.HasValue)
                throw new Exception("Orçamento já aprovado em " + DataDeAprovacao.Value.ToString("d"));

            DataDeAprovacao = DateTime.Now;
        }
    }
}
