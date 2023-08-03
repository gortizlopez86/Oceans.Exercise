using System;
using System.Collections.Generic;
using System.Linq;

namespace Oceans.Exercise
{
    public class User
    {
        /// <summary>
        /// The name of the user
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The user's chosen payment type
        /// </summary>
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// The user's subscriptions
        /// </summary>
        internal IEnumerable<Subscription> Subscriptions { get; }

        /// <summary>
        /// Creates a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="subscriptions">The subscriptions the user has.</param>
        public User(IEnumerable<Subscription> subscriptions)
        {
            this.Subscriptions = subscriptions;
        }

        /// <summary>
        /// The number of expired subscriptions the user has
        /// </summary>
        public int ExpiredSubscriptions
        {
            get
            {
                int expirationMonth = DateTime.Now.Month;
                int expirationYear = DateTime.Now.Year;

                //Use LINQ to get the right number
                return Subscriptions.Where(item => 
                (item.ExpirationYear > expirationYear && item.ExpirationMonth >= expirationMonth) || 
                (item.ExpirationYear <= expirationYear && item.ExpirationMonth <= expirationMonth)).Count();
            }
        }

        public int ExpiringSubscriptions
        {
            get
            {
                int expirationMonth = DateTime.Now.Month;
                int expirationYear = DateTime.Now.Year;
                return Subscriptions.Where(item =>
                (item.ExpirationYear > expirationYear && item.ExpirationMonth >= expirationMonth) ||
                (item.ExpirationYear >= expirationYear && item.ExpirationMonth >= expirationMonth)).Count();
            }
        }

        /// <summary>
        /// Rewrite this method using discard for output variable
        /// </summary>
        public void UpdateUserName()
        {
            const string strForExercise = "1";

            if (int.TryParse(strForExercise, out _))
            {
                Name = "Oceans Code Experts";
            }
        }

        /// <summary>
        /// Rewrite this method to return a tuple of Name, PaymentType and the local variable
        /// </summary>
        public Tuple<string, PaymentType, bool> UserInformation()
        {
            bool codeExperts = true;
            return Tuple.Create(Name, PaymentType, codeExperts);
            
        }

        /// <summary>
        /// Update the local variables by deconstructing the tuple from UserInformation
        /// Follow the sugested logic to update the User Name
        /// </summary>
        public void UpdateUserInformation()
        {

            string nameFromTuple = string.Empty;
            PaymentType pt = new PaymentType();
            bool codeExpertsFromTuple = false;

            //deconstruct the tuple
            Tuple<string, PaymentType, bool> getvalue = UserInformation();
            nameFromTuple = getvalue.Item1;
            pt = getvalue.Item2;
            codeExpertsFromTuple = getvalue.Item3;

            if (codeExpertsFromTuple)
            {
                Name = $"Recruiting {nameFromTuple}";
            }
        }
    }
}