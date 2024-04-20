// Faça um programa que leia o valor atual do salário de uma pessoa e o valor com acréscimo e informe a porcentagem de acréscimo que foi dado

Console.Write("Informe o valor do seu salário atual SEM acréscimo: ");
double salary = double.Parse(Console.ReadLine());

while (salary <= 0)
{
    Console.Write("Salário não pode ser zero ou negativo, tente novamente: ");
    salary = double.Parse(Console.ReadLine());
}

Console.Write("Informe o valor do seu salário atual COM acréscimo: ");
double increaseadSalary = double.Parse(Console.ReadLine());

while (increaseadSalary <= salary)
{
    Console.Write("Salário acrescido não pode ser menor/igual ao seu salário sem acréscimo, tente novamente: ");
    increaseadSalary = double.Parse(Console.ReadLine());
}

double increasePercentage = (increaseadSalary - salary) / salary;

Console.WriteLine($"\nSeu acréscimo foi de {(increasePercentage * 100).ToString("0.0")}%");