using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    public class MyAppConstants
    {
        public static List<string> repeat;
        public static List<string> category;

        static MyAppConstants(){
            repeat = new List<string>();
            for(int i = 0; i< 9; i++)
            {
                repeat.Add("None");
                repeat.Add("Everyday");
                repeat.Add("Monday");
                repeat.Add("Tuesday");
                repeat.Add("Wednesday");
                repeat.Add("Thursday");
                repeat.Add("Friday");
                repeat.Add("Saturday");
                repeat.Add("Sunday");
            }
    category = new List<string>();
            for(int i = 0; i< 4; i++)
            {
                category.Add("Critical");
                category.Add("High");
                category.Add("Normal");
                category.Add("Low");
            }
            }
       

    }
}
