namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository(){
            _users.Add(new UserInfo(){Id=0,Name="Harrik",Email="harrik@mail.com",Phone="123123123", WillAttend=true});
            _users.Add(new UserInfo(){Id=1,Name="Test",Email="test@mail.com",Phone="3123123", WillAttend=false});
            _users.Add(new UserInfo(){Id=2,Name="Coll",Email="coll@mail.com",Phone="2222222", WillAttend=true});
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}