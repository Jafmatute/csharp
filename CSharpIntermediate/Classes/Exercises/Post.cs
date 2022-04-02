using System;

public class Post
{
    private int _vote;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Creating { get; set; }

    public void Like(int vote)
    {
        _vote += vote;
    }

    public void RemoveLike(int vote)
    {
        _vote -= vote;
    }

    public int GetVotes()
    {
        return _vote;
    }

}