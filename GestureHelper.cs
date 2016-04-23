using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Samples.Kinect.DiscreteGestureBasics;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public static class GestureHelper
    {
        public static List<KinectGesture> gestures = new List<KinectGesture>()
        {
            new KinectGesture(SpotifyHelper.SpotifyAction.Next, @"Database\nav_next.gbd"),
            new KinectGesture(SpotifyHelper.SpotifyAction.VolumeUp, @"Database\nav_volup.gbd"),
        };
    }
}
