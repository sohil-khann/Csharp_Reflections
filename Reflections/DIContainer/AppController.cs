using System;

namespace Reflections.DIContainer
{
    public class AppController
    {
        [Inject]
        private DatabaseService _dbService;

        public void Start()
        {
            Console.WriteLine("App Controller Starting...");
            _dbService?.Connect();
        }
    }
}
