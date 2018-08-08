using System;
using Xunit;
using MyFinance.Models;

namespace ProjetoTeste
{
    public class UnitTestModels
    {
        [Fact]
        public void TestLoginUsuario()
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            usuarioModel.Email = "filipenhimi@gmail.com";
            usuarioModel.Senha = "123456";
            bool result = usuarioModel.ValidarLogin();
            Assert.True(result);            
        }

        [Fact]
        public void TestRegistrarUsuario()
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            usuarioModel.Nome = "Teste";
            usuarioModel.Data_Nascimento = "1987/05/22";
            usuarioModel.Email = "usuario@gmail.com";
            usuarioModel.Senha = "123456";
            usuarioModel.RegistrarUsuario();
            bool result = usuarioModel.ValidarLogin();
            Assert.True(result);                        
        }
    }
}
