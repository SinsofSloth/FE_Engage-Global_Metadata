// Namespace: App
public class MainSequence : ProcSceneSequence<MainSequence> // TypeDefIndex: 13105
{
	// Fields
	private static MainSequence.Label s_JumpLabel; // 0x0
	private static MainSequence.Label s_FakeLabel; // 0x4
	private static bool s_Initialized; // 0x8

	// Methods

	// RVA: 0x22F55C0 Offset: 0x22F56C1 VA: 0x22F55C0
	private void JumpToLabel() { }

	// RVA: 0x22F5760 Offset: 0x22F5861 VA: 0x22F5760
	private void JumpToLabelNoGCCollect() { }

	// RVA: 0x22F55D0 Offset: 0x22F56D1 VA: 0x22F55D0
	private void JumpToLabelImpl(bool isGCCollect) { }

	// RVA: 0x22F5780 Offset: 0x22F5881 VA: 0x22F5780
	private static ProcInst GetCurrent(ProcInst super) { }

	// RVA: 0x22F5830 Offset: 0x22F5931 VA: 0x22F5830
	public static ProcInst GetCurrent() { }

	// RVA: 0x22F5960 Offset: 0x22F5A61 VA: 0x22F5960
	public static void SetJumpSeq(MainSequence.Label label) { }

	// RVA: 0x22F59D0 Offset: 0x22F5AD1 VA: 0x22F59D0
	private void Initialize() { }

	// RVA: 0x22F5DC0 Offset: 0x22F5EC1 VA: 0x22F5DC0
	private void PostInitialize() { }

	// RVA: 0x22F5EB0 Offset: 0x22F5FB1 VA: 0x22F5EB0
	private void LoadPublic() { }

	// RVA: 0x22F5F20 Offset: 0x22F6021 VA: 0x22F5F20
	private void LoadResource() { }

	// RVA: 0x22F60E0 Offset: 0x22F61E1 VA: 0x22F60E0
	private void PostLoadResource() { }

	// RVA: 0x22F6180 Offset: 0x22F6281 VA: 0x22F6180
	private void BeginSilentVolume() { }

	// RVA: 0x22F6190 Offset: 0x22F6291 VA: 0x22F6190
	private void EndSilentVolume() { }

	// RVA: 0x22F61A0 Offset: 0x22F62A1 VA: 0x22F61A0 Slot: 8
	protected override void OnPersistent() { }

	// RVA: 0x22F6220 Offset: 0x22F6321 VA: 0x22F6220
	private void BranchStart() { }

	// RVA: 0x22F6290 Offset: 0x22F6391 VA: 0x22F6290
	private void BranchChapterStart() { }

	// RVA: 0x22F6420 Offset: 0x22F6521 VA: 0x22F6420
	private void TryJumpToKizuna() { }

	// RVA: 0x22F6710 Offset: 0x22F6811 VA: 0x22F6710
	private void TryJumpToContinueMap() { }

	// RVA: 0x22F68F0 Offset: 0x22F69F1 VA: 0x22F68F0
	private void TryJumpToHub() { }

	// RVA: 0x22F6A10 Offset: 0x22F6B11 VA: 0x22F6A10
	private void TryJumpToGmap() { }

	// RVA: 0x22F67F0 Offset: 0x22F68F1 VA: 0x22F67F0
	private void TryJumpToNextChapter() { }

	// RVA: 0x22F6AE0 Offset: 0x22F6BE1 VA: 0x22F6AE0
	private void HubToSavePosition() { }

	// RVA: 0x22F6B60 Offset: 0x22F6C61 VA: 0x22F6B60
	private void GameReset() { }

	// RVA: 0x22F6C20 Offset: 0x22F6D21 VA: 0x22F6C20
	private void AutoSave() { }

	// RVA: 0x22F6C40 Offset: 0x22F6D41 VA: 0x22F6C40
	private void SetSaveDataLoadTarget() { }

	// RVA: 0x22F6D90 Offset: 0x22F6E91 VA: 0x22F6D90
	private void SaveDataLoad() { }

	// RVA: 0x22F7040 Offset: 0x22F7141 VA: 0x22F7040
	private void SaveDataLoadResult() { }

	// RVA: 0x22F7170 Offset: 0x22F7271 VA: 0x22F7170
	private void SaveDataRelease() { }

	// RVA: 0x22F7240 Offset: 0x22F7341 VA: 0x22F7240
	private void SaveDataNormalize() { }

	// RVA: 0x22F7250 Offset: 0x22F7351 VA: 0x22F7250
	private void SaveDataBranchFirst() { }

	// RVA: 0x22F7390 Offset: 0x22F7491 VA: 0x22F7390
	private void SaveDataBranchSecond() { }

	// RVA: 0x22F7490 Offset: 0x22F7591 VA: 0x22F7490
	private void SaveDataLoadFailed() { }

	// RVA: 0x22F7520 Offset: 0x22F7621 VA: 0x22F7520
	private void SaveDataVersionFailed() { }

	// RVA: 0x22F75B0 Offset: 0x22F76B1 VA: 0x22F75B0
	private void DataLoadFailed() { }

	// RVA: 0x22F7640 Offset: 0x22F7741 VA: 0x22F7640
	private void DeleteTemporary() { }

	// RVA: 0x22F7650 Offset: 0x22F7751 VA: 0x22F7650
	private void GameSoundReset() { }

	// RVA: 0x22F5770 Offset: 0x22F5871 VA: 0x22F5770
	private void DumpMemory(MainSequence.Label label) { }

	// RVA: 0x22F7720 Offset: 0x22F7821 VA: 0x22F7720
	private void DumpMemory(string name) { }

	// RVA: 0x22F7730 Offset: 0x22F7831 VA: 0x22F7730
	private void LoadLogo() { }

	// RVA: 0x22F77A0 Offset: 0x22F78A1 VA: 0x22F77A0
	private void ShowLogo() { }

	// RVA: 0x22F77D0 Offset: 0x22F78D1 VA: 0x22F77D0
	private void ShowIcon() { }

	// RVA: 0x22F7800 Offset: 0x22F7901 VA: 0x22F7800
	public static void Create() { }

	// RVA: 0x22FBD30 Offset: 0x22FBE31 VA: 0x22FBD30
	public static bool IsInitialized() { }

	// RVA: 0x22FBCD0 Offset: 0x22FBDD1 VA: 0x22FBCD0
	public void .ctor() { }

	// RVA: 0x22FBE10 Offset: 0x22FBF11 VA: 0x22FBE10
	private static void .cctor() { }
}

