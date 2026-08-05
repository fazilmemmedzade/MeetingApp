namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "User 1", Email = "user1@gmail.com", Phone = "0556667788", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "User 2", Email = "user2@gmail.com", Phone = "0557778899", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "User 3", Email = "user3@gmail.com", Phone = "0559998877", WillAttend = false });
            _users.Add(new UserInfo() { Id = 4, Name = "User 4", Email = "user4@gmail.com", Phone = "0553338877", WillAttend = false });
            _users.Add(new UserInfo() { Id = 5, Name = "User 5", Email = "user5@gmail.com", Phone = "0554448877", WillAttend = true });
        }

        public static List<UserInfo> Users { get { return _users; } }

        public static void CreateUser(UserInfo user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
