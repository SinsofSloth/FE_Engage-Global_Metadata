// Namespace: App
public class GameUserGlobalData : SingletonClass<GameUserGlobalData> // TypeDefIndex: 13616
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C700 Offset: 0x29C801 VA: 0x29C700
	private GameSaveData.Types <LastSaveDataType>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x29C710 Offset: 0x29C811 VA: 0x29C710
	private int <LastSaveDataIndex>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29C720 Offset: 0x29C821 VA: 0x29C720
	private uint <IdentifierCount>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x29C730 Offset: 0x29C831 VA: 0x29C730
	private readonly GameUserGlobalData.FlagsField <Flag>k__BackingField; // 0x28
	private HashSet<string> m_CompletedHash; // 0x30
	private List<string> m_CompletedList; // 0x38

	// Properties
	protected override int Version { get; }
	private GameSaveData.Types LastSaveDataType { get; set; }
	private int LastSaveDataIndex { get; set; }
	public uint IdentifierCount { get; set; }
	public GameUserGlobalData.FlagsField Flag { get; }

	// Methods

	// RVA: 0x28DABD0 Offset: 0x28DACD1 VA: 0x28DABD0
	public void .ctor() { }

	// RVA: 0x28DADA0 Offset: 0x28DAEA1 VA: 0x28DADA0
	public void Reset() { }

	// RVA: 0x28DAE30 Offset: 0x28DAF31 VA: 0x28DAE30
	public GameSaveData.Types GetLastSaveDataType() { }

	// RVA: 0x28DAE40 Offset: 0x28DAF41 VA: 0x28DAE40
	public int GetLastSaveDataIndex() { }

	// RVA: 0x28DAE50 Offset: 0x28DAF51 VA: 0x28DAE50
	public int GetLastSaveDataIndex(GameSaveData.Types type) { }

	// RVA: 0x28DAE70 Offset: 0x28DAF71 VA: 0x28DAE70
	public void SetLastSaveDataInfo(GameSaveData.Types type, int index) { }

	// RVA: 0x28DAE80 Offset: 0x28DAF81 VA: 0x28DAE80
	public bool IsLastSaveDataInfo(GameSaveData.Types type, int index) { }

	// RVA: 0x28DAEB0 Offset: 0x28DAFB1 VA: 0x28DAEB0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x28DAEC0 Offset: 0x28DAFC1 VA: 0x28DAEC0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x28DB0E0 Offset: 0x28DB1E1 VA: 0x28DB0E0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC400 Offset: 0x2CC501 VA: 0x2CC400
	// RVA: 0x28DB7E0 Offset: 0x28DB8E1 VA: 0x28DB7E0
	private GameSaveData.Types get_LastSaveDataType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC410 Offset: 0x2CC511 VA: 0x2CC410
	// RVA: 0x28DB7F0 Offset: 0x28DB8F1 VA: 0x28DB7F0
	private void set_LastSaveDataType(GameSaveData.Types value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC420 Offset: 0x2CC521 VA: 0x2CC420
	// RVA: 0x28DB800 Offset: 0x28DB901 VA: 0x28DB800
	private int get_LastSaveDataIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC430 Offset: 0x2CC531 VA: 0x2CC430
	// RVA: 0x28DB810 Offset: 0x28DB911 VA: 0x28DB810
	private void set_LastSaveDataIndex(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC440 Offset: 0x2CC541 VA: 0x2CC440
	// RVA: 0x28DB820 Offset: 0x28DB921 VA: 0x28DB820
	public uint get_IdentifierCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC450 Offset: 0x2CC551 VA: 0x2CC450
	// RVA: 0x28DB830 Offset: 0x28DB931 VA: 0x28DB830
	public void set_IdentifierCount(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC460 Offset: 0x2CC561 VA: 0x2CC460
	// RVA: 0x28DB840 Offset: 0x28DB941 VA: 0x28DB840
	public GameUserGlobalData.FlagsField get_Flag() { }

	// RVA: 0x28D5200 Offset: 0x28D5301 VA: 0x28D5200
	public void Completed() { }

	// RVA: 0x28D5600 Offset: 0x28D5701 VA: 0x28D5600
	public void ClearCompleted() { }

	// RVA: 0x28DB850 Offset: 0x28DB951 VA: 0x28DB850
	public bool IsCompleted() { }

	// RVA: 0x28D5070 Offset: 0x28D5171 VA: 0x28D5070
	public void SetCompleted(ChapterData chapter) { }

	// RVA: 0x28DB8B0 Offset: 0x28DB9B1 VA: 0x28DB8B0
	public void ClearCompleted(ChapterData chapter) { }

	// RVA: 0x28DB970 Offset: 0x28DBA71 VA: 0x28DB970
	public bool IsCompleted(string cid) { }

	// RVA: 0x28D16F0 Offset: 0x28D17F1 VA: 0x28D16F0
	public static ulong CreateIdentifier() { }
}

