using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace kinnect
{
    public partial class Chats : ContentPage
    {
        public class Chat
        {

            public string FromUser { get; set; }
            public string ToUser { get; set; }
            public string Message { get; set; }
            public DateTime DateSent { get; set; }
            public string ImageUrl { get; set; }
            public string Status { get; set; }


            public List<Chats> GetMessages()
            {
                List<Chats> messages = new List<Chats>()
                {

                };
                return messages;
            }

        }

    }
}
