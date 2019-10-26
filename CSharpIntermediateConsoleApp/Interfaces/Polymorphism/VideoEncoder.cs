using System.Collections.Generic;

namespace CSharpIntermediateConsoleApp.Interfaces.Polymorphism
{
    class VideoEncoder
    {
        #region w/o OCP principle
        //private readonly MailService _mailService;

        //public VideoEncoder()
        //{
        //    _mailService = new MailService();
        //}

        //public void Encode(Video video)
        //{
        //    //Video encoding logic here
        //    //...

        //    //But if tomorrow we want to notify the user in another way (e.g through text), then we've to change this method
        //    //hence the class has to recompiled and redeployed and it's subsequent child classes if any
        //    //Hence when we design software, or in this case, we should not think about mail service, we should think in abstraction
        //    //we should just think that, when the VideoEncoder encodes the video, we just need to send a notification to the user, how we don't know what kind of notification
        //    //hence we think Notification channel as an abstraction and that's where interface comes in

        //    _mailService.Send(new Mail());
        //}

        #endregion

        #region with OCP principle and polymorphism

        private readonly IList<INotificationChannel> _notificationChannels; //as we may want to send notification via more than one medium, hence list is used

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //Video encoding logic here
            //....

            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

        #endregion

    }
}