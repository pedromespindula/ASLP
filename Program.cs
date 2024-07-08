Empresa empresa = new Empresa();
    int opcao;
    do
    {
    Console.WriteLine("Menu Principal");
    Console.WriteLine("-----------------");
    Console.WriteLine("1. Adicionar Funcionário Tempo Integral");
    Console.WriteLine("2. Adicionar Funcionário Meio Período");
    Console.WriteLine("3. Remover Funcionário");
    Console.WriteLine("4. Exibir Funcionários");
    Console.WriteLine("5. Adicionar Projeto(s) a Funcionário");
    Console.WriteLine("0. Sair");
    Console.Write("Digite a opção desejada: ");
        opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarFuncionarioTempoIntegral(empresa);
                    break;
                case 2:
                    AdicionarFuncionarioMeioPeriodo(empresa);
                    break;
                case 3:
                    RemoverFuncionario(empresa);
                    break;
                case 4:
                    ExibirFuncionarios(empresa);
                    break;
                case 5:
                    AdicionarProjetoFuncionario(empresa);
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
    } while (opcao != 0);

    void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.WriteLine("Adicionar Funcionário Tempo Integral");
        Console.WriteLine("------------------------------------");

        Console.WriteLine("Nome: ");
        string? nome = Console.ReadLine();

        Console.WriteLine("Matrícula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Salário Mensal: ");
        double salarioMensal = Convert.ToDouble(Console.ReadLine());

        empresa.AdicionarFuncionario(new FuncionarioTempoIntegral(nome, matricula, salarioMensal));
        Console.WriteLine("Funcionário Tempo Integral adicionado com sucesso!");
        Console.ReadLine();
    }

    void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
    {
        Console.WriteLine("Adicionar Funcionário Meio Período");
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Nome: ");
        string? nome = Console.ReadLine();

        Console.WriteLine("Matrícula: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Salário Hora: ");
        double salarioHora = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Horas Trabalhadas: ");
        int horasTrabalhadas = Convert.ToInt32(Console.ReadLine());

        empresa.AdicionarFuncionario(new FuncionarioMeioPeriodo(nome, matricula, salarioHora, horasTrabalhadas));
        Console.WriteLine("Funcionário Meio Período adicionado com sucesso!");
        Console.ReadLine();
    }

    void RemoverFuncionario(Empresa empresa)
    {
        Console.WriteLine("Remover Funcionário");
        Console.WriteLine("-------------------");

        Console.WriteLine("Digite a matrícula do funcionário a ser removido: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

         Funcionario funcionarioRemovido = empresa.Funcionarios.FirstOrDefault(f => f.matriculaFunc == matricula);

        if (funcionarioRemovido != null)
    {
        empresa.Funcionarios.Remove(funcionarioRemovido);
        Console.WriteLine($"Funcionário {funcionarioRemovido.nome} removido com sucesso!");
    }
    else
    {
        Console.WriteLine("Funcionário com matrícula {0} não encontrado!", matricula);
    }

    }

    static void ExibirFuncionarios(Empresa empresa)
    {
        Console.Clear();
        Console.WriteLine("Lista de Funcionários");
        Console.WriteLine("----------------------");

        if (empresa.Funcionarios.Count == 0)
        {
            Console.WriteLine("Não há funcionários cadastrados.");
        }
        else
        {
            foreach (Funcionario funcionario in empresa.Funcionarios)
            {
                funcionario.ExibirInfo();
            }
        }

        Console.ReadLine();
    }

    void AdicionarProjetoFuncionario(Empresa empresa)
    {
        Console.WriteLine("Adicionar Projeto(s) a Funcionário");
        Console.WriteLine("----------------------------------");

        Console.WriteLine("Digite a matrícula do funcionário: ");
        int matricula = Convert.ToInt32(Console.ReadLine());

        Funcionario funcionario = empresa.BuscarFuncionario(matricula);

        if (funcionario != null)
        {
            Console.WriteLine("Quantidade de projetos a adicionar: ");
            int quantidadeProjetos = Convert.ToInt32(Console.ReadLine());

            List<string> novosProjetos = new List<string>();
            for (int i = 0; i < quantidadeProjetos; i++)
            {
                Console.WriteLine($"Nome do Projeto {i + 1}: ");
                string? nomeProjeto = Console.ReadLine();
                novosProjetos.Add(nomeProjeto);
            }

            funcionario.AdicionarProjeto(novosProjetos);
            Console.WriteLine("Projetos adicionados com sucesso!");
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado!");
        }
    }