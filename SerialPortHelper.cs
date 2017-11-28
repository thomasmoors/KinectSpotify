using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public static class SerialPortHelper
    {
      public static void SendBytesOverCom(SerialPort sp, string message)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(message);
            sp.Write(byteArray, 0, byteArray.Length);
        }
    }
}
