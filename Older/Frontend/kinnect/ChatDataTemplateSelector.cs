using System;
using Xamarin.Forms;
using static kinnect.Chats;

namespace kinnect
{
    public class ChatDataTemplateSelector : DataTemplateSelector
    {
      
            public DataTemplate FromTemplate { get; set; }
        public DataTemplate ToTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Chat)item).Status.ToUpper().Equals("Sent") ? FromTemplate : ToTemplate;
        }
    }
}

