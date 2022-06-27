using System;
using System.Collections.Generic;

namespace Examen
{
    public class FakeGradeModel : IGradeModel
    {
        private Dictionary<int, Lessons[]> _grades;
        public FakeGradeModel()
        {
            _grades = new Dictionary<int, Lessons[]>()
            {
                { 1,
                    new Lessons[] 
                    {
                        new Lessons() { Subject = "Python", Grade ="9"},
                        new Lessons() { Subject = "C++", Grade ="10"},
                        new Lessons() { Subject = "C#", Grade ="8"},
                        new Lessons() { Subject = "SQL", Grade ="12"},
                    }
                },
                { 2,
                    new Lessons[]
                    {
                        new Lessons() { Subject = "Python", Grade ="10"},
                        new Lessons() { Subject = "C++", Grade ="12"},
                        new Lessons() { Subject = "C#", Grade ="_"},
                        new Lessons() { Subject = "SQL", Grade ="11"},
                    }
                }
            };
        }
        public Lessons[] GetLessons(int stidentId)
        {
            if (_grades.TryGetValue(stidentId, out var lessons))
                return lessons;
        return Array.Empty<Lessons>();
        }
        
    }
}
