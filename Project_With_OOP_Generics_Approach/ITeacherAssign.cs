using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_With_OOP_Generics_Approach
{
    public interface ITeacherAssign<in T>
    {
        void AssignTeacher(T obj, Batch batch);
    }
}
