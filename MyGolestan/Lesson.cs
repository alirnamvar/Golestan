using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGolestan
{
    [Serializable]
    public class Lesson
    {
        public enum TypeOflesson { پایه, اصلی, تخصصی, عمومی };
        public string Name { get; set; }
        public int Vahed { get; set; }
        public TypeOflesson Type { set; get; }

        public List<Lesson> Pishniaz = new List<Lesson>();
        public List<Lesson> Hamniaz = new List<Lesson>();

        public Lesson(string name, int vahed, TypeOflesson type)
        {
            Name = name;
            Vahed = vahed;
            Type = type;
        }

        public Lesson(string name)
        {
            Name = name;
        }

    }


    [Serializable]
    class LessonInTerm : Lesson
    {
        public string LocationOfClass { get; set; }
        public string TimeOfWeek { get; set; }
        public string TimeOfExam { get; set; }
        public int Zarfiat { get; set; }
        public string TeachingOstad { get; set; }


        public LessonInTerm(string name, int vahed, TypeOflesson type, string locationofclass, string timeofWeek, string timeofExam, int zarfiat, string teachingOstad) : base(name, vahed, type)
        {
            Name = name;
            Vahed = vahed;
            Type = type;
            LocationOfClass = locationofclass;
            TimeOfExam = timeofExam;
            TimeOfWeek = timeofWeek;
            Zarfiat = zarfiat;
            TeachingOstad = teachingOstad;
        }

    }
}
