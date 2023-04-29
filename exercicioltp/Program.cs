// See https://aka.ms/new-console-template for more information



int opçao;
do
{
    Console.WriteLine("\n /// Menu Principal /// \n");

    Console.WriteLine("0   sair");
    Console.WriteLine("1   Somar 2 números");
    Console.WriteLine("2   Converter metros em milimetros");
    Console.WriteLine("3   Calcular aumento");
    Console.WriteLine("4   Calcular desconto");
    Console.WriteLine("5   Calcular aluguel do carro");
    Console.WriteLine("6   Calcular IMC");
    Console.WriteLine("7   Calcular tabuada");
    Console.WriteLine("8   Números multiplos de 3");
    Console.WriteLine("9   Calcular Fatorial");
    Console.WriteLine("10  Calcular imposto de renda");
    Console.WriteLine("11  Jogo de Adivinhar o número ");
    Console.WriteLine("12  Financiamento");
    Console.WriteLine("13  Aposentadoria");
    Console.WriteLine("Digite sua opção: ");

    string entrada = Console.ReadLine();
    opçao = int.Parse(entrada);


    switch (opçao)
    {
        case 0:
            Console.WriteLine("Saindo do programa");
            return;

        case 1:
            some();
            break;

        case 2:
            metromn();
            break;

        case 3:
            aumento();
            break;

        case 4:
            desconto();
            break;
        case 5:
            aluguel();
            break;
        case 6:
            imc();
            break;
        case 7:
            tabuada();
            break;
        case 8:
            multiplos3();
            break;
        case 9:
            fatorial();
            break;
        case 10:
            impostorenda();
            break;
        case 11:
            adivinhar();
            break;
        case 12:
            financiamento();
            break;
        case 13:
            aposentadoria();
            break;

    }

} while (opçao != 0);

aposentadoria();
financiamento();
aumento();
some();
metromn();
desconto();
imc();
impostorenda();
aluguel();
fatorial();
tabuada();
multiplos3();
adivinhar();




void adivinhar()
{
    int tentativas = 0;
    int num = 0;
    Random r = new Random();
    int a = r.Next(0, 100);
    while (true)
    {
        tentativas++;




        Console.WriteLine("Advinha o numero!");
        try
        {
            num = int.Parse(Console.ReadLine());
        }
        catch { Console.WriteLine("Eu disse número."); }
        if (num < a) { Console.WriteLine("Maior..."); }
        else if (num > a) { Console.WriteLine("Menor..."); }
        if (tentativas >= 10)
        {
            Console.WriteLine("Voce errou");
            Console.WriteLine("O numero era " + a);
            break;

        }
        if (num == a)
        {
            Console.WriteLine("Acertou!");
            Console.WriteLine("\nDepois de {0} tentativas.", tentativas);

            break;

        }


    }
}
void multiplos3()
{
    float[] multiplosde3 = new float[101];
    multiplosde3[0] = 3;
    for (int i = 1; i < multiplosde3.Length; i++)
    {
        multiplosde3[i] = i + 1;
        if (i % 3 == 0)
        {
            Console.WriteLine("É  multiplo de 3 " + i);
        }

    }
    Console.WriteLine("Esses números são os multiplos de 3");
}
void financiamento()
{
    int i;
    double divveiculo = 0, vtaxa = 0, vtotal = 0;
    Console.WriteLine("Digite o valor do veiculo");
    double valorVeiculo = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o numero de parcelas");
    double nparcelas = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite taxa mensal ");
    double taxamensal = double.Parse(Console.ReadLine()) / 100;

    for (i = 0; i != nparcelas; i++)
    {
        divveiculo = valorVeiculo / nparcelas;
        vtaxa = divveiculo + (divveiculo * taxamensal);
        vtotal = vtaxa + valorVeiculo;


    }
    Console.WriteLine("Valor do Veiculo Total é :" + vtotal);

}

void tabuada()
{
    int form, cont, num;


    Console.Write("Digite o Numero para Obter a Taboada : ");
    num = int.Parse(Console.ReadLine());


    for (cont = 1; cont <= 10; ++cont)
    {
        form = num * cont;
        Console.WriteLine(num + " X " + cont + " = " + form);

    }
}
void some()
{


    Console.WriteLine("Digite um valor ");
    byte n1 = byte.Parse(Console.ReadLine());
    Console.WriteLine("Digite outro valor ");
    byte n2 = byte.Parse(Console.ReadLine());
    byte soma = (byte)(n1 + n2);
    Console.WriteLine("Soma dos números" + soma);

}
void metromn()
{

    Console.WriteLine("Digite valor em metro: ");
    float metro = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor em  metro: : " + metro);
    double milimetros = metro * 1000;
    Console.WriteLine($"Valor em milimetros: " + milimetros);

}
void desconto()
{
    Console.WriteLine("Digite o valor ");
    float real = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite a porcentagem do desconto");
    float desconto = float.Parse(Console.ReadLine());
    float valorcomdesconto = real - (real * desconto) / 100;
    Console.WriteLine("Valor com desconto: " + valorcomdesconto);
    Console.WriteLine("Valor sem desconto: " + real);
    Console.WriteLine("Desconto: " + desconto + "%");
}
void imc()
{
    Console.WriteLine("Digite a altura em metros : ");
    float altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o peso em kg : ");
    float peso = float.Parse(Console.ReadLine());
    float imc = peso / (altura * altura);
    Console.WriteLine("Imc igual:" + imc);
    if (imc < 18.5)
    {
        Console.WriteLine("Abaixo do peso");
    }
    else if (imc <= 24.9)
    {
        Console.WriteLine("Peso ideal");
    }
    else if (imc <= 29.9)
    {
        Console.WriteLine("Levemente acima do peso");
    }
    else if (imc <= 34.9)
    {
        Console.WriteLine("Obesidade grau 1");
    }
    else if (imc <= 39.9)
    {
        Console.WriteLine("Obesidade grau 2");
    }
    else if (imc >= 40)
    {
        Console.WriteLine("Obesidade morbida");
    }
}
void impostorenda()
{
    Console.WriteLine("Digite seu salario");
    double salarioBruto = double.Parse(Console.ReadLine());
    if (salarioBruto < 1903.93)
    {
        Console.WriteLine(" Não recebe desconto");
    }
    else if (salarioBruto <= 2826.65)
    {
        double porcentagemdesconto = 7.5 / 100;
        double Salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdesconto);
        Console.WriteLine("Salario com desconto igual a  " + Salariocomdesconto);
    }
    else if (salarioBruto <= 3751.05)
    {
        double porcentagemdedesconto = 15.0 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);

        var valordaporcentagem = (salarioBruto * porcentagemdedesconto);
        double valorapagar = valordaporcentagem - 142.80;

        Console.WriteLine("Valor a pagar = " + valorapagar);
    }
    else if (salarioBruto <= 4664.68)
    {
        double porcentagemdedesconto = 22.5 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);
        var valordaporcentagem = (salarioBruto * porcentagemdedesconto);

        double valorapagar = valordaporcentagem - 142.80;

        Console.WriteLine("Valor a pagar = " + valorapagar);

    }
    else if (salarioBruto > 4664.68)
    {
        double porcentagemdedesconto = 27.5 / 100;
        double salariocomdesconto = salarioBruto - (salarioBruto * porcentagemdedesconto);
        Console.WriteLine("Salario com desconto igual a " + salariocomdesconto);

        var valordaporcentagem = (salarioBruto * porcentagemdedesconto);
        double valorapagar = valordaporcentagem - 142.80;

        Console.WriteLine("Valor a pagar = " + valorapagar);
    }
}
void aluguel()
{
    Console.WriteLine("Informe o numero de dias ");
    byte numerosdedias = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe Quilometro inicial");
    byte quilometroinicial = byte.Parse(Console.ReadLine());
    Console.WriteLine("Informe Quilometro Final");
    byte quilometrofinal = byte.Parse(Console.ReadLine());

    int valorpordia = (int)(numerosdedias * 95);
    double valorporquilometro = (double)(quilometrofinal - quilometroinicial) * 0.35;
    double valortotal = (double)(valorporquilometro + valorpordia);

    Console.WriteLine("Valor a ser pago é :" + valortotal);

}
void fatorial()
{

    float[] fatorial = new float[11];
    fatorial[0] = 1;

    for (int i = 1; i < fatorial.Length; i++)
    {
        fatorial[i] = fatorial[i - 1] * i;
        Console.WriteLine($"O fatorial de: {i} é: {fatorial[i]}");
    }
}
void aumento()
{
    Console.WriteLine("Informe o salario ");
    double salario = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe percentual de aumento");

    double porcentagemdeaumento = double.Parse(Console.ReadLine()) / 100;
    double percentualaumento = (double)(salario * porcentagemdeaumento);

    Console.WriteLine("Percentual de aumento é " + percentualaumento);
    double novsal = (double)(salario + percentualaumento);
    Console.WriteLine("Valor do novo salario é " + novsal);
    Console.WriteLine("Salario inicial é " + salario);

}
void aposentadoria()
{
    Console.WriteLine("Informe a sua idade");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a idade que quer se aposentar");
    int idadefinal = int.Parse(Console.ReadLine());
    Console.WriteLine("Valor para aposentadoria");
    float valoraposentadoria = float.Parse(Console.ReadLine());
    Console.WriteLine("Qual sua taxa de rendimento");

    float taxarendimento = float.Parse(Console.ReadLine());
    float valoracumulado = (idadefinal - idade) * valoraposentadoria;

    Console.WriteLine("Valor acumulado " + valoracumulado);
    float rendamensal = taxarendimento + valoracumulado;
    Console.WriteLine("Renda mensal igual a " + rendamensal);
}
