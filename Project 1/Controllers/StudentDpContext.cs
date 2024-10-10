namespace Project_1.Controllers
{
    public class StudentDpContext : DbContext
    {
        public StudentDpContext(DbContext Option<StudentDbContext>Options) : base(Option)
        { }

        public Db Set<student>students { Get();Set(); }


    }


}
