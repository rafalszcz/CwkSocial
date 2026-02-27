using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.Domain.Aggregates.PostAgregate
{
    public class PostInteraction
    {
        private PostInteraction()
        {
            
        }
        public Guid InteracionId { get;private  set; }
        public Guid PostId { get; private set; }
        public Guid UserProfileId { get; private set; }
        public InteractionType InteractionType { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime LastModified { get; private set; }
        //Factory method to create a new interaction
        public static PostInteraction CreatePostInteraction(Guid postId, Guid userProfileId, InteractionType interactionType)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            return new PostInteraction()
            {
                InteracionId = Guid.NewGuid(),
                PostId = postId,
                UserProfileId = userProfileId,
                InteractionType = interactionType,
                CreatedDate = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }

    }
}
