using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_With_OOP_Generics_Approach
{
    public abstract class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public abstract void AssignBatch(Batch batch);
        public abstract Batch[] GetBatches();

    }
}
