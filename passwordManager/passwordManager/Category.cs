using passwordManager.Exceptions;
using System;

namespace passwordManager
{
    public class Category
    {
        public Category() { }

        public Category(string name)
        {
            this.Name = name;
        }
        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (!this.ValidateName(value))
                    throw new invalidCategoryNameException();
                this._name = value;
            }

        }

        public bool ValidateName(string name)
        {
            
            if (name.Length >= 3 && name.Length <= 15)
                return true;
            return false;
        }

        public void ModifyCategory(string newName)
        {
            this.Name = newName;
        }
    }
}