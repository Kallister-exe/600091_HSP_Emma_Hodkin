using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Honours.Models
{
    public class Routine
    {
        public Guid ID { get; init; }
        [ForeignKey("UserID")]
        public Guid UserID { get; init; }
        public Routine(Guid userID) : this(Guid.NewGuid(), userID) { }
        public Routine(Guid id, Guid userID)
        {
            ID = id;
            UserID = userID;
        }
    }
}
