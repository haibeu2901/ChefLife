using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefLife.Core
{
    internal class GameState
    {
        // Properties
        public bool IsRunning {  get; set; }
        public TimeSpan GameTime { get; set; }
        public int DaysPassed { get; set; }

        // Constructor
        public GameState()
        {
            IsRunning = true;
            GameTime = new TimeSpan(8, 0, 0); // Start at 8:00 AM
            DaysPassed = 0;
        }

        // Method to start a new day
        public void StartNewDay()
        {
            DaysPassed++;
            GameTime = new TimeSpan(8, 0, 0); // Reset to 8:00 AM
        }

        // Method to advance time
        public void AdvanceTime(int hours, int minutes = 0)
        {
            GameTime = GameTime.Add(new TimeSpan(hours, minutes, 0));
            // If past midnight, start a new day
            if (GameTime.Days > 0 || GameTime.Hours >= 24)
            {
                StartNewDay();
            }
        }

        // Method to get current time as string
        public string GetTimeString()
        {
            return GameTime.ToString(@"hh\:mm tt");
        }
    }
}
