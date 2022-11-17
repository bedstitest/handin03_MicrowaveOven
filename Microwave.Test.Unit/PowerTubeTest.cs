using System;
using Microwave.Classes.Boundary;
using Microwave.Classes.Interfaces;
using NSubstitute;
using NSubstitute.Core.Arguments;
using NUnit.Framework;

namespace Microwave.Test.Unit
{
    [TestFixture]
    public class PowerTubeTest
    {
        private PowerTube uut;
        private IOutput output;

        [SetUp]
        public void Setup()
        {
            output = Substitute.For<IOutput>();
            uut = new PowerTube(output);
        }

        [TestCase(PowerTube.Power.LowPower, 1)]
        [TestCase(PowerTube.Power.LowPower, 50)]
        [TestCase(PowerTube.Power.LowPower, 100)]
        [TestCase(PowerTube.Power.LowPower,(int)PowerTube.Power.LowPower-1)]
        [TestCase(PowerTube.Power.LowPower,(int)PowerTube.Power.LowPower)]
        [TestCase(PowerTube.Power.MediumPower, 1)]
        [TestCase(PowerTube.Power.MediumPower, 50)]
        [TestCase(PowerTube.Power.MediumPower, 100)]
        [TestCase(PowerTube.Power.MediumPower,(int)PowerTube.Power.MediumPower-1)]
        [TestCase(PowerTube.Power.MediumPower,(int)PowerTube.Power.MediumPower)]
        [TestCase(PowerTube.Power.HighPower, 1)]
        [TestCase(PowerTube.Power.HighPower, 50)]
        [TestCase(PowerTube.Power.HighPower, 100)]
        [TestCase(PowerTube.Power.HighPower,(int)PowerTube.Power.HighPower-1)]
        [TestCase(PowerTube.Power.HighPower,(int)PowerTube.Power.HighPower)]
        public void TurnOn_WasOffCorrectPower_CorrectOutput(PowerTube.Power tubeSize, int power)
        {
            uut = new PowerTube(output, tubeSize);
            uut.TurnOn(power);
            output.Received().OutputLine(Arg.Is<string>(str => str.Contains($"{power}")));
        }

        [TestCase(-5)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(701)]
        [TestCase(750)]
        public void TurnOn_WasOffOutOfRangePower_ThrowsException(int power)
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => uut.TurnOn(power));
        }

        [Test]
        public void TurnOff_WasOn_CorrectOutput()
        {
            uut.TurnOn(50);
            uut.TurnOff();
            output.Received().OutputLine(Arg.Is<string>(str => str.Contains("off")));
        }

        [Test]
        public void TurnOff_WasOff_NoOutput()
        {
            uut.TurnOff();
            output.DidNotReceive().OutputLine(Arg.Any<string>());
        }

        [Test]
        public void TurnOn_WasOn_ThrowsException()
        {
            uut.TurnOn(50);
            Assert.Throws<System.ApplicationException>(() => uut.TurnOn(60));
        }
    }
}
