// Namespace: NexPlugin
public class NotificationEvent // TypeDefIndex: 14860
{
	// Fields
	internal ulong param1; // 0x10
	internal ulong param2; // 0x18
	internal Common.NotificationEvents type; // 0x20
	internal uint subType; // 0x24
	internal string stringParam; // 0x28
	internal ulong pid; // 0x30

	// Methods

	// RVA: 0x235DF00 Offset: 0x235E001 VA: 0x235DF00
	public ulong GetSource() { }

	// RVA: 0x235DF10 Offset: 0x235E011 VA: 0x235DF10
	public Common.NotificationEvents GetType() { }

	// RVA: 0x235DF20 Offset: 0x235E021 VA: 0x235DF20
	public uint GetSubType() { }

	// RVA: 0x235DF30 Offset: 0x235E031 VA: 0x235DF30
	public ulong GetParam1() { }

	// RVA: 0x235DF40 Offset: 0x235E041 VA: 0x235DF40
	public ulong GetParam2() { }

	// RVA: 0x235DF50 Offset: 0x235E051 VA: 0x235DF50
	public string GetStringParam() { }

	// RVA: 0x235DF60 Offset: 0x235E061 VA: 0x235DF60
	public void Trace() { }

	// RVA: 0x235DF70 Offset: 0x235E071 VA: 0x235DF70
	internal string ToString() { }

	// RVA: 0x235E210 Offset: 0x235E311 VA: 0x235E210
	public void .ctor() { }
}

