using Mastermattie.FreeStyler.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mastermattie.FreeStyler.Tests
{
    [TestClass]
    public class FreeStylerTests
    {
        private readonly IServiceProvider _provider;
        private readonly ILogger _logger;
        private readonly FreeStylerClient _client;

        public FreeStylerTests()
        {
            var services = new ServiceCollection();
            services.AddLogging(logging =>
            {
                logging.SetMinimumLevel(LogLevel.Debug);
                logging.AddConsole();
            });
            services.AddSingleton<FreeStylerClient>();
            _provider = services.BuildServiceProvider();

            _logger = _provider.GetRequiredService<ILogger<FreeStylerTests>>();
            Assert.IsNotNull(_logger, "No logger found");

            _client = _provider.GetRequiredService<FreeStylerClient>();
            Assert.IsNotNull(_client, "No client found");
        }

        /// <summary>
        /// Connects to FreeStyler
        /// </summary>
        [TestMethod]
        public void Connect()
        {
            _logger.LogInformation("Connecting...");
            _client.Connect();
            Assert.IsTrue(_client.Connected, "Client not connected");
            _logger.LogInformation("Connected!");
        }

        /// <summary>
        /// Disconnects from FreeStyler
        /// </summary>
        [TestMethod]
        public void Disconnect()
        {
            _logger.LogInformation("Disconnecting...");
            _client.Disconnect();
            Assert.IsFalse(_client.Connected, "Client connected");
            _logger.LogInformation("Disconnected!");
        }

        /// <summary>
        /// Toggle all fixtures
        /// </summary>
        [TestMethod]
        public void ToggleAllFixtures()
        {
            Connect();

            _logger.LogInformation("Toggle all fixtures");
            _client.PressButton(FreeStylerCommand.ToggleAllFixtures);

            Disconnect();
        }

        /// <summary>
        /// Toggle favorite
        /// </summary>
        [TestMethod]
        public void ToggleFavorite()
        {
            Connect();

            _logger.LogInformation("Toggle favorite");
            _client.PressButton(FreeStylerCommand.ToggleFavorite);

            Disconnect();
        }

        /// <summary>
        /// Toggle blackout
        /// </summary>
        [TestMethod]
        public void ToggleBlackout()
        {
            Connect();

            _logger.LogInformation("Toggle blackout");
            _client.PressButton(FreeStylerCommand.ToggleBlackout);

            Disconnect();
        }

        /// <summary>
        /// Release all
        /// </summary>
        [TestMethod]
        public void ReleaseAll()
        {
            Connect();

            _logger.LogInformation("Release all");
            _client.PressButton(FreeStylerCommand.ReleaseAll);

            Disconnect();
        }

        /// <summary>
        /// Fog / Smoke
        /// </summary>
        [TestMethod]
        public void FogSmoke()
        {
            Connect();

            _logger.LogInformation("Fog / Smoke");
            _client.PressButton(FreeStylerCommand.FogSmoke, 1000);

            Disconnect();
        }

        /// <summary>
        /// Fog level to 0%
        /// </summary>
        [TestMethod]
        public void FogLevelEmpty()
        {
            Connect();

            _logger.LogInformation("Fog level to 0%");
            _client.SendCommand(FreeStylerCommand.FogLevel, 0);

            Disconnect();
        }

        /// <summary>
        /// Fog level to 100%
        /// </summary>
        [TestMethod]
        public void FogLevelFull()
        {
            Connect();

            _logger.LogInformation("Fog level to 100%");
            _client.SendCommand(FreeStylerCommand.FogLevel, 255);

            Disconnect();
        }

        /// <summary>
        /// Fog fan level to 0%
        /// </summary>
        [TestMethod]
        public void FogFanLevelEmpty()
        {
            Connect();

            _logger.LogInformation("Fog fan level to 0%");
            _client.SendCommand(FreeStylerCommand.FogFanLevel, 0);

            Disconnect();
        }

        /// <summary>
        /// Fog fan level to 100%
        /// </summary>
        [TestMethod]
        public void FogFanLevelFull()
        {
            Connect();

            _logger.LogInformation("Fog fan level to 100%");
            _client.SendCommand(FreeStylerCommand.FogFanLevel, 255);

            Disconnect();
        }

        /// <summary>
        /// Get cue captions
        /// </summary>
        [TestMethod]
        public void GetCueCaptions()
        {
            Connect();

            _logger.LogInformation("Get cue captions");
            _client.SendRequest(FreeStylerRequest.CueCaptions);

            Disconnect();
        }
    }
}
