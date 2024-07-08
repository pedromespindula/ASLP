public class Empresa
{
    public List<Funcionario> Funcionarios;

    // Construtor para inicializar a lista de funcionários
    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }

    // Método para adicionar um funcionário à lista
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    // Método para remover um funcionário da lista com base na matrícula
    public void RemoverFuncionario(int matricula)
    {
        Funcionarios.RemoveAll(f => f.matriculaFunc == matricula);
    }

    // Método para exibir informações de todos os funcionários na lista
    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInfo();
        }
    }
     public Funcionario BuscarFuncionario(int matricula)
    {
        return Funcionarios.Find(f => f.matriculaFunc == matricula);
    }
}