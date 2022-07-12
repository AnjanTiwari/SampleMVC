using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using Business_Library;

namespace Dependency_Injection
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
             container.RegisterType<IEmployee, Employee>();
            ///which ever clas implements IEmployee just add it her like below 
           ////  container.RegisterType<IEmployee, Employer>();
           
            container.RegisterType<IStudent, Student>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}