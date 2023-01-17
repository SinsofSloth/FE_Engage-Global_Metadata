// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274140 Offset: 0x274241 VA: 0x274140
internal class CharacterLyingHuman : CharacterLying // TypeDefIndex: 8666
{
	// Fields
	private Vector3 m_StartPos; // 0x24
	private Vector3 m_EndPos; // 0x30
	private float m_Time; // 0x3C
	private float m_EndTime; // 0x40
	private Quaternion m_BodyRotation; // 0x44
	private Vector3 m_LastNrm; // 0x54
	private float m_LastY; // 0x60
	private bool m_Skipped; // 0x64
	private int m_SkipFrames; // 0x68

	// Properties
	private bool IsInAir { get; }
	private float Progress { get; }

	// Methods

	// RVA: 0x29B1C20 Offset: 0x29B1D21 VA: 0x29B1C20
	private bool get_IsInAir() { }

	// RVA: 0x29B1C30 Offset: 0x29B1D31 VA: 0x29B1C30
	private float get_Progress() { }

	// RVA: 0x29B1C40 Offset: 0x29B1D41 VA: 0x29B1C40 Slot: 4
	protected override void MyStart(int dieHash) { }

	// RVA: 0x29B1CF0 Offset: 0x29B1DF1 VA: 0x29B1CF0 Slot: 5
	protected override void MakeMyDeadPose() { }

	// RVA: 0x29B1DD0 Offset: 0x29B1ED1 VA: 0x29B1DD0 Slot: 7
	protected override void MyLateUpdate() { }

	// RVA: 0x29B2090 Offset: 0x29B2191 VA: 0x29B2090
	public void .ctor() { }
}

