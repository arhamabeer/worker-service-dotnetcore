using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserUpdateService
{
    public class UserService : BackgroundService
    {
        private readonly ILogger<UserService> _logger;

        public UserService(ILogger<UserService> logger) {
            _logger = logger;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Execution Started");
                try
                {
                    // api/method/service/logging code will be here!
                }
                catch(Exception ex)
                {
                    _logger.LogError("Execution Error: ", ex.Message);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service Started");
            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            return base.StopAsync(cancellationToken);
        }

    }
}
