namespace CustomExceptionDemo
{
    public class Student
    {
        private string studentName;

        public int StudentId { get; set; }
        public string? StudentName
        {
            get => studentName;
            set
            {
                if (value.Length < 2)
                    throw new InvalidStudentInfoException("Name is too short", value);
                else
                    studentName = value;
            }
        }
    }

    class InvalidStudentInfoException : Exception
    {
        public string Value { get; }

        public InvalidStudentInfoException() { }

        public InvalidStudentInfoException(string message)
            : base(message)
        {
        }

        public InvalidStudentInfoException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public InvalidStudentInfoException(string message, string value)
        : base(message)
        {
            Value = value;
        }

        public override string HelpLink
        {
            get
            {
                return "Find more information here: https://some-documentation-address/";
            }
        }
}
}
