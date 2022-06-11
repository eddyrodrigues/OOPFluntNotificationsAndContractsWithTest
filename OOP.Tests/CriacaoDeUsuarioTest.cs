using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.Domain.Entities;
using OOP.Domain.ValueObjects;

namespace OOP.Tests;

[TestClass]
public class CriacaoDeUsuarioTest
{
    [TestMethod]
    [DataRow("Eduardo", "Rodrigues")]
    [DataRow("Edut", "Rodr")]
    [DataRow("Edut", "Rodrdajsidjasid")]
    [DataRow("aosijdasidjiasdjias", "joasdoajksd")]
    public void RetornoTrueQuandoNAMEEstiverCerto(string Nome, string Sobrenome)
    {
      Name nomeUsuario = new Name(Nome, Sobrenome);
      Usuario usuario = new Usuario(nomeUsuario);
      Assert.AreEqual(true, usuario.IsValid);
    }
    
    [TestMethod]
    [DataRow("", "Rodrigues")]
    [DataRow("Eduardo", "")]
    [DataRow("", "")]
    public void RetornaFalseQuandoNAMEEstiverErrado(string Nome, string Sobrenome)
    {
      Name nomeUsuario = new Name(Nome, Sobrenome);
      Usuario usuario = new Usuario(nomeUsuario);
      Assert.AreEqual(false, usuario.IsValid);
    }

}