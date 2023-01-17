// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274100 Offset: 0x274201 VA: 0x274100
[DefaultExecutionOrder] // RVA: 0x274100 Offset: 0x274201 VA: 0x274100
internal sealed class CharacterLyingHorse : CharacterLying // TypeDefIndex: 8665
{
	// Fields
	private TR m_StartBaseTR; // 0x24
	private TR m_EndBaseTR; // 0x40
	private Quaternion m_StartHumanQ; // 0x5C
	private Quaternion m_EndHumanQ; // 0x6C
	private Transform m_HumanRoot; // 0x80
	private Transform m_HorseRoot; // 0x88
	private Quaternion m_HorseRootRotation; // 0x90
	private Vector3 m_HorseNrm; // 0xA0
	private float m_Time; // 0xAC
	private float m_EndTime; // 0xB0
	private bool m_IsCollide; // 0xB4
	private FXZ m_LastSafetyHipXZ; // 0xB8
	private FXZ m_LastLookAtRide; // 0xC0

	// Methods

	// RVA: 0x2B82780 Offset: 0x2B82881 VA: 0x2B82780
	private CharacterLyingHorse.Progress GetProgess() { }

	// RVA: 0x2B827B0 Offset: 0x2B828B1 VA: 0x2B827B0 Slot: 4
	protected override void MyStart(int dieHash) { }

	// RVA: 0x2B82A40 Offset: 0x2B82B41 VA: 0x2B82A40 Slot: 5
	protected override void MakeMyDeadPose() { }

	// RVA: 0x2B82B60 Offset: 0x2B82C61 VA: 0x2B82B60 Slot: 7
	protected override void MyLateUpdate() { }

	// RVA: 0x2B82FC0 Offset: 0x2B830C1 VA: 0x2B82FC0
	public void .ctor() { }
}

