using Microwave.Classes.Boundary;
using NUnit.Framework;
using System;
using System.IO;


namespace Microwave.Test.Unit;

[TestFixture]
public class BuzzerTest
{
    private buzzer uut;

    [SetUp]
    public void Setup()
    {
        uut = new buzzer();
    }


    [Test]
    public void WriteToConsoleTest()
    {
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        uut.CookingIsEndedSound();

        Assert.AreEqual("Ding, Ding, Ding! Cooking Done\a\r\n", stringWriter.ToString());
    }



}