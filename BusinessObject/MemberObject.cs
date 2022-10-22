namespace BusinessObject
{
    public class MemberObject
    {
        private string username;
        private string password;
        private string fullName;
        private string birthOfDate;

        public MemberObject(string username, string password, string fullName, string birthOfDate)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.birthOfDate = birthOfDate;
        }
        public MemberObject()
        {
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string BirthOfDate { get; set; }
    }
}
