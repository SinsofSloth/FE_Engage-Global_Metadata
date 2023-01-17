// Namespace: App
[DisallowMultipleComponent] // RVA: 0x278B80 Offset: 0x278C81 VA: 0x278B80
[RequireComponent] // RVA: 0x278B80 Offset: 0x278C81 VA: 0x278B80
[RequireComponent] // RVA: 0x278B80 Offset: 0x278C81 VA: 0x278B80
public class TelopInstance : MonoBehaviour // TypeDefIndex: 13394
{
	// Fields
	public bool m_IsKeyWait; // 0x18
	public string m_StartSoundEvent; // 0x20
	public string m_KeySoundEvent; // 0x28
	[RangeAttribute] // RVA: 0x29BDD0 Offset: 0x29BED1 VA: 0x29BDD0
	public float m_SkipableTime; // 0x30
	[RangeAttribute] // RVA: 0x29BDF0 Offset: 0x29BEF1 VA: 0x29BDF0
	[HeaderAttribute] // RVA: 0x29BDF0 Offset: 0x29BEF1 VA: 0x29BDF0
	public float m_MvpWaitTime; // 0x34
	private const int AnimeLayerMain = 0;
	private const int AnimeLayerLoopColor = 1;
	private const int AnimeLayerLoopSRT = 2;
	private const float FadeTime = 0.25;
	private Animator m_Animator; // 0x38
	private CanvasGroup m_CanvasGroup; // 0x40
	private float m_FadeTime; // 0x48
	private float m_ElapsedTime; // 0x4C
	private MVPRoot m_MVPRoot; // 0x50
	private bool m_IsKeyLock; // 0x58
	private bool m_IsForcedPlayOut; // 0x59

	// Methods

	// RVA: 0x2C3C9E0 Offset: 0x2C3CAE1 VA: 0x2C3C9E0
	public void SetKeyLock() { }

	// RVA: 0x2C3C9F0 Offset: 0x2C3CAF1 VA: 0x2C3C9F0
	public void PlayOut() { }

	// RVA: 0x2C3CA00 Offset: 0x2C3CB01 VA: 0x2C3CA00
	private void Start() { }

	// RVA: 0x2C3CCB0 Offset: 0x2C3CDB1 VA: 0x2C3CCB0
	private void Update() { }

	// RVA: 0x2C3D250 Offset: 0x2C3D351 VA: 0x2C3D250
	public void .ctor() { }
}

