
public class Student
{
    private string _name;
    private StudentGrades _grade;
    private StudentGroup _group;
    private const string SECRET_NICKNAME = "MySecretNickName";
    private enum StudentGrades
    {
        A, B, C, D, E
    }
    private enum StudentGroup
    {
        One = 1, Two = 2, Three = 3, Four = 4, Five = 5
    }


    public Student(string name, char grade, int group)
    {
        this._name = name;
        this._grade = (StudentGrades)grade;
        this._group = (StudentGroup)group;
    }

    public char GetGrade()
    {
        return (char)this._grade;
    }

    public int GetGroup()
    {
        return (int)this._group;
    }

    public bool UpgradeGrade()
    {
        /* Find the array index of the current grade and if it is B,C,D,E we upgrade it */
        int index = Array.IndexOf(Enum.GetValues(this._grade.GetType()), this._grade);
        if (index > 0)
        {
            this._grade = (StudentGrades)(index - 1);
            return true;
        }
        return false;
    }

    public bool DowngradeGrade()
    {
        /* Find the array index of the current grade and if it is B,C,D,E we downgrade it */
        int index = Array.IndexOf(Enum.GetValues(this._grade.GetType()), this._grade);
        if (index < 4)
        {
            this._grade = (StudentGrades)(index + 1);
            return true;
        }
        return false;
    }

}