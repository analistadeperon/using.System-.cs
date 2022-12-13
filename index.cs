using System;
namespace Course {
 class Retangulo {
 public double Largura;
 public double Altura;
 public double Area() {
 return Largura * Altura;
 }
 public double Perimetro() {
 return 2 * (Largura + Altura);
 }
 public double Diagonal() {
 return Math.Sqrt(Largura * Largura + Altura * Altura);
 }
 }
}


Classe Program:
using System;
using System.Globalization;
namespace Course {
 class Program {
 static void Main(string[] args) {
 Retangulo ret = new Retangulo();
 Console.WriteLine("Entre a largura e altura do retângulo: ");
 ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
 Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
 Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
 }
 }
}

Classe Funcionario:
using System.Globalization;
namespace Course {
 class Funcionario {
 public string Nome;
 public double SalarioBruto;
 public double Imposto;
 public double SalarioLiquido() {
 return SalarioBruto - Imposto;
 }
 public void AumentarSalario(double porcentagem) {
 SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
 }
 public override string ToString() {
 return Nome
 + ", R$ "
 + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
 }
 }
}



Classe Program:
using System;
using System.Globalization;
namespace Course {
 class Program {
 static void Main(string[] args) {
 Funcionario func = new Funcionario();
 Console.Write("Nome: ");
 func.Nome = Console.ReadLine();
 Console.Write("Salario bruto: ");
 func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 Console.Write("Imposto: ");
 func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 Console.WriteLine();
 Console.WriteLine("Funcionário: " + func);
 Console.WriteLine();
 Console.Write("Deseja aumentar o salário em qual porcentagem? ");
 double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 func.AumentarSalario(porcent);
 Console.WriteLine();
 Console.WriteLine("Dados atualizados: " + func);
 }
 }
}


Classe Aluno:
namespace Course {
 class Aluno {
 public string Nome;
 public double Nota1, Nota2, Nota3;
 public double NotaFinal() {
 return Nota1 + Nota2 + Nota3;
 }
 public bool Aprovado() {
 if (NotaFinal() >= 60.0) {
 return true;
 }
 else {
 return false;
 }
 }
 public double NotaRestante() {
 if (Aprovado()) {
 return 0.0;
 }
 else {
 return 60.0 - NotaFinal();
 }
 }
 }
}



Classe Program:
using System;
using System.Globalization;
namespace Course {
 class Program {
 static void Main(string[] args) {
 Aluno aluno = new Aluno();
 Console.Write("Nome do aluno: ");
 aluno.Nome = Console.ReadLine();
 Console.WriteLine("Digite as três notas do aluno:");
 aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 Console.WriteLine("NOTA FINAL = "
 + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
 if (aluno.Aprovado()) {
 Console.WriteLine("APROVADO");
 }
 else {
 Console.WriteLine("Reprovado");
 Console.WriteLine("FALTARAM "
 + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
 + " PONTOS");
 }
 }
 }
}

