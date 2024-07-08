public class FuncionarioMeioPeriodo :Funcionario, IBonus //Implemente a interface IBonus nas classes FuncionarioMeioPeriodo.
{ //Crie uma classe FuncionarioMeioPeriodo que herda de Funcionario.
    private double salarioPorHora;
    private int horasTrabalhadas; //Adicione variáveis privadas para armazenar o salário por hora e o número de horas trabalhadas.
    public FuncionarioMeioPeriodo(string nome, int matriculaFunc, double salarioPorHora, int horasTrabalhadas)
        : base(nome, matriculaFunc)
    {
        this.salarioPorHora = salarioPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
    } //Implemente o construtor para inicializar o nome, a matrícula, o salário por hora e o número de horas trabalhadas.
    public override double CalcularSalario()
    {
        return salarioPorHora * horasTrabalhadas;
    }
    public override void ExibirInfo()
    {
        Console.WriteLine($"Funcionário Meio Período - Nome: {nome}, Matrícula: {matriculaFunc}, Salário por Hora: {salarioPorHora}, Horas Trabalhadas: {horasTrabalhadas}");
        Console.WriteLine("Projetos:");
        foreach (var projeto in Projetos)
        {
            Console.WriteLine(projeto);
        }
        Console.WriteLine();
    } //Implemente os métodos CalcularSalario() e ExibirInformacoes().
     public double CalcularBonus()
    {
        return 0.05 * CalcularSalario();
    } //FuncionarioMeioPeriodo: O método CalcularBonus() deve retornar 5% do salário total calculado pelo método CalcularSalario().

}