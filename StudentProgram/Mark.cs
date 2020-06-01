using System;
using System.Collections.Generic;
using System.Text;

namespace StudentProgram
{
    class Mark
    {
        public int Rating { get; set; }
        public string Subject { get; set; }
        public Mark()
        {

        }
        public Mark(int rating, string subject)
        {
            this.Rating = rating;
            this.Subject = subject;
        }
    }
}
