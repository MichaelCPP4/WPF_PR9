using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    /*struct Person
    {*//*
        public string[] _fio;
*//*
        public string _gender, _placeOfBirth, _nationality;

        public Int16 _yearOfBirth;
*//*
        public string[] Fio
        {
            get => _fio;
            set => _fio = value;
        }
*//*
        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public string Nationality
        {
            get => _nationality;
            set => _nationality = value;
        }

        public string PlaceOfBirth
        {
            get => _placeOfBirth;
            set => _placeOfBirth = value;
        }

        public Int16 YearOfBirth
        {
            get => _yearOfBirth;
            set => _yearOfBirth = value;
        }

        public Person(string gender, string nationality, string placeOfBirth, Int16 yearOfBirth)
        {
            //_fio = fio;
            Gender = gender;
            Nationality = nationality;
            PlaceOfBirth = placeOfBirth;
            YearOfBirth = yearOfBirth;
        }
    }*/

    public struct Person
    {
        public string[] Fio { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }

        public string PlaceOfBirth { get; set; }

        public Int16 YearOfBirth { get; set; }

        public Person(string[] fio, string gender, string nationality, string placeOfBirth, Int16 yearOfBirth)
        {
            Fio = fio;
            Gender = gender;
            Nationality = nationality;
            PlaceOfBirth = placeOfBirth;
            YearOfBirth = yearOfBirth;
        }
    }
}
