using Microwave.Classes.Boundary;
using Microwave.Classes.Interfaces;
using NSubstitute;
using NUnit.Framework;
using System;
using System.IO;


namespace Microwave.Test.Unit;

[TestFixture]
public class BuzzerTest
{
    private IOutput output;
    private buzzer uut;

    [SetUp]
    public void Setup()
    {
        output = Substitute.For<IOutput>();
        uut = new buzzer(output);
    }


    [Test]
    public void WriteToConsoleTest()
    {
        
        uut.CookingIsEndedSound();

        output.Received(1).OutputLine(Arg.Is<string>(str => str.Contains("Ding, Ding, Ding! Cooking Done")));
        
    }



}