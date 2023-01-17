// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2738E0 Offset: 0x2739E1 VA: 0x2738E0
[Serializable]
public class CameraControllerDie : BaseCameraController // TypeDefIndex: 8536
{
	// Fields
	[HeaderAttribute] // RVA: 0x280D40 Offset: 0x280E41 VA: 0x280D40
	public float HeightFixer; // 0xA8
	[HeaderAttribute] // RVA: 0x280D80 Offset: 0x280E81 VA: 0x280D80
	public float LookDownMax; // 0xAC
	[HeaderAttribute] // RVA: 0x280DC0 Offset: 0x280EC1 VA: 0x280DC0
	public float Distance; // 0xB0
	[HeaderAttribute] // RVA: 0x280E00 Offset: 0x280F01 VA: 0x280E00
	public float BaseDegree; // 0xB4
	[HeaderAttribute] // RVA: 0x280E40 Offset: 0x280F41 VA: 0x280E40
	public float StartCameraDownTime; // 0xB8
	[HeaderAttribute] // RVA: 0x280E80 Offset: 0x280F81 VA: 0x280E80
	public float StartRotateTime; // 0xBC
	private bool m_IsBeforeDead; // 0xC0
	private float m_Degree; // 0xC4
	private float m_DeadTime; // 0xC8
	private float m_DeadHeight; // 0xCC
	private bool m_IsEnemy; // 0xD0
	private bool m_IsInverse; // 0xD1
	private bool m_IsStandingDie; // 0xD2
	private float m_LookDown; // 0xD4
	private bool m_IsEngageAtk; // 0xD8
	private readonly float LookDownTime; // 0xDC
	private Vector3 m_ForwardVec; // 0xE0

	// Methods

	// RVA: 0x299C760 Offset: 0x299C861 VA: 0x299C760
	private void Start() { }

	// RVA: 0x299C7A0 Offset: 0x299C8A1 VA: 0x299C7A0 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299CAC0 Offset: 0x299CBC1 VA: 0x299CAC0 Slot: 5
	public override ValueTuple<bool, bool> GetInverse() { }

	// RVA: 0x299CB30 Offset: 0x299CC31 VA: 0x299CB30 Slot: 6
	public override void SetInverse(bool invSide, bool invCamera) { }

	// RVA: 0x299CB50 Offset: 0x299CC51 VA: 0x299CB50 Slot: 10
	public override void Activate() { }

	// RVA: 0x299CCD0 Offset: 0x299CDD1 VA: 0x299CCD0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299CD70 Offset: 0x299CE71 VA: 0x299CD70
	public void .ctor() { }
}

