using minimal_api.Dominio.Interfaces;
using MinimalApi.Dominio.DTOs;
using MinimalApi.Dominio.Entidades;

namespace Test.Mocks;

public class AdministradorServicoMock : IAdministradorServico
{
    private static List<Administrador> administradores = new List<Administrador>()
    {
        new Administrador()
        {
            Id = 1,
            Email = "emailTeste",
            Senha = "1234",
            Perfil = "pTeste"
        }
    };
    public Administrador? BuscaPorId(int id)
    {
        return administradores.Find(a=> a.Id == id);
        
    }

    public Administrador Incluir(Administrador administrador)
    {
        administrador.Id = administradores.Count + 1;
        administradores.Add(administrador);
        return administrador;
    }

    public Administrador? Login(LoginDTO loginDTO)
    {
        return administradores.Find(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha);
    }

    public List<Administrador> Todos(int? pagina)
    {
        return administradores;
    }
}