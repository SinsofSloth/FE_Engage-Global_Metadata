// Namespace: Combat
internal class VCamShaker : CinemachineComponentBase // TypeDefIndex: 8565
{
	// Fields
	private CameraPositionData.CameraShakeSettings m_Setting; // 0x50
	private VCamShaker.ShakeType m_ShakeType; // 0x58
	private int m_Life; // 0x5C
	private float m_Magnitude; // 0x60

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x2A3FE20 Offset: 0x2A3FF21 VA: 0x2A3FE20 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x2A3FE30 Offset: 0x2A3FF31 VA: 0x2A3FE30 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x2A3FE40 Offset: 0x2A3FF41 VA: 0x2A3FE40
	private void Awake() { }

	// RVA: 0x2A3FE50 Offset: 0x2A3FF51 VA: 0x2A3FE50 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x2A3FF30 Offset: 0x2A40031 VA: 0x2A3FF30
	private Vector3 CalcImpact() { }

	// RVA: 0x2A3FFA0 Offset: 0x2A400A1 VA: 0x2A3FFA0
	private Vector3 CalcArmorStep() { }

	// RVA: 0x2A3FFF0 Offset: 0x2A400F1 VA: 0x2A3FFF0
	public void StartShake(CameraPositionData.CameraShakeSettings setting, float magnitude, float distance, bool isCritical) { }

	// RVA: 0x2A40060 Offset: 0x2A40161 VA: 0x2A40060
	public void ArmorShake(CameraPositionData.CameraShakeSettings setting, float magnitude, float distance) { }

	// RVA: 0x2A400E0 Offset: 0x2A401E1 VA: 0x2A400E0
	public void .ctor() { }
}

