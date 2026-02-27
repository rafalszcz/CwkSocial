using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.Domain.Aggregates.PostAgregate
{
    public class PostComment
    {
        private PostComment()
        {
            
        }
        public Guid CommentId { get; private set; }
        public Guid PostId { get; private set; }
        public string Text { get; private set; }
        public Guid UserProfileId { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }
        //Factory method to create a new comment
        public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            return new PostComment()
            {
                CommentId = Guid.NewGuid(),
                PostId = postId,
                Text = text,
                UserProfileId = userProfileId,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }
        //public methods
        public void UpdateCommentText(string newText)
        {
            Text = newText;
            LastModified = DateTime.UtcNow;
        }
    }
}
