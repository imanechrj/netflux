using System;
namespace Netflux
{
    public class Movie : Content, ISelectable
    {
        public Movie(string director, int duration, string name) : base(director, duration, name)
        {

        }

        public void Selected(User user)
        {
            user.Watch(this);
        }
    }
}


