using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Model
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(20)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return LastName.ToString() + " " + FirstName.ToString() + " " + Phone.ToString();
        }
    }
}
