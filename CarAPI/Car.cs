﻿namespace CarAPI
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Power { get; set; }
        public int ProductionYear { get; set; }
    }
}
