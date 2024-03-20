# School Manager
<hr/>

## Description: 
#### Manager School is a fully functional school maintenance system developed in C#.
<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/load.png)

## Key Features:

## Login:
Login can be done normally, but creating a user depends on the admin, it is a management application so only secretaries, teachers and administrators have access.


![Image](https://github.com/PedroHenriqDev/Images/blob/main/login.png)
    
<hr/>

## Home Form: 
The main form provides access to the system's features, with varying levels of access for different user groups, including administrators, secretaries, and teachers.

![Image](https://github.com/PedroHenriqDev/Images/blob/main/homeAdmin.png)

<hr/>
- It is observable that the administrator has access to all items.
<hr/>


![Image](https://github.com/PedroHenriqDev/Images/blob/main/homeSecretary.png)

<hr/>
- The secretary group has only one restriction: they cannot access the user item.
<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/homeTeacher.png)

<hr/>
- The teacher group has limited access and cannot view users, classrooms, courses, or students.
<hr/>

## Student: 
You can create, delete, and edit students.

![Image](https://github.com/PedroHenriqDev/Images/blob/main/registerStudent1.png)

<hr/>
- Classrooms appear based on course choice.
<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/registerStudent2.png)

<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/registerStudent33.png)

<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/editStudent1.png)
<hr/>
- The search takes place in real time, the user just needs to type something in the search field, and when clicking on the item within the list box, the components will be filled in.
<hr/>

<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/editStudent2.png)

<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/editStudent3.png)
<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/deleteStudent2.png)
<hr/>
- Items in the list will only appear when the user selects a classroom.
<hr/>

## The same object manipulation system extends to other objects!

## Charts: 
It is possible to see graphs related to the number of objects in the database.

![Image](https://github.com/PedroHenriqDev/Images/blob/main/chartBarts.png)
<hr/>
- The bar graph is the default and is displayed immediately upon form loading.
<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/chartLines.png)
<hr/>
- The line graph provides more accurate data regarding the months of the year.
<hr/>

![Image](https://github.com/PedroHenriqDev/Images/blob/main/chartPie.png)
<hr/>
- Pie charts offer a more intuitive representation compared to other types of graphs.
<hr/>


## The system also includes basic functionalities such as logout and password change.
<hr/>

## Technologies Used:
- **Dapper:** Utilized for efficient data access and manipulation in the backend.
- **C#:** Employed as the primary programming language for developing the application.
- **AutoFac:** Utilized for dependency injection and managing application dependencies.
- **Encryption:** Employed for securing sensitive data within the application.
- **SQL Server:** Utilized as the relational database management system for storing and managing data.

<hr/>

## Database creation:
Execute the following SQL Server query to create the database schema. If you intend to utilize the system, ensure its execution.

```sql
CREATE DATABASE schoolDb
USE schoolDb

CREATE TABLE Users
(
    Id INT PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(50) NOT NULL,
    GroupId INT NOT NULL,
    DateCreation DATETIME NOT NULL
); 

CREATE TABLE Groups
(
    Id INT PRIMARY KEY,
    GroupName NVARCHAR(50),
    AccessLevel INT,
    DateCreation DATETIME NOT NULL
);

INSERT INTO Groups VALUES('33333', 'Administrator', '3', GETDATE());
INSERT INTO Groups VALUES('22222', 'Secretary', '2', GETDATE());
INSERT INTO Groups VALUES('11111', 'Teacher', '1', GETDATE());

CREATE TABLE Students
(
    Id INT PRIMARY KEY,
    ClassroomId INT,
    CompleteName NVARCHAR (80) NOT NULL,
    DateCreation DATETIME NOT NULL
)

CREATE TABLE Courses
(
    Id INT PRIMARY KEY NOT NULL,
    CourseName NVARCHAR(30) NOT NULL,
    DateCreation DATETIME NOT NULL
);

CREATE TABLE Classrooms
(
    Id INT PRIMARY KEY,
    ClassroomName NVARCHAR(50),
    CourseId INT NOT NULL,
    DateCreation DATETIME NOT NULL
);

```
## Connection string: 
After creating the user, proceed to connect to the database and the source code. Navigate to the "App.config" file and modify the server configuration according to your local machine.

```Config
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.7.2" />
    </startup>
  <connectionStrings>
    <add name="sql" connectionString="server=EXAMPLE;integrated security=true;database=schoolDb" />
  </connectionStrings>
  <runtime>
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
      <dependentAssembly>
        <assemblyIdentity name="System.Runtime.CompilerServices.Unsafe" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-6.0.0.0" newVersion="6.0.0.0" />
      </dependentAssembly>
      <dependentAssembly>
        <assemblyIdentity name="System.Diagnostics.DiagnosticSource" publicKeyToken="cc7b13ffcd2ddd51" culture="neutral" />
        <bindingRedirect oldVersion="0.0.0.0-7.0.0.2" newVersion="7.0.0.2" />
      </dependentAssembly>
    </assemblyBinding>
  </runtime>
</configuration>
```
  















