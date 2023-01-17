// Namespace: System.Net.Sockets
[FlagsAttribute] // RVA: 0x31230 Offset: 0x31331 VA: 0x31230
public enum SocketFlags // TypeDefIndex: 2630
{
	// Fields
	public int value__; // 0x0
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;
}

