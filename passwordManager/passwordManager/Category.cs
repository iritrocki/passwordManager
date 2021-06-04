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

        public int Id { get; set; }

        private string _name;
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


        public void ModifyCategory(string newName)
        {
            this.Name = newName;
        }
    }
}