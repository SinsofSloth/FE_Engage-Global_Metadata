// Namespace: System.Net
[Serializable]
public class IPAddress // TypeDefIndex: 2460
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	internal long m_Address; // 0x10
	internal string m_ToString; // 0x18
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private AddressFamily m_Family; // 0x20
	private ushort[] m_Numbers; // 0x28
	private long m_ScopeId; // 0x30
	private int m_HashCode; // 0x38
	internal const int IPv4AddressBytes = 4;
	internal const int IPv6AddressBytes = 16;
	internal const int NumberOfLabels = 8;

	// Properties
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }

	// Methods

	// RVA: 0x1AF2DC0 Offset: 0x1AF2EC1 VA: 0x1AF2DC0
	public void .ctor(long newAddress) { }

	// RVA: 0x1AF2EA0 Offset: 0x1AF2FA1 VA: 0x1AF2EA0
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1AF31D0 Offset: 0x1AF32D1 VA: 0x1AF31D0
	private void .ctor(ushort[] address, uint scopeid) { }

	// RVA: 0x1AF3280 Offset: 0x1AF3381 VA: 0x1AF3280
	internal void .ctor(int newAddress) { }

	// RVA: 0x1AD9E40 Offset: 0x1AD9F41 VA: 0x1AD9E40
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x1AD9A80 Offset: 0x1AD9B81 VA: 0x1AD9A80
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x1AF3310 Offset: 0x1AF3411 VA: 0x1AF3310
	private static IPAddress InternalParse(string ipString, bool tryParse) { }

	// RVA: 0x1AE65F0 Offset: 0x1AE66F1 VA: 0x1AE65F0
	public byte[] GetAddressBytes() { }

	// RVA: 0x1AF3780 Offset: 0x1AF3881 VA: 0x1AF3780
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1AF3790 Offset: 0x1AF3891 VA: 0x1AF3790
	public long get_ScopeId() { }

	// RVA: 0x1AF37F0 Offset: 0x1AF38F1 VA: 0x1AF37F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AF3990 Offset: 0x1AF3A91 VA: 0x1AF3990
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x1AF3AA0 Offset: 0x1AF3BA1 VA: 0x1AF3AA0
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1AF3CA0 Offset: 0x1AF3DA1 VA: 0x1AF3CA0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1AF3CB0 Offset: 0x1AF3DB1 VA: 0x1AF3CB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AF3DC0 Offset: 0x1AF3EC1 VA: 0x1AF3DC0
	public IPAddress MapToIPv6() { }

	// RVA: 0x1AF3F10 Offset: 0x1AF4011 VA: 0x1AF3F10
	private static void .cctor() { }
}

