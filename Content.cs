using System;
namespace Netflux
{
	public abstract class Content
	{
		public string Name { get; set; }
		public int Duration { get; set; }
		public string Director { get; set; }
		public int  NumberOfViews { get; set; }

        public Content(string director, int duration, string name)
        {
            NumberOfViews = 0;
            Director = director;
            Duration = duration;
            Name = name;
        }

        public void Watched()
        {
            NumberOfViews++;
        }
    }
}

