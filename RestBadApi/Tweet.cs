using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBadApi
{
    /* Tweet Example:
     {
        "id": "976930413695438851",
        "stamp": "2016-03-20T05:58:30.4218367+00:00",
        "text": "Happy birthday to the one and only @BenWahBallz could bounce marvel theories and Anime awesomeness around with him… https://t.co/bjN4iT7JuY"
     } 
     */

    class Tweet
    { 
        public string id { get; set; }
        public DateTime stamp { get; set; }
        public string text { get; set; }
    }

    // This class implements the methods required to compare tweet elements when using List operations 
    class TweetComparer : IEqualityComparer<Tweet>

    {
        public bool Equals(Tweet x, Tweet y)
        {

            //Check whether the compared objects reference the same data.
            if (Object.ReferenceEquals(x, y))
                return true;

            //Check whether any of the compared objects is null.
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            //Check whether the ids are equal.
            return x.id == y.id;
        }
        
        // If Equals() returns true, GetHashCode() will return the same values.

        public int GetHashCode(Tweet t)
        {
            //Check whether the object is null
            if (Object.ReferenceEquals(t, null)) return 0;

            //Get hash code for the id field if it is not null.
            int hashTweetId = t.id == null ? 0 : t.id.GetHashCode();

            //Calculate the hash code for the product.
            return hashTweetId;
        }



    }
}
