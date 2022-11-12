using System;
using Microwave.Classes.Interfaces;

namespace Microwave.Classes.Controllers
{
    public class CookController : ICookController
    {
        // Since there is a 2-way association, this cannot be set until the UI object has been created
        // It also demonstrates property dependency injection
        public IUserInterface UI { set; private get; }

        private bool isCooking = false;

        private IDisplay myDisplay;
        private IPowerTube myPowerTube;
        private ITimer myTimer;
        private IBuzzer myBuzzer;

        public CookController(
            ITimer timer,
            IDisplay display,
            IPowerTube powerTube,
            IBuzzer buzzer,
            IUserInterface ui) : this(timer, display, powerTube, buzzer)
        {
            UI = ui;
        }

        public CookController(
            ITimer timer,
            IDisplay display,
            IPowerTube powerTube,
            IBuzzer buzzer)
        {
            myTimer = timer;
            myDisplay = display;
            myPowerTube = powerTube;
            myBuzzer = buzzer;
            

            timer.Expired += new EventHandler(OnTimerExpired);
            timer.TimerTick += new EventHandler(OnTimerTick);
        }

        public void StartCooking(int power, int time)
        {
            myPowerTube.TurnOn(power);
            myTimer.Start(time);
            isCooking = true;
        }

        public void Stop()
        {
            isCooking = false;
            myPowerTube.TurnOff();
            myBuzzer.CookingIsEndedSound();
            myTimer.Stop();

        }

        public void OnTimerExpired(object sender, EventArgs e)
        {
            if (isCooking)
            {
                isCooking = false;
                myPowerTube.TurnOff();
                myBuzzer.CookingIsEndedSound();
                UI.CookingIsDone();
                
            }
        }

        public void OnTimerTick(object sender, EventArgs e)
        {
            if (isCooking)
            {
                int remaining = myTimer.TimeRemaining;
                myDisplay.ShowTime(remaining / 60, remaining % 60);
            }
        }
    }
}