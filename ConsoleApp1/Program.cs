using ConsoleApp1.Models;

List<Pessoa> Hospedes = new List<Pessoa>();
Reserva r = new Reserva();

int quantidadePessoa;
int opcao = 0;

while (opcao != 3)
{

    Console.WriteLine("------- Seja bem vindo ao sistema de reserva The Place Hotel ------");
    Console.WriteLine("1 - Cadastrar.");
    Console.WriteLine("2 - Listar. ");
    Console.WriteLine("3 - Sair.");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Pessoa p = new Pessoa();
            Suite s = new Suite();


            Console.WriteLine("Digite nome do hospede anfitrião.");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do hospede.");
            p.Sobrenome = Console.ReadLine();
            Hospedes.Add(p);

            Console.WriteLine("Digite quantas pessoas irão se hospedar.");
            quantidadePessoa = int.Parse(Console.ReadLine());


            Console.WriteLine("Serão quantos dias de hospedagem? ");
            r.DiasReservados = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual a Suite o hospede escolheu.\n 1 - Basica.\n 2 - Intermediaria.\n 3 - Premium.");
            s.TipoSuite = Console.ReadLine().ToUpper();


            if (s.TipoSuite == "1")
            {
                s.Capacidade = 4;
                if (quantidadePessoa > s.Capacidade)
                {
                    throw new ArgumentException($"A suite comporta apenas {s.Capacidade} hospedes. ");
                }
                else
                {
                    s.TipoSuite = "Básica";
                    Console.WriteLine("A suite escolhida é a basica e comporta 4 pessoas.");
                    s.ValorDiaria = 120.00m;
                    r.CadastrarSuite(s);
                    r.CadastrarHospede(Hospedes);
                    r.CalcularValordaDiaria();
                }

            }
            else if (s.TipoSuite == "2")
            {
                s.Capacidade = 4;
                if (quantidadePessoa > s.Capacidade)
                {
                    throw new ArgumentException($"A suite comporta apenas {s.Capacidade} hospedes. ");
                }
                else
                {
                    s.TipoSuite = "Intermediaria";
                    Console.WriteLine("A Suite escolhida foi Intermediaria e comporta 4 pessoas.");
                    s.ValorDiaria = 250.00m;
                    r.CadastrarSuite(s);
                    r.CadastrarHospede(Hospedes);
                    r.CalcularValordaDiaria();
                }
            }
            else
            {
                s.Capacidade = 6;
                if (quantidadePessoa > s.Capacidade)
                {
                    throw new ArgumentException($"A suite comporta apenas {s.Capacidade} hospedes. ");
                }
                else
                {
                    s.TipoSuite = "Premium";
                    s.ValorDiaria = 580.00M;
                    r.CadastrarSuite(s);
                    r.CadastrarHospede(Hospedes);
                    r.CalcularValordaDiaria();
                }
            }
            break;

        case 2:

            foreach (var hospdes in r.Hospedes)
            {
                Console.WriteLine($"Hospede {hospdes.NomeCompleto} esta na suite {r.Suite.TipoSuite}.");
            }
            break;

        case 3:
            Console.WriteLine("Programa encerrado. Obrigado por usar o The Place Hotel!");
            break;

        default:
            Console.WriteLine("Opção invalida tente novamente. ");
            break;
    }
}
