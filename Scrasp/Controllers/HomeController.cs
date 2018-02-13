using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scrasp.Models;

namespace Scrasp.Controllers
{
    public class HomeController : Controller
    {
        private List<Story> stories;
        private List<User> users;

        public HomeController()
        {
            List<Task> newTasks = new List<Task>();
            List<Story> newStories = new List<Story>();
            List<User> newUsers = new List<User>();

            Story story = new Story(description: "Semaine 01", tasks: newTasks);
            Task task1 = new Task(description: "Ajouter du bois.");
            Task task2 = new Task(description: "Acheter du pain.");
            Task task3 = new Task(description: "Acheter du vin");
            User user1 = new User(1, "Eric", "Password", "étudiant");
            User user2 = new User(2, "Sam", "Password", "étudiant");
            User user3 = new User(3, "Gaël", "Password", "étudiant");
            User user4 = new User(4, "Abraham", "Password", "président");

            newTasks.Add(task1);
            newTasks.Add(task2);
            newTasks.Add(task3);
            newStories.Add(story);
            newUsers.Add(user1);
            newUsers.Add(user2);
            newUsers.Add(user3);
            newUsers.Add(user4);
            this.stories = newStories;
            this.users = newUsers;
        }

        public ActionResult Index()
        {
            ViewBag.Users = this.users;
            ViewBag.Stories = this.stories;
            ViewBag.Todo = getTodoList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Scrasp, un outil de gestion de projet Scrum developpé sur ASP MVC par la classe SI-T2a de 2018";
            return View();
        }

        public ActionResult Add()
        {
            // Préparez vos données comme dans la méthode Index
            List<string> todo = getTodoList();
            ViewBag.Todo = todo;

            // Ajoutez-y un utilisateur supplémentaire
            User user = new Models.User(5, "Paul", "Password", "ingénieur en sécurité");
            this.users.Add(user);
           
            ViewBag.Users = this.users;
            ViewBag.Stories = this.stories;
            ViewBag.Message = "Utilisateur ajouté";
            
            return View("Index");
        }

        public ActionResult Delete(int id){
            Boolean flagDeleted = false;
            for (int i = this.users.Count - 1; i >= 0; --i){
                if (this.users[i].Id.Equals(id)){
                    this.users.RemoveAt(i);
                    flagDeleted = true;
                }
            }
            if(flagDeleted){
                ViewBag.Message = string.Format("Utilisateur {} supprimé", id);
            }else{
                ViewBag.Message = string.Format("Utilisateur introuvable");
            }
            ViewBag.Todo = getTodoList();
            ViewBag.Users = this.users;
            ViewBag.Stories = this.stories;
            return View("Index");    
        }

        public ActionResult ChangeId(int fromId, int toId){
            foreach (Models.User user in this.users){
                if (user.Id.Equals(fromId)){
                    user.Id = 10;
                    ViewBag.message = string.Format("Utilisateur {0} changé en {1}", user.UserName, user.Id.ToString());
                }
            }

            ViewBag.Todo = getTodoList();
            ViewBag.Users = this.users;
            ViewBag.Stories = this.stories;
            return View("Index");
        }

        public ActionResult Rename(int id)
        {
            // Préparez vos données comme dans la méthode Index
            List<string> todo = getTodoList();
            ViewBag.Todo = todo;
            
            Boolean flagFound = false;

            // Trouve l'utilisateur avec l'id
            foreach (Models.User user in this.users)
            {
                if (user.Id.Equals(id))
                {
                    // Utilsateur trouvé 
                    flagFound = true;
                    user.UserName = "Jacky";
                }
            }

            if (flagFound)
            {
                ViewBag.Message = string.Format("Utilisateur {0} renommé", id);
            }
            else
            {
                ViewBag.Message = string.Format("Utilisateur introuvable");
            }

            ViewBag.Stories = this.stories;
            ViewBag.Users = this.users;

            return View("Index");
        }

        private List<string> getTodoList()
        {
            return 
                new List<string>(new string[] {
                    "Coder les classes décrites dans le modèle Scrasp.asta",
                    "Instancier des objets Story, Task et User hardcodés dans HomeController.Index, les mettre dans des listes, les passer à la vue avec le ViewBag et les afficher dans la section Données ci-dessous",
                    "Compléter HomeController.Add() et Index.cshtml pour faire fonctionner l'ajout d'un utilisateur (premier lien dans les actions ci-dessous)",
                    "Faire de même pour le renommage (deuxième lien lien dans les actions ci-dessous). Observer la différence des routes et méthodes (passage de paramètre)",
                    "Modifier App_Start/RouteConfig.cs pour configurer les routes supplémentaires delete et changeid. Créer les méthodes nécessaires dans HomeController et modifier Index.cshtml pour faire fonctionner les liens de suppression et de modification",
                    "Autoriser la modification de l'attribut id avec une auto-property dans IdentifiableEntity. L'attribut statique lastId prendra la valeur d'id donnée",
                    "Modifier IdentifiableEntity de telle sorte qu'elle lève une exception si l'application tente de changer l'id d'un objet à une valeur inférieure ou égale à lastId. Choisissez la bonne exception en vous appuyant sur https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions",
                    "Soumettre vos questions au moyen d'issues dans le repo Git"
                });
        }

    }
}