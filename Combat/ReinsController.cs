// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2744F0 Offset: 0x2745F1 VA: 0x2744F0
[DefaultExecutionOrder] // RVA: 0x2744F0 Offset: 0x2745F1 VA: 0x2744F0
public abstract class ReinsController : MonoBehaviour // TypeDefIndex: 8731
{
	// Fields
	private Character _cp; // 0x18
	private bool m_bInitialized; // 0x20
	private Vector3 m_LastPos; // 0x24
	public List<string> names; // 0x30
	[RangeAttribute] // RVA: 0x283F90 Offset: 0x284091 VA: 0x283F90
	public float Weight; // 0x38
	private Transform[] transforms; // 0x40
	public Vector3 WorldOffset; // 0x48
	public bool FrameLatencyCompensation; // 0x54

	// Properties
	private Character CP { get; }

	// Methods

	// RVA: 0x2536950 Offset: 0x2536A51 VA: 0x2536950
	private Character get_CP() { }

	// RVA: 0x2536A10 Offset: 0x2536B11 VA: 0x2536A10
	public float SetWeight(float weight) { }

	// RVA: 0x2536A20 Offset: 0x2536B21 VA: 0x2536A20
	private void Start() { }

	// RVA: 0x2536B10 Offset: 0x2536C11 VA: 0x2536B10
	private void MyStart() { }

	// RVA: 0x2536DA0 Offset: 0x2536EA1 VA: 0x2536DA0
	private void LateUpdate() { }

	// RVA: 0x2537100 Offset: 0x2537201 VA: 0x2537100
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC590 Offset: 0x2AC691 VA: 0x2AC590
	// RVA: 0x25371E0 Offset: 0x25372E1 VA: 0x25371E0
	private void <Start>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC5A0 Offset: 0x2AC6A1 VA: 0x2AC5A0
	// RVA: 0x25371F0 Offset: 0x25372F1 VA: 0x25371F0
	private void <MyStart>b__12_0(Character chr) { }
}

