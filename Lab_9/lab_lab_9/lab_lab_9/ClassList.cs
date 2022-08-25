using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_lab_9
{
    public class ClassList
    {
        public long lenght { get; set; }
        public string filename { get; set; }
        public string filename_ { get; set; }

        public string path { get; set; }

        public ClassList(long lenght, string filesnames, string path,  string filename_)
        {
            this.lenght = lenght;
            this.filename = filesnames;
            this.path = path;
            this.filename_ = filename_;
        }
    }
}