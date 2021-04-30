using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    public class Account : DataUnit
    {
        public enum Color
        {
            Red = 1,
            Orange = 2,
            Yellow = 3,
            LightGreen = 4,
            DarkGreen = 5
        }
        private string _username;
        private string _password;
        private string _site;
        private string _note;
        private DateTime _modification;
        public string Username { 
            get { return this._username; }
            set 
            {
                if (!this.ValidateUsernameAndPassword(value))
                    throw new InvalidAccountUsernameException();
                this._username = value;
            } }
        public string Password {
            get { return this._password; } 
            set
            {
                if (!this.ValidateUsernameAndPassword(value))
                    throw new InvalidAccountPasswordException();
                ClassifyColor(value);
                this._password = value;

            }
        }

        private void ClassifyColor(string password)
        {
            if (password.Length < 8)
                this.Classification = Color.Red;
            else if (password.Length <= 14)
                this.Classification = Color.Orange;
            else
            {
                int cuantity = TypesOfCharacters(password);
                if (cuantity == 1)
                {
                    this.Classification = Color.Yellow;
                }
                else if (cuantity == 2)
                {
                    if (this.ContainsLowerCase(password) && this.ContainsUpperCase(password)) this.Classification = Color.LightGreen;
                    else this.Classification = Color.Yellow;
                }
                else if (cuantity == 3) this.Classification = Color.LightGreen;
                else this.Classification = Color.DarkGreen;
            }

        }

        private int TypesOfCharacters(string password)
        {
            int count = 0;
            if (this.ContainsUpperCase(password)) count++;
            if (this.ContainsLowerCase(password)) count++;
            if (this.ContainsDigits(password)) count++;
            if (this.ContainsSpecials(password)) count++;

            return count;
        }

        public string Site {
            get { return this._site; }
            set {
                if (!this.ValidateSite(value))
                    throw new InvalidAccountSiteException();
                this._site = value;
            } 
        }
        
        public string Note {
            get { return this._note; }
            set {
                if (!this.ValidateNotes(value))
                    throw new InvalidAccountNotesException();
                this._note = value;
            }
        }
        public DateTime Modification { get; set; }
        public Color Classification { get; set; }

        public bool ValidateUsernameAndPassword(string s)
        {
            if (s.Length >= 5 && s.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateSite(string v)
        {
            if (v.Length >= 3 && v.Length <= 25)
                return true;
            return false;
        }

        public bool ValidateNotes(string v)
        {
            if (v.Length > 250)
                return false;
            return true;
        }

        public void GeneratePassword(int length, bool upper, bool lower, bool digits, bool specials)
        {
            if (upper || lower || digits || specials)
            {
                int cont = 0;
                string password = "";
                List<int> ASCII_numbers = new List<int>();
                Random rdm = new Random();
                if (upper)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(65, (91 - 65)));
                    int asciiLetterCode = rdm.Next(65, 91);
                    password = password.Insert(0, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                if (lower)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(97, (123 - 97)));
                    int asciiLetterCode = rdm.Next(97, 123);
                    int position = rdm.Next(0, password.Length);
                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                if (digits)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(48, (58 - 48)));
                    int asciiLetterCode = rdm.Next(48, 58);
                    int position = rdm.Next(0, password.Length);
                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                if (specials)
                {
                    ASCII_numbers.AddRange(Enumerable.Range(32, (48 - 32)));
                    ASCII_numbers.AddRange(Enumerable.Range(58, (65 - 58)));
                    ASCII_numbers.AddRange(Enumerable.Range(91, (97 - 91)));
                    ASCII_numbers.AddRange(Enumerable.Range(123, (127 - 123)));

                    int[] randomNumbersEspeciales = new int[] { rdm.Next(32, 48), rdm.Next(58, 65), rdm.Next(91, 97), rdm.Next(123, 127) };
                    int posArray = rdm.Next(0, randomNumbersEspeciales.Length);

                    int asciiLetterCode = randomNumbersEspeciales[posArray];
                    int position = rdm.Next(0, password.Length);

                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }
                for (int i = cont; i < length; i++)
                {

                    int index = rdm.Next(0, ASCII_numbers.Count);
                    int asciiLetterCode = ASCII_numbers[index];
                    int position = rdm.Next(0, (cont - 1));
                    password = password.Insert(position, ((char)asciiLetterCode).ToString());
                    cont++;
                }

                this.Password = password;
            }
            else
                throw new InvalidSelectionForPasswordException();
        }

        public bool ContainsUpperCase(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 65, 90);
        }

        public bool ContainsLowerCase(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 97, 122);
        }
        
        public bool ContainsSpecials(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 32, 47) || ContainsCharBetweenAsciiValues(password, 58, 64) || ContainsCharBetweenAsciiValues(password, 91, 96) || ContainsCharBetweenAsciiValues(password, 123, 126);
        }

        public bool ContainsDigits(string password)
        {
            return ContainsCharBetweenAsciiValues(password, 48, 57);
        }

        private static bool ContainsCharBetweenAsciiValues(string password, int value1, int value2)
        {
            foreach (char n in password)
            {
                int asciiValue = (int)n;
                if (asciiValue >= value1 && asciiValue <= value2)
                    return true;
            }
            return false;
        }


        
    }
}