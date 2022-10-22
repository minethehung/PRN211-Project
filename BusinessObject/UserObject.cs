namespace BusinessObject
{
    public class UserObject
    {


        public UserObject()
        {
        }

        public UserObject(string username, string password, string fullName, DateTime dateOfBirh, string imagePath)
        {
            Username = username;
            Password = password;
            FullName = fullName;
            DateOfBirh = dateOfBirh;
            ImagePath = imagePath;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirh { get; set; }
        public string ImagePath { get; set; }
    }
}
