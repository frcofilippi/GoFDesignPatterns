using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SamsungAdapter : IDeviceControllerAdapter
    {
        private readonly ISamsungDeviceController deviceController;

        public SamsungAdapter(ISamsungDeviceController deviceController)
        {
            this.deviceController = deviceController;
        }

        public string SwitchOnOffDevice()
        {
            return deviceController.TurnOnOff(); ;
        }
    }
}
