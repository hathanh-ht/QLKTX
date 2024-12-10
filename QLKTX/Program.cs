using Microsoft.Extensions.DependencyInjection;
using QLKTX.Domains.Interface;
using QLKTX.Infras;
using QLKTX.Infras.Repository;
using System;
using System.Windows.Forms;

namespace QLKTX
{
    internal static class Program
    {
        public static ServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainForm = ServiceProvider.GetService<Login>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<DormitoryContext>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<Login>();
        }
    }
}
