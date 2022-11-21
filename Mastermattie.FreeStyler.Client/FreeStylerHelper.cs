namespace Mastermattie.FreeStyler.Client
{
    public static class FreeStylerHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="state"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static byte[] CreateCommandPacket(FreeStylerCommand command, byte state = 0x00, params byte[] args)
        {
            var packet = new byte[9] { (byte)'F', (byte)'S', (byte)'O', (byte)'D', 0x00, 0x00, 0x00, 0x00, 0x00 };

            var cmd = BitConverter.GetBytes((short)command);

            if (!BitConverter.IsLittleEndian)
                Array.Reverse(cmd);

            packet[4] = cmd[0];
            packet[5] = cmd[1];
            packet[6] = state;

            if (args.Length >= 1)
                packet[7] = args[0];

            if (args.Length >= 2)
                packet[8] = args[1];

            return packet;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <param name="state"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static byte[] CreateRequestPacket(FreeStylerRequest request, params byte[] args)
        {
            var packet = new byte[9] { (byte)'F', (byte)'S', (byte)'B', (byte)'C', 0x00, 0x00, 0x00, 0x00, 0x00 };

            var cmd = BitConverter.GetBytes((uint)request);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(cmd);

            packet[4] = cmd[1];
            packet[5] = cmd[2];
            packet[6] = cmd[3];
            
            if (args.Length >= 2)
                packet[7] = args[1];
            
            if (args.Length >= 3)
                packet[8] = args[2];

            return packet;
        }
    }
}
