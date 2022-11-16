using System;
using System.Threading;
using Microwave.Classes.Boundary;
using Microwave.Classes.Controllers;
using Timer = Microwave.Classes.Boundary.Timer;



namespace Microwave.App
{

    class Program
    {
        static PowerTube.Power power = PowerTube.Power.HighPower;
        static void Main(string[] args)
        {
            Button startCancelButton = new Button();
            Button powerButton = new Button();
            Button timeButton = new Button();

            Door door = new Door();

            Output output = new Output();

            buzzer buzzer = new buzzer(output);

            Display display = new Display(output);

            PowerTube powerTube = new PowerTube(output, power);

            Light light = new Light(output);

            Microwave.Classes.Boundary.Timer timer = new Timer();

            CookController cooker = new CookController(buzzer, timer, display, powerTube);

            UserInterface ui = new UserInterface(powerButton, timeButton, startCancelButton, door, display, light, cooker, timer, (int)power);

            // Finish the double association
            cooker.UI = ui;
            Console.WriteLine("P = power, T = time, S = start/cancel and esc = exit");
            // Simulate a simple sequence
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var keyPressed = Console.ReadKey(true);

                    if (keyPressed.Key == ConsoleKey.P) powerButton.Press();
                    if (keyPressed.Key == ConsoleKey.T) timeButton.Press();
                    if (keyPressed.Key == ConsoleKey.S) startCancelButton.Press();
                    if (keyPressed.Key == ConsoleKey.Escape) break;
                }
            }
        }
    }
}
