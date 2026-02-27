using System;


namespace Cwk.Domain.Aggregates.UserProfileAgregate
{
    /*
    PSEUDOCODE / PLAN (detailed):

    - Make the BasicInfo class encapsulated:
      - Remove public setters; expose read-only properties (public getter, private setter).
      - Provide a private constructor to prevent direct instantiation.

    - Add a static factory method `CreateBasicInfo` with parameters:
      - `string firstName, string lastName, string emailAddress, string phone, DateTime dateOfBirth, string currentCity`

    - Validation inside factory:
      - Ensure `firstName` and `lastName` are not null/empty/whitespace -> throw `ArgumentException`.
      - If `emailAddress` is provided (non-empty) validate format using `System.Net.Mail.MailAddress` -> throw `ArgumentException` if invalid.
      - Ensure `dateOfBirth` is not in the future -> throw `ArgumentException`.
      - Trim string inputs where appropriate.
      - Optionally allow `phone` and `currentCity` to be null/empty.

    - Return a new BasicInfo instance populated with validated/normalized values.

    - Keep class simple and immutable-ish (properties can only be set within the class).
    */

    public sealed class BasicInfo
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public string Phone { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string CurrentCity { get; private set; }

        // Private constructor prevents external instantiation.
        private BasicInfo() { }

        //TO DO:add validation, errror handling strategies, error notification streategies
        public static BasicInfo CreateBasicInfo(
            string firstName,
            string lastName,
            string emailAddress,
            string phone,
            DateTime dateOfBirth)
        {
         

            // Normalize date to date portion only
         

            return new BasicInfo
            {
                FirstName = firstName.Trim(),
                LastName = lastName.Trim(),
                EmailAddress = string.IsNullOrWhiteSpace(emailAddress) ? null : emailAddress.Trim(),
                Phone = string.IsNullOrWhiteSpace(phone) ? null : phone.Trim(),
                DateOfBirth = dateOfBirth
            };
        }

      
    }
}
