using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CI.Demo
{
    public class Feature
    {
        public string Name { get; private set; }

        public Feature(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            this.Name = name.ToLower();
        }
    }
}
