﻿namespace Demo_FileIO_NTier.Starter.Models
{
    public class Character
    {
        public enum GenderType { NOTSPECIFIED, MALE, FEMALE }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
