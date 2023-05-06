﻿using System;
using System.Globalization;

namespace ExercicioClassesFuncionario {
    class Program {
        static void Main(string[] args) {

            /* Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do 
             * funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o
             * salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.*/

            Funcionario func = new Funcionario();


            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porc);
            
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + func);



        }
    }
}