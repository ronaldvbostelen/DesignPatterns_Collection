using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();
            remote.SetCommand(new LightOnCommand(new Light()));
            remote.ButtonWasPressed();
            
            remote.SetCommand(new GarageDoorOpenCommand(new GarageDoor()));
            remote.ButtonWasPressed();


            // LAMBDA STYLE
            Console.WriteLine("LAMBDA STYLE");
            var remoteControl = new RemoteControl(); // invoker
            var livingRoomLight = new Light(); // reciever
            remoteControl.SetCommand(0,() => livingRoomLight.TurnOn(), () => livingRoomLight.TurnOff());

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);

        }
    }
}
