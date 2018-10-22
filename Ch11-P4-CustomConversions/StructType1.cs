using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11_P4_CustomConversions
{
    struct StructType1
    {
        private int number;
        public static StructType2 ConvertToType2(StructType1 type1)
        {
            return new StructType2(type1.number);
        }
    }

    struct StructType2
    {
        private int number;
        public StructType2(int no)
        {
            number = no;
        }
    }
}
