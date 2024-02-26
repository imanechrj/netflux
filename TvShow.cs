using System;
namespace Netflux
{
	public class TvShow : ISelectable
	{
		public List<Episode> Episodes { get; set; }

        public TvShow()
        {
            Episodes = new List<Episode>();
        }

        public void Selected(User user)
        {
			bool tvShowAlreadyWatched = user.WatchHistory.ContainsKey(this);


			if (!tvShowAlreadyWatched)
			{
				user.Watch(Episodes[0]);
				user.WatchHistory.Add(this, 0);
			}
			else if (user.WatchHistory[this]+1 > user.WatchHistory.Count)
			{
				Console.WriteLine("End of the show, back to the start");
				user.WatchHistory[this] = 0;
                user.Watch(Episodes[0]);
            }
			else
			{
				int lastWatched = user.WatchHistory[this];
				user.Watch(Episodes[lastWatched + 1]);
				user.WatchHistory[this] ++ ; 
			}
        }
    }
}

