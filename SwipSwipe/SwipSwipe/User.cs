using System;
using System.Collections.Generic;
using System.Text;

namespace SwipSwipe
{
    public class User
    {
        public string UserID { get; }

        public string ProfileID { get; }

        public Uri ProfilePicture { get; set; }

        public string UserTag { get; set; }

        public string UserName { get; set; }

        public Post[] Posts { get; set; }

        public int Score { get; set; }

        public int Followers { get; set; }

        public int Following { get; set; }
    }

    public class Post
    {
        public User Poster { get; }

        public string PostID { get; }

        public Uri PostLink { get; }

        public string Caption { get; set; }

        public int ViewCount { get; set; }

        public User[] LikeCount { get; set; }

        public Comment[] Comments { get; set; }
    }

    public class Comment
    {
        public User Poster { get; }

        public string Content { get; set; }

        public User[] LikeCount { get; set; }
    }
}
