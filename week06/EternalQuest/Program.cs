using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements:
        // I added a simple level system based on the player's score.
        // The program displays the user's current level along with their score.
        // This adds a small gamification element beyond the core requirements.

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}