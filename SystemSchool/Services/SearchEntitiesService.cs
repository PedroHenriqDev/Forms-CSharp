﻿using Datas;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SearchEntitiesService
    {
        private readonly ConnectionDb _connectionDb;

       public SearchEntitiesService(ConnectionDb connectionDb) 
       {
            _connectionDb = connectionDb;
       }

        public async Task<IEnumerable<Course>> FindAllCoursesAsync() 
        {
            return await _connectionDb.ReturnAllCoursesAsync();
        }

        public async Task<Classroom> FindClassroomByNameAsync(string classroomName) 
        {
            return await _connectionDb.ReturnClassroomByNameAsync(classroomName);
        }

        public async Task<Classroom> FindClassroomByIdAsync(int classroomId) 
        {
            return await _connectionDb.ReturnEntityByIdAsync<Classroom>(classroomId);
        }

        public async Task<IEnumerable<Student>> FindStudentByQueryAsync(string query) 
        {
            IEnumerable<Student> students =  await _connectionDb.ReturnAllStudentsAsync();

            if (query == null) 
            {
                return students;
            }

            return students.Where(s => s.CompleteName.ToLower().Contains(query.ToLower())).ToList();
        }

        public async Task<Student> FindStudentByIdAsync(int id) 
        {
            return await _connectionDb.ReturnEntityByIdAsync<Student>(id);
        }

        public async Task<IEnumerable<Classroom>> FindClassroomsByCourseNameAsync(string courseName) 
        {
            Course course = await FindCourseByNameAsync(courseName);
            return await _connectionDb.ReturnClassroomsByCourseIdAsync(course.Id);
        }

        public async Task<IEnumerable<Classroom>> FindAllClassroomsAsync() 
        {
            return await _connectionDb.ReturnAllClassromsAsync();
        }

        public async Task<IEnumerable<Student>> FindAllStudentsAsync() 
        {
            return await _connectionDb.ReturnAllStudentsAsync();
        }

        public async Task<Course> FindCourseByNameAsync(string courseName) 
        {
            return await _connectionDb.ReturnCourseByNameAsync(courseName);
        }

        public async Task<Course> FindCourseByIdAsync(int courseId) 
        {
            return await _connectionDb.ReturnEntityByIdAsync<Course>(courseId);
        }

        public async Task<IEnumerable<Student>> FindStudentsByClassroomNameAsync(string ClassroomName) 
        {
            Classroom classroom = await _connectionDb.ReturnClassroomByNameAsync(ClassroomName);
            return await _connectionDb.ReturnStudentsByClassroomIdAsync(classroom.Id);
        }

        public async Task<IEnumerable<char>> FindLettersAvailableBySchoolYearAsync(string schoolYear) 
        {
            IEnumerable<Classroom> classrooms = await _connectionDb.ReturnAllClassromsAsync();
            
            IEnumerable<char> existingLetters = classrooms.Where(c => c.ClassroomName[0] == schoolYear[0]).Select(c => c.ClassroomName[1])
                .Where(letter => char.IsLetter(letter) && letter < 'E');

            return Enumerable.Range('A', 'D' - 'A' + 1)
                .Select(letter => (char)letter)
                .Except(existingLetters);
        }
    }
}
