namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> hospedes { get; set; }
    public Suite suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> _hospedes)
    {

      if (suite.Capacidade >= _hospedes.Count)
      {
        hospedes = _hospedes;
      }
      else
      {
        throw new Exception("Não foi possivel cadastrar a reserva");
      }
    }

    public void CadastrarSuite(Suite _suite)
    {
      suite = _suite;
    }

    public int ObterQuantidadeHospedes()
    {
      return hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {

      decimal valor = DiasReservados * suite.ValorDiaria;

      // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
      // *IMPLEMENTE AQUI*
      if (DiasReservados > 10)
      {
        valor = (valor / 100 * 90);
      }

      return valor;
    }
  }
}