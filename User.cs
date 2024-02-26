using System;
namespace Netflux
{
	public class User
	{
		public string Email { get; set; }
		public string Pseudo { get; set; }
		public int Watchtime { get; set; }
		public Dictionary<TvShow, int> WatchHistory { get; set; }

		public User(string email, string pseudo)
        {
            Email = email;
            Pseudo = pseudo;
            Watchtime = 0 ;
			WatchHistory = new Dictionary<TvShow, int>();
        }

        public void Watch(Content content)
		{
			Watchtime += content.Duration;
			content.Watched();
		}

		public void Select(ISelectable selectable)
		{
			selectable.Selected(this);
		}

		public void Display()
		{
			Console.WriteLine("User : "+ Pseudo +"\n");
			Console.WriteLine("User Email :" + Email);
			Console.WriteLine("Watchtime :" + Watchtime);
		}
	}
}

