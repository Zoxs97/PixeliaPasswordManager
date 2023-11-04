using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixeliaPasswordManager
{
    public class Data
    {
        public List<Entry> Entries { get; set; }
        public List<string> Types { get; set; }


        public Data()
        {
            Entries = new List<Entry>();
            Types = new List<string>();
        }
    }

    public class Entry
    {
        public string Type { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
