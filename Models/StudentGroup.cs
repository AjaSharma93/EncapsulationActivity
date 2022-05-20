public class StudentGroup
{
    private int _group;
    public static readonly int[] StudentGroups = { 1,2,3,4,5 };
    public StudentGroup(int group)
    {
        if (Array.IndexOf(StudentGroups, this._group) != -1) this._group = group;
    }

    public int GetGroup()
    {   
        return this._group;
    }
}