using Oceans.Exercise;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oceans.WebApplication.Data
{
    public class ExeriseService
    {
        public Task<int> GetExpectedNumberOfExpiredSubscriptions()
        {
            // Add here your expected number of expired subscriptions
            return Task.FromResult(0);
        }

        public Task<int> GetNumberExpiredSubscriptionsAsync()
        {
            // Configure a set of subscriptions
            // Example: 3 subscriptions expired last year previous month
            var subscriptions = new List<Subscription>();

            var user = new User(subscriptions)
            {
                Name = "Mike Mora",
                PaymentType = PaymentType.AmericanExpress
            };

            // Return the number of expired subscriptions
            return Task.FromResult(0);
        }
    }
}
