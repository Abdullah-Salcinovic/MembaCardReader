using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Registration
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public DateTime DateOfBirth {  get; set; }

        public PhoneAttribute PhoneNumber { get; set; }

        public EmailAddressAttribute EmailAddress { get; set; }

        public int SubscriptionType {  get; set; }


        public DateTime Expiration {  get; set; }


        public Registration(string Id, string Name, String Sex, DateTime DoB, PhoneAttribute PNumber, EmailAddressAttribute Email, int Subscription, DateTime Expiration)
        {
            this.Id = Id;
            this.Name = Name;
            this.Sex = Sex;
            this.DateOfBirth = DoB;
            this.PhoneNumber = PNumber;
            this.EmailAddress = Email;
            this.SubscriptionType = Subscription;
            this.Expiration = Expiration;

        }

    }
}
