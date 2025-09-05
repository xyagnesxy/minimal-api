using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;

namespace Test.Dominio.Servicos;

[TestClass]
public sealed class AdministradorServicoTest
{
    private DbContexto CriarContextoDeTeste()
    {
        var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "", "..", "..", ".."));

        var builder = new ConfigurationBuilder()
            .SetBasePath(path ?? Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();
        var configuration = builder.Build();



        return new DbContexto(configuration);
    }


    [TestMethod]
    public void TestandoSalvarAdministrador()
    {
        // Arrange
        var contexto = CriarContextoDeTeste();

        contexto.Database.ExecuteSqlRaw("truncate table Administradores;");
        var administrador = new Administrador();
        administrador.Id = 1;
        administrador.Email = "emailTeste";
        administrador.Senha = "senhaTeste";
        administrador.Perfil = "pTeste";
        var administradorServico = new AdministradorServico(contexto);

        //Act
        administradorServico.Incluir(administrador);
        

        //Assert

        Assert.AreEqual(1, administradorServico.Todos(1).Count);
    }


    [TestMethod]
    public void TestandoBuscaPorId()
    {
        // Arrange
        var contexto = CriarContextoDeTeste();

        contexto.Database.ExecuteSqlRaw("truncate table Administradores;");
        var administrador = new Administrador();
        administrador.Id = 1;
        administrador.Email = "emailTeste";
        administrador.Senha = "senhaTeste";
        administrador.Perfil = "pTeste";
        var administradorServico = new AdministradorServico(contexto);

        //Act
        administradorServico.Incluir(administrador);
        var admin = administradorServico.BuscaPorId(1);

        

        //Assert

        Assert.AreEqual(1, admin?.Id);
    }
}
