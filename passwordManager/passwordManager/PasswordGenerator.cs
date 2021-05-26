using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    public class PasswordGenerator
    {
        private List<PasswordRequirement> _requirements;
        private int length;
        private List<int> _asciiNumbers;
        public string Password { get; set; }

        public PasswordGenerator(int length, List<PasswordRequirement> requirements)
        {
            this.length = length;
            this._requirements = requirements;
            SelectionValidation();
            this.Password = "";
            this._asciiNumbers = new List<int>();
            AddAsciiRangesByRequirement();
            GeneratePassword();
        }

        public void SelectionValidation()
        {
            if(this._requirements.Count == 0)
                throw new InvalidSelectionForPasswordException();
            if(this.length < 5 || this.length > 25)
                throw new InvalidAccountPasswordException();
        }

        public void GeneratePassword()
        {
            AddMandatoryRequirementsToPassword();
            CompletePassword();
        }

        public void AddAsciiRangesByRequirement()
        {
            foreach (PasswordRequirement req in _requirements)
            {
                this._asciiNumbers.AddRange(req.AsciiNumbers);
            }
        }

        public void AddMandatoryRequirementsToPassword()
        {
            foreach(PasswordRequirement req in _requirements)
            {
                InsertInRandomStringPosition(req.GenerateCharacter());
            }
        }
        
        private void CompletePassword()
        {
           while(Password.Length != this.length)
           {
                AsciiRangeRandomNumber rdm = new AsciiRangeRandomNumber(this._asciiNumbers);
                InsertInRandomStringPosition((char)rdm.Number);
           }
        }

        public void InsertInRandomStringPosition(char character)
        {
            Random rdm = new Random();
            int position = rdm.Next(0, this.Password.Length);
            this.Password = this.Password.Insert(position, character.ToString());
        }

    }
}