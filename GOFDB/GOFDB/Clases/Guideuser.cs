using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace GOFDB.Clases
{
    class Guideuser
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }

        public string Game { get; set; }
        public string Username { get; set; }
        public string Guide { get; set; }

        public override string ToString()
        {
            return $"{Game} - {Username} - {Guide}";
        }
    }
}
