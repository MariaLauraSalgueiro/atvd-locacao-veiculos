public class Locacao
{
    private Cliente _cliente = null!;
    private Veiculo _veiculo = null!;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;

    public Cliente Cliente
    {
        get => _cliente;
        set => _cliente = value ?? throw new ArgumentException("A locação precisa possuir um cliente.");
    }

    public Veiculo Veiculo
    {
        get => _veiculo;
        set => _veiculo = value ?? throw new ArgumentException("A locação precisa possuir um veículo.");
    }

    public DateOnly DataRetirada
    {
        get => _dataRetirada;
        private set => _dataRetirada = value;
    }

    public int QuantidadeDias
    {
        get => _quantidadeDias;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("A quantidade de dias deve ser maior que zero.");
            _quantidadeDias = value;
        }
    }

    public decimal ValorDiaria
    {
        get => _valorDiaria;
        private set
        {
            if (value <= 0)
                throw new ArgumentException("O valor da diária deve ser maior que zero.");
            _valorDiaria = value;
        }
    }

    public Locacao(Cliente cliente, Veiculo veiculo, DateOnly dataRetirada, int quantidadeDias, decimal valorDiaria)
    {
        Cliente = cliente;
        Veiculo = veiculo;
        DataRetirada = dataRetirada;
        QuantidadeDias = quantidadeDias;
        ValorDiaria = valorDiaria;
    }

    public decimal CalcularValorBruto()
    {
        return QuantidadeDias * ValorDiaria;
    }

    public decimal CalcularDesconto()
    {
        decimal valorBruto = CalcularValorBruto();

        // Regra atualizada (Desafio Extra):
        // Menos de 7 dias: 0% de desconto
        // De 7 a 14 dias: 10% de desconto
        // 15 dias ou mais: 15% de desconto
        if (QuantidadeDias >= 15)
        {
            return valorBruto * 0.15m;
        }
        else if (QuantidadeDias >= 7)
        {
            return valorBruto * 0.10m;
        }
        
        return 0m;
    }

    public decimal CalcularValorFinal()
    {
        return CalcularValorBruto() - CalcularDesconto();
    }

    public void ExibirResumo()
    {
        Console.WriteLine("===== RESUMO DA LOCAÇÃO =====");
        Console.WriteLine($"Cliente: {Cliente.Nome} (CPF: {Cliente.Cpf})");
        Console.WriteLine($"Veículo: {Veiculo.Modelo} (Placa: {Veiculo.Placa})");
        Console.WriteLine($"Data de Retirada: {DataRetirada:dd/MM/yyyy}");
        Console.WriteLine($"Quantidade de Dias: {QuantidadeDias}");
        Console.WriteLine($"Valor da Diária: R$ {ValorDiaria:F2}");
        Console.WriteLine($"Valor Bruto: R$ {CalcularValorBruto():F2}");
        Console.WriteLine($"Desconto Aplicado: R$ {CalcularDesconto():F2}");
        Console.WriteLine($"Valor Final: R$ {CalcularValorFinal():F2}");
        Console.WriteLine("=============================\n");
    }
}