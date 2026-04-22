using System.ComponentModel.DataAnnotations.Schema;

namespace Honours.Models
{
    public class Timer
    {
        public Guid ID { get; init; }
        [ForeignKey("UserID")]
        public Guid UserID { get; init; }
        [ForeignKey("RoutineID")]
        public Guid? RoutineID { get; init; } // using ? marks the property as nullable, as a timer may not be connected to a routine
        public float TimerLength { get; set; }
        public DateTime Datestamp { get; set; } // timers save the timestamp of when they were started so total hours worked in a day can be calculated
        public int TimerType { get; set; } // defines the timer as a 'work' timer or a 'rest' timer, room for scaling to add other types of timer

        public Timer(Guid userID, Guid? routineID, float timerLength, DateTime datestamp, int timerType) : this(Guid.NewGuid(), userID, routineID, timerLength, datestamp, timerType) { }
        public Timer(Guid id, Guid userID, Guid? routineID, float timerLength, DateTime datestamp, int timerType)
        {
            ID = id;
            UserID = userID;
            RoutineID = routineID;
            TimerLength = timerLength;
            Datestamp = datestamp;
            TimerType = timerType;
        }
    }
}
