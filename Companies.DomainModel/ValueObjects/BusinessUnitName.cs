using System;
using System.Collections.Generic;
using System.Text;

namespace Companies.DomainModel.ValueObjects
{
    public class BusinessUnitName
    {
        public BusinessUnitName(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
