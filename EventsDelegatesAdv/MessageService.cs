using System;

namespace EventsDelegatesAdv
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Sending message {args.Video.Title}");
        }
    }
}