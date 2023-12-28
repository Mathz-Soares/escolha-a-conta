int somar = 1;
int subtrair = 2;
int multiplicar = 3;


Console.WriteLine("Digite o número da operação: 1-somar; 2-subtrair; 3-multiplicar");
int escolha = Convert.ToInt16(Console.ReadLine());

if (escolha == somar)
{
    Console.WriteLine("digite o primeiro número que deseja somar");
    int numero1 = (Convert.ToInt16(Console.ReadLine()));
    Console.WriteLine("digite o segundo número que deseja somar");
    int numero2 = (Convert.ToInt16(Console.ReadLine()));

        for (int i = numero1; i<2;);
            int totalsoma= numero1+numero2;
                Console.WriteLine("o resultado da soma é igual a {0}",totalsoma);
}
else if (escolha == subtrair)
{
    Console.WriteLine("digite o primeiro número que deseja subtrair");
    int numero1 = (Convert.ToInt16(Console.ReadLine()));
    Console.WriteLine("digite o segundo número que deseja subtrair");
    int numero2 = (Convert.ToInt16(Console.ReadLine()));

        for (int i = numero1; i<2;);
            int totalsub= numero1-numero2;
                Console.WriteLine("o resultado da subtração é igual a {0}",totalsub);
}
else if (escolha == multiplicar)
{
    Console.WriteLine("digite o primeiro número que deseja multiplicar");
    int numero1 = (Convert.ToInt16(Console.ReadLine()));
    Console.WriteLine("digite o segundo número que deseja multiplicar");
    int numero2 = (Convert.ToInt16(Console.ReadLine()));

        for (int i = numero1; i<2;);
            int totamulti= numero1*numero2;
                Console.WriteLine("o resultado da multiplicação é igual a {0}",totamulti);
}