namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesListaTests
    {
        private ValidacoesLista _validacoesLista;

        public ValidacoesListaTests()
        {
            _validacoesLista = new ValidacoesLista();
        }

        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            // Arrange
            List<int> lista = new List<int> { -1, 0, 1, 2, -3, 4, 5 };

            // Act
            List<int> resultado = _validacoesLista.RemoverNumerosNegativos(lista);

            // Assert
            Assert.All(resultado, num => Assert.True(num >= 0));
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            // Arrange
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            bool resultado = _validacoesLista.ListaContemDeterminadoNumero(lista, 9);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            // Arrange
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            bool resultado = _validacoesLista.ListaContemDeterminadoNumero(lista, 10);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            // Arrange
            List<int> lista = new List<int> { 1, 2, 3, 4, 5 };

            // Act
            List<int> resultado = _validacoesLista.MultiplicarNumerosLista(lista, 2);

            // Assert
            Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            // Arrange
            List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            int resultado = _validacoesLista.RetornarMaiorNumeroLista(lista);

            // Assert
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
        {
            // Arrange
            List<int> lista = new List<int> { -8, -7, -6, -5, -4, -3, -2, -1, 0 };

            // Act
            int resultado = _validacoesLista.RetornarMenorNumeroLista(lista);

            // Assert
            Assert.Equal(-8, resultado);
        }
    }
}