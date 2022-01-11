// See https://aka.ms/new-console-template for more information

// Define a new custom class named Course
internal class Course
{
    #region Readonly Data Fields
    //Define readonly date fields
    public readonly string CourseNo;
    public readonly string CourseName;
    public readonly List<string> Students = new List<string>();
    #endregion

    #region Readonly Property
    public int StudentCount 
    { 
        get { return Students.Count; }
    }
    #endregion

    #region Constructors
    public Course(string courseNo, string courseName)
    {
        //Validate that courseNo is not null, or an empty string, and must contains exactly 8 characters
        //where the first 4 characters are letters and the last 4 characters are digits
        if (string.IsNullOrEmpty(courseNo))
        {
            throw new ArgumentNullException("CourseNo is required.");
        }
        if(courseNo.Length != 8)
        {
            throw new ArgumentException("CourseNo must contains exactly 8 characters.");
        }
        //Challenge to vaildate the first four characters are letters and the last 4 are digits
        else
        {
            CourseNo = courseNo;
        }

        //Validate that courseName are not null or an empty string
        if (string.IsNullOrEmpty(courseName))
        {
            throw new ArgumentNullException("CourseName is required.");
        }
        else
        {
            CourseName = courseName;

        }
    }
    #endregion

    public string CourseInfo()
    {
        return $"{CourseNo}:{CourseName}";
    }


    #region Instance-Level Methods
    public void AddStudent(string name)
    {
        Students.Add(name);
    }

    public void DropStudent(string name)
    {
        Students.Remove(name);
    }
    #endregion
    /*
    public int StudentCount(int studentCount)
    {
        
        return studentCount;
    }*/
}



