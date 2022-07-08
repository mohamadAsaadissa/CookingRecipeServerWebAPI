using System;
using System.Collections.Generic;

namespace CookingRecipesWebAPI.Models
{
    public class User
    {
       
            public string UserId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Pass { get; set; }
            public string Tel { get; set; }
          
            public DateTime PubDate { get; set; }
            public bool Access { get; set; }
            public string Password { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public User()
        {
            Comments = new List<Comment>();
        }
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; } 
        public User User { get; set; }
        public List<Receipt> Receipts { get; set; } = new List<Receipt>();
    }
 }
