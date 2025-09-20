Console.Write("Digite o nome do aluno: ");
string nome = Console.ReadLine();
Console.Write("Digite a nota 1 do aluno: ");
double nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a nota 2 do aluno: ");
double nota2 = double.Parse(Console.ReadLine());
Console.Write("Digite a nota 3 do aluno: ");
double nota3 = double.Parse(Console.ReadLine());
Console.Write("Digite a nota 4 do aluno: ");
double nota4 = double.Parse(Console.ReadLine());

double media_final = (nota1 + nota2 + nota3 + nota4) / 4;

if (media_final >= 9 && media_final <= 10)
{
    Console.WriteLine("==========================================");
    Console.WriteLine("             BOLETIM ESCOLAR              ");
    Console.WriteLine("==========================================");
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"NotaS: {nota1} | {nota1} | {nota2} | {nota1}");
    Console.WriteLine($"Média: {media_final}");
    Console.WriteLine($"Menção: A");
    Console.WriteLine("Situação: Aprovado");
}

else if (media_final >= 7 && media_final < 9)
{
    Console.WriteLine("==========================================");
    Console.WriteLine("             BOLETIM ESCOLAR              ");
    Console.WriteLine("==========================================");
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"NotaS: {nota1} | {nota1} | {nota2} | {nota1}");
    Console.WriteLine($"Média: {media_final}");
    Console.WriteLine($"Menção: B");
    Console.WriteLine("Situação: Aprovado");
}
else if (media_final >= 5 && media_final < 7)
{
    Console.WriteLine("==========================================");
    Console.WriteLine("             BOLETIM ESCOLAR              ");
    Console.WriteLine("==========================================");
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"NotaS: {nota1} | {nota1} | {nota2} | {nota1}");
    Console.WriteLine($"Média: {media_final}");
    Console.WriteLine($"Menção: C");
    Console.WriteLine("Situação: Recuperação");
}
else if (media_final >= 3 && media_final < 5)
{
    Console.WriteLine("==========================================");
    Console.WriteLine("             BOLETIM ESCOLAR              ");
    Console.WriteLine("==========================================");
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"NotaS: {nota1} | {nota1} | {nota2} | {nota1}");
    Console.WriteLine($"Média: {media_final}");
    Console.WriteLine($"Menção: D");
    Console.WriteLine("Situação: Reprovado");
}
else if (media_final > 3)
{
    Console.WriteLine("==========================================");
    Console.WriteLine("             BOLETIM ESCOLAR              ");
    Console.WriteLine("==========================================");
    Console.WriteLine($"Aluno: {nome}");
    Console.WriteLine($"Notas: {nota1} | {nota1} | {nota2} | {nota1}");
    Console.Write($"Média: {media_final}");
    Console.Write($"Menção: D");
    Console.WriteLine("Situação: Reprovado");

}
 