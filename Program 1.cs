using System.IO;
using System;

class Student {
   public int id, age, rollno;  
   public String name, subject;

   public Student(int id, String name, int age, String subject) {
      rollno = 20;
      this.id = id; // If we comment out this keyword initialization we cannot use these variables(id,name,subject,age) in other
      this.name = name;// Methods such as showInfo but we an use them in this method.
      this.subject = subject;
      this.age = age;
       //Console.WriteLine(id + " " + name+" "+age+ " "+subject); //This will print everytime when an object is defined for calling Student
   }

   public void showInfo() {
      Console.WriteLine(id + " " + name+" "+age+ " "+subject);// this will print the id defined in object std1(ie. Id = 1)
      id = 256987;// If we define this before the above print then that statement will print this Id  
      Console.WriteLine(id); // Id = 256987
   }
}

class StudentDetails {
   public static void Main(string[] args) {
      Student std1 = new Student(001, "Jack", 23, "Maths");
      //Student std2 = new Student(002, "Harry", 27, "Science");
      //Student std3 = new Student(003, "Steve", 23, "Programming");
      //Student std4 = new Student(004, "David", 27, "English");
      // Console.WriteLine(id + " " + name+" "+age+ " "+subject);
      Console.WriteLine(std1.rollno); // This will print Rollno as 20 as defined in the constructor
      std1.showInfo();
      /*std2.showInfo();
      std3.showInfo();
      std4.showInfo();*/
   }
} 
