## Git Structure

We have decided to use `Feature branching` for our git workflow.

## Git branches

There are a total of 4 branches. The different brances are:

1. main
2. feature/buzzer
3. feature/powerChange
4. feature/timeChange


## Jenkins jobs

There are a total of 4 jobs - one for each branch. The different jobs are:

1. team04E22-microwave-main
2. team04E22-microwave-feature-buzzer
3. team04E22-microwave-feature-powerChange
4. team04E22-microwave-feature-timeChange


## Feature/buzzer

There has been implemented a buzzer class that has the responsibility of making a 3 burst sound whenever Cooking is done.
This is obtained by making an interface and a class that implements this interface which has 1 function "CookingIsEndedSound()".
CookingController.cs and UserInterface.cs have been altered so as it also takes a buzzer object in its constructor parameter.
The function CookingIsEndedSound() is then inserted in CookController.OnTimerExpired(), CookController.Stop() and UserInterface.CookingIsDone().

In the tests the test.integration project was unloaded so to avoid testings conflicts.
The BuzzerTest.cs tests the simple functionality of the buzzer class. It creates a Trace object which can catch console outputs when running the tests. This output is then asserted with the expected string value "Ding, Ding, Ding! Cooking Done\a".

There has also been written a functional test in the CookingControllerTest.cs. Cooking_stopsound_CookingDone() tests if the CookingIsEndedSound() through the uut (CookController.StartCooking() function). 
