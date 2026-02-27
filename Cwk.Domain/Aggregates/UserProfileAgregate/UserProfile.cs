using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.Domain.Aggregates.UserProfileAgregate
{
    public class UserProfile
    {
        private UserProfile()
        {
            
        }
        public Guid UserProfileId { get;private set; }
        public string  IdentityId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private set; }
        //Factory method to create a new user profile
        public static UserProfile CreateUserProfile(string identityId,BasicInfo basicInfo)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            return new UserProfile()
            {
                IdentityId= identityId,
                BasicInfo= basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified= DateTime.UtcNow
            };
        }

        //public methods
        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            //TO DO:add validation, errror handling strategies, error notification streategies
            BasicInfo = newInfo;
            LastModified = DateTime.UtcNow;
        }
    }
}
