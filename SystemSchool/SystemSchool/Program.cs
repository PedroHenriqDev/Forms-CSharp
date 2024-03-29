﻿using Autofac;
using System;
using System.Windows.Forms;
using Services;
using SystemSchool.Forms.ClassroomForms;
using SystemSchool.Forms.CourseForms;
using SystemSchool.Forms.StudentForms;
using Datas;
using SystemSchool.Controls;
using SystemSchool.Forms.UserForms;
using SystemSchool.Helpers;
using SystemSchool.Forms;
using SystemSchool.Forms.StatisticsForms;
using SystemSchool.Forms.PasswordForms;

namespace SystemSchool
{
    internal static class Program
    {
        /// <summary>
        /// Gets the Autofac container instance.
        /// </summary>
        public static IContainer Container { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Enable visual styles and set compatible text rendering defaults
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure Autofac container
            var builder = new ContainerBuilder();

            // Register forms
            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<Login>().AsSelf();
            builder.RegisterType<RegistrationStudentForm>().AsSelf();
            builder.RegisterType<RegistrationClassroomForm>().AsSelf();
            builder.RegisterType<RegistrationCourseForm>().AsSelf();
            builder.RegisterType<RegistrationUserForm>().AsSelf();
            builder.RegisterType<EditStudentForm>().AsSelf();
            builder.RegisterType<EditClassroomForm>().AsSelf();
            builder.RegisterType<EditUserForm>().AsSelf();
            builder.RegisterType<DeleteCourseForm>().AsSelf();
            builder.RegisterType<DeleteStudentForm>().AsSelf();
            builder.RegisterType<DeleteClassroomForm>().AsSelf();
            builder.RegisterType<DeleteUserForm>().AsSelf();
            builder.RegisterType<StatisticsForm>().AsSelf();
            builder.RegisterType<ConfirmPasswordForm>().AsSelf();
            builder.RegisterType<ChangePasswordForm>().AsSelf();

            // Register generic services
            builder.RegisterGeneric(typeof(CreateEntitiesService<>)).AsSelf();
            builder.RegisterGeneric(typeof(DeleteEntitiesService<>)).AsSelf();
            builder.RegisterGeneric(typeof(EditEntitiesService<>)).AsSelf();

            builder.RegisterType<ValidationEntitiesService>().AsSelf();
            builder.RegisterType<EncryptEntitiesService>().AsSelf();
            builder.RegisterType<LoginService>().AsSelf();
            builder.RegisterType<AmountEntitiesService>().AsSelf();
            builder.RegisterType<FillEntitiesService>().AsSelf();
            builder.RegisterType<SearchEntitiesService>().AsSelf();
            builder.RegisterType<ConnectionDb>().AsSelf();

            builder.RegisterType<DataAccess>().AsSelf();
            builder.RegisterType<CreateTransientEntities>().AsSelf();
            builder.RegisterType<LoadFormComponents>().AsSelf();

            // Build Autofac container
            Container = builder.Build();

            // Run the application by opening the load form
            Application.Run(new LoadForm());
        }
    }
}
