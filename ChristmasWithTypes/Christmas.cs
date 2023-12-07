using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable - done

        //TODO Make the property, "Day", type enum - done
        public enum Day {Monday, Tuseday,Wednesday,Thursday,Friday, Saturday, Sunday};

    }
}
