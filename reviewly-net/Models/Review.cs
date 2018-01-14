using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewly_net.Models
{
    public class Review
    {
        int _rating;
        int _comment;
        int _commenter;
        int _reviewDate;

        public Review(int rating, int comment, int commenter, int reviewDate)
        {
            Rating = rating;
            Comment = comment;
            Commenter = commenter;
            ReviewDate = reviewDate;
            Rating = rating;
            Comment = comment;
            Commenter = commenter;
            ReviewDate = reviewDate;
        }

        public int Rating { get => _rating; set => _rating = value; }
        public int Comment { get => _comment; set => _comment = value; }
        public int Commenter { get => _commenter; set => _commenter = value; }
        public int ReviewDate { get => _reviewDate; set => _reviewDate = value; }
    }
}