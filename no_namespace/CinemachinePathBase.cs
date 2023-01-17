// Namespace: 
[DocumentationSortingAttribute] // RVA: 0x1B900 Offset: 0x1BA01 VA: 0x1B900
[Serializable]
public class CinemachinePathBase.Appearance // TypeDefIndex: 5833
{
	// Fields
	[TooltipAttribute] // RVA: 0x21A90 Offset: 0x21B91 VA: 0x21A90
	public Color pathColor; // 0x10
	[TooltipAttribute] // RVA: 0x21AD0 Offset: 0x21BD1 VA: 0x21AD0
	public Color inactivePathColor; // 0x20
	[RangeAttribute] // RVA: 0x21B10 Offset: 0x21C11 VA: 0x21B10
	[TooltipAttribute] // RVA: 0x21B10 Offset: 0x21C11 VA: 0x21B10
	public float width; // 0x30

	// Methods

	// RVA: 0x1A8B420 Offset: 0x1A8B521 VA: 0x1A8B420
	public void .ctor() { }
}

// Namespace: 
public enum CinemachinePathBase.PositionUnits // TypeDefIndex: 5834
{
	// Fields
	public int value__; // 0x0
	public const CinemachinePathBase.PositionUnits PathUnits = 0;
	public const CinemachinePathBase.PositionUnits Distance = 1;
	public const CinemachinePathBase.PositionUnits Normalized = 2;
}

