namespace BusinessObject
{
    public class UserObject
    {


        public UserObject()
        {
        }

        public UserObject(string username, string password, string fullName, string birthOfDate, string imagePath)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            BirthOfDate = birthOfDate;
            ImagePath = imagePath;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string BirthOfDate { get; set; }
        public string ImagePath { get; set }
    }
}
