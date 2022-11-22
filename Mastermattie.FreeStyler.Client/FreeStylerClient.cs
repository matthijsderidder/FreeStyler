using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace Mastermattie.FreeStyler.Client;
public class FreeStylerClient : IDisposable
{
    private readonly TcpClient _client = new TcpClient();
    private readonly int _port = 3332;

    /// <summary>
    /// 
    /// </summary>
    public bool Connected
        => _client.Connected;

    /// <summary>
    /// Establishes a connection to a FreeStyler host.
    /// </summary>
    /// <returns></returns>
    public async Task ConnecAsync()
        => await _client.ConnectAsync(IPAddress.Loopback, _port);

    /// <summary>
    /// Establishes a connection to a FreeStyler host.
    /// </summary>
    /// <param name="address">The IPAddress of the FreeStyler host to connect to.</param>
    /// <returns>An asynchronous task that completes when the connection is established.</returns>
    public async Task ConnecAsync(IPAddress address)
        => await _client.ConnectAsync(address, _port);

    /// <summary>
    /// Establishes a connection to a FreeStyler host.
    /// </summary>
    /// <param name="host">The hostname of the remote host to connect to.</param>
    /// <returns>An asynchronous task that completes when the connection is established.</returns>
    public async Task ConnectAsync(string host)
        => await _client.ConnectAsync(host, _port);

    /// <summary>
    /// Disconnects a connected socket from the FreeStyler host.
    /// </summary>
    /// <returns>An asynchronous task that completes when the connection is established.</returns>
    public async Task DisconnectAsync()
        => await Task.Run(() => _client.Close());

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="state"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public async Task<bool> SendCommandAsync(FreeStylerCommand command, byte state = 0xFF, params byte[] args)
    {
        var packet = FreeStylerHelper.CreateCommandPacket(command, state, args);
        await SendDataAsync(packet);
        await Task.Delay(100);
        var response = await ReceiveDataAsync();
        return (response != null && response[0] == 0xFF);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="level"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public async Task<bool> SendCommandAsync(FreeStylerCommand command, int level, params byte[] args)
        => await SendCommandAsync(command, (byte)level, args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command"></param>
    /// <param name="state"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public async Task<bool> SendCommandAsync(FreeStylerCommand command, FreeStylerMouse state, params byte[] args)
        => await SendCommandAsync(command, (byte)state, args);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public async Task<string[]> SendRequestAsync(FreeStylerRequest request, params byte[] args)
    {
        var str = $"FSBC{((uint)request):D3}000";
        await SendTextAsync(str);

        await Task.Delay(100);

        while (_client.Connected && _client.Available == 0)
            await Task.Delay(100);
        
        var response = await ReceiveTextAsync();
        return ParseResponse(response, "FSBC").ToArray();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    public async Task SendDataAsync(params byte[] data)
    {
        var stream = _client.GetStream();
        await stream.WriteAsync(data, 0, data.Length);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<byte[]> ReceiveDataAsync()
    {
        var buffer = new byte[_client.ReceiveBufferSize];
        var stream = _client.GetStream();
        var len = await stream.ReadAsync(buffer, 0, buffer.Length);
        Array.Resize(ref buffer, len);
        return buffer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public async Task SendTextAsync(string text)
    {
        var stream = _client.GetStream();
        var writer = new StreamWriter(stream);
        await writer.WriteAsync(text);
        await writer.FlushAsync();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<string> ReceiveTextAsync()
    {
        var response = await ReceiveDataAsync();
        if (response == null) return string.Empty;
        var enc = Encoding.GetEncoding(
            Encoding.ASCII.EncodingName,
            new EncoderReplacementFallback(string.Empty),
            new DecoderExceptionFallback()
        );
        return Encoding.ASCII.GetString(Encoding.Convert(Encoding.UTF8, enc, response));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="command">Button to press</param>
    /// <param name="duration">Duration in milliseconds</param>
    /// <returns></returns>
    public async Task<bool> PressButtonAsync(FreeStylerCommand command, int duration = 0)
    {
        if (!await SendCommandAsync(command, FreeStylerMouse.Click))
            return false;

        await Task.Delay(duration);

        return await SendCommandAsync(command, FreeStylerMouse.Release);
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose()
        => _client.Close();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <param name="request"></param>
    private IEnumerable<string> ParseResponse(string str, string request = ",")
    {
        if (!str.StartsWith(request)) yield break;
        str = str.Remove(0, 5);

        var fields = str.Split(',');
        foreach (var field in fields)
            if (!string.IsNullOrEmpty(field) && field.Length > 1) yield return field;
    }
}
