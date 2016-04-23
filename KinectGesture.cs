using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public class KinectGesture
    {
        public SpotifyHelper.SpotifyAction sa;
        public string databaseLocation;

        public KinectGesture(SpotifyHelper.SpotifyAction sa, string dbLoc)
        {
            this.sa = sa;
            this.databaseLocation = dbLoc;
        }
    }
}
