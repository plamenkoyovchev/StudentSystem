using System.Collections;
using System.Collections.Generic;

namespace StudentSystem
{
    public class Course
    {
        private ICollection<Student> students;

        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
        }

        public Course(string name, string description, IList materials)
            : base()
        {
            this.Name = name;
            this.Description = description;
            this.Materials = materials;
            this.homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public IList Materials { get; set; }

        //EF will automatically add ParentId
        public virtual Course Parent { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public ICollection<Homework> Homeworks
        {
            get { return homeworks; }
            set { homeworks = value; }
        }
    }
}