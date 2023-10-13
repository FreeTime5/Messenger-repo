namespace MessLibrary
{
    public class MessageInfo
    {
        public int Id { get; private set; }

        public string Message { get; set; }

        public User MessageSender { get; private set; }

        public User MessageResiver { get; private set; }

        public DateTime SendTime { get; private set; }

        public void DeleteMessage (User u)
        {
            if (MessageSender.Username == u.Username)
            {
                using (var db = new ProgramContext())
                {
                    db.Remove(db.Messages.Where(m => m.Id == Id));
                }
            }
        }

       
    }
}