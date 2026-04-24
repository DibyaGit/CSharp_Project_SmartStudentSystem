using System;

namespace SmartStudentSystem
{
    public class StudentManager
    {
        private Student[] studentList = new Student[10];
        private int count = 0;

        // The Indexer: allows using sm[0]
        public Student this[int index]
        {
            get { return studentList[index]; }
            set { studentList[index] = value; }
        }

        public void AddStudent(Student s)
        {
            if (count < 10)
            {
                studentList[count++] = s;
            }
        }

        public int GetCount() => count;

        // Linear Search - checks one by one
        public int LinearSearch(int searchId)
        {
            for (int i = 0; i < count; i++)
            {
                if (studentList[i].Id == searchId) return i;
            }
            return -1;
        }

        // Bubble Sort - compares neighbors and swaps
        public void BubbleSortByMarks()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (studentList[j].Marks > studentList[j + 1].Marks)
                    {
                        var temp = studentList[j];
                        studentList[j] = studentList[j + 1];
                        studentList[j + 1] = temp;
                    }
                }
            }
        }
    }
}