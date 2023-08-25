using Serilog;
using UserUpdateService;


// WORKER SERVICE
IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        //services.AddHostedService<Worker>();
        services.AddHostedService<UserService>();
    }).UseSerilog()
    .Build();

Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(@"D:\.NET logs\userServiceLogs\logs.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

host.Run();
