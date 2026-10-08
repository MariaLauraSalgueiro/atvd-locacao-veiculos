public class Cliente
{
    private string _nome = string.Empty;
    private string _cpf = string.Empty;

    public string Nome
    {
        get => _nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O nome do cliente não pode ser vazio.");
            _nome = value.Trim();
        }
    }

    public string Cpf
    {
        get => _cpf;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O CPF não pode ser vazio.");
            _cpf = value.Trim();
        }
    }

    public Cliente(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Cliente: {Nome} | CPF: {Cpf}");
    }
}