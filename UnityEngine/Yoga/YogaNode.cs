// Namespace: UnityEngine.Yoga
[DefaultMemberAttribute] // RVA: 0x74840 Offset: 0x74941 VA: 0x74840
internal class YogaNode // TypeDefIndex: 7567
{
	// Fields
	internal IntPtr _ygNode; // 0x10
	private MeasureFunction _measureFunction; // 0x18
	private BaselineFunction _baselineFunction; // 0x20

	// Methods

	// RVA: 0x1C69710 Offset: 0x1C69811 VA: 0x1C69710
	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x1C697E0 Offset: 0x1C698E1 VA: 0x1C697E0
	public static float BaselineInternal(YogaNode node, float width, float height) { }
}

