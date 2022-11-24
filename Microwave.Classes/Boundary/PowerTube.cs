using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Boundary
{
    public class PowerTube : IPowerTube
    {
        private IOutput myOutput;

        public enum Power : int{
            LowPower = 500,
            MediumPower = 800,
            HighPower = 1000
        }

        public Power PowerTubeSize { get; set; }

        private bool IsOn = false;

        public PowerTube(IOutput output, Power powerTubeSize)
        {
            myOutput = output;
            PowerTubeSize = powerTubeSize;
        }

        public void TurnOn(int power)
        {
            if (power < 1 || power > (int)PowerTubeSize)
            {
                throw new ArgumentOutOfRangeException("power", power, $"Must be between 1 and {power} (incl.)");
            }

            if (IsOn)
            {
                throw new ApplicationException("PowerTube.TurnOn: is already on");
            }

            myOutput.OutputLine($"PowerTube works with {power}");
            IsOn = true;
        }

        public void TurnOff()
        {
            if (IsOn)
            {
                myOutput.OutputLine($"PowerTube turned off");
            }

            IsOn = false;
        }
    }
}