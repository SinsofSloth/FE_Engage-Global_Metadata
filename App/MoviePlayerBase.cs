// Namespace: App
public abstract class MoviePlayerBase // TypeDefIndex: 12706
{
	// Fields
	public const string UseFileExtName = ".webm";
	public const string UseSceneName = "MoviePlayer";
	private const string HeroFemalePostfix = "F";
	protected GameObject m_ScreenObject; // 0x10
	protected GameObject m_CanvasObject; // 0x18
	protected MoviePlayerBase.Caption m_Caption; // 0x20
	protected MoviePlayerBase.TitleLogo m_TitleLogo; // 0x28
	protected MoviePlayerBase.KeyHelp m_KeyHelp; // 0x30
	protected bool m_IsMovieFileNameDirect; // 0x38
	protected string m_BaseMovieFileName; // 0x40
	protected string m_MovieFileName; // 0x48
	protected string m_SoundBankName; // 0x50
	protected double m_PrevPlayTime; // 0x58
	protected bool m_IsErrorOccured; // 0x60
	protected string m_SoundEventOnStartViewer1; // 0x68
	protected string m_SoundEventOnStartViewer2; // 0x70
	protected string m_SoundEventOnStartViewer3; // 0x78

	// Methods

	// RVA: 0x227AED0 Offset: 0x227AFD1 VA: 0x227AED0
	public void .ctor(string movieFileName, bool isMovieFileNameDirect) { }

	// RVA: 0x227BF40 Offset: 0x227C041 VA: 0x227BF40
	public void Load(string movieFileName, bool isMovieFileNameDirect) { }

	// RVA: 0x227C3C0 Offset: 0x227C4C1 VA: 0x227C3C0
	public void Unload() { }

	// RVA: 0x227C160 Offset: 0x227C261 VA: 0x227C160
	public static void ResolveMovieFileName(ref string baseMovieFileName, ref string movieFileName, bool isMovieFileNameDirect) { }

	// RVA: 0x227B530 Offset: 0x227B631 VA: 0x227B530
	public string GetMovieFilePath() { }

	// RVA: 0x227C4E0 Offset: 0x227C5E1 VA: 0x227C4E0
	private static string GetMovieFilePath(string baseMovieFileName, string movieFileName) { }

	// RVA: 0x227C840 Offset: 0x227C941 VA: 0x227C840
	public void LoadSceneBind(ProcInst super) { }

	// RVA: 0x227C8D0 Offset: 0x227C9D1 VA: 0x227C8D0
	public void UnloadSceneBind(ProcInst super) { }

	// RVA: 0x227B040 Offset: 0x227B141 VA: 0x227B040 Slot: 4
	public virtual bool SetupAfterLoadScene() { }

	// RVA: 0x227B280 Offset: 0x227B381 VA: 0x227B280 Slot: 5
	public virtual bool SetupByMovieCanvasPrefab(GameObject canvasPrefab) { }

	// RVA: 0x227C960 Offset: 0x227CA61 VA: 0x227C960
	private bool SetupCommon() { }

	// RVA: 0x227CD60 Offset: 0x227CE61 VA: 0x227CD60 Slot: 6
	public virtual bool SetMovieFilePathToVideoPlayer() { }

	// RVA: 0x227CD70 Offset: 0x227CE71 VA: 0x227CD70
	public void EnableScene() { }

	// RVA: 0x227CE80 Offset: 0x227CF81 VA: 0x227CE80
	public void DisableScene() { }

	// RVA: 0x227CD80 Offset: 0x227CE81 VA: 0x227CD80
	private void SetSceneActive(bool isActive) { }

	// RVA: 0x227CE90 Offset: 0x227CF91 VA: 0x227CE90
	public void EnableCanvas() { }

	// RVA: 0x227CEB0 Offset: 0x227CFB1 VA: 0x227CEB0
	public void DisableCanvas() { }

	// RVA: 0x227CED0 Offset: 0x227CFD1 VA: 0x227CED0
	public void ShowHelp() { }

	// RVA: 0x227CEE0 Offset: 0x227CFE1 VA: 0x227CEE0
	public void HideHelp() { }

	// RVA: 0x227CEF0 Offset: 0x227CFF1 VA: 0x227CEF0
	public bool IsShowCaption() { }

	// RVA: 0x227CF00 Offset: 0x227D001 VA: 0x227CF00
	public void SetCaption(string mid, int msec) { }

	// RVA: 0x227CF70 Offset: 0x227D071 VA: 0x227CF70
	public void SwitchCaptionOnOff() { }

	// RVA: 0x227CF80 Offset: 0x227D081 VA: 0x227CF80
	public void ShowTitleLogo(int msec) { }

	// RVA: 0x227BAF0 Offset: 0x227BBF1 VA: 0x227BAF0
	protected void PostSoundEventOnStartViewer() { }

	// RVA: 0x227D030 Offset: 0x227D131 VA: 0x227D030
	public void PostSoundEventOnEnd() { }

	// RVA: 0x227D040 Offset: 0x227D141 VA: 0x227D040
	public static void PostSoundEventOnEnd(string movieFileName) { }

	// RVA: 0x227CFA0 Offset: 0x227D0A1 VA: 0x227CFA0
	private static void PostSoundEvent(string soundEventName) { }

	// RVA: 0x227BA90 Offset: 0x227BB91 VA: 0x227BA90
	protected static string GetSoundEventNameOnStart(string movieFileName) { }

	// RVA: 0x227D340 Offset: 0x227D441 VA: 0x227D340 Slot: 7
	public virtual string GetScreenObjectName() { }

	// RVA: 0x227D390 Offset: 0x227D491 VA: 0x227D390 Slot: 8
	public virtual bool IsPaused() { }

	// RVA: 0x227D3A0 Offset: 0x227D4A1 VA: 0x227D3A0 Slot: 9
	public virtual bool IsPlaying() { }

	// RVA: 0x227D3B0 Offset: 0x227D4B1 VA: 0x227D3B0 Slot: 10
	public virtual bool IsPlayEnd() { }

	// RVA: 0x227D3C0 Offset: 0x227D4C1 VA: 0x227D3C0 Slot: 11
	public virtual bool IsErrorOccured() { }

	// RVA: 0x227D3D0 Offset: 0x227D4D1 VA: 0x227D3D0 Slot: 12
	public virtual float GetMovieLength() { }

	// RVA: 0x227D3E0 Offset: 0x227D4E1 VA: 0x227D3E0 Slot: 13
	public virtual float GetPlayingPosition() { }

	// RVA: 0x227D3F0 Offset: 0x227D4F1 VA: 0x227D3F0 Slot: 14
	public virtual void Persistent() { }

	// RVA: 0x227D400 Offset: 0x227D501 VA: 0x227D400 Slot: 15
	public virtual void Tick() { }

	// RVA: 0x227D410 Offset: 0x227D511 VA: 0x227D410 Slot: 16
	public virtual void Prepare() { }

	// RVA: 0x227D420 Offset: 0x227D521 VA: 0x227D420 Slot: 17
	public virtual bool IsPrepared() { }

	// RVA: 0x227D430 Offset: 0x227D531 VA: 0x227D430 Slot: 18
	public virtual void Play() { }

	// RVA: 0x227D440 Offset: 0x227D541 VA: 0x227D440 Slot: 19
	public virtual void Stop() { }

	// RVA: 0x227D450 Offset: 0x227D551 VA: 0x227D450 Slot: 20
	public virtual void SuspendOn() { }

	// RVA: 0x227D460 Offset: 0x227D561 VA: 0x227D460 Slot: 21
	public virtual void SuspendOff() { }
}

