// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase // TypeDefIndex: 1544
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x1BCBBA0 Offset: 0x1BCBCA1 VA: 0x1BCBBA0
	protected void .ctor(int messageType) { }

	// RVA: 0x1BCBBD0 Offset: 0x1BCBCD1 VA: 0x1BCBBD0
	public NtlmFlags get_Flags() { }

	// RVA: 0x1BCBBE0 Offset: 0x1BCBCE1 VA: 0x1BCBBE0
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x1BCBBF0 Offset: 0x1BCBCF1 VA: 0x1BCBBF0
	public int get_Type() { }

	// RVA: 0x1BCBC00 Offset: 0x1BCBD01 VA: 0x1BCBC00
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x1BCBD10 Offset: 0x1BCBE11 VA: 0x1BCBD10 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1BCBEB0 Offset: 0x1BCBFB1 VA: 0x1BCBEB0
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x1BCBFE0 Offset: 0x1BCC0E1 VA: 0x1BCBFE0
	private static void .cctor() { }
}

