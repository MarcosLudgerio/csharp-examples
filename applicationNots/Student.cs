namespace ApplicationNots
{
    public struct Student
    {
        public string Name { get; set; }
        public decimal Note { get; set; }

        override public string ToString()
        {
            return Name;
        }

    }

}