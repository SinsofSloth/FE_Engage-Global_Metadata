// Namespace: 
private class FieldBgmManager.BgmHandle // TypeDefIndex: 13788
{
	// Fields
	private SoundSystem.SoundHandle m_soundHandle; // 0x10
	private bool m_isFirstPlayed; // 0x18
	private bool m_isPaused; // 0x19

	// Methods

	// RVA: 0x22DA6F0 Offset: 0x22DA7F1 VA: 0x22DA6F0
	public void .ctor(SoundSystem.SoundHandle soundHandle) { }

	// RVA: 0x22DA730 Offset: 0x22DA831 VA: 0x22DA730
	public bool IsEnable() { }

	// RVA: 0x22DA740 Offset: 0x22DA841 VA: 0x22DA740
	public bool IsFirstPlayed() { }

	// RVA: 0x22DA750 Offset: 0x22DA851 VA: 0x22DA750
	public bool IsPlaying() { }

	// RVA: 0x22DA760 Offset: 0x22DA861 VA: 0x22DA760
	public bool IsPaused() { }

	// RVA: 0x22DA770 Offset: 0x22DA871 VA: 0x22DA770
	public string GetEventName() { }

	// RVA: 0x22DA780 Offset: 0x22DA881 VA: 0x22DA780
	public void Stop(int fadeMsec) { }

	// RVA: 0x22DA7A0 Offset: 0x22DA8A1 VA: 0x22DA7A0
	public void Pause(int fadeMsec) { }

	// RVA: 0x22DA7F0 Offset: 0x22DA8F1 VA: 0x22DA7F0
	public void Resume(int fadeMsec) { }

	// RVA: 0x22DA830 Offset: 0x22DA931 VA: 0x22DA830
	public void SetFirstPlayed() { }
}

// Namespace: 
private class FieldBgmManager.VolumeFader // TypeDefIndex: 13789
{
	// Fields
	private float m_vol; // 0x10
	private float m_volFrom; // 0x14
	private float m_volTo; // 0x18
	private float m_time; // 0x1C
	private float m_duration; // 0x20

	// Methods

	// RVA: 0x22DACD0 Offset: 0x22DADD1 VA: 0x22DACD0
	public void .ctor() { }

	// RVA: 0x22DAD10 Offset: 0x22DAE11 VA: 0x22DAD10
	public void Reset() { }

	// RVA: 0x22DAD30 Offset: 0x22DAE31 VA: 0x22DAD30
	public float Get() { }

	// RVA: 0x22DAD40 Offset: 0x22DAE41 VA: 0x22DAD40
	public void Set(float vol, int msec) { }

	// RVA: 0x22DAD80 Offset: 0x22DAE81 VA: 0x22DAD80
	public void Tick() { }
}

// Namespace: 
private class FieldBgmManager.ProcChangeBgm : SingletonProcInst<FieldBgmManager.ProcChangeBgm> // TypeDefIndex: 13790
{
	// Fields
	private FieldBgmManager m_bgmManager; // 0x78
	private bool m_isReturnToNormalBgm; // 0x80

	// Methods

	// RVA: 0x22DA840 Offset: 0x22DA941 VA: 0x22DA840
	private void .ctor(FieldBgmManager bgmManager, bool isReturnToNormalBgm) { }

	// RVA: 0x22DA8F0 Offset: 0x22DA9F1 VA: 0x22DA8F0
	private void ProcCall_ResumeBgm() { }

	// RVA: 0x22DA920 Offset: 0x22DAA21 VA: 0x22DA920
	private void ProcCall_PauseBgm() { }

	// RVA: 0x22DA970 Offset: 0x22DAA71 VA: 0x22DA970
	public static void Create(FieldBgmManager bgmManager, Force.Type forceType, bool isReturnToNormalBgm, ProcInst super) { }
}

