public class Veiculo
{
    private string _modelo = string.Empty;
    private string _placa = string.Empty;

    public string Modelo
    {
        get => _modelo;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("O modelo do veículo não pode ser vazio.");
            _modelo = value.Trim();
        }
    }

    public string Placa
    {
        get => _placa;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("A placa do veículo não pode ser vazia.");
            _placa = value.Trim();
        }
    }

    public Veiculo(string modelo, string placa)
    {
        Modelo = modelo;
        Placa = placa;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"Veículo: {Modelo} | Placa: {Placa}");
    }
}