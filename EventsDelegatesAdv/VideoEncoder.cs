using System;
using System.Threading;

namespace EventsDelegatesAdv
{
    public class VideoEncoder
    {
//        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event EventHandler<VideoEventArgs> VideoEncoded;
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        public void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs()
                {
                    Video = video
                });
            }
        }
    }
}