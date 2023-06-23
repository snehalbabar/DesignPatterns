
using SingletonPattern;

Singleton employee = Singleton.getInstance;
employee.printDetails("Hello from employee");

Singleton student = Singleton.getInstance;
student.printDetails("Hello from student");
Console.Read();

