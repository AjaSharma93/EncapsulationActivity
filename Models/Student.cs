public class Student
{
    private string _name;
    private StudentGrade _grade;
    private StudentGroup _group;
    private const string SECRET_NICKNAME = "MySecretNickName";

    public Student(string name, char grade, int group)
    {
        this._name = name;
        this._grade = new StudentGrade(grade);
        this._group = new StudentGroup(group);
    }

    public string getName(){
        return this._name;
    }

    public char GetGrade()
    {
        return _grade.GetGrade();
    }

    public int GetGroup()
    {
        return _group.GetGroup();
    }

    public bool UpgradeGrade()
    {
        return _grade.UpgradeGrade();
    }

    public bool DowngradeGrade()
    {
        return _grade.DowngradeGrade();
    }

}