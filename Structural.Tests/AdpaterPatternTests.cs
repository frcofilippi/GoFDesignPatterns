using Adapter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Structural.Tests
{
    [Collection("Adapter")]
    public class AdpaterPatternTests
    {

        [Fact]
        public void ShouldBeAbteToTurnOnSamsungTv()
        {
            IDeviceControllerAdapter deviceController = new SamsungAdapter(new SamsungTvController());
            var expected = "Samsung TV turned on";
            Assert.Equal(expected, deviceController.SwitchOnOffDevice());
        }

        [Fact]
        public void ShouldBeAbteToTurnOnSonyTv()
        {
            IDeviceControllerAdapter deviceController = new SonyAdapter(new SonyTvController());
            var expected = "Sony Tv turned on";
            Assert.Equal(expected, deviceController.SwitchOnOffDevice());
        }
    }
}
