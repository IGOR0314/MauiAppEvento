using MauiAppEvento.Models;

namespace MauiAppEvento;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object? sender, EventArgs e)
    {
        try
        {
            Evento e1 = new Evento
            {
                NomeEvento = txt_nome.Text,
                DataInicio = dt_inicio.Date.Value,
                DataFim = dt_fim.Date.Value,
                NumeroParticipantes = Convert.ToInt32(stp_participantes.Value),
                LocalEvento = txt_local.Text,
                CustoPorParticipante = Convert.ToDouble(txt_custo.Text)
            };

            await DisplayAlertAsync(
                "Evento Cadastrado",
                $"Evento: {e1.NomeEvento}\n" +
                $"Duração: {e1.DuracaoEvento} dias\n" +
                $"Custo Total: R$ {e1.CustoTotal}",
                "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlertAsync("Erro", ex.Message, "OK");
        }
    }
}