// Namespace: App
public class VersusServerRankedMetaData : VersusServerMetaData // TypeDefIndex: 13776
{
	// Fields
	private const ushort Version = 4;
	private ushort m_Version; // 0x30
	private ulong m_OwnerId; // 0x38
	private string m_OwnerName; // 0x40
	private ulong m_SaveIdentifier; // 0x48
	private short m_Rate; // 0x50
	private DateTime m_SaveTime; // 0x58
	private ulong m_ScreenShotDataId; // 0x60
	private string m_Language; // 0x68
	public const short INITIAL_RATE = 1500;
	[CompilerGeneratedAttribute] // RVA: 0x29CB70 Offset: 0x29CC71 VA: 0x29CB70
	private string <FriendName>k__BackingField; // 0x70

	// Properties
	public ulong OwnerId { get; }
	public string OwnerName { get; }
	public ulong SaveIdentifier { get; }
	public int Rate { get; }
	public DateTime SaveTime { get; }
	public ulong ScreenShotDataId { get; }
	public string Language { get; }
	public string FriendName { get; set; }

	// Methods

	// RVA: 0x2A44BC0 Offset: 0x2A44CC1 VA: 0x2A44BC0
	public void .ctor() { }

	// RVA: 0x2A57250 Offset: 0x2A57351 VA: 0x2A57250 Slot: 4
	public override void Clear() { }

	// RVA: 0x2A57350 Offset: 0x2A57451 VA: 0x2A57350
	public void SetOwner(ulong principalId, string name, ulong saveId) { }

	// RVA: 0x2A57390 Offset: 0x2A57491 VA: 0x2A57390
	public void SetRate(int rate) { }

	// RVA: 0x2A573A0 Offset: 0x2A574A1 VA: 0x2A573A0
	public void SetSaveTime(DateTime dateTime) { }

	// RVA: 0x2A573B0 Offset: 0x2A574B1 VA: 0x2A573B0
	public void SetScreenShotDataId(ulong dataId) { }

	// RVA: 0x2A573C0 Offset: 0x2A574C1 VA: 0x2A573C0
	public void SetLanguage(string language) { }

	// RVA: 0x2A573D0 Offset: 0x2A574D1 VA: 0x2A573D0 Slot: 5
	public override void CopyFrom(VersusServerMetaData metaData) { }

	// RVA: 0x2A57500 Offset: 0x2A57601 VA: 0x2A57500
	public string GetOwnerName() { }

	// RVA: 0x2A57530 Offset: 0x2A57631 VA: 0x2A57530 Slot: 6
	public override void Serialize() { }

	// RVA: 0x2A57740 Offset: 0x2A57841 VA: 0x2A57740 Slot: 7
	public override bool Deserialize() { }

	[ConditionalAttribute] // RVA: 0x2CD440 Offset: 0x2CD541 VA: 0x2CD440
	// RVA: 0x2A58150 Offset: 0x2A58251 VA: 0x2A58150
	public void Dump(string opt = "") { }

	// RVA: 0x2A58570 Offset: 0x2A58671 VA: 0x2A58570
	public ulong get_OwnerId() { }

	// RVA: 0x2A58580 Offset: 0x2A58681 VA: 0x2A58580
	public string get_OwnerName() { }

	// RVA: 0x2A58590 Offset: 0x2A58691 VA: 0x2A58590
	public ulong get_SaveIdentifier() { }

	// RVA: 0x2A585A0 Offset: 0x2A586A1 VA: 0x2A585A0
	public int get_Rate() { }

	// RVA: 0x2A585B0 Offset: 0x2A586B1 VA: 0x2A585B0
	public DateTime get_SaveTime() { }

	// RVA: 0x2A585C0 Offset: 0x2A586C1 VA: 0x2A585C0
	public ulong get_ScreenShotDataId() { }

	// RVA: 0x2A585D0 Offset: 0x2A586D1 VA: 0x2A585D0
	public string get_Language() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD480 Offset: 0x2CD581 VA: 0x2CD480
	// RVA: 0x2A585E0 Offset: 0x2A586E1 VA: 0x2A585E0
	public string get_FriendName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD490 Offset: 0x2CD591 VA: 0x2CD490
	// RVA: 0x2A585F0 Offset: 0x2A586F1 VA: 0x2A585F0
	public void set_FriendName(string value) { }
}

