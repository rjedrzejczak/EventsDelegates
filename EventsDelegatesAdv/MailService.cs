using System;

namespace EventsDelegatesAdv
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Sending email {args.Video.Title}");
        }
    }
}