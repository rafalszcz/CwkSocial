using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.Domain.Aggregates.PostAgregate
{
    public class PostInteraction
    {
        public Guid InteracionId { get; set; }
        public Guid PostId { get; set; }
        public Guid UserProfileId { get; set; }
        public InteractionType InteractionType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModified { get; set; }

    }
}
