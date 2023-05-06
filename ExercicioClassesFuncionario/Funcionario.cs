using System;
using System.Globalization;

namespace ExercicioClassesFuncionario {
    internal class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100);            
        }

        override public string ToString() {
            return Nome
                + ", Salário líquido: R$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
