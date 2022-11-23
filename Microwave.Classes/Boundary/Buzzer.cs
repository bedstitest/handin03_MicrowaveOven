using Microwave.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave.Classes.Boundary;

public class buzzer : IBuzzer
{

    private IOutput myOutput;

    public buzzer(IOutput output)
    {
        myOutput = output;
    }

    public void CookingIsEndedSound()
    {
        myOutput.OutputLine("Ding, Ding, Ding! Cooking Done\a");
    }
}
