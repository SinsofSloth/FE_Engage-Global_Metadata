// Namespace: App
public class VersusServerCasualMetaData : VersusServerMetaData // TypeDefIndex: 13772
{
	// Fields
	private const ushort Version = 2;
	private ulong m_OwnerId; // 0x30
	private string m_OwnerName; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29CB60 Offset: 0x29CC61 VA: 0x29CB60
	private string <FriendName>k__BackingField; // 0x40

	// Properties
	public ulong OwnerId { get; }
	public string OwnerName { get; }
	public string FriendName { get; set; }

	// Methods

	// RVA: 0x2A55D00 Offset: 0x2A55E01 VA: 0x2A55D00
	public void .ctor() { }

	// RVA: 0x2A55E30 Offset: 0x2A55F31 VA: 0x2A55E30 Slot: 4
	public override void Clear() { }

	// RVA: 0x2A55F00 Offset: 0x2A56001 VA: 0x2A55F00
	public void SetOwnerInfo(ulong ownerId, string ownerName) { }

	// RVA: 0x2A55F10 Offset: 0x2A56011 VA: 0x2A55F10 Slot: 5
	public override void CopyFrom(VersusServerMetaData metaData) { }

	// RVA: 0x2A56070 Offset: 0x2A56171 VA: 0x2A56070
	public string GetOwnerName() { }

	[ConditionalAttribute] // RVA: 0x2CD3E0 Offset: 0x2CD4E1 VA: 0x2CD3E0
	// RVA: 0x2A560A0 Offset: 0x2A561A1 VA: 0x2A560A0
	public void Dump(string opt = "") { }

	// RVA: 0x2A56300 Offset: 0x2A56401 VA: 0x2A56300 Slot: 6
	public override void Serialize() { }

	// RVA: 0x2A564B0 Offset: 0x2A565B1 VA: 0x2A564B0 Slot: 7
	public override bool Deserialize() { }

	// RVA: 0x2A56A60 Offset: 0x2A56B61 VA: 0x2A56A60
	public ulong get_OwnerId() { }

	// RVA: 0x2A56A70 Offset: 0x2A56B71 VA: 0x2A56A70
	public string get_OwnerName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD420 Offset: 0x2CD521 VA: 0x2CD420
	// RVA: 0x2A56A80 Offset: 0x2A56B81 VA: 0x2A56A80
	public string get_FriendName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD430 Offset: 0x2CD531 VA: 0x2CD430
	// RVA: 0x2A56A90 Offset: 0x2A56B91 VA: 0x2A56A90
	public void set_FriendName(string value) { }
}

