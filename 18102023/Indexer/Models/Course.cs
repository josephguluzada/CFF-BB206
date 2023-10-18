namespace Indexer.Models
{
    internal class Course
    {
        public string Name { get; set; }
        private Student[] _students;
        public Student this[int index] // course[1] => studen2 (Ulker)
        {
            get => _students[index];
            set => _students[index] = value;
        }

        public string this[int index, string fullname]
        {
            get => _students[index].Fullname;
            set => _students[index].Fullname = fullname;
        }

        public int Length { get => _students.Length;}

        public Course() 
        {
            _students = new Student[0];
        }

        public void Add(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[^1] = student;
        }
    }
}
