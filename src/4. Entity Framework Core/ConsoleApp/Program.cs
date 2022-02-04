using EfCore.Infrastructure;

InitializeDb();

RemoveClassRoom();

Console.WriteLine("Fin du programme");

Console.ReadLine();

void RemoveClassRoom()
{
    using var dbContext = new ApplicationDbContext();
    
    var classRoomToDelete = new Classroom(Guid.Parse("7b38297a-8341-4e75-9e37-1c44bebbc7e8"));
    dbContext.Classrooms.Remove(classRoomToDelete);

    dbContext.SaveChanges();
}

void InitializeDb()
{
    using var dbContext = new ApplicationDbContext();

    var classRoom1 = new Classroom(Guid.Parse("7b38297a-8341-4e75-9e37-1c44bebbc7e8"));
    var classRoom2 = new Classroom(Guid.Empty);

    dbContext.Classrooms.Add(classRoom1);
    dbContext.Add(classRoom2);

    dbContext.SaveChanges();
}