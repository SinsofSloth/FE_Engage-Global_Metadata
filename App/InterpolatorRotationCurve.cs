// Namespace: App
public class InterpolatorRotationCurve // TypeDefIndex: 10811
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295300 Offset: 0x295401 VA: 0x295300
	private float <Value>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x295310 Offset: 0x295411 VA: 0x295310
	private float <Prev>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x295320 Offset: 0x295421 VA: 0x295320
	private float <Next>k__BackingField; // 0x18
	private float m_time; // 0x1C
	private float m_term; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x295330 Offset: 0x295431 VA: 0x295330
	private readonly AnimationCurve <Curve>k__BackingField; // 0x28

	// Properties
	public float Value { get; set; }
	public float Prev { get; set; }
	public float Next { get; set; }
	public bool IsEnd { get; }
	private AnimationCurve Curve { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C1880 Offset: 0x2C1981 VA: 0x2C1880
	// RVA: 0x2B4F040 Offset: 0x2B4F141 VA: 0x2B4F040
	public float get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1890 Offset: 0x2C1991 VA: 0x2C1890
	// RVA: 0x2B4F050 Offset: 0x2B4F151 VA: 0x2B4F050
	public void set_Value(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C18A0 Offset: 0x2C19A1 VA: 0x2C18A0
	// RVA: 0x2B4F060 Offset: 0x2B4F161 VA: 0x2B4F060
	public float get_Prev() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C18B0 Offset: 0x2C19B1 VA: 0x2C18B0
	// RVA: 0x2B4F070 Offset: 0x2B4F171 VA: 0x2B4F070
	public void set_Prev(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C18C0 Offset: 0x2C19C1 VA: 0x2C18C0
	// RVA: 0x2B4F080 Offset: 0x2B4F181 VA: 0x2B4F080
	public float get_Next() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C18D0 Offset: 0x2C19D1 VA: 0x2C18D0
	// RVA: 0x2B4F090 Offset: 0x2B4F191 VA: 0x2B4F090
	public void set_Next(float value) { }

	// RVA: 0x2B4F0A0 Offset: 0x2B4F1A1 VA: 0x2B4F0A0
	public bool get_IsEnd() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C18E0 Offset: 0x2C19E1 VA: 0x2C18E0
	// RVA: 0x2B4F0C0 Offset: 0x2B4F1C1 VA: 0x2B4F0C0
	private AnimationCurve get_Curve() { }

	// RVA: 0x2B4F0D0 Offset: 0x2B4F1D1 VA: 0x2B4F0D0
	public void .ctor(AnimationCurve animationCurve) { }

	// RVA: 0x2B4F110 Offset: 0x2B4F211 VA: 0x2B4F110
	public void Set(float value, float time = 0) { }

	// RVA: 0x2B4F1D0 Offset: 0x2B4F2D1 VA: 0x2B4F1D0
	public void Tick() { }
}

