public class Locacao
{
    private Cliente _cliente = null!;
    private Veiculo _veiculo = null!;
    private DateOnly _dataRetirada;
    private int _quantidadeDias;
    private decimal _valorDiaria;

    public Cliente Cliente
    {
        get { return _cliente; }
        set { _cliente = value; }
    }

    public Veiculo Veiculo
    {
        get { return _veiculo; }
        set { _veiculo = value; }
    }

    public DateOnly DataRetirada
    {
        get { return _dataRetirada; }
        set { _dataRetirada = value; }
    }

    public int QuantidadeDias
    {
        get { return _quantidadeDias; }
        set { _quantidadeDias = value; }
    }

    public decimal ValorDiaria
    {
        get { return _valorDiaria; }
        set { _valorDiaria = value; }
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