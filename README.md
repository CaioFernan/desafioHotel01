DIO - Trilha .NET - Explorando a linguagem C#

Desafio de projeto
Para este desafio, você precisará utilizar seus conhecimentos adquiridos no módulo de exploração da linguagem C#, da trilha .NET do DIO.

Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que farão um relacionamento entre ambos.

O seu programa deverá calcular corretamente os valores dos métodos da classe Reserva, que precisarão trazer uma quantidade de hóspedes e o valor diário, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

Regras e validações
Não será possível realizar uma reserva de uma suíte com capacidade menor que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de acomodar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exceção.
O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.
Diagrama de classe de estacionamento

Solução
O código está pela metade, e você deverá dar continuidade obedecendo às regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
