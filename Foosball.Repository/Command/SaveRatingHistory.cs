using Foosball.Repository.Model;

namespace Foosball.Repository.Command
{
    internal class SaveRatingHistory : RepositorySave<RatingHistory>
    {
        public SaveRatingHistory(RatingHistory model) : base(model)
        { }
    }
}
