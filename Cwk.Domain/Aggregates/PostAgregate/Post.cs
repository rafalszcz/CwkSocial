using Cwk.Domain.Aggregates.UserProfileAgregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.Domain.Aggregates.PostAgregate
{
    public class Post
    {
        private readonly List<PostComment> _comments = new List<PostComment>();
        private readonly List<PostInteraction> _interactions = new List<PostInteraction>();
        private Post()
        {
           
        }
        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public string TextContent { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        public IEnumerable<PostComment> Comments { get { return _comments; } }
            }
        public IEnumerable<PostInteraction> Interacions { get { return _interactions; } }

        //factories
        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            return new Post()
            {
                PostId = Guid.NewGuid(),
                UserProfileId = userProfileId,
                TextContent = textContent,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }
        //public methods
        public  void UpdatePostText(string newText)
        {
            TextContent= newText;
            LastModified = DateTime.UtcNow;
        }
        public void AddComment(PostComment newComment)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            _comments.Add(newComment);
            LastModified = DateTime.UtcNow;
        }
        public void RemoveComment(PostComment newComment)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            _comments.Remove(newComment);
            LastModified = DateTime.UtcNow;
        }
        public void AddIteraction(PostInteraction newIteraction)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            _interactions.Add(newIteraction);
            LastModified = DateTime.UtcNow;
        }
        public void RemoveIteraction(PostInteraction newIteraction)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            _interactions.Add(newIteraction);
            LastModified = DateTime.UtcNow;
        }
    }
}
