using Microwave.Classes.Boundary;
using Microwave.Classes.Interfaces;
using NUnit.Framework;
using System;
using System.Diagnostics;

namespace Microwave.Test.Unit;

[TestFixture]
public class BuzzerTest
{
    private buzzer uut;

    [SetUp]
    public void Setup()
    {
        uut = new buzzer();
        Trace.Listeners.Add(new ConsoleTraceListener());
    }

    [Test]
    public void ConsolePrintTest()
    {

        // We don't need an assert, as an exception would fail the test case
        uut.CookingIsEndedSound();

        Debug.WriteLine("This is Debug.WriteLine");
        Trace.WriteLine("This is Trace.WriteLine");
        Console.WriteLine("This is Console.Writeline");
        Assert.Pass();
    }



}