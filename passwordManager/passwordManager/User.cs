
﻿using passwordManager.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace passwordManager
{
    public class User
    {
        private string _masterKey;
        
        public int Id { get; set; }
        
        public bool Status { get; set; }

        public string MasterKey
        {
            get { return this._masterKey; }
            set
            {
                if (!Validator.ValidateStringLength(value, (5, 25)))
                    throw new InvalidMasterKeyException();
                else
                    this._masterKey = value;

            }
        }

        public User()
        {
            this.Status = false;
        }

        public void SignIn(string input)
        {
            if(input == this.MasterKey)
            {
                this.Status = true;
            }
            else
            {
                throw new InvalidMasterKeyException();
            }
        }

        public void SignOut()
        {
            this.Status = false;
        }

        public void ChangeMasterKey(string actualMasterKey, string newMasterKey)
        {
            if(actualMasterKey == this.MasterKey)
                this.MasterKey = newMasterKey;
            else
                throw new InvalidMasterKeyException();
        }

    }
}