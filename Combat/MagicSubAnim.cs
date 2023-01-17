// Namespace: Combat
[RequireComponent] // RVA: 0x274740 Offset: 0x274841 VA: 0x274740
[RequireComponent] // RVA: 0x274740 Offset: 0x274841 VA: 0x274740
public abstract class MagicSubAnim : MagicSub // TypeDefIndex: 8789
{
	// Fields
	[HideInInspector] // RVA: 0x2845C0 Offset: 0x2846C1 VA: 0x2845C0
	public float HitTimeOnAnim; // 0x50
	private Transform m_TargetNode; // 0x58
	private float m_FlyingTime; // 0x60
	private float m_Elapsed; // 0x64
	private Vector3 m_StartPos; // 0x68
	private Vector3 m_EndPos; // 0x74
	private Vector3 m_Forward; // 0x80
	private float m_Distance; // 0x8C
	private List<Vector3> m_InitialLocalScaleList; // 0x90

	// Properties
	private float DistanceScale { get; }

	// Methods

	// RVA: 0x1F977A0 Offset: 0x1F978A1 VA: 0x1F977A0
	private float get_DistanceScale() { }

	// RVA: 0x1F977C0 Offset: 0x1F978C1 VA: 0x1F977C0 Slot: 4
	public override void Setup(Character chr, in Vector3 initialStartPos, in Vector3 initialEndPos) { }

	// RVA: 0x1F97C90 Offset: 0x1F97D91 VA: 0x1F97C90
	private void Update() { }

	// RVA: 0x1F97DE0 Offset: 0x1F97EE1 VA: 0x1F97DE0
	protected void .ctor() { }
}

