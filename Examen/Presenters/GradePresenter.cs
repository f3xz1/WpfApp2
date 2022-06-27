using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{

    public class GradePresenter  
    {
        private IGradeModel _model;  
        private IGradeView _view;

        public GradePresenter(IGradeModel model, IGradeView view)
        {
            _model = model;
            _view = view;

            _view.ShowGradeCalled += View_ShowGreadCalled;
        }

        private void View_ShowGreadCalled(object? sender, ShowGradeEventArgs e)
        {
            var lessons = _model.GetLessons(e.StudentId);
            _view.ShowGrade(lessons);
        }
    }
}
