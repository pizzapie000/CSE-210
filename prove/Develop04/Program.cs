using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        MindfulnessProgram program = new MindfulnessProgram();
        program.AddActivity(new BreathingActivity("Breathing Exercise", 0));  // 0 is for the duration
        program.AddActivity(new ReflectionActivity("Reflection Exercise", 0));
        program.AddActivity(new ListingActivity("Listing Exercise", 0));
        program.Start();
    }
}
