using FreeStyler.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace FreeStyler.Tests
{
    [TestClass]
    public class FreeStylerTests
    {
        private readonly IServiceProvider _provider;
        private readonly ILogger _logger;
        private readonly FreeStylerClient _client;

        private readonly string _host = "localhost";

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
        public async Task Connect()
        {
            if (_client.Connected)
                return;

            _logger.LogDebug("Connecting...");
            await _client.ConnectAsync(_host);
            Assert.IsTrue(_client.Connected, "Client not connected");
            _logger.LogDebug("Connected!");
        }

        /// <summary>
        /// Disconnects from FreeStyler
        /// </summary>
        [TestMethod]
        public async Task Disconnect()
        {
            if (!_client.Connected)
                return;

            _logger.LogDebug("Disconnecting...");
            await _client.DisconnectAsync();
            Assert.IsFalse(_client.Connected, "Client connected");
            _logger.LogDebug("Disconnected!");
        }

        /// <summary>
        /// Toggle all fixtures
        /// </summary>
        [TestMethod]
        public async Task ToggleAllFixtures()
        {
            await Connect();

            _logger.LogDebug("Toggle all fixtures");
            var result = await _client.PressButtonAsync(FreeStylerCommand.ToggleAllFixtures);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Toggle favorite
        /// </summary>
        [TestMethod]
        public async Task ToggleFavorite()
        {
            await Connect();

            _logger.LogDebug("Toggle favorite");
            var result = await _client.PressButtonAsync(FreeStylerCommand.ToggleFavorite);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Toggle blackout
        /// </summary>
        [TestMethod]
        public async Task ToggleBlackout()
        {
            await Connect();

            _logger.LogDebug("Toggle blackout");
            var result = await _client.PressButtonAsync(FreeStylerCommand.ToggleBlackout);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Release all
        /// </summary>
        [TestMethod]
        public async Task ReleaseAll()
        {
            await Connect();

            _logger.LogDebug("Release all");
            var result = await _client.PressButtonAsync(FreeStylerCommand.ReleaseAll);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Fog / Smoke
        /// </summary>
        [TestMethod]
        public async Task FogSmoke()
        {
            await Connect();

            _logger.LogDebug("Fog / Smoke");
            var result = await _client.PressButtonAsync(FreeStylerCommand.FogSmoke, 1000);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Fog level to 0%
        /// </summary>
        [TestMethod]
        public async Task FogLevelEmpty()
        {
            await Connect();

            _logger.LogDebug("Fog level to 0%");
            var result = await _client.SendCommandAsync(FreeStylerCommand.FogLevel, 0);
            Assert.IsTrue(result, "Send command failed!");

            await Disconnect();
        }

        /// <summary>
        /// Fog level to 100%
        /// </summary>
        [TestMethod]
        public async Task FogLevelFull()
        {
            await Connect();

            _logger.LogDebug("Fog level to 100%");
            var result = await _client.SendCommandAsync(FreeStylerCommand.FogLevel, 255);
            Assert.IsTrue(result, "Send command failed!");

            await Disconnect();
        }

        /// <summary>
        /// Fog fan level to 0%
        /// </summary>
        [TestMethod]
        public async Task FogFanLevelEmpty()
        {
            await Connect();

            _logger.LogDebug("Fog fan level to 0%");
            var result = await _client.SendCommandAsync(FreeStylerCommand.FogFanLevel, 0);
            Assert.IsTrue(result, "Send command failed!");

            await Disconnect();
        }

        /// <summary>
        /// Fog fan level to 100%
        /// </summary>
        [TestMethod]
        public async Task FogFanLevelFull()
        {
            await Connect();

            _logger.LogDebug("Fog fan level to 100%");
            var result = await _client.SendCommandAsync(FreeStylerCommand.FogFanLevel, 255);
            Assert.IsTrue(result, "Send command failed!");

            await Disconnect();
        }

        /// <summary>
        /// Get cue captions
        /// </summary>
        [TestMethod]
        public async Task GetCueCaptions()
        {
            await Connect();

            _logger.LogDebug("Get cue captions");
            var fields = await _client.SendRequestAsync(FreeStylerRequest.CueCaptions);
            _logger.LogInformation(string.Join(Environment.NewLine, fields));

            await Disconnect();
        }

        /// <summary>
        /// Get cuelist captions
        /// </summary>
        [TestMethod]
        public async Task GetCuelistCaptions()
        {
            await Connect();

            _logger.LogDebug("Get cuelist captions");
            var fields = await _client.SendRequestAsync(FreeStylerRequest.CuelistCaptionsAll);
            _logger.LogInformation(string.Join(Environment.NewLine, fields));

            await Disconnect();
        }

        /// <summary>
        /// Get group names
        /// </summary>
        [TestMethod]
        public async Task GetGroupNames()
        {
            await Connect();

            _logger.LogDebug("Get group names");
            var fields = await _client.SendRequestAsync(FreeStylerRequest.GroupNames);
            _logger.LogInformation(string.Join(Environment.NewLine, fields));

            await Disconnect();
        }

        /// <summary>
        /// Get FreeStyler version
        /// </summary>
        [TestMethod]
        public async Task GetFreestylerVersion()
        {
            await Connect();

            _logger.LogDebug("Get FreeStyler version");
            var fields = await _client.SendRequestAsync(FreeStylerRequest.FreeStylerVersion);
            _logger.LogInformation(string.Join(Environment.NewLine, fields));

            await Disconnect();
        }

        /// <summary>
        /// Get fixtures
        /// </summary>
        [TestMethod]
        public async Task GetFixtures()
        {
            await Connect();           

            _logger.LogDebug("Get fixture addresses");
            var addresses = await _client.SendRequestAsync<byte>(FreeStylerRequest.FixtureAddresses);
            Assert.IsNotNull(addresses, "No addresses received");

            _logger.LogDebug("Get fixture names");
            var names = await _client.SendRequestAsync(FreeStylerRequest.FixtureNames);
            Assert.IsNotNull(names, "No names received");

            _logger.LogDebug("Get fixture status");
            var statuses = await _client.SendRequestAsync<byte>(FreeStylerRequest.FixtureSelectionStatuses);
            Assert.IsNotNull(statuses, "No statuses received");

            Assert.IsTrue((addresses.Length == names.Length && addresses.Length == statuses.Length), "Number of items do not match");

            var sb = new StringBuilder();
            for (var i = 0; i < addresses.Length; i++)
                sb.AppendLine($"{(addresses[i]):D3}\t{statuses[i]}\t{names[i]}");
            _logger.LogInformation(sb.ToString().TrimEnd());

            await Disconnect();
        }
    }
}
