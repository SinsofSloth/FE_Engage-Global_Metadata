// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BC00 Offset: 0x1BD01 VA: 0x1BC00
[HelpURLAttribute] // RVA: 0x1BC00 Offset: 0x1BD01 VA: 0x1BC00
public class CinemachineFixedSignal : SignalSourceAsset // TypeDefIndex: 5878
{
	// Fields
	[TooltipAttribute] // RVA: 0x228F0 Offset: 0x229F1 VA: 0x228F0
	public AnimationCurve m_XCurve; // 0x18
	[TooltipAttribute] // RVA: 0x22930 Offset: 0x22A31 VA: 0x22930
	public AnimationCurve m_YCurve; // 0x20
	[TooltipAttribute] // RVA: 0x22970 Offset: 0x22A71 VA: 0x22970
	public AnimationCurve m_ZCurve; // 0x28

	// Properties
	public override float SignalDuration { get; }

	// Methods

	// RVA: 0x1B97F00 Offset: 0x1B98001 VA: 0x1B97F00 Slot: 6
	public override float get_SignalDuration() { }

	// RVA: 0x1B97F60 Offset: 0x1B98061 VA: 0x1B97F60
	private float AxisDuration(AnimationCurve axis) { }

	// RVA: 0x1B98040 Offset: 0x1B98141 VA: 0x1B98040 Slot: 7
	public override void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1B98140 Offset: 0x1B98241 VA: 0x1B98140
	private float AxisValue(AnimationCurve axis, float time) { }

	// RVA: 0x1B981A0 Offset: 0x1B982A1 VA: 0x1B981A0
	public void .ctor() { }
}

