// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B810 Offset: 0x1B911 VA: 0x1B810
[Serializable]
public struct CinemachineBlendDefinition // TypeDefIndex: 5817
{
	// Fields
	[TooltipAttribute] // RVA: 0x21540 Offset: 0x21641 VA: 0x21540
	public CinemachineBlendDefinition.Style m_Style; // 0x0
	[TooltipAttribute] // RVA: 0x21580 Offset: 0x21681 VA: 0x21580
	public float m_Time; // 0x4
	public AnimationCurve m_CustomCurve; // 0x8
	private static AnimationCurve[] sStandardCurves; // 0x0

	// Properties
	public float BlendTime { get; }
	public AnimationCurve BlendCurve { get; }

	// Methods

	// RVA: 0x1B86EE0 Offset: 0x1B86FE1 VA: 0x1B86EE0
	public float get_BlendTime() { }

	// RVA: 0x1B86F00 Offset: 0x1B87001 VA: 0x1B86F00
	public void .ctor(CinemachineBlendDefinition.Style style, float time) { }

	// RVA: 0x1B86F20 Offset: 0x1B87021 VA: 0x1B86F20
	private void CreateStandardCurves() { }

	// RVA: 0x1B87420 Offset: 0x1B87521 VA: 0x1B87420
	public AnimationCurve get_BlendCurve() { }
}

