using webapp.Models;

namespace webapp.Services;
public static class ProjectService
{
    static List<Projects> Project { get; }
    static int nextId = 1;
    static ProjectService()
    {
        Project = new List<Projects>
                {
                    new Projects { Id = 1, Name = "Project 1", Description = "Learn of web app with .NET", Status = "Active", Type = "C# Learn", Owner = "Ethan Huret" },
                };
    }

    public static List<Projects> GetAll() => Project;

    public static Projects? Get(int id) => Project.FirstOrDefault(p => p.Id == id);

    public static void Add(Projects new_project)
    {
        new_project.Id = nextId++;
        Project.Add(new_project);
    }

    public static void Delete(int id)
    {
        var delete_project = Get(id);
        if (delete_project is null)
            return;

        Project.Remove(delete_project);
    }

    public static void Update(Projects update_project)
    {
        var index = Project.FindIndex(p => p.Id == update_project.Id);
        if (index == -1)
            return;

        Project[index] = update_project;
    }
}