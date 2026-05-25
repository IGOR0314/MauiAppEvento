namespace MauiAppEvento.Models
{
    public class Evento
    {
        public string? NomeEvento { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public int NumeroParticipantes { get; set; }

        public string? LocalEvento { get; set; }

        public double CustoPorParticipante { get; set; }

        public int DuracaoEvento
        {
            get => DataFim.Subtract(DataInicio).Days;
        }

        public double CustoTotal
        {
            get => NumeroParticipantes * CustoPorParticipante;
        }
    }
}