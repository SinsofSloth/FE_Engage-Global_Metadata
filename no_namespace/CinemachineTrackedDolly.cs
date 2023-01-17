// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B710 Offset: 0x1B811 VA: 0x1B710
public enum CinemachineTrackedDolly.CameraUpMode // TypeDefIndex: 5802
{
	// Fields
	public int value__; // 0x0
	public const CinemachineTrackedDolly.CameraUpMode Default = 0;
	public const CinemachineTrackedDolly.CameraUpMode Path = 1;
	public const CinemachineTrackedDolly.CameraUpMode PathNoRoll = 2;
	public const CinemachineTrackedDolly.CameraUpMode FollowTarget = 3;
	public const CinemachineTrackedDolly.CameraUpMode FollowTargetNoRoll = 4;
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B730 Offset: 0x1B831 VA: 0x1B730
[Serializable]
public struct CinemachineTrackedDolly.AutoDolly // TypeDefIndex: 5803
{
	// Fields
	[TooltipAttribute] // RVA: 0x20AF0 Offset: 0x20BF1 VA: 0x20AF0
	public bool m_Enabled; // 0x0
	[TooltipAttribute] // RVA: 0x20B30 Offset: 0x20C31 VA: 0x20B30
	public float m_PositionOffset; // 0x4
	[TooltipAttribute] // RVA: 0x20B70 Offset: 0x20C71 VA: 0x20B70
	public int m_SearchRadius; // 0x8
	[FormerlySerializedAsAttribute] // RVA: 0x20BB0 Offset: 0x20CB1 VA: 0x20BB0
	[TooltipAttribute] // RVA: 0x20BB0 Offset: 0x20CB1 VA: 0x20BB0
	public int m_SearchResolution; // 0xC

	// Methods

	// RVA: 0x1A78300 Offset: 0x1A78401 VA: 0x1A78300
	public void .ctor(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) { }
}

