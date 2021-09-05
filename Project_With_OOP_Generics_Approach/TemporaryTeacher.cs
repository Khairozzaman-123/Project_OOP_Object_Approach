using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_With_OOP_Generics_Approach
{
    public sealed class TemporaryTeacher:Teacher
    {
        public Batch Batch { get; set; }
        public override void AssignBatch(Batch batch)
        {
            this.Batch = batch;
        }
        public override Batch[] GetBatches()
        {
            return new Batch[]
            {
                this.Batch
            };
        }
    }
}
