﻿using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessLogic
{
    public class ValidationEntitiesBusiness<T>
    {
        public bool IsValidNameCourse(Course course, IEnumerable<Course> courses)
        {
            if(string.IsNullOrWhiteSpace(course.CourseName)) 
            {
                throw new ArgumentNullException("The course name cannot be empty!");
            }

            return !EqualEntityInSet(courses.Select(c => c.CourseName).ToList(), course.CourseName)
                && !HasNumbersInString(course.CourseName)
                && EntityHasId(course.CourseId);
        }

        public bool IsValidStudent(Student student, IEnumerable<Student> students) 
        {
            if (student == null || string.IsNullOrEmpty(student.CompleteName)) 
            {
                throw new ArgumentNullException("The student cannot be empty!");
            }

            return !EqualEntityInSet(students.Select(s => s.StudentId).ToList(), student.StudentId)
                && HasNumbersInString(student.CompleteName)
                && EntityHasId(student.StudentId);
        }

        public bool IsValidClassroomName(Classroom classroom, IEnumerable<Classroom> classrooms)
        {
            return !EqualEntityInSet(classrooms.Select(c => c.ClassroomName).ToList(), classroom.ClassroomName)
                && ClassroomNameIsInCorrectOrder(classroom.ClassroomName)
                && EntityHasId(classroom.ClassroomId);
        }

        public bool EntityHasId(int id) 
        {
            if(id == 0 || id <= 0) 
            {
                return false;
            }
            return true;
        }

        public bool ClassroomNameIsInCorrectOrder(string entity) 
        {
            if(entity == null || entity.Length > 2) 
            {
                throw new ArgumentNullException("The classroom name cannot be null, and must be 2 characters long");
            }

            if (!char.IsNumber(entity[0]) || !char.IsLetter(entity[1]))
            {
                return false;
            }
            return true;
        }

        public bool HasNumbersInString(string entity)
        {
            for (int i = 0; i < entity.Length; i++)
            {
                if (!char.IsLetter(entity[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool EqualEntityInSet<T>(IEnumerable<T> entities, T entity) 
        {
            List<string> entitiesToLower = new List<string>();

            foreach(var ent in entities) 
            {
                entitiesToLower.Add(ent.ToString().ToLower());
            }

            if(entity == null || entitiesToLower.Any(t => t.Equals(entity.ToString().ToLower())))
            {
                return true;
            }
            return false;
        }
    }
}
