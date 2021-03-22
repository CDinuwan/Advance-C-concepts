using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var tower = new ClockTower();
            var john = new Perosn("Jhon", tower);

            tower.ChimeFivePM();
            tower.ChimeSixAM();
        }
    }
    public class Perosn
    {
        private string _name;
        private ClockTower _tower;
        public Perosn(string name,ClockTower tower)
        {
            _name = name;
            _tower = tower;

            _tower.Chime += (object sender,EventArgs args) => Console.WriteLine("{0} heard the clock chime.", _name);
        }
    }
    public delegate void ChimeEventHandler(object sender,EventArgs args);
    public class ClockTowerEventArgs:EventArgs
    {
        public int Time { get; set; }
    }
    public class ClockTower
    {
        public event ChimeEventHandler Chime;
        public void ChimeFivePM()
        {
            Chime(this,new ClockTowerEventArgs { Time=17});
        }
        public void ChimeSixAM()
        {
            Chime(this, new ClockTowerEventArgs { Time = 6 });
        }
    }
}
