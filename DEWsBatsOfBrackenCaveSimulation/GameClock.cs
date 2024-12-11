using System;
using System.Windows.Media;
using System.Windows.Threading;

namespace DEWsBatsOfBrackenCave
{
    public class GameClock
    {
        private DispatcherTimer timer;
        private Action<string, SolidColorBrush> updateUI;
        private int totalRealTimeMinutes = 12;
        private int gameHoursPerRealMinute = 1;
        public int elapsedSeconds = 0;
        public bool Timestopped = false;
            public bool Gamepaused = false;

        public GameClock(Action<string, SolidColorBrush> updateUI)
        {
            this.updateUI = updateUI;
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Tick;
        }

        public void Start()
        {
            
            timer.Start();
        }

        //public void Stop()
        //{
        //    Timestopped = true;
        //    timer.Stop();
        //    elapsedSeconds = 0;
        //}
        public void Reset()
        {
            timer.Stop();
             Timestopped = true;
            elapsedSeconds = 0; 
            timer.Start();
        }
        public void Pause()
        {
            Gamepaused = true;
            timer.Stop();
        }

        private void Tick(object? sender, EventArgs e)
        {
            elapsedSeconds++;
            double totalMinutes = elapsedSeconds / 60.0 * gameHoursPerRealMinute * 60;
            int hours = (int)totalMinutes / 60 % 24;
            int minutes = (int)totalMinutes % 60;
            string formattedTime = $"{hours:D2}:{minutes:D2}";

            updateUI(formattedTime, new SolidColorBrush(Colors.LightBlue));

            if (elapsedSeconds >= totalRealTimeMinutes * 60)
            {
                Reset();
            }
        }
    }
}
