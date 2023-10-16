
namespace MessLibrary
{
    public class PostgreConnection : IDisposable 
    {
        private ProgramContext _connection = new ProgramContext();

        public void AddUser (User user)
        {
            _connection.Users.Add(user);
            _connection.SaveChanges();
        }

        public void AddMessage (MessageInfo message)
        {
            _connection.Messages.Add(message);
            _connection.SaveChanges();
        }

        public void UpdateUsers(User user)
        {
            _connection.Users.Update(user);
            _connection.SaveChanges();
        }

        public void UpdateMessages(MessageInfo message)
        {
            _connection.Messages.Update(message);
            _connection.SaveChanges();
        }

        public User? GetInfoUser(string username)
        {
            return _connection.Users.Find(username);
        }

        public MessageInfo? GetInfoMessage(int id)
        {
            return _connection.Messages.Find(id);
        }

        public void RemoveMessage (MessageInfo message)
        {
            _connection.Messages.Remove(message);
            _connection.SaveChanges();
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}