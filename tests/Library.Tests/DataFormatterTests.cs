using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1FormatoCorrecto()
    {
        ///Arrange
        string miFecha = "10/12/2024";
        string resultadoEsperado = "2024-12-10";

        ///Act
        string resultadoObtenido = DateFormatter.ChangeFormat(miFecha);

        ///Assert
        Assert.That(resultadoObtenido, Is.EqualTo(resultadoEsperado));
    }
    
    [Test]
    public void Test2FormatoIncorrecto()
    {
        ///Arrange
        string miFecha = "2024-12-10";


        /// Assert de Exception
        Assert.Throws<Exception>(() => DateFormatter.ChangeFormat(miFecha));  
    }

    [Test]

    public void Test3FechaEnBlanco()
    {
        //Arrange
        string miFecha = " ";

        ///Assert de Exception
        Assert.Throws<Exception>(() => DateFormatter.ChangeFormat(miFecha));
    }
}