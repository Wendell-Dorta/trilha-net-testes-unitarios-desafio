using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoesString;

        public ValidacoesStringTests()
        {
            _validacoesString = new ValidacoesString();
        }

        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            // Arrange
            string palavra = "Matrix";

            // Act
            int resultado = _validacoesString.RetornarQuantidadeCaracteres(palavra);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            // Arrange
            string texto = "Esse é um texto qualquer";
            string palavra = "qualquer";

            // Act
            bool resultado = _validacoesString.ContemCaractere(texto, palavra);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            // Arrange
            string texto = "Esse é um texto qualquer";
            string palavra = "teste";

            // Act
            bool resultado = _validacoesString.ContemCaractere(texto, palavra);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            // Arrange
            string texto = "Começo, meio e fim do texto procurado";
            string palavra = "procurado";

            // Act
            bool resultado = _validacoesString.TextoTerminaCom(texto, palavra);

            // Assert
            Assert.True(resultado);
        }
    }
}