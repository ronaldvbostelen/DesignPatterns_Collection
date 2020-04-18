using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            if (CanExecute())
            {
                light.TurnOn();
            }
        }

        public void Undo() => light.TurnOff();

        public bool CanExecute() => !light.IsOn();
    }
}
