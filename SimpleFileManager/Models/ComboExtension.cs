using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileManager.Models
{
    
    public class ComboExtension
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public override string ToString()
        {
            return this.Value;
        }
    }
}
