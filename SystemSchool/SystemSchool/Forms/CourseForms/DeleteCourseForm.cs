using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemSchool.Forms.CourseForms
{
    public partial class DeleteCourseForm : Form
    {
        public DeleteCourseForm()
        {
            InitializeComponent();
        }

        private void DeleteCourseForm_Load(object sender, EventArgs e)
        {
            LoadListBoxCourses();
        }
    }
}
