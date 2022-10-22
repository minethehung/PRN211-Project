namespace BusinessObject
{
    public class CategoryObject
    {
        private int id;
        private string name;
        public CategoryObject(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public CategoryObject()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
