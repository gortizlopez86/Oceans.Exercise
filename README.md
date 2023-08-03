# recruitment-exercise-net-core

1. Make all the changes required for the solution to compile.

2. Make all required changes for Ocean's.WebApplication to run smoothly.

3. Perform the tasks indicated in Oceans.Exercise.User: develop the ExpiredSubscriptions property and the UpdateUserName, UserInformation, UpdateUserInformation methods; following the directions given.

     To complete this take into account:
        RecruitingTest class has five tests that ensure the correct functioning of User.ExpiredSubscriptions property. Three of them are implemented already.

        3.1. Implement the ExpiredSubscriptions property in User class. An user has a list of subscriptions, which in turn might contain expired subscriptions.
        This property must return the number of expired subscriptions that the user has. Be aware that you can do any coding you need in both the Subscription
        and the User classes to solve the exercise.

        3.2. Implement the two remaining unit tests. For this, copy and paste the code located in any of the already existing tests. Keep in mind that you *will
        have to modify at most* two lines of code in order to make the two unit tests fulfill their purpose. The method name suggests what needs to be corrected and
        serves the purpose of instructing what the unit test is meant for.
        The already existing tests must not be modified. Assume that they are correct and will pass, provided the code you implement in User.ExpiredSubscriptions
        property is working as expected.

        3.3. Assume that the expiration date of a subscription works similar to how credit/debit cards work (they expire the last day of the month).
        Example: a subscription has an expiration date of Jan 31, 2019. If the current date is Feb 14, 2019, this subscription is considered as expired.

4. Develop the missing methods in Oceans.Test.RecruitingTest to complete the unit testing of the UpdateUserName, UserInformation, UpdateUserInformation methods. The logic of each method must be consistent with its name, follow the instructions given.

5. You are allowed to ask any questions regarding the structure of the code.

6. Feel free to do any research that can be of aid to solve the exercise.

7. The scope of the exercise can be reduced or guided by the instructor during the exercise.

Optional if you can complete the test:
Develop the required logic in Oceans.WebApplication.Exercise.razor.cs to load data according to your implementation of Oceans.Exercise.User-ExpiredSubscriptions, follow the given instructions.
