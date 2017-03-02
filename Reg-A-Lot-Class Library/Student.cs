using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg_A_Lot_Class_Library
{
    abstract class Student
    {
        int user_ID;

        Student(int userID)
        {
            user_ID = userID;
        }
    }
}
