using System.Collections.Generic;
using System.Linq;
using SystemSchool.Expections;
using Entities;

namespace SystemSchool.Helpers
{
    public class DataAccess
    {
        public IEnumerable<User> RemoveCurrentUserFromSet(IEnumerable<User> users)
        {
            if (users != null)
            {
                return users.Where(u => u.Id != Login.CurrentUser.Id).ToList();
            }
            return users;
        }


        public void MainFormAccess(MainForm mainForm, User user)
        {
            if (mainForm == null)
            {
                throw new MainFormException("An brutal error while the main form was trying to run");
            }

            if (user.Group.AccessLevel == 3)
            {
            }
            else if (user.Group.AccessLevel == 2)
            {
                mainForm.pictureUser.Enabled = false;
                mainForm.LabelUser.Enabled = false;
            }
            else if (user.Group.AccessLevel == 1)
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