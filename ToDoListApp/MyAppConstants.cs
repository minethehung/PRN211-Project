namespace ToDoListApp
{
    public class MyAppConstants
    {
        public static List<string> repeat;
        public static List<string> category;

        static MyAppConstants()
        {
            repeat = new List<string>();
                repeat.Add("Day");
                repeat.Add("weeks");
            category = new List<string>();
                category.Add("Critical");
                category.Add("High");
                category.Add("Normal");
                category.Add("Low");
        }

        
    }
}
