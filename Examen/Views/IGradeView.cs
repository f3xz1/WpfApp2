using System;

namespace Examen
{
    public class ShowGradeEventArgs : EventArgs
    {
        public int StudentId { get; }
        public ShowGradeEventArgs(int studentId)
        {
            StudentId = studentId;
        }

    }
    public interface IGradeView
    {
        event EventHandler<ShowGradeEventArgs> ShowGradeCalled;
        void ShowGrade(Lessons[] lessons);
    }
}
