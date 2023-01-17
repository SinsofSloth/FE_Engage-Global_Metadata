// Namespace: Combat
[DefaultExecutionOrder] // RVA: 0x274150 Offset: 0x274251 VA: 0x274150
[DisallowMultipleComponent] // RVA: 0x274150 Offset: 0x274251 VA: 0x274150
internal sealed class CharacterLyingPegasus : CharacterLying // TypeDefIndex: 8667
{
	// Fields
	private bool m_WasHumanLanded; // 0x21
	private bool m_WasRideLanded; // 0x22
	private TR m_HumanOrient; // 0x24
	private TR m_RideOrient; // 0x40
	private int m_SkipFrames; // 0x5C
	private Quaternion m_RidePushedLocalRotation; // 0x60
	private bool m_IsCollide; // 0x70
	private FXZ m_LastSafetyCTransXZ; // 0x74
	private FXZ m_LastLookAtRideLoc; // 0x7C
	private Transform c_hip_ride_jnt; // 0x88

	// Methods

	// RVA: 0x29B20A0 Offset: 0x29B21A1 VA: 0x29B20A0
	public static bool IsNeedToWork(Character chr) { }

	// RVA: 0x29B20C0 Offset: 0x29B21C1 VA: 0x29B20C0 Slot: 4
	protected override void MyStart(int dieHash) { }

	// RVA: 0x29B21A0 Offset: 0x29B22A1 VA: 0x29B21A0 Slot: 5
	protected override void MakeMyDeadPose() { }

	// RVA: 0x29B2560 Offset: 0x29B2661 VA: 0x29B2560 Slot: 6
	protected override void MyUpdate() { }

	// RVA: 0x29B25B0 Offset: 0x29B26B1 VA: 0x29B25B0 Slot: 7
	protected override void MyLateUpdate() { }

	// RVA: 0x29B2430 Offset: 0x29B2531 VA: 0x29B2430
	private static TR GetGroundTR(in Vector3 pos) { }

	// RVA: 0x29B2B50 Offset: 0x29B2C51 VA: 0x29B2B50
	private static TR GetGroundTR(in Vector3 pos, in Vector4 abcd) { }

	// RVA: 0x29B2C30 Offset: 0x29B2D31 VA: 0x29B2C30
	private void OnLandHuman() { }

	// RVA: 0x29B2E40 Offset: 0x29B2F41 VA: 0x29B2E40
	private void OnLandPegasus() { }

	// RVA: 0x29B3250 Offset: 0x29B3351 VA: 0x29B3250
	public void .ctor() { }
}

