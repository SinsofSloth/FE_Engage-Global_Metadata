// Namespace: App
public class MovieSequence : SingletonProcInst<MovieSequence> // TypeDefIndex: 12709
{
	// Fields
	private static int PrepareRetryCountLimit; // 0x0
	private MoviePlayer m_MoviePlayer; // 0x78
	private bool m_IsFadeOutInStart; // 0x80
	private bool m_IsWaitForPlayGOP; // 0x81
	private bool m_IsPlayGOPFromTitle; // 0x82
	private int m_PrepareRetryCount; // 0x84

	// Methods

	// RVA: 0x227D470 Offset: 0x227D571 VA: 0x227D470
	private void .ctor(string movieFileName, bool isMovieFileNameDirect) { }

	// RVA: 0x227D560 Offset: 0x227D661 VA: 0x227D560 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x227D620 Offset: 0x227D721 VA: 0x227D620 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x227D700 Offset: 0x227D801 VA: 0x227D700
	private void PushFade() { }

	// RVA: 0x227D7D0 Offset: 0x227D8D1 VA: 0x227D7D0
	private void PopFade() { }

	// RVA: 0x227D850 Offset: 0x227D951 VA: 0x227D850
	private void LoadScene() { }

	// RVA: 0x227D8E0 Offset: 0x227D9E1 VA: 0x227D8E0
	private void SetupAfterLoadScene() { }

	// RVA: 0x227D9A0 Offset: 0x227DAA1 VA: 0x227D9A0
	private void UnloadScene() { }

	// RVA: 0x227DA30 Offset: 0x227DB31 VA: 0x227DA30
	private void Prepare() { }

	// RVA: 0x227DA50 Offset: 0x227DB51 VA: 0x227DA50
	private void WaitPrepare() { }

	// RVA: 0x227DB70 Offset: 0x227DC71 VA: 0x227DB70
	private void PlayMovie() { }

	// RVA: 0x227DB90 Offset: 0x227DC91 VA: 0x227DB90
	private void StopMovie() { }

	// RVA: 0x227DBB0 Offset: 0x227DCB1 VA: 0x227DBB0
	private bool IsTruePlayEnd() { }

	// RVA: 0x227DBF0 Offset: 0x227DCF1 VA: 0x227DBF0
	private bool IsShowCaption() { }

	// RVA: 0x227DC00 Offset: 0x227DD01 VA: 0x227DC00
	private void SetCaption(string mid, int msec) { }

	// RVA: 0x227DC70 Offset: 0x227DD71 VA: 0x227DC70
	private void ShowTitleLogo(int msec) { }

	// RVA: 0x227DC90 Offset: 0x227DD91 VA: 0x227DC90
	private void EnableControllerSupport() { }

	// RVA: 0x227DCF0 Offset: 0x227DDF1 VA: 0x227DCF0
	private void DisableControllerSupport() { }

	// RVA: 0x227DD50 Offset: 0x227DE51 VA: 0x227DD50
	private void WaitPlayMovie() { }

	// RVA: 0x227DE70 Offset: 0x227DF71 VA: 0x227DE70
	public void EnableScene() { }

	// RVA: 0x227DE80 Offset: 0x227DF81 VA: 0x227DE80
	public void DisableScene() { }

	// RVA: 0x227DE90 Offset: 0x227DF91 VA: 0x227DE90
	private void Persistent() { }

	// RVA: 0x227DEB0 Offset: 0x227DFB1 VA: 0x227DEB0
	private void Tick() { }

	// RVA: 0x227E160 Offset: 0x227E261 VA: 0x227E160
	private void PostSoundEventOnEnd() { }

	// RVA: 0x227E170 Offset: 0x227E271 VA: 0x227E170 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x227E1B0 Offset: 0x227E2B1 VA: 0x227E1B0
	public static void StartCaption(string mid, int msec) { }

	// RVA: 0x227E2A0 Offset: 0x227E3A1 VA: 0x227E2A0
	public static void StartTitleLogo(int msec) { }

	// RVA: 0x227E390 Offset: 0x227E491 VA: 0x227E390
	private void Init() { }

	// RVA: 0x227E470 Offset: 0x227E571 VA: 0x227E470
	private void End() { }

	// RVA: 0x227E540 Offset: 0x227E641 VA: 0x227E540
	private static bool IsSkip() { }

	// RVA: 0x227E550 Offset: 0x227E651 VA: 0x227E550
	public static void CreateBind(ProcInst super, string movieFileName, bool isMovieFileNameDirect) { }

	// RVA: 0x227F200 Offset: 0x227F301 VA: 0x227F200
	private void SetupByTitleMovieCanvasPrefab() { }

	// RVA: 0x227F2D0 Offset: 0x227F3D1 VA: 0x227F2D0
	private void InitLoopGOP() { }

	// RVA: 0x227F2E0 Offset: 0x227F3E1 VA: 0x227F2E0
	public void EnableCanvas() { }

	// RVA: 0x227F300 Offset: 0x227F401 VA: 0x227F300
	public void DisableCanvas() { }

	// RVA: 0x227F320 Offset: 0x227F421 VA: 0x227F320
	private void SwitchGenderGOP() { }

	// RVA: 0x227F430 Offset: 0x227F531 VA: 0x227F430
	private void InitWaitForPlayGOP() { }

	// RVA: 0x227F480 Offset: 0x227F581 VA: 0x227F480
	private bool WaitForPlayGOP() { }

	// RVA: 0x227F490 Offset: 0x227F591 VA: 0x227F490
	private void PlayMovieGOP() { }

	// RVA: 0x227F4C0 Offset: 0x227F5C1 VA: 0x227F4C0
	private void TickGOP() { }

	// RVA: 0x227F660 Offset: 0x227F761 VA: 0x227F660
	private void FadeOutGOP() { }

	// RVA: 0x227F700 Offset: 0x227F801 VA: 0x227F700
	public void SetPlayGOPFromTitle(bool isFromTitle) { }

	// RVA: 0x227F710 Offset: 0x227F811 VA: 0x227F710
	public void WaitEndForPlayGOP() { }

	// RVA: 0x227F760 Offset: 0x227F861 VA: 0x227F760
	public static void CreateBindGOPForTitleLoop(ProcInst super, bool isHeroFemale) { }

	// RVA: 0x2280320 Offset: 0x2280421 VA: 0x2280320
	private static void .cctor() { }
}

