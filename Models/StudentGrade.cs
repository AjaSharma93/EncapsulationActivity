public class StudentGrade
{
    private char _grade;
    public static readonly char[] StudentGrades = { 'A', 'B', 'C', 'D', 'E' };
    public StudentGrade(char grade)
    {
        if (Array.IndexOf(StudentGrades, grade) != -1) this._grade = grade;
    }

    public bool UpgradeGrade()
    {   
        int index = Array.IndexOf(StudentGrades, this._grade);
        if ( index > 0)
        {
            this._grade = StudentGrades[index-1];
            return true;
        }
        return false;
    }

    public bool DowngradeGrade()
    {
        int index = Array.IndexOf(StudentGrades, this._grade);
        Console.WriteLine(index);
        if (index < (StudentGrades.Length - 1))
        {
            this._grade = StudentGrades[index+1];
            return true;
        }
        return false;
    }

    public char GetGrade(){
        return this._grade;
    }
}