using passwordManager.Exceptions;
using System;

namespace passwordManager
{
    public class Category
    {
        public Category() { }

        public Category(string v)
        {
            _name = v;
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

        public bool ValidateName(string unString)
        {
            if (unString.Length >= 3 && unString.Length <= 15)
                return true;
            return false;
        }

        public void ModifyCategory(string newName)
        {
            this.Name = newName;
        }
    }
}