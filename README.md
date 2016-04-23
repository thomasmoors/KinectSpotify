# About KinectSpotify
You can control Spotify with your Kinect (One) with this

# For who
- Requested by Roel Stein
- Written in C# using the Kinect SDK 2.0
- Using "DiscreteGestureBasics-WPF" example from Microsoft

# How to use
- Create your own database (.gbd file)
- Register it in 'GestureHelper.cs' with and SpotifyAction
- You can create custom SpotifyActions by editing 'SpotifyHelper.cs'
- You can even target other processes / applications by changing the process that is searched for in 'SpotifyHelper.cs' by name
