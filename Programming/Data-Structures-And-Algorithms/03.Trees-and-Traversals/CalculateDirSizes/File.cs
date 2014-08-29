using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDirSizes
{
    class File
    {
        public string Name { get; set; }

        public int Size { get; set; }

        public File(string name)
        {
            this.Name = name;
        }
    }
}
