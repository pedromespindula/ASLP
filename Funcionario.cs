public abstract class Funcionario{ //Crie uma classe abstrata chamada Funcionario.
    public string nome;
    public int matriculaFunc; //Declare variáveis publicas para armazenar o nome, matrícula do funcionário e uma lista de string para Projetos
    public List<string> Projetos = new List<string>();// lista de string para Projetos.
    
    public Funcionario(string nome, int matriculaFunc){
        this.nome = nome;
        this.matriculaFunc = matriculaFunc; //Crie um construtor para inicializar o nome e a matrícula.
    }
    public abstract double CalcularSalario();
    public abstract void ExibirInfo();
    public void AdicionarProjeto(string projeto)  //Na classe Funcionario, adicione um método sobrecarregado AdicionarProjeto:
    {
        Projetos.Add(projeto); //AdicionarProjeto(string projeto): armazena o nome do projeto em uma lista de strings.
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);
    }//AdicionarProjeto(List<string> projetos): armazena cada nome de projeto da lista em uma lista de strings.


}