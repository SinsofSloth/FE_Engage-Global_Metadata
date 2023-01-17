// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BD10 Offset: 0x1BE11 VA: 0x1BD10
public class CinemachineImpulseManager // TypeDefIndex: 5890
{
	// Fields
	private static CinemachineImpulseManager sInstance; // 0x0
	private const float Epsilon = 0.0001;
	private List<CinemachineImpulseManager.ImpulseEvent> m_ExpiredEvents; // 0x10
	private List<CinemachineImpulseManager.ImpulseEvent> m_ActiveEvents; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x22E00 Offset: 0x22F01 VA: 0x22E00
	private bool <IgnoreTimeScale>k__BackingField; // 0x20

	// Properties
	public static CinemachineImpulseManager Instance { get; }
	public bool IgnoreTimeScale { get; set; }
	public float CurrentTime { get; }

	// Methods

	// RVA: 0x1BA06F0 Offset: 0x1BA07F1 VA: 0x1BA06F0
	private void .ctor() { }

	// RVA: 0x1B9FF00 Offset: 0x1BA0001 VA: 0x1B9FF00
	public static CinemachineImpulseManager get_Instance() { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x24090 Offset: 0x24191 VA: 0x24090
	// RVA: 0x1BA0700 Offset: 0x1BA0801 VA: 0x1BA0700
	private static void InitializeModule() { }

	// RVA: 0x1BA0410 Offset: 0x1BA0511 VA: 0x1BA0410
	public bool GetImpulseAt(Vector3 listenerLocation, bool distance2D, int channelMask, out Vector3 pos, out Quaternion rot) { }

	[CompilerGeneratedAttribute] // RVA: 0x240A0 Offset: 0x241A1 VA: 0x240A0
	// RVA: 0x1BA08A0 Offset: 0x1BA09A1 VA: 0x1BA08A0
	public bool get_IgnoreTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x240B0 Offset: 0x241B1 VA: 0x240B0
	// RVA: 0x1BA08B0 Offset: 0x1BA09B1 VA: 0x1BA08B0
	public void set_IgnoreTimeScale(bool value) { }

	// RVA: 0x1BA08C0 Offset: 0x1BA09C1 VA: 0x1BA08C0
	public float get_CurrentTime() { }

	// RVA: 0x1B9FFE0 Offset: 0x1BA00E1 VA: 0x1B9FFE0
	public CinemachineImpulseManager.ImpulseEvent NewImpulseEvent() { }

	// RVA: 0x1BA00A0 Offset: 0x1BA01A1 VA: 0x1BA00A0
	public void AddImpulseEvent(CinemachineImpulseManager.ImpulseEvent e) { }

	// RVA: 0x1BA07C0 Offset: 0x1BA08C1 VA: 0x1BA07C0
	public void Clear() { }

	// RVA: 0x1BA0950 Offset: 0x1BA0A51 VA: 0x1BA0950
	private static void .cctor() { }
}

