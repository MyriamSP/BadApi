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
    
    class jsonTweet
    {
        public string id { get; set; }
        public DateTime stamp { get; set; }
        public string text { get; set; }
    }
}
