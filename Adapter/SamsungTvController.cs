using System;

namespace Adapter
{
    public class SamsungTvController : ISamsungDeviceController
    {
        private bool _turnedOn = false;
        public string TurnOnOff()
        {
            if (_turnedOn)
            {
                _turnedOn = false;
                return "Samsung TV turned off";
            }
            else
            {
                _turnedOn = true;
                return "Samsung TV turned on";
            }
        }
    }
}
