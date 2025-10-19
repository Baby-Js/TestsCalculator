using NUnit.Framework;
using App.Core;

namespace App.Tests;

public class CalculatorTests
{

    private Calculator _calc = null!;


    [TestCase(2, true)]
    [TestCase(3, true)]
    [TestCase(4, false)]
    [TestCase(9, false)]
    [TestCase(17, true)]
    public void IsPrime_TestCases(int number, bool expected)
    {
        var result = _calc.IsPrime(number);
        Assert.That(result, Is.EqualTo(expected));
    }


    [SetUp]
    public void Setup()
    {
        _calc = new Calculator();
    }

    [Test]
    public void Sum_DeveSomar2e3_Retorna5()
    {
        var a = 2;
        var b = 3;

        var result = _calc.Sum(a, b);

        Assert.That(result, Is.EqualTo(5));

    }

    [TestCase(1, 1, 2)]
    [TestCase(-2, 2, 0)]
    [TestCase(10, -3, 7)]
    [TestCase(0, 0, 0)]
    public void Sum_VariosCenarios(int a, int b, int esperado)
    {
        var calc = new Calculator();
        var result = calc.Sum(a, b);
        Assert.That(result, Is.EqualTo(esperado));
    }

    [TestCase(10, 3, 7)]
    [TestCase(5, 10, -5)]
    [TestCase(-5, 2, -7)]
    [TestCase(-5, -2, -3)]
    public void Sub_VariosCenarios(int a, int b, int esperado)
    {
        var result = _calc.Sub(a, b);
        Assert.That(result, Is.EqualTo(esperado));
    }

    [TestCase(5, 5, 25)]
    [TestCase(5, -2, -10)]
    [TestCase(-3, -3, 9)]
    [TestCase(10, 0, 0)]
    public void Mul_VariosCenarios(int a, int b, int esperado)
    {
        var result = _calc.Mul(a, b);
        Assert.That(result, Is.EqualTo(esperado));
    }

    [TestCase(10, 2, 5)]
    [TestCase(-20, 5, -4)]
    [TestCase(-100, -10, 10)]
    [TestCase(7, 3, 2)]
    public void Div_VariosCenarios_Retornaresultado(int a, int b, int esperado)
    {
        var result = _calc.Div(a, b);
        Assert.That(result, Is.EqualTo(esperado));
    }

    [Test]
    public void Div_DenominadorZero_LancaDivideByZeroException()
    {
        var a = 10;
        var b = 0;
        var ex = Assert.Throws<DivideByZeroException>(() => _calc.Div(a, b));
        Assert.That(ex!.Message, Is.EqualTo("Denominador nao pode ser zero."));
    }
}