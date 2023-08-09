using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SellTech.Application.Dtos.Categoria.Request;
using SellTech.Application.Interfaces;
using SellTech.Utilities.Static;

namespace SellTech.Test.Categoria
{
    [TestClass]
    public class CategoriaApplicationTest
    {
        private static WebApplicationFactory<Program>? _factory = null;
        private static IServiceScopeFactory? _scopeFactory = null;

        [ClassInitialize]
        public static void Initialize(TestContext _testContext)
        {
            _factory = new CustomWebApplicationFactory();
            _scopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
        }

        [TestMethod]
        public async Task RegisterCategoria_WhenSendingNullValuesEmpty_ValidationErrors()
        {
            using var scope = _scopeFactory?.CreateScope();
            var context = scope?.ServiceProvider.GetService<ICategoriaApplication>();

            //Arrange
            var nombre = "";
            var descripcion = "";
            var estado = 1;
            var expected = ReplyMessage.MESSAGE_VALIDATE;
            //Act
            var result = await context!.RegisterCategoria(new CategoriaRequestDto()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Estado = estado
            });

            var current = result.Message;
            //Assert
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public async Task RegisterCategoria_WhenSendingCorrectValues_RegisteredSuccessfully()
        {
            using var scope = _scopeFactory?.CreateScope();
            var context = scope?.ServiceProvider.GetService<ICategoriaApplication>();

            //Arrange
            var nombre = "nuevo registro";
            var descripcion = "nueva descripcion";
            var estado = 1;
            var expected = ReplyMessage.MESSAGE_SAVE;
            //Act
            var result = await context!.RegisterCategoria(new CategoriaRequestDto()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Estado = estado
            });

            var current = result.Message;
            //Assert
            Assert.AreEqual(expected, current);
        }
    }
}
