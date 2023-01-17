// Namespace: 
private enum RelaySequence.Label // TypeDefIndex: 12956
{
	// Fields
	public int value__; // 0x0
	public const RelaySequence.Label Entry = 0;
	public const RelaySequence.Label ModeMenu = 1;
	public const RelaySequence.Label New = 2;
	public const RelaySequence.Label NewDisposPlayerCounts = 3;
	public const RelaySequence.Label NewMapSelect = 4;
	public const RelaySequence.Label NewSetup = 5;
	public const RelaySequence.Label TakeOver = 6;
	public const RelaySequence.Label TakeOverModeSelect = 7;
	public const RelaySequence.Label TakeOverSearch = 8;
	public const RelaySequence.Label TakeOverSearchDisposPlayerCounts = 9;
	public const RelaySequence.Label TakeOverPostsearchBranch = 10;
	public const RelaySequence.Label TakeOverRandomSelect = 11;
	public const RelaySequence.Label TakeOverDataCode = 12;
	public const RelaySequence.Label TakeOverPredownloadMetaWithDataCode = 13;
	public const RelaySequence.Label TakeOverDataCodeDisposPlayerCounts = 14;
	public const RelaySequence.Label TakeOverDownloadMetaWithDataCode = 15;
	public const RelaySequence.Label TakeOverShow = 16;
	public const RelaySequence.Label TakeOverDataMenu = 17;
	public const RelaySequence.Label TakeOverDownload = 18;
	public const RelaySequence.Label Replay = 19;
	public const RelaySequence.Label ReplayDataMenu = 20;
	public const RelaySequence.Label ReplayDownload = 21;
	public const RelaySequence.Label MapSequence = 22;
	public const RelaySequence.Label Award = 23;
	public const RelaySequence.Label NoTicket = 24;
	public const RelaySequence.Label NoSelectableMap = 25;
	public const RelaySequence.Label NotFoundMapForTakeOverRandom = 26;
	public const RelaySequence.Label NotFoundMapForTakeOverDataCode = 27;
	public const RelaySequence.Label CantTakeOverSelfCreate = 28;
	public const RelaySequence.Label CantTakeOverEnd = 29;
	public const RelaySequence.Label CantTakeOverOtherPlaying = 30;
	public const RelaySequence.Label CantTakeOverAlreadyPlayed = 31;
	public const RelaySequence.Label CantTakeOverLackOfUnit = 32;
	public const RelaySequence.Label CantTakeOverUnknown = 33;
	public const RelaySequence.Label NotFoundMapForReplay = 34;
	public const RelaySequence.Label NoEnteredMap = 35;
	public const RelaySequence.Label CantGetByDeletingForTakeOver = 36;
	public const RelaySequence.Label CantGetByDeletingForReplay = 37;
	public const RelaySequence.Label InvalidDownloadDataForTakeOver = 38;
	public const RelaySequence.Label InvalidDownloadDataForReplay = 39;
	public const RelaySequence.Label RestoreAndReturnToModeMenu = 40;
	public const RelaySequence.Label RestoreAndReturnToTakeOverModeSelect = 41;
	public const RelaySequence.Label Shutdown = 42;
	public const RelaySequence.Label End = 43;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2788C0 Offset: 0x2789C1 VA: 0x2788C0
[Serializable]
private sealed class RelaySequence.RelaySequenceBase.<>c<T> // TypeDefIndex: 12958
{
	// Fields
	public static readonly RelaySequence.RelaySequenceBase.<>c<T> <>9; // 0x0
	public static Action<Unit> <>9__14_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33E40 Offset: 0x2B33F41 VA: 0x2B33E40
	|-RelaySequence.RelaySequenceBase.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33F20 Offset: 0x2B34021 VA: 0x2B33F20
	|-RelaySequence.RelaySequenceBase.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <Backup>b__14_0(Unit unit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33F30 Offset: 0x2B34031 VA: 0x2B33F30
	|-RelaySequence.RelaySequenceBase.<>c<object>.<Backup>b__14_0
	*/
}

// Namespace: 
private class RelaySequence.RelaySequenceLocal : RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal> // TypeDefIndex: 12960
{
	// Fields
	private string m_RootPath; // 0xC0

	// Methods

	// RVA: 0x1F42160 Offset: 0x1F42261 VA: 0x1F42160 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1F42210 Offset: 0x1F42311 VA: 0x1F42210
	private void InitializeLanRootPath() { }

	// RVA: 0x1F42470 Offset: 0x1F42571 VA: 0x1F42470 Slot: 27
	protected override void TakeOverSearchImpl() { }

	// RVA: 0x1F42790 Offset: 0x1F42891 VA: 0x1F42790 Slot: 28
	protected override void TakeOverPostsearchImpl() { }

	// RVA: 0x1F427F0 Offset: 0x1F428F1 VA: 0x1F427F0 Slot: 29
	protected override void TakeOverDownloadMetaWithDataCodeImpl() { }

	// RVA: 0x1F42800 Offset: 0x1F42901 VA: 0x1F42800 Slot: 30
	protected override void TakeOverPostdownloadMetaWithDataCodeImpl() { }

	// RVA: 0x1F42870 Offset: 0x1F42971 VA: 0x1F42870 Slot: 31
	protected override void TakeOverSetPlayingImpl() { }

	// RVA: 0x1F42880 Offset: 0x1F42981 VA: 0x1F42880 Slot: 32
	protected override void TakeOverPostsetPlayingImpl() { }

	// RVA: 0x1F42890 Offset: 0x1F42991 VA: 0x1F42890 Slot: 33
	protected override void ReplaySearchEnteredImpl() { }

	// RVA: 0x1F42A70 Offset: 0x1F42B71 VA: 0x1F42A70 Slot: 34
	protected override void ReplaySearchAnyImpl() { }

	// RVA: 0x1F42BE0 Offset: 0x1F42CE1 VA: 0x1F42BE0 Slot: 35
	protected override void ReplayPostsearchImpl() { }

	// RVA: 0x1F42C40 Offset: 0x1F42D41 VA: 0x1F42C40 Slot: 36
	protected override void DownloadImpl(bool withMetaData) { }

	// RVA: 0x1F42F10 Offset: 0x1F43011 VA: 0x1F42F10 Slot: 37
	protected override void PostdownloadTakeOverImpl() { }

	// RVA: 0x1F42F70 Offset: 0x1F43071 VA: 0x1F42F70 Slot: 38
	protected override void PostdownloadReplayImpl() { }

	// RVA: 0x1F42FD0 Offset: 0x1F430D1 VA: 0x1F42FD0 Slot: 39
	protected override void UploadImpl() { }

	// RVA: 0x1F434D0 Offset: 0x1F435D1 VA: 0x1F434D0 Slot: 40
	protected override void PostuploadImpl() { }

	// RVA: 0x1F42E40 Offset: 0x1F42F41 VA: 0x1F42E40
	private static string GetDataFileName(RelayServerMetaData metaData) { }

	// RVA: 0x1F43470 Offset: 0x1F43571 VA: 0x1F43470
	private static string GetMetaDataFileName(RelayServerMetaData metaData) { }

	// RVA: 0x1F43300 Offset: 0x1F43401 VA: 0x1F43300
	private static ulong GetPseudoPrincipalId(string playerName) { }

	// RVA: 0x1F425E0 Offset: 0x1F426E1 VA: 0x1F425E0
	private static ulong GetPseudoDataId(string metaPath) { }

	// RVA: 0x1F43540 Offset: 0x1F43641 VA: 0x1F43540
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F435A0 Offset: 0x1F436A1 VA: 0x1F435A0
	public void .ctor() { }
}

