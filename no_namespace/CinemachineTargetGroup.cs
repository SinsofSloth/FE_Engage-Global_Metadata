// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B150 Offset: 0x1B251 VA: 0x1B150
[Serializable]
public struct CinemachineTargetGroup.Target // TypeDefIndex: 5773
{
	// Fields
	[TooltipAttribute] // RVA: 0x1E720 Offset: 0x1E821 VA: 0x1E720
	public Transform target; // 0x0
	[TooltipAttribute] // RVA: 0x1E760 Offset: 0x1E861 VA: 0x1E760
	public float weight; // 0x8
	[TooltipAttribute] // RVA: 0x1E7A0 Offset: 0x1E8A1 VA: 0x1E7A0
	public float radius; // 0xC
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B170 Offset: 0x1B271 VA: 0x1B170
public enum CinemachineTargetGroup.PositionMode // TypeDefIndex: 5774
{
	// Fields
	public int value__; // 0x0
	public const CinemachineTargetGroup.PositionMode GroupCenter = 0;
	public const CinemachineTargetGroup.PositionMode GroupAverage = 1;
}

// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B190 Offset: 0x1B291 VA: 0x1B190
public enum CinemachineTargetGroup.RotationMode // TypeDefIndex: 5775
{
	// Fields
	public int value__; // 0x0
	public const CinemachineTargetGroup.RotationMode Manual = 0;
	public const CinemachineTargetGroup.RotationMode GroupAverage = 1;
}

// Namespace: 
public enum CinemachineTargetGroup.UpdateMethod // TypeDefIndex: 5776
{
	// Fields
	public int value__; // 0x0
	public const CinemachineTargetGroup.UpdateMethod Update = 0;
	public const CinemachineTargetGroup.UpdateMethod FixedUpdate = 1;
	public const CinemachineTargetGroup.UpdateMethod LateUpdate = 2;
}

