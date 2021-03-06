using passwordManager.Exceptions;
using System;

namespace passwordManager
{
    public class Category
    {
        private string _name;

        public int Id { get; set; }

        public string Name
        {
            get { return this._name; }
            set
            {
                if (!Validator.ValidateStringLength(value, (3, 15)))
                    throw new invalidCategoryNameException();
                this._name = value;
            }

        }

        public Category() { }

        public Category(string name)
        {
            this.Name = name;
        }

        public void ModifyCategory(string newName)
        {
            this.Name = newName;
        }
    }
}