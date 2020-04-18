using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class HomeTheaterFacade
    {
        private Amplifier amplifier;
        private CdPlayer cdPlayer;
        private DvdPlayer dvdPlayer;
        private PopcornPopper popcornPopper;
        private Projector projector;
        private Screen screen;
        private TheaterLights theaterLights;
        private Tuner tuner;

        public HomeTheaterFacade(Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer, 
            PopcornPopper popcornPopper, Projector projector, Screen screen, 
            TheaterLights theaterLights, Tuner tuner)
        {
            this.amplifier = amplifier;
            this.cdPlayer = cdPlayer;
            this.dvdPlayer = dvdPlayer;
            this.popcornPopper = popcornPopper;
            this.projector = projector;
            this.screen = screen;
            this.theaterLights = theaterLights;
            this.tuner = tuner;
        }

        public void WatchMovie()
        {
            Console.WriteLine("Get ready to watch a movie...");
            popcornPopper.TurnOn();
            theaterLights.TurnOn();
            screen.TurnOn();
            projector.TurnOn();
            amplifier.TurnOn();
            dvdPlayer.TurnOn();
        }

        public void EndMovie()
        {
            Console.WriteLine("Turning the devices off");
            popcornPopper.TurnOff();
            theaterLights.TurnOff();
            screen.TurnOff();
            projector.TurnOff();
            amplifier.TurnOff();
            dvdPlayer.TurnOff();
        }
    }
}
