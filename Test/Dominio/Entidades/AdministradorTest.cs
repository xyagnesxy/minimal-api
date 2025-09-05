using MinimalApi.Dominio.Entidades;

namespace Test.Dominio.Entidades;

[TestClass]
public sealed class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var administrador = new Administrador();
        administrador.Id = 1;
        administrador.Email = "emailTeste";
        administrador.Senha = "senhaTeste";
        administrador.Perfil = "perfilTeste";

        //Act

        //Assert

        Assert.AreEqual(1, administrador.Id);
        Assert.AreEqual("emailTeste", administrador.Email);
        Assert.AreEqual("senhaTeste", administrador.Senha);
        Assert.AreEqual("perfilTeste", administrador.Perfil);
    }
}
