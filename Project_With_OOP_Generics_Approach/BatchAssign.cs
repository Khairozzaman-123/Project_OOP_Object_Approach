using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_With_OOP_Generics_Approach
{
    public class BatchAssign<T> : ITeacherAssign<T> where T : Teacher
    {
        public void AssignTeacher(T obj, Batch batch)
        {
            if (obj is PermanentTeacher)
            {
                PermanentTeacher teacher = obj as PermanentTeacher;
                if (teacher.Batches[0] != null && teacher.Batches[1] != null)
                {
                    throw new Exception("Already has two batches.");
                }
                bool slotMatch = false;
                foreach (var b in teacher.Batches)
                {
                    if (b != null)
                    {
                        if (b.TimeSlot == batch.TimeSlot)
                        {
                            slotMatch = true;
                            break;
                        }
                    }
                }
                if (slotMatch)
                {
                    throw new Exception("Already has two batch in same time slot");
                }
                else
                {
                    teacher.AssignBatch(batch);
                }
            }
            else if (obj is TemporaryTeacher)
            {
                TemporaryTeacher temTeacher = obj as TemporaryTeacher;
                if (temTeacher.Batch != null)
                {
                    throw new Exception("Already has batch");
                }
                else
                {
                    temTeacher.AssignBatch(batch);
                }
            }
            else
            {
                throw new Exception("Not a teacher.");
            }
        }
    }
}
