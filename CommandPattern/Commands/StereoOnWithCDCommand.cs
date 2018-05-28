using CommandPattern.Commands.Contracts;
using CommandPattern.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(20);
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
