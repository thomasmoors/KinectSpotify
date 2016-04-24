using Microsoft.Kinect.VisualGestureBuilder;

namespace Microsoft.Samples.Kinect.DiscreteGestureBasics
{
    public class KinectGesture
    {
        public SpotifyHelper.SpotifyAction sa;
        public Gesture g;

        public KinectGesture(SpotifyHelper.SpotifyAction sa, Gesture g)
        {
            this.sa = sa;
            this.g = g;
        }
    }
}
