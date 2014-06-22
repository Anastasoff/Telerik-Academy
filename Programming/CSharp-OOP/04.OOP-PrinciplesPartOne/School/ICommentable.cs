namespace School
{
    public interface ICommentable
    {
        string Comment { get; }

        void AddComment(string comment);
    }
}
