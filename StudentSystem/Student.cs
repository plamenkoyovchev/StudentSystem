using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Student
    {
        private ICollection<Course> courses;

        private ICollection<Homework> homeworks;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Number { get; set; }

        //public Course Course { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public ICollection<Homework> Homeworks
        {
            get { return homeworks; }
            set { homeworks = value; }
        }
        
    }
}
