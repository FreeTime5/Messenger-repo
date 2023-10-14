using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MessLibrary
{
    public class MessageInfo
    {
        public int Id { get; private set; }

        public string Message { get; set; }

        public User MessageSender { get; private set; }

        public User MessageResiver { get; private set; }

        [MaxLength(12)]
        public string SendTime { get; private set; }

        public MessageInfo()
        {

        }
        public MessageInfo (string message, User sender, User reciver)
        {
            Message = message;
            MessageSender = sender;
            MessageResiver = reciver;
            SendTime = DateTime.Now.ToString("dd-MM, hh-mm");
        }
        
        public void DeleteMessage (User u)
        {
            if (MessageSender.Username == u.Username)
            {
                using (var db = new PostgreConnection())
                {
                    db.RemoveMessage(this);
                }
            }
        }

       
    }
}