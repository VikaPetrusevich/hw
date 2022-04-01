using HW._10.Task1;

Person person = new Person();

person.Say();

Student student = new Student();

student.Say();

int studentyears = 21;

student.SetAge(ref studentyears);

student.ShowAge();

Teacher teacher = new Teacher();

teacher.Say();

int teacheryears = 30;

teacher.SetAge(ref teacheryears);

teacher.Explain();