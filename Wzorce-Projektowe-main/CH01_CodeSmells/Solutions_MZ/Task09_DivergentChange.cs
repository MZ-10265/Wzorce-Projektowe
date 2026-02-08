using System;

namespace Solutions_MZ;

public static class Task09_DivergentChange
{
    public sealed class UserAccount
    {
        public string Username { get; }
        public string Password { get; } // hash

        public UserAccount(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public sealed class AuthenticationService
    {
        public bool Login(UserAccount account, string username, string password)
        {
            if (account is null) throw new ArgumentNullException(nameof(account));

            bool ok = account.Username == username && account.Password == password;
            Console.WriteLine(ok ? "User logged in." : "Login failed.");
            return ok;
        }

        public void Logout(UserAccount account)
        {
            if (account is null) throw new ArgumentNullException(nameof(account));
            Console.WriteLine("User logged out.");
        }
    }

    public sealed class UserReportGenerator
    {
        public void Generate(UserAccount account)
        {
            if (account is null) throw new ArgumentNullException(nameof(account));
            Console.WriteLine($"Generating user report for: {account.Username}");
        }
    }

    public static void Run()
    {
        Console.WriteLine("[09] Divergent Change");

        var account = new UserAccount("mateusz", "pass123");
        var auth = new AuthenticationService();
        var reports = new UserReportGenerator();

        bool loggedIn = auth.Login(account, "mateusz", "pass123");
        if (loggedIn)
        {
            reports.Generate(account);
            auth.Logout(account);
        }

        Console.WriteLine("Expected: logged in -> report -> logged out");
    }
}
