// Namespace: 
[Serializable]
public class VRIKCalibrator.Settings // TypeDefIndex: 14482
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5EE0 Offset: 0x2A5FE1 VA: 0x2A5EE0
	public float scaleMlp; // 0x10
	[TooltipAttribute] // RVA: 0x2A5F20 Offset: 0x2A6021 VA: 0x2A5F20
	public Vector3 headTrackerForward; // 0x14
	[TooltipAttribute] // RVA: 0x2A5F60 Offset: 0x2A6061 VA: 0x2A5F60
	public Vector3 headTrackerUp; // 0x20
	[TooltipAttribute] // RVA: 0x2A5FA0 Offset: 0x2A60A1 VA: 0x2A5FA0
	public Vector3 handTrackerForward; // 0x2C
	[TooltipAttribute] // RVA: 0x2A5FE0 Offset: 0x2A60E1 VA: 0x2A5FE0
	public Vector3 handTrackerUp; // 0x38
	[TooltipAttribute] // RVA: 0x2A6020 Offset: 0x2A6121 VA: 0x2A6020
	public Vector3 footTrackerForward; // 0x44
	[TooltipAttribute] // RVA: 0x2A6060 Offset: 0x2A6161 VA: 0x2A6060
	public Vector3 footTrackerUp; // 0x50
	[SpaceAttribute] // RVA: 0x2A60A0 Offset: 0x2A61A1 VA: 0x2A60A0
	[TooltipAttribute] // RVA: 0x2A60A0 Offset: 0x2A61A1 VA: 0x2A60A0
	public Vector3 headOffset; // 0x5C
	[TooltipAttribute] // RVA: 0x2A60F0 Offset: 0x2A61F1 VA: 0x2A60F0
	public Vector3 handOffset; // 0x68
	[TooltipAttribute] // RVA: 0x2A6130 Offset: 0x2A6231 VA: 0x2A6130
	public float footForwardOffset; // 0x74
	[TooltipAttribute] // RVA: 0x2A6170 Offset: 0x2A6271 VA: 0x2A6170
	public float footInwardOffset; // 0x78
	[RangeAttribute] // RVA: 0x2A61B0 Offset: 0x2A62B1 VA: 0x2A61B0
	[TooltipAttribute] // RVA: 0x2A61B0 Offset: 0x2A62B1 VA: 0x2A61B0
	public float footHeadingOffset; // 0x7C
	[RangeAttribute] // RVA: 0x2A6210 Offset: 0x2A6311 VA: 0x2A6210
	public float pelvisPositionWeight; // 0x80
	[RangeAttribute] // RVA: 0x2A6230 Offset: 0x2A6331 VA: 0x2A6230
	public float pelvisRotationWeight; // 0x84

	// Methods

	// RVA: 0x1EE0260 Offset: 0x1EE0361 VA: 0x1EE0260
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class VRIKCalibrator.CalibrationData // TypeDefIndex: 14484
{
	// Fields
	public float scale; // 0x10
	public VRIKCalibrator.CalibrationData.Target head; // 0x18
	public VRIKCalibrator.CalibrationData.Target leftHand; // 0x20
	public VRIKCalibrator.CalibrationData.Target rightHand; // 0x28
	public VRIKCalibrator.CalibrationData.Target pelvis; // 0x30
	public VRIKCalibrator.CalibrationData.Target leftFoot; // 0x38
	public VRIKCalibrator.CalibrationData.Target rightFoot; // 0x40
	public VRIKCalibrator.CalibrationData.Target leftLegGoal; // 0x48
	public VRIKCalibrator.CalibrationData.Target rightLegGoal; // 0x50
	public Vector3 pelvisTargetRight; // 0x58
	public float pelvisPositionWeight; // 0x64
	public float pelvisRotationWeight; // 0x68

	// Methods

	// RVA: 0x1EE0250 Offset: 0x1EE0351 VA: 0x1EE0250
	public void .ctor() { }
}

