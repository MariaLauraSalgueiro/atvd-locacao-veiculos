class Program
{
    static void Main(string[] args)
    {
        // Instanciando 2 clientes
        Cliente cliente1 = new Cliente("Arthur Morgan", "123.456.789-01");
        Cliente cliente2 = new Cliente("John Marston", "987.654.321-02");

        // Instanciando 2 veículos
        Veiculo veiculo1 = new Veiculo("Toyota Corolla", "ABC-1234");
        Veiculo veiculo2 = new Veiculo("Jeep Compass", "XYZ-9876");

        // Criando locação com menos de 7 dias (ex: 4 dias)
        Locacao locacao1 = new Locacao(
            cliente1,
            veiculo1,
            new DateOnly(2026, 10, 06),
            4,
            150.00m
        );

        // Criando locação com 7 dias ou mais (ex: 10 dias - faixa de 10%)
        Locacao locacao2 = new Locacao(
            cliente2,
            veiculo2,
            new DateOnly(2026, 10, 06),
            10,
            200.00m
        );

        // Exibindo os resumos no console
        locacao1.ExibirResumo();
        locacao2.ExibirResumo();
    }
}
