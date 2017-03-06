using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_A_Lot_Class_Library
{
    public class Student: UserClass
    {
        public int user_ID { get; set; }

        public Student(int UserID)
        {
            user_ID = UserID;
        }
    }
}
