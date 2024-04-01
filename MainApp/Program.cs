using Domain.Models;
using Infrastructure.Services.ClassroomService;
using Infrastructure.Services.ClassService;
using Infrastructure.Services.ClassStudentService;
using Infrastructure.Services.ParentService;
using Infrastructure.Services.SchoolService;
using Infrastructure.Services.StudentParentService;
using Infrastructure.Services.StudentService;
using Infrastructure.Services.SubjectSevice;
using Infrastructure.Services.TeacherService;

var classroomservice=new ClassroomService();
var classService=new Classservice();
var classStudentService=new ClassStudentService();
var parentService=new ParentService();
var schoolService=new SchoolService();  
var studentService=new StudentService();
var subjectService = new SubjectService();
var teacherService=new TeacherService();
var studentparentservice=new StudentParentService();


var teachers = new Teachers()
{
    TeacherCode = "t3",
    FullName = "Muqadas sabirova ",
    Gender = "Female",
    Dob = new DateTime(1985 - 10 - 15),
    Email = "mq@gmail.com",
    Phone = "1054123",
    IsActive = "yes",
    JoinDate = new DateTime(2023 - 10 - 12)
};
//teacherService.AdTeachers(teachers);
var parents = new Parent()
{
    ParentCode = "3",
    ParentFullName = "Gulov Shom",
    Email = "guli@gmail.com",
    Phone = "1503654",
    CreatedAt = new DateTime(2023 - 10 - 12)
}; 
//parentService.AdParent(parents);
var school = new School()
{
    SchoolTitle = "maxsus",
    LevelCount = 4,
    IsActive = "yes",
    CreatedAt = new DateTime(2020 - 10 - 12)
};
//schoolService.AdSchool(school); 
var subject = new Subject()
{
    Title = "IT",
    SchoolId = 3,
    CreatedAt = new DateTime(2021 - 05 - 06)
};
//subjectService.AdSubject(subject); 
var student = new Student()
{
    StudentCode = "s2",
    Studentfullname = "Alex",
    Gender = "Male",
    Dob = new DateTime(1999 - 10 - 19),
    Email = "alex@gmail.com",
    Phone = "1143456",
    SchoolId = 2,
    IsActive = "yes",
    JoinDate = new DateTime(2024 - 10 - 12)
};
//studentService.AdStudent(student); 
var stp = new StudentParent()
{
    StudentId = 2,
    ParentId = 4,
    Relationship = "n/a"
};
//studentparentservice.AdStudentParent(stp);  
var clasrooms = new Classroom()
{
    Capacity = 18,
    RoomType = "obshiy",
    Description = "na",
    CreatedAt = new DateTime(2024 - 10 - 15)
};
//classroomservice.AddClasroom(clasrooms);
var cls = new Class()
{
    ClassName=".Net",
    SubjectId=2,
    TeacherId=4,
    ClassroomId=2,
    Section="A",
    CreatedAt=new DateTime(2022-05-05)
};
//classService.AdClass(cls);
var classtudent = new ClassStudent()
{
    ClassId=3,
    StudentId=2,
}; 
classStudentService.AdClassStudent(classtudent);