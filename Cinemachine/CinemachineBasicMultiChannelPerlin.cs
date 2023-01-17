// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B2C0 Offset: 0x1B3C1 VA: 0x1B2C0
[SaveDuringPlayAttribute] // RVA: 0x1B2C0 Offset: 0x1B3C1 VA: 0x1B2C0
[AddComponentMenu] // RVA: 0x1B2C0 Offset: 0x1B3C1 VA: 0x1B2C0
public class CinemachineBasicMultiChannelPerlin : CinemachineComponentBase // TypeDefIndex: 5783
{
	// Fields
	[TooltipAttribute] // RVA: 0x1EC70 Offset: 0x1ED71 VA: 0x1EC70
	[FormerlySerializedAsAttribute] // RVA: 0x1EC70 Offset: 0x1ED71 VA: 0x1EC70
	[NoiseSettingsPropertyAttribute] // RVA: 0x1EC70 Offset: 0x1ED71 VA: 0x1EC70
	public NoiseSettings m_NoiseProfile; // 0x50
	[TooltipAttribute] // RVA: 0x1ECE0 Offset: 0x1EDE1 VA: 0x1ECE0
	public Vector3 m_PivotOffset; // 0x58
	[TooltipAttribute] // RVA: 0x1ED20 Offset: 0x1EE21 VA: 0x1ED20
	public float m_AmplitudeGain; // 0x64
	[TooltipAttribute] // RVA: 0x1ED60 Offset: 0x1EE61 VA: 0x1ED60
	public float m_FrequencyGain; // 0x68
	private bool mInitialized; // 0x6C
	private float mNoiseTime; // 0x70
	[SerializeField] // RVA: 0x1EDA0 Offset: 0x1EEA1 VA: 0x1EDA0
	[HideInInspector] // RVA: 0x1EDA0 Offset: 0x1EEA1 VA: 0x1EDA0
	private Vector3 mNoiseOffsets; // 0x74

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1B862D0 Offset: 0x1B863D1 VA: 0x1B862D0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1B86360 Offset: 0x1B86461 VA: 0x1B86360 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1B86370 Offset: 0x1B86471 VA: 0x1B86370 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B86A50 Offset: 0x1B86B51 VA: 0x1B86A50
	public void ReSeed() { }

	// RVA: 0x1B868A0 Offset: 0x1B869A1 VA: 0x1B868A0
	private void Initialize() { }

	// RVA: 0x1B86B90 Offset: 0x1B86C91 VA: 0x1B86B90
	public void .ctor() { }
}

