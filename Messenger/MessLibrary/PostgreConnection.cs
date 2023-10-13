
namespace MessLibrary
{
    public class PostgreConnection : IDisposable 
    {
        private ProgramContext _connection = new ProgramContext();

        public void Dispose()
        {
            _connection.Dispose();
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

        
    }
}