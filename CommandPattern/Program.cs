using CommandPattern.Commands;
using CommandPattern.Commands.Contracts;
using CommandPattern.Entities;
using CommandPattern.Handlers;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl(7);

            var locationLivingRoom = new Location("LIVING ROOM");
            var light = new Light(locationLivingRoom);
            var lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonPressed();

            var locationGarage = new Location("GARAGE");
            var garageDoor = new Gate(locationGarage);
            var garageDoorOpen = new GateOpenCommand(garageDoor);

            remote.SetCommand(garageDoorOpen);
            remote.ButtonPressed();

            remote.UndoButtonPressed();

            Console.ReadKey();
            
        }
    }
}
