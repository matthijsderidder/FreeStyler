using System.Net;
using System.Net.Sockets;

namespace Mastermattie.FreeStyler.Client;
public class FreeStylerClient
{
    private readonly TcpClient _client = new TcpClient();
    private readonly int _port = 3332;

    /// <summary>
    /// 
    /// </summary>
    public bool Connected => _client.Connected;

    /// <summary>
    /// 
    /// </summary>
    public void Connect() => _client.Connect(IPAddress.Loopback, _port);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address"></param>
    public void Connect(IPAddress address) => _client.Connect(address, _port);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hostname"></param>
    public void Connect(string hostname) => _client.Connect(hostname, _port);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task ConnecAsync() => await _client.ConnectAsync(IPAddress.Loopback, _port);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="address"></param>
    /// <returns></returns>
    public async Task ConnecAsync(IPAddress address) => await _client.ConnectAsync(address, _port);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hostname"></param>
    /// <returns></returns>
    public async Task ConnectAsync(string hostname) => await _client.ConnectAsync(hostname, _port);

    /// <summary>
    /// 
    /// </summary>
    public void Disconnect() => _client.Close();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="state"></param>
    /// <param name="args"></param>
    public void SendCommand(FreeStylerCommand command, byte state = 0xFF, params byte[] args)
    {
        var packet = FreeStylerHelper.CreateCommandPacket(command, state, args);
        var stream = _client.GetStream();
        stream.Write(packet);
        stream.Flush();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="state"></param>
    /// <param name="args"></param>
    public void SendCommand(FreeStylerCommand command, int level, params byte[] args)
        => SendCommand(command, (byte)level, args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="state"></param>
    /// <param name="args"></param>
    public void SendCommand(FreeStylerCommand command, FreeStylerMouse state, params byte[] args)
        => SendCommand(command, (byte)state, args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="state"></param>
    /// <param name="args"></param>
    public void SendRequest(FreeStylerRequest request, params byte[] args)
    {
        var packet = FreeStylerHelper.CreateRequestPacket(request, args);
        var stream = _client.GetStream();
        var reader = new StreamReader(stream);
        stream.Write(packet);
        stream.Flush();
        var b = reader.Read();
        Console.WriteLine($"Received: {b:X2}");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command">Button to press</param>
    /// <param name="duration">Duration in milliseconds</param>
    public void PressButton(FreeStylerCommand command, int duration = 0)
    {
        SendCommand(command, FreeStylerMouse.Click);
        Thread.Sleep(duration);
        SendCommand(command, FreeStylerMouse.Release);
    }
}
