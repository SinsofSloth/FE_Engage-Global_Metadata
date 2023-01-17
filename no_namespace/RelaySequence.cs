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
private interface RelaySequence.IRelaySequenceBase // TypeDefIndex: 12957
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void JumpTo(RelaySequence.Label label);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SelectMode(Relay.Modes mode);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SelectMap(string cid);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SelectTakeOverMode(Relay.TakeOverModes mode);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetPublic(bool enable);
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
private abstract class RelaySequence.RelaySequenceBase<T> : SingletonProcInst<T>, RelaySequence.IRelaySequenceBase // TypeDefIndex: 12959
{
	// Fields
	protected List<RelayServerMetaData> m_SearchResults; // 0x0
	protected RelayServerMetaData m_DownloadMetaResult; // 0x0
	protected string m_DataCode; // 0x0
	protected RelayReplayCache m_ReplayCache; // 0x0
	protected bool m_IsPublic; // 0x0
	private Relay.Modes m_Mode; // 0x0
	protected Relay.TakeOverModes m_TakeOverMode; // 0x0
	private string m_Cid; // 0x0
	private bool m_IsAwarded; // 0x0
	private MenuBg m_Bg; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	protected override void OnCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9E00 Offset: 0x2FE9F01 VA: 0x2FE9E00
	|-RelaySequence.RelaySequenceBase<object>.OnCreate
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.OnCreate
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.OnCreate
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9EC0 Offset: 0x2FE9FC1 VA: 0x2FE9EC0
	|-RelaySequence.RelaySequenceBase<object>.OnDispose
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.OnDispose
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.OnDispose
	*/

	// RVA: -1 Offset: -1 Slot: 15
	protected override void OnShutdown() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE9F80 Offset: 0x2FEA081 VA: 0x2FE9F80
	|-RelaySequence.RelaySequenceBase<object>.OnShutdown
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.OnShutdown
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.OnShutdown
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void JumpTo(RelaySequence.Label label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA010 Offset: 0x2FEA111 VA: 0x2FEA010
	|-RelaySequence.RelaySequenceBase<object>.JumpTo
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.JumpTo
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.JumpTo
	*/

	// RVA: -1 Offset: -1
	private void Backup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA090 Offset: 0x2FEA191 VA: 0x2FEA090
	|-RelaySequence.RelaySequenceBase<object>.Backup
	*/

	// RVA: -1 Offset: -1
	private void RestoreFromBackup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA2E0 Offset: 0x2FEA3E1 VA: 0x2FEA2E0
	|-RelaySequence.RelaySequenceBase<object>.RestoreFromBackup
	*/

	// RVA: -1 Offset: -1
	private void RestoreFromBackupForShutdown() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA6F0 Offset: 0x2FEA7F1 VA: 0x2FEA6F0
	|-RelaySequence.RelaySequenceBase<object>.RestoreFromBackupForShutdown
	*/

	// RVA: -1 Offset: -1
	private void LoadResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA7D0 Offset: 0x2FEA8D1 VA: 0x2FEA7D0
	|-RelaySequence.RelaySequenceBase<object>.LoadResources
	*/

	// RVA: -1 Offset: -1
	private bool IsLoadingResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA880 Offset: 0x2FEA981 VA: 0x2FEA880
	|-RelaySequence.RelaySequenceBase<object>.IsLoadingResources
	*/

	// RVA: -1 Offset: -1
	private void End() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEA940 Offset: 0x2FEAA41 VA: 0x2FEA940
	|-RelaySequence.RelaySequenceBase<object>.End
	*/

	// RVA: -1 Offset: -1
	private void OpenTitleBar() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEAB00 Offset: 0x2FEAC01 VA: 0x2FEAB00
	|-RelaySequence.RelaySequenceBase<object>.OpenTitleBar
	*/

	// RVA: -1 Offset: -1
	private void CloseTitleBar() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEACF0 Offset: 0x2FEADF1 VA: 0x2FEACF0
	|-RelaySequence.RelaySequenceBase<object>.CloseTitleBar
	*/

	// RVA: -1 Offset: -1
	private void CreateBg() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEAE50 Offset: 0x2FEAF51 VA: 0x2FEAE50
	|-RelaySequence.RelaySequenceBase<object>.CreateBg
	*/

	// RVA: -1 Offset: -1
	private void DestroyBg() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEAEF0 Offset: 0x2FEAFF1 VA: 0x2FEAEF0
	|-RelaySequence.RelaySequenceBase<object>.DestroyBg
	*/

	// RVA: -1 Offset: -1
	private void UpdateProfileCard() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEAF30 Offset: 0x2FEB031 VA: 0x2FEAF30
	|-RelaySequence.RelaySequenceBase<object>.UpdateProfileCard
	*/

	// RVA: -1 Offset: -1
	private void ModeMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEAFB0 Offset: 0x2FEB0B1 VA: 0x2FEAFB0
	|-RelaySequence.RelaySequenceBase<object>.ModeMenu
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public void SelectMode(Relay.Modes mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEAFE0 Offset: 0x2FEB0E1 VA: 0x2FEAFE0
	|-RelaySequence.RelaySequenceBase<object>.SelectMode
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.SelectMode
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.SelectMode
	*/

	// RVA: -1 Offset: -1
	private void DisposPlayerCounts() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB090 Offset: 0x2FEB191 VA: 0x2FEB090
	|-RelaySequence.RelaySequenceBase<object>.DisposPlayerCounts
	*/

	// RVA: -1 Offset: -1
	private void NewMapSelectMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB120 Offset: 0x2FEB221 VA: 0x2FEB120
	|-RelaySequence.RelaySequenceBase<object>.NewMapSelectMenu
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public void SelectMap(string cid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB280 Offset: 0x2FEB381 VA: 0x2FEB280
	|-RelaySequence.RelaySequenceBase<object>.SelectMap
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.SelectMap
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.SelectMap
	*/

	// RVA: -1 Offset: -1
	private void NewSetup() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB380 Offset: 0x2FEB481 VA: 0x2FEB380
	|-RelaySequence.RelaySequenceBase<object>.NewSetup
	*/

	// RVA: -1 Offset: -1
	private void TakeOverModeMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB520 Offset: 0x2FEB621 VA: 0x2FEB520
	|-RelaySequence.RelaySequenceBase<object>.TakeOverModeMenu
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public void SelectTakeOverMode(Relay.TakeOverModes mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB6E0 Offset: 0x2FEB7E1 VA: 0x2FEB6E0
	|-RelaySequence.RelaySequenceBase<object>.SelectTakeOverMode
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.SelectTakeOverMode
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.SelectTakeOverMode
	*/

	// RVA: -1 Offset: -1
	private void TakeOverSearch() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB7B0 Offset: 0x2FEB8B1 VA: 0x2FEB7B0
	|-RelaySequence.RelaySequenceBase<object>.TakeOverSearch
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract void TakeOverSearchImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.TakeOverSearchImpl
	*/

	// RVA: -1 Offset: -1
	private void TakeOverPostsearch() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB880 Offset: 0x2FEB981 VA: 0x2FEB880
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostsearch
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract void TakeOverPostsearchImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostsearchImpl
	*/

	// RVA: -1 Offset: -1
	protected void TakeOverPostsearchSucceeded(ulong principalId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB890 Offset: 0x2FEB991 VA: 0x2FEB890
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostsearchSucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.TakeOverPostsearchSucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.TakeOverPostsearchSucceeded
	*/

	// RVA: -1 Offset: -1
	protected bool CanSelectTakeOver(RelayServerMetaData metaDataFromServer, ulong principalId, out Relay.CstoResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEB9E0 Offset: 0x2FEBAE1 VA: 0x2FEB9E0
	|-RelaySequence.RelaySequenceBase<object>.CanSelectTakeOver
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.CanSelectTakeOver
	*/

	// RVA: -1 Offset: -1
	protected bool CanSelectTakeOver(RelayServerMetaData metaDataFromServer, ulong principalId, long currentUnixTime, out Relay.CstoResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBA90 Offset: 0x2FEBB91 VA: 0x2FEBA90
	|-RelaySequence.RelaySequenceBase<object>.CanSelectTakeOver
	*/

	// RVA: -1 Offset: -1
	private void TakeOverPostsearchBranch() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBB70 Offset: 0x2FEBC71 VA: 0x2FEBB70
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostsearchBranch
	*/

	// RVA: -1 Offset: -1
	private void TakeOverRandomSelect() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBC20 Offset: 0x2FEBD21 VA: 0x2FEBC20
	|-RelaySequence.RelaySequenceBase<object>.TakeOverRandomSelect
	*/

	// RVA: -1 Offset: -1
	private void InputDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBD60 Offset: 0x2FEBE61 VA: 0x2FEBD60
	|-RelaySequence.RelaySequenceBase<object>.InputDataCode
	*/

	// RVA: -1 Offset: -1
	private void ConfirmSearchDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBE50 Offset: 0x2FEBF51 VA: 0x2FEBE50
	|-RelaySequence.RelaySequenceBase<object>.ConfirmSearchDataCode
	*/

	// RVA: -1 Offset: -1
	private void TakeOverDownloadMetaWithDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBF40 Offset: 0x2FEC041 VA: 0x2FEBF40
	|-RelaySequence.RelaySequenceBase<object>.TakeOverDownloadMetaWithDataCode
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract void TakeOverDownloadMetaWithDataCodeImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.TakeOverDownloadMetaWithDataCodeImpl
	*/

	// RVA: -1 Offset: -1
	private void TakeOverPostdownloadMetaWithDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBFE0 Offset: 0x2FEC0E1 VA: 0x2FEBFE0
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostdownloadMetaWithDataCode
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void TakeOverPostdownloadMetaWithDataCodeImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostdownloadMetaWithDataCodeImpl
	*/

	// RVA: -1 Offset: -1
	private void TakeOverShow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEBFF0 Offset: 0x2FEC0F1 VA: 0x2FEBFF0
	|-RelaySequence.RelaySequenceBase<object>.TakeOverShow
	*/

	// RVA: -1 Offset: -1
	private void TakeOverSetPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC0A0 Offset: 0x2FEC1A1 VA: 0x2FEC0A0
	|-RelaySequence.RelaySequenceBase<object>.TakeOverSetPlaying
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected abstract void TakeOverSetPlayingImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.TakeOverSetPlayingImpl
	*/

	// RVA: -1 Offset: -1
	private void TakeOverPostsetPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC0B0 Offset: 0x2FEC1B1 VA: 0x2FEC0B0
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostsetPlaying
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract void TakeOverPostsetPlayingImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.TakeOverPostsetPlayingImpl
	*/

	// RVA: -1 Offset: -1
	private void ReplaySearch() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC0C0 Offset: 0x2FEC1C1 VA: 0x2FEC0C0
	|-RelaySequence.RelaySequenceBase<object>.ReplaySearch
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract void ReplaySearchEnteredImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.ReplaySearchEnteredImpl
	*/

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract void ReplaySearchAnyImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.ReplaySearchAnyImpl
	*/

	// RVA: -1 Offset: -1
	private void ReplayPostsearch() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC2E0 Offset: 0x2FEC3E1 VA: 0x2FEC2E0
	|-RelaySequence.RelaySequenceBase<object>.ReplayPostsearch
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract void ReplayPostsearchImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.ReplayPostsearchImpl
	*/

	// RVA: -1 Offset: -1
	protected void ReplayPostsearchSucceeded(bool isCacheUsed = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC2F0 Offset: 0x2FEC3F1 VA: 0x2FEC2F0
	|-RelaySequence.RelaySequenceBase<object>.ReplayPostsearchSucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.ReplayPostsearchSucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.ReplayPostsearchSucceeded
	*/

	// RVA: -1 Offset: -1
	private void ReplayDataMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC440 Offset: 0x2FEC541 VA: 0x2FEC440
	|-RelaySequence.RelaySequenceBase<object>.ReplayDataMenu
	*/

	// RVA: -1 Offset: -1
	private void DownloadTakeOver() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC600 Offset: 0x2FEC701 VA: 0x2FEC600
	|-RelaySequence.RelaySequenceBase<object>.DownloadTakeOver
	*/

	// RVA: -1 Offset: -1
	private void DownloadReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC620 Offset: 0x2FEC721 VA: 0x2FEC620
	|-RelaySequence.RelaySequenceBase<object>.DownloadReplay
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void DownloadImpl(bool withMetaData);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.DownloadImpl
	*/

	// RVA: -1 Offset: -1
	private void PostdownloadTakeOver() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC6C0 Offset: 0x2FEC7C1 VA: 0x2FEC6C0
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadTakeOver
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract void PostdownloadTakeOverImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadTakeOverImpl
	*/

	// RVA: -1 Offset: -1
	protected void PostdownloadTakeOverSucceeded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC6D0 Offset: 0x2FEC7D1 VA: 0x2FEC6D0
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadTakeOverSucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.PostdownloadTakeOverSucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.PostdownloadTakeOverSucceeded
	*/

	// RVA: -1 Offset: -1
	private void PostdownloadReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC6F0 Offset: 0x2FEC7F1 VA: 0x2FEC6F0
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadReplay
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void PostdownloadReplayImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadReplayImpl
	*/

	// RVA: -1 Offset: -1
	protected void PostdownloadReplaySucceeded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC700 Offset: 0x2FEC801 VA: 0x2FEC700
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadReplaySucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.PostdownloadReplaySucceeded
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.PostdownloadReplaySucceeded
	*/

	// RVA: -1 Offset: -1
	private void PostdownloadSucceededImpl(RelaySequence.Label labelFailed, bool withMetaData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC720 Offset: 0x2FEC821 VA: 0x2FEC720
	|-RelaySequence.RelaySequenceBase<object>.PostdownloadSucceededImpl
	*/

	// RVA: -1 Offset: -1
	private void MapSequence() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC890 Offset: 0x2FEC991 VA: 0x2FEC890
	|-RelaySequence.RelaySequenceBase<object>.MapSequence
	*/

	// RVA: -1 Offset: -1
	private void UploadShow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FEC940 Offset: 0x2FECA41 VA: 0x2FEC940
	|-RelaySequence.RelaySequenceBase<object>.UploadShow
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void SetPublic(bool isPublic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECA50 Offset: 0x2FECB51 VA: 0x2FECA50
	|-RelaySequence.RelaySequenceBase<object>.SetPublic
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.SetPublic
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.SetPublic
	*/

	// RVA: -1 Offset: -1
	private void Upload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECA60 Offset: 0x2FECB61 VA: 0x2FECA60
	|-RelaySequence.RelaySequenceBase<object>.Upload
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract void UploadImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.UploadImpl
	*/

	// RVA: -1 Offset: -1
	private void Postupload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECB70 Offset: 0x2FECC71 VA: 0x2FECB70
	|-RelaySequence.RelaySequenceBase<object>.Postupload
	*/

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract void PostuploadImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RelaySequence.RelaySequenceBase<object>.PostuploadImpl
	*/

	// RVA: -1 Offset: -1
	protected void ShowDataCode(string code) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECB80 Offset: 0x2FECC81 VA: 0x2FECB80
	|-RelaySequence.RelaySequenceBase<object>.ShowDataCode
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.ShowDataCode
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.ShowDataCode
	*/

	// RVA: -1 Offset: -1
	private void UploadProfileCard() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECD00 Offset: 0x2FECE01 VA: 0x2FECD00
	|-RelaySequence.RelaySequenceBase<object>.UploadProfileCard
	*/

	// RVA: -1 Offset: -1
	private void UseTicket() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECDD0 Offset: 0x2FECED1 VA: 0x2FECDD0
	|-RelaySequence.RelaySequenceBase<object>.UseTicket
	*/

	// RVA: -1 Offset: -1
	private bool IsAward() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FECED0 Offset: 0x2FECFD1 VA: 0x2FECED0
	|-RelaySequence.RelaySequenceBase<object>.IsAward
	*/

	// RVA: -1 Offset: -1
	private void Preaward() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED000 Offset: 0x2FED101 VA: 0x2FED000
	|-RelaySequence.RelaySequenceBase<object>.Preaward
	*/

	// RVA: -1 Offset: -1
	private void DownloadProfileCards() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED0B0 Offset: 0x2FED1B1 VA: 0x2FED0B0
	|-RelaySequence.RelaySequenceBase<object>.DownloadProfileCards
	*/

	// RVA: -1 Offset: -1
	protected void CloseWaitMessageSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED0D0 Offset: 0x2FED1D1 VA: 0x2FED0D0
	|-RelaySequence.RelaySequenceBase<object>.CloseWaitMessageSuccess
	*/

	// RVA: -1 Offset: -1
	protected void CloseWaitMessageFailure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED0F0 Offset: 0x2FED1F1 VA: 0x2FED0F0
	|-RelaySequence.RelaySequenceBase<object>.CloseWaitMessageFailure
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected virtual void CloseWaitMessageImpl(ProcInst super, bool isSuccess) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED110 Offset: 0x2FED211 VA: 0x2FED110
	|-RelaySequence.RelaySequenceBase<object>.CloseWaitMessageImpl
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.CloseWaitMessageImpl
	*/

	// RVA: -1 Offset: -1
	private void NoTicket() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED120 Offset: 0x2FED221 VA: 0x2FED120
	|-RelaySequence.RelaySequenceBase<object>.NoTicket
	*/

	// RVA: -1 Offset: -1
	private void NoSelectableMap() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED1B0 Offset: 0x2FED2B1 VA: 0x2FED1B0
	|-RelaySequence.RelaySequenceBase<object>.NoSelectableMap
	*/

	// RVA: -1 Offset: -1
	private void NotFoundMapForTakeOverRandom() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED240 Offset: 0x2FED341 VA: 0x2FED240
	|-RelaySequence.RelaySequenceBase<object>.NotFoundMapForTakeOverRandom
	*/

	// RVA: -1 Offset: -1
	private void NotFoundMapForTakeOverDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED2D0 Offset: 0x2FED3D1 VA: 0x2FED2D0
	|-RelaySequence.RelaySequenceBase<object>.NotFoundMapForTakeOverDataCode
	*/

	// RVA: -1 Offset: -1
	private void CantTakeOverSelfCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED360 Offset: 0x2FED461 VA: 0x2FED360
	|-RelaySequence.RelaySequenceBase<object>.CantTakeOverSelfCreate
	*/

	// RVA: -1 Offset: -1
	private void CantTakeOverEnd() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED3F0 Offset: 0x2FED4F1 VA: 0x2FED3F0
	|-RelaySequence.RelaySequenceBase<object>.CantTakeOverEnd
	*/

	// RVA: -1 Offset: -1
	private void CantTakeOverOtherPlaying() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED480 Offset: 0x2FED581 VA: 0x2FED480
	|-RelaySequence.RelaySequenceBase<object>.CantTakeOverOtherPlaying
	*/

	// RVA: -1 Offset: -1
	private void CantTakeOverAlreadyPlayed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED510 Offset: 0x2FED611 VA: 0x2FED510
	|-RelaySequence.RelaySequenceBase<object>.CantTakeOverAlreadyPlayed
	*/

	// RVA: -1 Offset: -1
	private void CantTakeOverLackOfUnit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED5A0 Offset: 0x2FED6A1 VA: 0x2FED5A0
	|-RelaySequence.RelaySequenceBase<object>.CantTakeOverLackOfUnit
	*/

	// RVA: -1 Offset: -1
	private void CantTakeOverUnknown() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED630 Offset: 0x2FED731 VA: 0x2FED630
	|-RelaySequence.RelaySequenceBase<object>.CantTakeOverUnknown
	*/

	// RVA: -1 Offset: -1
	private void NotFoundMapForReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED6C0 Offset: 0x2FED7C1 VA: 0x2FED6C0
	|-RelaySequence.RelaySequenceBase<object>.NotFoundMapForReplay
	*/

	// RVA: -1 Offset: -1
	private void NoEnteredMap() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED750 Offset: 0x2FED851 VA: 0x2FED750
	|-RelaySequence.RelaySequenceBase<object>.NoEnteredMap
	*/

	// RVA: -1 Offset: -1
	private void CantGetByDeleting() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED7E0 Offset: 0x2FED8E1 VA: 0x2FED7E0
	|-RelaySequence.RelaySequenceBase<object>.CantGetByDeleting
	*/

	// RVA: -1 Offset: -1
	private void InvalidDownloadData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED870 Offset: 0x2FED971 VA: 0x2FED870
	|-RelaySequence.RelaySequenceBase<object>.InvalidDownloadData
	*/

	// RVA: -1 Offset: -1
	private void DeletedHalfwayBranchForReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED900 Offset: 0x2FEDA01 VA: 0x2FED900
	|-RelaySequence.RelaySequenceBase<object>.DeletedHalfwayBranchForReplay
	*/

	// RVA: -1 Offset: -1
	protected static void CreateBind(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FED9A0 Offset: 0x2FEDAA1 VA: 0x2FED9A0
	|-RelaySequence.RelaySequenceBase<object>.CreateBind
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>.CreateBind
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>.CreateBind
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FF1930 Offset: 0x2FF1A31 VA: 0x2FF1930
	|-RelaySequence.RelaySequenceBase<object>..ctor
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceLocal>..ctor
	|-RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet>..ctor
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

// Namespace: 
private class RelaySequence.RelaySequenceNet : RelaySequence.RelaySequenceBase<RelaySequence.RelaySequenceNet> // TypeDefIndex: 12961
{
	// Methods

	// RVA: 0x1F43600 Offset: 0x1F43701 VA: 0x1F43600 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1F436A0 Offset: 0x1F437A1 VA: 0x1F436A0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1F43740 Offset: 0x1F43841 VA: 0x1F43740 Slot: 27
	protected override void TakeOverSearchImpl() { }

	// RVA: 0x1F437D0 Offset: 0x1F438D1 VA: 0x1F437D0 Slot: 28
	protected override void TakeOverPostsearchImpl() { }

	// RVA: 0x1F43940 Offset: 0x1F43A41 VA: 0x1F43940 Slot: 29
	protected override void TakeOverDownloadMetaWithDataCodeImpl() { }

	// RVA: 0x1F439D0 Offset: 0x1F43AD1 VA: 0x1F439D0 Slot: 30
	protected override void TakeOverPostdownloadMetaWithDataCodeImpl() { }

	// RVA: 0x1F43BF0 Offset: 0x1F43CF1 VA: 0x1F43BF0 Slot: 31
	protected override void TakeOverSetPlayingImpl() { }

	// RVA: 0x1F43CF0 Offset: 0x1F43DF1 VA: 0x1F43CF0 Slot: 32
	protected override void TakeOverPostsetPlayingImpl() { }

	// RVA: 0x1F44030 Offset: 0x1F44131 VA: 0x1F44030 Slot: 33
	protected override void ReplaySearchEnteredImpl() { }

	// RVA: 0x1F44200 Offset: 0x1F44301 VA: 0x1F44200 Slot: 34
	protected override void ReplaySearchAnyImpl() { }

	// RVA: 0x1F44290 Offset: 0x1F44391 VA: 0x1F44290 Slot: 35
	protected override void ReplayPostsearchImpl() { }

	// RVA: 0x1F443E0 Offset: 0x1F444E1 VA: 0x1F443E0 Slot: 36
	protected override void DownloadImpl(bool withMetaData) { }

	// RVA: 0x1F445C0 Offset: 0x1F446C1 VA: 0x1F445C0 Slot: 37
	protected override void PostdownloadTakeOverImpl() { }

	// RVA: 0x1F44710 Offset: 0x1F44811 VA: 0x1F44710 Slot: 38
	protected override void PostdownloadReplayImpl() { }

	// RVA: 0x1F44870 Offset: 0x1F44971 VA: 0x1F44870 Slot: 39
	protected override void UploadImpl() { }

	// RVA: 0x1F44A50 Offset: 0x1F44B51 VA: 0x1F44A50 Slot: 40
	protected override void PostuploadImpl() { }

	// RVA: 0x1F44CB0 Offset: 0x1F44DB1 VA: 0x1F44CB0 Slot: 41
	protected override void CloseWaitMessageImpl(ProcInst super, bool isSuccess) { }

	// RVA: 0x1F43EF0 Offset: 0x1F43FF1 VA: 0x1F43EF0
	private void DeleteSelectedFromSearchResults() { }

	// RVA: 0x1F44CC0 Offset: 0x1F44DC1 VA: 0x1F44CC0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F44D20 Offset: 0x1F44E21 VA: 0x1F44D20
	public void .ctor() { }
}

