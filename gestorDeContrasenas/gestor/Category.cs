using System;

namespace passwordManager
{
    public class Category
    {
        public Category(){}

        public Category(string v)
        {
            name = v;
        }

        public string name { get; set; }

        public void update(Category c, string v)
        {
            c.name = v;
        }

        public bool validateName(string unString)
        {
            if(unString.Length >= 3 && unString.Length <= 15)
                return true;
            return false;
        }

    }
}