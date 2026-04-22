using Microsoft.EntityFrameworkCore;
using Honours.Models;

namespace Honours
{
    public class DataDBContext : DbContext
    {
        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Routine> Routines { get; set; }
        public DbSet<Cosmetic> Cosmetics { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Models.Timer> Timers { get; set; }

        public async Task<User> CreateUser(string name, string email, string password)
        {
            User user = new User(name, email);
            Password hPass = new Password(user.ID, password);
            await Users.AddAsync(user);
            await Passwords.AddAsync(hPass); // the password is added at the same time as the user
            SaveChanges(); // commits the changes to the disk
            return user;
        }
        public async Task<Cosmetic> CreateCosmetic(string mainColour, string highlight, string lowlight, string contrast)
        {
            Cosmetic cosmetic = new Cosmetic(mainColour, highlight, lowlight, contrast);
            await Cosmetics.AddAsync(cosmetic);
            SaveChanges();
            return cosmetic;
        }
        public async Task<Routine> CreateRoutine(Guid userID)
        {
            Routine routine = new Routine(userID);
            await Routines.AddAsync(routine);
            SaveChanges();
            return routine;
        }
        public async Task<Models.Timer> CreateTimer(Guid userID, Guid routineID, float timerLength, DateTime datestamp, int timerType)
        {
            Models.Timer timer = new Models.Timer(userID, routineID, timerLength, datestamp, timerType);
            await Timers.AddAsync(timer);
            SaveChanges();
            return timer;
        }
        public async Task<User> UpdateUserName(Guid userID, string name)
        {
            if (userID == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(userID));
                return null;
            }
            
        }
    }
}
