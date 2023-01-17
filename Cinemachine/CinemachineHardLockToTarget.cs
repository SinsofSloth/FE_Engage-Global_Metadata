// Namespace: Cinemachine
[SaveDuringPlayAttribute] // RVA: 0x1B480 Offset: 0x1B581 VA: 0x1B480
[AddComponentMenu] // RVA: 0x1B480 Offset: 0x1B581 VA: 0x1B480
[DocumentationSortingAttribute] // RVA: 0x1B480 Offset: 0x1B581 VA: 0x1B480
public class CinemachineHardLockToTarget : CinemachineComponentBase // TypeDefIndex: 5792
{
	// Fields
	[TooltipAttribute] // RVA: 0x20170 Offset: 0x20271 VA: 0x20170
	public float m_Damping; // 0x50
	private Vector3 m_PreviousTargetPosition; // 0x54

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1B9F880 Offset: 0x1B9F981 VA: 0x1B9F880 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1B9F920 Offset: 0x1B9FA21 VA: 0x1B9F920 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1B9F930 Offset: 0x1B9FA31 VA: 0x1B9F930 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1B9F940 Offset: 0x1B9FA41 VA: 0x1B9F940 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B9FA10 Offset: 0x1B9FB11 VA: 0x1B9FA10
	public void .ctor() { }
}

