using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_With_OOP_Generics_Approach
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch[] batches = new Batch[]
            {
                new Batch{BatchId=1,TimeSlot=TimeSlot.Morning,Subject="Programming in C#"},
                new Batch{BatchId=2,TimeSlot=TimeSlot.Evening,Subject="Programming in C#"},
                new Batch{BatchId=3,TimeSlot=TimeSlot.Morning,Subject="Programming in GAVE"},
                new Batch{BatchId=4,TimeSlot=TimeSlot.Evening,Subject="Programming in JAVA"},
                new Batch{BatchId=5,TimeSlot=TimeSlot.Morning,Subject="Programming in NT"},
                new Batch{BatchId=6,TimeSlot=TimeSlot.Evening,Subject="Programming in DDD"}
            };
            Teacher[] teachers = new Teacher[]
            {
                new PermanentTeacher{Id=1,Name="Azman Ali Mollah",Phone="01795885845"},
                new TemporaryTeacher{Id=2,Name="Md.Hafijur Rahman",Phone="0172548750"},
                new TemporaryTeacher{Id=3,Name="Ilias Hossain",Phone="01625847995"},
                new TemporaryTeacher{Id=4,Name="Md.Abu Sayed",Phone="01725478545"},
                new PermanentTeacher{Id=5,Name="Azman Ali",Phone="01911311076"}
            };
            BatchAssign<Teacher> batchAssign = new BatchAssign<Teacher>();
            batchAssign.AssignTeacher(teachers[0], batches[0]);//1 Batch
            try
            {
                batchAssign.AssignTeacher(teachers[0], batches[6]);//fails, already batch assigned
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            batchAssign.AssignTeacher(teachers[0], batches[1]);//2 batch
            try
            {
                batchAssign.AssignTeacher(teachers[0], batches[6]);//fails, already 2 batch assigned
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            batchAssign.AssignTeacher(teachers[2], batches[2]);//1 batch
            try
            {
                batchAssign.AssignTeacher(teachers[2], batches[3]);//fails, temporary 1 batch
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            Console.WriteLine($"{ teachers[0].Name}");
            Console.WriteLine("================Batches====================");
            foreach (var b in teachers[0].GetBatches())
            {
                Console.WriteLine($"{b.BatchId}\t{b.TimeSlot}\t\t{b.Subject}");
            }
            Console.WriteLine();
            Console.WriteLine($"{teachers[2].Name}");
            Console.WriteLine("================Batches====================");
            foreach (var b in teachers[2].GetBatches())
            {
                Console.WriteLine($"{b.BatchId}\t{b.TimeSlot}\t\t{b.Subject}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
