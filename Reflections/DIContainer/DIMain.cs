using System;

namespace Reflections.DIContainer
{
    public class DIMain
    {
        public static void Run()
        {
            var container = new SimpleDIContainer();
            container.Register(new DatabaseService());

            AppController controller = container.CreateInstance<AppController>();
            controller.Start();
        }
    }
}
