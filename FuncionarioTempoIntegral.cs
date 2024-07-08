public class FuncionarioTempoIntegral :Funcionario, IBonus //Implemente a interface IBonus nas classes FuncionarioTempoIntegral
{ //Crie uma classe FuncionarioTempoIntegral que herda de Funcionario.
    private double SalarioMensal; //Adicione uma variável privada para armazenar o salário mensal.

    public FuncionarioTempoIntegral(string nome, int matriculaFunc, double salarioMensal)
        : base(nome, matriculaFunc)
    {
        this.SalarioMensal = salarioMensal;
    } //Implemente o construtor para inicializar o nome, a matrícula e o salário mensal.

    public override double CalcularSalario()
    {
        return SalarioMensal;
    } 
      public override void ExibirInfo()
    {
        Console.WriteLine($"Funcionário Tempo Integral - Nome: {nome}, Matrícula: {matriculaFunc}, Salário Mensal: {SalarioMensal}");
        Console.WriteLine("Projetos:");
        foreach (var projeto in Projetos)
        {
            Console.WriteLine(projeto);
        }
        Console.WriteLine();
    } //Implemente os métodos CalcularSalario() e ExibirInformacoes().
     public double CalcularBonus()
    {
        return 0.1 * SalarioMensal;
    } //FuncionarioTempoIntegral: O método CalcularBonus() deve retornar 10% do salário mensal.

}
