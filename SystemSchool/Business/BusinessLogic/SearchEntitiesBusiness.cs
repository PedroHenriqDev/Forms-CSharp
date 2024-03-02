﻿using Datas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class SearchEntitiesBusiness
    {
        ConnectionDb ConnectionDb { get; set; } = new ConnectionDb();

        public async Task<IEnumerable<Course>> FindAllCoursesAsync() 
        {
            return await ConnectionDb.ReturnAllCoursesAsync();
        }

        public async Task<IEnumerable<Classroom>> FindClassroomsByCourseNameAsync(string CourseName) 
        {
            return await ConnectionDb.ReturnClassroomsByCourseNameAsync(CourseName);
        }

        public async Task<IEnumerable<Classroom>> FindAllClassroomsAsync() 
        {
            return await ConnectionDb.ReturnAllClassromsAsync();
        }

        public async Task<IEnumerable<Student>> FindAllStudentsAsync() 
        {
            return await ConnectionDb.ReturnAllStudentsAsync();
        }

        public async Task<IEnumerable<Student>> FindStudentsByClassroomNameAsync(string ClassroomName) 
        {
            Classroom classroom = await ConnectionDb.FindClassroomByNameAsync(ClassroomName);
            return await ConnectionDb.ReturnStudentsByClassroomIdAsync(classroom.ClassroomId);
        }
    }
}
