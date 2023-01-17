// Namespace: App
public class VersusUserData // TypeDefIndex: 13780
{
	// Fields
	private const int Version = 2;
	private short m_Rate; // 0x10
	private ulong m_DataId; // 0x18

	// Properties
	public ulong DataId { get; }
	public int Rate { get; }

	// Methods

	// RVA: 0x26BE5A0 Offset: 0x26BE6A1 VA: 0x26BE5A0
	public void .ctor() { }

	// RVA: 0x26BE5D0 Offset: 0x26BE6D1 VA: 0x26BE5D0
	public void Clear() { }

	// RVA: 0x26BE5E0 Offset: 0x26BE6E1 VA: 0x26BE5E0
	public void SetUploadedInfo(ulong dataId) { }

	// RVA: 0x26BE5F0 Offset: 0x26BE6F1 VA: 0x26BE5F0
	public void SetRate(int rate) { }

	[ConditionalAttribute] // RVA: 0x2CD520 Offset: 0x2CD621 VA: 0x2CD520
	// RVA: 0x26BE600 Offset: 0x26BE701 VA: 0x26BE600
	public void Dump(string mess = "") { }

	// RVA: 0x26BE7E0 Offset: 0x26BE8E1 VA: 0x26BE7E0
	public void Serialize(Stream stream) { }

	// RVA: 0x26BE840 Offset: 0x26BE941 VA: 0x26BE840
	public void Deserialize(Stream stream) { }

	// RVA: 0x26BE9C0 Offset: 0x26BEAC1 VA: 0x26BE9C0
	public ulong get_DataId() { }

	// RVA: 0x26BE9D0 Offset: 0x26BEAD1 VA: 0x26BE9D0
	public int get_Rate() { }
}

