using System;

namespace Solutions_MZ;

public static class Task12_GodClass
{
    public sealed class UserManager
    {
        public void ManageUsers() => Console.WriteLine("Managing users.");
    }

    public sealed class SystemConfigurator
    {
        public void ConfigureSystem() => Console.WriteLine("Configuring system.");
    }

    public sealed class LogRegistrar
    {
        public void RegisterLog(string log) => Console.WriteLine($"Log: {log}");
    }

    public sealed class SystemReportGenerator
    {
        public void GenerateSystemReport() => Console.WriteLine("System report generated.");
    }

    //AdminPanel zostaje jako “wysoki poziom” orchestrator
    public sealed class AdminPanel
    {
        private readonly UserManager _userManager;
        private readonly SystemConfigurator _configurator;
        private readonly LogRegistrar _logRegistrar;
        private readonly SystemReportGenerator _reportGenerator;

        public AdminPanel(
            UserManager userManager,
            SystemConfigurator configurator,
            LogRegistrar logRegistrar,
            SystemReportGenerator reportGenerator)
        {
            _userManager = userManager;
            _configurator = configurator;
            _logRegistrar = logRegistrar;
            _reportGenerator = reportGenerator;
        }

        public void RunDailyAdminTasks()
        {
            _userManager.ManageUsers();
            _configurator.ConfigureSystem();
            _logRegistrar.RegisterLog("Daily admin tasks executed.");
            _reportGenerator.GenerateSystemReport();
        }
    }

    public static void Run()
    {
        Console.WriteLine("[12] God Class");

        var panel = new AdminPanel(
            new UserManager(),
            new SystemConfigurator(),
            new LogRegistrar(),
            new SystemReportGenerator()
        );

        panel.RunDailyAdminTasks();

        Console.WriteLine("Expected: manage users -> configure -> log -> report.");
    }
}
