using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_With_OOP_Generics_Approach
{
    public sealed class PermanentTeacher:Teacher
    {
        public PermanentTeacher()
        {
            this.Batches = new Batch[2];
        }
        public Batch[] Batches { get; set; }
        public override void AssignBatch(Batch batch)
        {
            for (int i = 0; i < this.Batches.Length; i++)
            {
                if (this.Batches[i] == null)
                {
                    this.Batches[i] = batch;
                    break;
                }
            }
        }
        public override Batch[] GetBatches()
        {
            return this.Batches;
        }
    }
}
