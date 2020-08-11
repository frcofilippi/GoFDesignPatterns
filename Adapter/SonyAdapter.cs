namespace Adapter
{
    public class SonyAdapter : IDeviceControllerAdapter
    {
        private readonly ISonyDeviceController deviceController;

        public SonyAdapter(ISonyDeviceController deviceController)
        {
            this.deviceController = deviceController;
        }

        public string SwitchOnOffDevice()
        {
            var state = deviceController.SwitchOnOff();
            if (state)
            {
                return "Sony Tv turned on";
            }
            else
            {
                return "Sony Tv turned off";
            }
        }
    }
}
