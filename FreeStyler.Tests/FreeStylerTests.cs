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
                logging.AddDebug();
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

        /// <summary>
        /// Show Zone 1
        /// </summary>
        [TestMethod]
        public async Task ShowZone1()
        {
            await Connect();

            _logger.LogDebug("Show Zone 1");
            var result = await _client.PressButtonAsync(FreeStylerCommand.Zone1);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Show Zone 2
        /// </summary>
        [TestMethod]
        public async Task ShowZone2()
        {
            await Connect();

            _logger.LogDebug("Show Zone 2");
            var result = await _client.PressButtonAsync(FreeStylerCommand.Zone2);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Show Zone 3
        /// </summary>
        [TestMethod]
        public async Task ShowZone3()
        {
            await Connect();

            _logger.LogDebug("Show Zone 3");
            var result = await _client.PressButtonAsync(FreeStylerCommand.Zone3);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Show Zone 4
        /// </summary>
        [TestMethod]
        public async Task ShowZone4()
        {
            await Connect();

            _logger.LogDebug("Show Zone 4");
            var result = await _client.PressButtonAsync(FreeStylerCommand.Zone4);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open All Windows
        /// </summary>
        [TestMethod]
        public async Task OpenAllWindows()
        {
            await Connect();

            _logger.LogDebug("Open All Windows");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenAll);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Gobo Window
        /// </summary>
        [TestMethod]
        public async Task OpenGoboWindow()
        {
            await Connect();

            _logger.LogDebug("Open Gobo Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenGobo);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Color Window
        /// </summary>
        [TestMethod]
        public async Task OpenColorWindow()
        {
            await Connect();

            _logger.LogDebug("Open Color Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenColor);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Pan/Tilt Window
        /// </summary>
        [TestMethod]
        public async Task OpenPanTiltWindow()
        {
            await Connect();

            _logger.LogDebug("Open Pan/Tilt Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenPanTilt);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Beam Window
        /// </summary>
        [TestMethod]
        public async Task OpenBeamWindow()
        {
            await Connect();

            _logger.LogDebug("Open Beam Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenBeam);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Macro Window
        /// </summary>
        [TestMethod]
        public async Task OpenMacroWindow()
        {
            await Connect();

            _logger.LogDebug("Open Macro Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenMacro);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Lamp Window
        /// </summary>
        [TestMethod]
        public async Task OpenLampWindow()
        {
            await Connect();

            _logger.LogDebug("Open Lamp Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenLamp);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Create Sequence Window
        /// </summary>
        [TestMethod]
        public async Task OpenCreateSequenceWindow()
        {
            await Connect();

            _logger.LogDebug("Open Create Sequence Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenCreateSequence);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Cue Window
        /// </summary>
        [TestMethod]
        public async Task OpenCueWindow()
        {
            await Connect();

            _logger.LogDebug("Open Cue Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenCue);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Sound Window
        /// </summary>
        [TestMethod]
        public async Task OpenSoundWindow()
        {
            await Connect();

            _logger.LogDebug("Open Sound Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenSound);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Output Window
        /// </summary>
        [TestMethod]
        public async Task OpenOutputWindow()
        {
            await Connect();

            _logger.LogDebug("Open Output Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenOutput);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Framing Window
        /// </summary>
        [TestMethod]
        public async Task OpenFramingWindow()
        {
            await Connect();

            _logger.LogDebug("Open Framing Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenFraming);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Override Buttons Window
        /// </summary>
        [TestMethod]
        public async Task OpenOverrideButtonsWindow()
        {
            await Connect();

            _logger.LogDebug("Open Override Buttons Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenOverrideButtons);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Command Line Window
        /// </summary>
        [TestMethod]
        public async Task OpenCommandLineWindow()
        {
            await Connect();

            _logger.LogDebug("Open Command Line Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenCommandLine);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Master Window
        /// </summary>
        [TestMethod]
        public async Task OpenMasterWindow()
        {
            await Connect();

            _logger.LogDebug("Open Master Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenMaster);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Submaster Window
        /// </summary>
        [TestMethod]
        public async Task OpenSubmasterWindow()
        {
            await Connect();

            _logger.LogDebug("Open Submaster Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenSubmaster);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Smoke Window
        /// </summary>
        [TestMethod]
        public async Task OpenSmokeWindow()
        {
            await Connect();

            _logger.LogDebug("Open Smoke Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.OpenSmoke);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }

        /// <summary>
        /// Open Custom Sliders Window
        /// </summary>
        [TestMethod]
        public async Task OpenCustomSlidersWindow()
        {
            await Connect();

            _logger.LogDebug("Open Custom Sliders Window");
            var result = await _client.PressButtonAsync(FreeStylerCommand.ShowSliders);
            Assert.IsTrue(result, "Button press failed!");

            await Disconnect();
        }
    }
}
