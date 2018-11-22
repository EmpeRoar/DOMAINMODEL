using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.ValueObjects
{
    public class Country
    {
        public Country(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
    }
}
