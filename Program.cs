
Console.WriteLine("========+++FARMÁCIA DROGAVAI+++========");
Console.WriteLine("nome do cliente: ");
string nome = Console.ReadLine();
Console.WriteLine("anos de nascimento: ");
int ano_nascimento = int.Parse(Console.ReadLine());
Console.WriteLine("cartão fidelidade(s/n): ");
string cartao_fide = Console.ReadLine();
Console.WriteLine("total a pagar: ");
float total = float.Parse(Console.ReadLine());

Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------------");

int idade = DateTime.Now.Year - ano_nascimento;
if (idade < 55)
{
    Console.WriteLine("Desconto de idade: 0%");
    Console.WriteLine($"Valor final: R${total}");
}
else if (idade >= 55 && idade < 70)
{
    float descontoidade1 = (total * 5) / 100;
    float valorfinal1 = total - descontoidade1;
    Console.WriteLine("Desconto de idade: 5%");
    Console.WriteLine($"Valor final: R${valorfinal1}");
}
else 
{
    float descontoidade2 = (total * 7) / 100;
    float valorfinal2 = total - descontoidade2;
    Console.WriteLine("Desconto de idade: 7%");
    Console.WriteLine($"Valor final: R${valorfinal2}");
}


if (cartao_fide == "s" || cartao_fide == "S")
{
    float descontofidelidade = (total * 5) / 100;
    float valorfinal3 = total - descontofidelidade;
    Console.WriteLine("Desconto do cartão fidelidade: 5%");
    Console.WriteLine($"Valor final: R${valorfinal3}");

}
else
{

}


if (idade >= 55 && idade < 70 && cartao_fide == "s" || cartao_fide == "S")
{
    float descontoidade3 = (total * 10) / 100;
    float valorfinal3 = total - descontoidade3;
    Console.WriteLine("Desconto total de: 10%");
    Console.WriteLine($"Valor final: R${valorfinal3}");
}
if (idade >= 70 && cartao_fide == "s" || cartao_fide == "S")
{
    float descontoidade4 = (total * 12) / 100;
    float valorfinal4 = total - descontoidade4;
    Console.WriteLine("Desconto total de: 12%");
    Console.WriteLine($"Valor final: R${valorfinal4}");
}