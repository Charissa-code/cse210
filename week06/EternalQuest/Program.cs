// Eternal Quest Program 
//Author: Charissa Maes
//
// Requirements Exceeded:
//1.  Multiple ways to display the goals: based on if I am listing, loading or saving the goals. GetShortDetails() for simple listing, GetDetailsString() for full details, and GetStringRepresentation() for saving. Each serves a different purpose as I tried showing polymorphism.
//2. Gamification: My point system keeps track of the total points. When the total becomes 1000 the user levels up one level. 2000 and they level up another level. The levels and total score are shown to the user throughout the program. 
//3.  I've added styling to make the program easier to follow and to let the eye go to where it needs to at that point in the program.
//4. I added line of code to prevent the system from crashing if there happens to be no file when running for the first time or if the save command didn't save anything or if there was an empty text file associated with the program.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}