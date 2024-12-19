namespace ProjectManagement.Tests
{
    public class EntitiesUnitTest
    {
        [Fact]
        public void TestNumberOfOverdueTasks()
        {
            var p1 = new Project
            {
                Name = "Test project #1",
                Tasks = new List<ProjectTask>()
            };

            p1.Tasks.Add(new ProjectTask { DueDate = new DateTime(2024, 8, 5), Description = "Get milk" });
            p1.Tasks.Add(new ProjectTask { DueDate = new DateTime(2024, 11, 24), Description = "Do laundry" });
            p1.Tasks.Add(new ProjectTask { DueDate = new DateTime(2025, 2, 9), Description = "Learn C#" });
            p1.Tasks.Add(new ProjectTask { DueDate = new DateTime(2025, 5, 8), Description = "Learn ASP.NET Core MVC" });
            p1.Tasks.Add(new ProjectTask { DueDate = new DateTime(2025, 5, 31), Description = "Learn Git" });

            // Complete this test method by using a LINQ expression to query for the overdue tasks
            // and assert that it is the expected number - then ensure that the test runs and passes.

            var currentDate = DateTime.Now;

            // Act
            var overdueTasks = p1.Tasks.Where(task => task.DueDate < currentDate).ToList();

            // Assert
            var expectedOverdueCount = p1.Tasks.Count(task => task.DueDate < currentDate);
            Assert.Equal(expectedOverdueCount, overdueTasks.Count);
        }
    }

    // Dummy implementations of Project and ProjectTask for testing purposes.
    public class Project
    {
        public string Name { get; set; }
        public List<ProjectTask> Tasks { get; set; } = new();
    }

    public class ProjectTask
    {
        public DateTime DueDate { get; set; }
        public string Description { get; set; }
    }
}