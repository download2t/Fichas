using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Classes
{
    public class Pai
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Pai()
        {
            _id = 0;
        }

        public Pai(int id)
        {
            _id = id;
        }
    }
}
