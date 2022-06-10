using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand_Models
{
    public class GenreVM
    {
        public GenreVM(int ID, string name)
        {
            ID = Id;
            name = Name;
        }

        public Genre Genre { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
