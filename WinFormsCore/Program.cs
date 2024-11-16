using WinFormsCore.Views;
using WinFormsCore.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WinFormsCore.Models.Entities;

namespace WinFormsCore
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            var services = new ServiceCollection();

            ServiceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Configure services
            var serviceProvider = ServiceConfigurator.ConfigureServices(services, configuration);

            // Resolve the MainForm with DI
            var mainForm = serviceProvider.GetRequiredService<MainForm>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ShopContext context = new ShopContext();

            FormAc a = new FormAc();
            HangHoa b = new HangHoa(context);
            MainForm c = new MainForm(context);
            Donhang d = new Donhang(context);




            Application.Run(a);
            //var loginForm = ServiceProvider.GetRequiredService<FormAc>();
            //var dialogResult = loginForm.ShowDialog();

            //if (dialogResult == DialogResult.OK) // If login is successful
            //{
            //    // Run MainForm
            //    var mainForm1 = ServiceProvider.GetRequiredService<MainForm>();
            //    Application.Run(mainForm1);
            //}
            //else
            //{
            //    // Exit if login is not successful
            //    Application.Exit();
            //}

        }
    }
}