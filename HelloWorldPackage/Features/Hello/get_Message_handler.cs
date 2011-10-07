using FubuCore;

namespace HelloWorldPackage.Features.Hello
{
    public class get_Message_handler
    {
         public MessageViewModel Execute(SpeakMessageModel request)
         {
             return new MessageViewModel
                        {
                            Content = "Hello, {0}".ToFormat(request.Message)
                        };
         }
    }

    public class SpeakMessageModel
    {
        public string Message { get; set; }
    }

    public class MessageViewModel
    {
        public string Content { get; set; }
    }
}