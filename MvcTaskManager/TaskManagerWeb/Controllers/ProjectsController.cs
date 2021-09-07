using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcTaskManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerWeb.Identity;

namespace MvcTaskManager.Controllers
{
    [Authorize]
    public class ProjectsController : Controller
    {
        private ApplicationDbContext db;

        public ProjectsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpGet]
        [Route("api/projects")]
        public List<Project> Get()
        {
            List<Project> projects = db.Projects.ToList();
            return projects;
        }

        [HttpPost]
        [Route("api/projects")]
        public Project Post([FromBody]Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
            return project;
        }

        [HttpPut]
        [Route("api/projects")]
        public Project Put([FromBody] Project project)
        {
            Project project1 = db.Projects.Where(m => m.ProjectId == project.ProjectId).FirstOrDefault();
            if (project1 != null)
            {
                project1.ProjectName = project.ProjectName;
                project1.DateOfStart = project.DateOfStart;
                project1.TeamSize = project.TeamSize;
                db.SaveChanges();
                return project1;
            }
            else
            {
                return null;
            }
        }

        [HttpGet]
        [Route("api/projects/search/{searchby}/{searchtext}")]
        public List<Project> Search(string searchBy, string searchText)
        {
            List<Project> projects = null;
            if (searchBy == "ProjectID")
                projects = db.Projects.Where(temp => temp.ProjectId.ToString().Contains(searchText)).ToList();
            else if (searchBy == "ProjectName")
                projects = db.Projects.Where(temp => temp.ProjectName.Contains(searchText)).ToList();
            if (searchBy == "DateOfStart")
                projects = db.Projects.Where(temp => temp.DateOfStart.ToString().Contains(searchText)).ToList();
            if (searchBy == "TeamSize")
                projects = db.Projects.Where(temp => temp.TeamSize.ToString().Contains(searchText)).ToList();

            return projects;
        }

        [HttpDelete]
        [Route("api/projects")]
        public int Delete(int ProjectId)
        {
            Project existingProject = db.Projects.Where(temp => temp.ProjectId == ProjectId).FirstOrDefault();
            if (existingProject != null)
            {
                db.Projects.Remove(existingProject);
                db.SaveChanges();
                return ProjectId;
            }
            else
            {
                return -1;
            }
        }
    }
}
