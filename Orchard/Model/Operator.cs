﻿using System;
using SQLite;

namespace Orchard
{
    public class Operator : NPCBase
    {
        public Operator Copy()
        {
            return (Operator)this.MemberwiseClone();
        }

        int _id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        string _name;

        public string Name
        { 
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string Image { get; set; }

        string _certificationNumber;

        public string CertificationNumber
        {
            get { return _certificationNumber; }
            set { SetProperty(ref _certificationNumber, value); }
        }

        string _note;

        public string Note
        { 
            get { return _note; } 
            set { SetProperty(ref _note, value); }
        }
    }
}

