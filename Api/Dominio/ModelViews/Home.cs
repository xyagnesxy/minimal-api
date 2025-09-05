namespace MinimalApi.Dominio.ModelViews;

public struct Home
{
    public string Doc { get => "/swagger"; }
    public string Mensagem { get => "Bem vindo a API de veículos - Minimal API"; }
}