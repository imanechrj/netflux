using System;
namespace Netflux
{
    public class Episode : Content
    {
        public int Number { get; set; }
        public Episode(string director, int duration, string name) : base(director, duration, name)
        {
        }
    }
}

