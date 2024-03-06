using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemSchool.Expections;
using System.Threading.Tasks;
using Entities;
using System.Windows.Forms;

namespace SystemSchool.Helpers
{
    public class DataAccess
    {
        public void MainFormAccess(MainForm mainForm, User user)
        {
            if (mainForm == null)
            {
                throw new MainFormException("An brutal error while the main form was trying to run");
            }

            if (user.Class.AccessLevel == 3)
            {
            }
            else if (user.Class.AccessLevel == 2)
            {
                mainForm.pictureUser.Enabled = false;
                mainForm.LabelUser.Enabled = false;
            }
            else if (user.Class.AccessLevel == 1)
            {
                mainForm.pictureUser.Enabled = false;
                mainForm.LabelUser.Enabled = false;
                mainForm.pictureStudent.Enabled = false;
                mainForm.LabelStudent.Enabled = false;
                mainForm.pictureClassroom.Enabled = false;
                mainForm.LabelClassroom.Enabled = false;
                mainForm.pictureCourse.Enabled = false;
                mainForm.LabelCourse.Enabled = false;
            }
            else
            {
                throw new MainFormException("An brutal error ocurred in user authorization");
            }
        }
    }
}