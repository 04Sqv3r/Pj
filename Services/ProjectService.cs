using System;
using System.Collections.Generic;

namespace BlazorApp1.Services
{
    public class Project
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class ProjectService
    {
        private readonly List<Project> _projects = new();

        public IReadOnlyList<Project> Projects => _projects;

        public void AddProject(Project project)
        {
            _projects.Add(project);
        }
    }
}
