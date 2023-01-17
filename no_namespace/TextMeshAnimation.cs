// Namespace: 
public enum TextMeshAnimation.EndType // TypeDefIndex: 13443
{
	// Fields
	public int value__; // 0x0
	public const TextMeshAnimation.EndType Loop = 0;
	public const TextMeshAnimation.EndType ToNext = 1;
	public const TextMeshAnimation.EndType Wait = 2;
	public const TextMeshAnimation.EndType Hide = 3;
	public const TextMeshAnimation.EndType Delete = 4;
}

// Namespace: 
[Serializable]
public class TextMeshAnimation.AnimationParams // TypeDefIndex: 13444
{
	// Fields
	public AnimationCurve OffsetCurveX; // 0x10
	public AnimationCurve OffsetCurveY; // 0x18
	[SpaceAttribute] // RVA: 0x29C110 Offset: 0x29C211 VA: 0x29C110
	public AnimationCurve RotationCurve; // 0x20
	[SpaceAttribute] // RVA: 0x29C130 Offset: 0x29C231 VA: 0x29C130
	public AnimationCurve ScaleCurveX; // 0x28
	public AnimationCurve ScaleCurveY; // 0x30
	[SpaceAttribute] // RVA: 0x29C150 Offset: 0x29C251 VA: 0x29C150
	public AnimationCurve RedCurve; // 0x38
	public AnimationCurve GreenCurve; // 0x40
	public AnimationCurve BlueCurve; // 0x48
	public AnimationCurve AlphaCurve; // 0x50
	[SpaceAttribute] // RVA: 0x29C170 Offset: 0x29C271 VA: 0x29C170
	public TextMeshAnimation.PivotType m_PivotType; // 0x58
	public float m_DelayTime; // 0x5C
	public TextMeshAnimation.DelayTimeType m_DelayTimeType; // 0x60
	public TextMeshAnimation.EndType m_EndType; // 0x64
	public bool m_StartFromRight; // 0x68
	public float m_MaxIntervalTime; // 0x6C
	private float m_EndTime; // 0x70

	// Properties
	public float EndTime { get; }

	// Methods

	// RVA: 0x2392CF0 Offset: 0x2392DF1 VA: 0x2392CF0
	public float GetDelayTime(int characterCount) { }

	// RVA: 0x2392D20 Offset: 0x2392E21 VA: 0x2392D20
	public void CalcEndTime() { }

	// RVA: 0x2393050 Offset: 0x2393151 VA: 0x2393050
	public bool IsEnd(float time) { }

	// RVA: 0x2393060 Offset: 0x2393161 VA: 0x2393060
	public void SetWrapMode(WrapMode mode) { }

	// RVA: 0x23931A0 Offset: 0x23932A1 VA: 0x23931A0
	public void ExpandAnimation(float ratio) { }

	// RVA: 0x23932F0 Offset: 0x23933F1 VA: 0x23932F0
	public float get_EndTime() { }

	// RVA: 0x2392DE0 Offset: 0x2392EE1 VA: 0x2392DE0
	private AnimationCurve[] GetAnimationList() { }

	// RVA: 0x2393300 Offset: 0x2393401 VA: 0x2393300
	public void .ctor() { }
}

// Namespace: 
public enum TextMeshAnimation.DelayTimeType // TypeDefIndex: 13445
{
	// Fields
	public int value__; // 0x0
	public const TextMeshAnimation.DelayTimeType Interval = 0;
	public const TextMeshAnimation.DelayTimeType Total = 1;
}

// Namespace: 
public enum TextMeshAnimation.PivotType // TypeDefIndex: 13446
{
	// Fields
	public int value__; // 0x0
	public const TextMeshAnimation.PivotType Center = 0;
	public const TextMeshAnimation.PivotType BaseLine = 1;
}

