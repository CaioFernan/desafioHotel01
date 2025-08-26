using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException($"A suite comporta apenas {Suite.Capacidade} hospedes. ");
            }
            
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeDeHospedes()
        {
            Console.WriteLine(Hospedes.Count);
            return Hospedes.Count;
        }

        public decimal CalcularValordaDiaria()
        {
            decimal total = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados < 10)
            {
                
                Console.WriteLine($"O valor há ser pago é {total:c}");
            }
            else
            {

                decimal percentDesconto = 10;
                decimal desconto = total * (1- (percentDesconto / 100m));
                Console.WriteLine($"Você recebou 10% de desconto devido aos dias de hospedagem o valor sem desconta era de {total:c} com o desconto o hospede deve pagar {desconto:c}");
            }
            return total;
        }

    }
}