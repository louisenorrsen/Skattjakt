﻿namespace Skattjakt.Data
{
    public class TreasureMap
    {
        // Add more properties here when needed
        public string Name { get; set; }
        public int Id { get; set; }
        public Settings Settings { get; set; } = new Settings();
        public List<Station> Stations { get; set; } = [];

        public TreasureMap(string name)
        {
            Name = name;
        }
    }
}
