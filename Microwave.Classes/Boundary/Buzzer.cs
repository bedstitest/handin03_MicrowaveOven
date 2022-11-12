using Microwave.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave.Classes.Boundary;

public class buzzer : IBuzzer
{
    public void CookingIsEndedSound()
    {
        Console.WriteLine("Ding, Ding, Ding! Cooking Done");
    }
}
