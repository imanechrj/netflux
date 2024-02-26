namespace Netflux;

class Program
{
    static void Main(string[] args)
    {

        User user1 = new User("imanecherraj@gmail.com", "imane");
        TvShow friends = new TvShow();
        Episode episodeFriends1 = new Episode("David Crane", 22, "Celui qui demenage");
        Episode episodeFriends2 = new Episode("David Crane", 25, "Celui qui est perdu");
        TvShow GOT = new TvShow();
        Episode episodeGOT1 = new Episode("Mark Huffman", 52, "Winter is coming");
        Episode episodeGOT2 = new Episode("Mark Huffman", 55, "The Kingsroad");

        GOT.Episodes.Add(episodeGOT1);
        GOT.Episodes.Add(episodeGOT2);

        friends.Episodes.Add(episodeFriends1);
        friends.Episodes.Add(episodeFriends2);

        user1.Select(friends);
        user1.Select(friends);
        user1.Select(friends);

        user1.Select(GOT);
        user1.Select(GOT);

        user1.Display();
      
    }
}

