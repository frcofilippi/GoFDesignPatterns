namespace Adapter
{
    public class SonyTvController : ISonyDeviceController
    {
        private bool _on = false;

        public bool SwitchOnOff()
        {
            return !_on;
        }

    }
}
