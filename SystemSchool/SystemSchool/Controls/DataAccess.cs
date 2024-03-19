using System;
using SystemSchool.Expections;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace SystemSchool.Helpers
{
    /// <summary>
    /// Provides helper methods for data access operations.
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Removes the current user from the given collection of users.
        /// </summary>
        /// <param name="users">The collection of users.</param>
        /// <returns>The filtered collection of users without the current user.</returns>
        public IEnumerable<User> RemoveCurrentUserFromSet(IEnumerable<User> users)
        {
            if (users != null)
            {
                return users.Where(u => u.Id != Login.CurrentUser.Id).ToList();
            }
            return users;
        }


        /// <summary>
        /// Grants access to the main form based on the user's group access level.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        /// <param name="user">The user.</param>
        /// <exception cref="MainFormException">Thrown when there is an error while accessing the main form.</exception>
        public void MainFormAccess(MainForm mainForm, User user)
        {
            if (mainForm == null)
            {
                throw new MainFormException("A critical error occurred while trying to access the main form.");
            }

            switch (user.Group.AccessLevel)
            {
                case 1:
                    DisableControlsForAdmin(mainForm);
                    break;
                case 2:
                    DisableControlsForManager(mainForm);
                    break;
                case 3:
                    break;
                default:
                    throw new MainFormException("An error occurred during user authorization.");
            }
        }

        /// <summary>
        /// Disables controls on the main form for an admin user.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        private void DisableControlsForAdmin(MainForm mainForm)
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

        /// <summary>
        /// Disables controls on the main form for a manager user.
        /// </summary>
        /// <param name="mainForm">The main form.</param>
        private void DisableControlsForManager(MainForm mainForm)
        {
            mainForm.pictureUser.Enabled = false;
            mainForm.LabelUser.Enabled = false;
        }
    }
}
