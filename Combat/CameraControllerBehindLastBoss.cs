// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273890 Offset: 0x273991 VA: 0x273890
[Serializable]
public class CameraControllerBehindLastBoss : BaseCameraController // TypeDefIndex: 8530
{
	// Fields
	[HeaderAttribute] // RVA: 0x280760 Offset: 0x280861 VA: 0x280760
	public Vector3 FollowVectorH; // 0xA8
	[HeaderAttribute] // RVA: 0x2807A0 Offset: 0x2808A1 VA: 0x2807A0
	public Vector3 LookAtVectorH; // 0xB4
	[HeaderAttribute] // RVA: 0x2807E0 Offset: 0x2808E1 VA: 0x2807E0
	public float FOVH; // 0xC0
	[HeaderAttribute] // RVA: 0x280820 Offset: 0x280921 VA: 0x280820
	public Vector3 FollowVectorL; // 0xC4
	[HeaderAttribute] // RVA: 0x280860 Offset: 0x280961 VA: 0x280860
	public Vector3 LookAtVectorL; // 0xD0
	[HeaderAttribute] // RVA: 0x2808A0 Offset: 0x2809A1 VA: 0x2808A0
	public float FOVL; // 0xDC
	public Vector3 FollowVectorD; // 0xE0
	[HeaderAttribute] // RVA: 0x2808E0 Offset: 0x2809E1 VA: 0x2808E0
	public float SpeedThresholdUp; // 0xEC
	[HeaderAttribute] // RVA: 0x280920 Offset: 0x280A21 VA: 0x280920
	public float SpeedThresholdDown; // 0xF0
	[HeaderAttribute] // RVA: 0x280960 Offset: 0x280A61 VA: 0x280960
	public Vector3 FollowVectorMulti; // 0xF4
	public Vector3 LookAtVectorMulti; // 0x100
	private bool m_IsHeadHigh; // 0x10C
	private float[] m_HeadHight; // 0x110
	private float[] m_WorldTime; // 0x118
	private bool m_IsCharacterLoaded; // 0x120

	// Methods

	// RVA: 0x2C86810 Offset: 0x2C86911 VA: 0x2C86810 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x2C86F80 Offset: 0x2C87081 VA: 0x2C86F80
	private ValueTuple<Vector3, Vector3> GetPositionInfoRangeAttack() { }

	// RVA: 0x2C86930 Offset: 0x2C86A31 VA: 0x2C86930
	private ValueTuple<Vector3, Vector3> GetPositionInfoBattle() { }

	// RVA: 0x2C87220 Offset: 0x2C87321 VA: 0x2C87220
	private Vector3 GetCombatVector(Vector3 vec) { }

	// RVA: 0x2C872C0 Offset: 0x2C873C1 VA: 0x2C872C0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x2C87330 Offset: 0x2C87431 VA: 0x2C87330
	public void .ctor() { }
}

