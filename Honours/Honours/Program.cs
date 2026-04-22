using Honours.Models;


namespace Honours
{
    public class Program
    {
        User user = new User(Guid.NewGuid(), "Emma", "hodkin@duck.com");
        public void Create()
        {
            
        }
        //public string[] Read()
        //{
            
        //}
        public string Read(string name)
        {
            return name;
        }
        public void Update(string name, string data)
        {
            name = data;
        }
        public void Delete(string name)
        {
            name = "Deleted";
        }

        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddSingleton<Honours.DataAccess.InsertUser>();
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }

    }
}
