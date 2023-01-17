// Namespace: App
public class HubRangeAction // TypeDefIndex: 10812
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x295340 Offset: 0x295441 VA: 0x295340
	private bool <IsStop>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x295350 Offset: 0x295451 VA: 0x295350
	private float <Distance>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x295360 Offset: 0x295461 VA: 0x295360
	private float <Interval>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x295370 Offset: 0x295471 VA: 0x295370
	private float <Angle>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x295380 Offset: 0x295481 VA: 0x295380
	private bool <IsStopMain>k__BackingField; // 0x20
	private float m_time; // 0x24
	private bool m_triggerIn; // 0x28
	private bool m_triggerOut; // 0x29
	private Action<HubUnitController> m_funcInRange; // 0x30
	private Action<HubUnitController> m_funcOutRange; // 0x38

	// Properties
	public bool IsStop { get; set; }
	public float Distance { get; set; }
	public float Interval { get; set; }
	public float Angle { get; set; }
	public bool IsStopMain { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C18F0 Offset: 0x2C19F1 VA: 0x2C18F0
	// RVA: 0x28BF910 Offset: 0x28BFA11 VA: 0x28BF910
	public bool get_IsStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1900 Offset: 0x2C1A01 VA: 0x2C1900
	// RVA: 0x28BF920 Offset: 0x28BFA21 VA: 0x28BF920
	public void set_IsStop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1910 Offset: 0x2C1A11 VA: 0x2C1910
	// RVA: 0x28BF930 Offset: 0x28BFA31 VA: 0x28BF930
	public float get_Distance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1920 Offset: 0x2C1A21 VA: 0x2C1920
	// RVA: 0x28BF940 Offset: 0x28BFA41 VA: 0x28BF940
	public void set_Distance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1930 Offset: 0x2C1A31 VA: 0x2C1930
	// RVA: 0x28BF950 Offset: 0x28BFA51 VA: 0x28BF950
	public float get_Interval() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1940 Offset: 0x2C1A41 VA: 0x2C1940
	// RVA: 0x28BF960 Offset: 0x28BFA61 VA: 0x28BF960
	public void set_Interval(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1950 Offset: 0x2C1A51 VA: 0x2C1950
	// RVA: 0x28BF970 Offset: 0x28BFA71 VA: 0x28BF970
	public float get_Angle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1960 Offset: 0x2C1A61 VA: 0x2C1960
	// RVA: 0x28BF980 Offset: 0x28BFA81 VA: 0x28BF980
	public void set_Angle(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1970 Offset: 0x2C1A71 VA: 0x2C1970
	// RVA: 0x28BF990 Offset: 0x28BFA91 VA: 0x28BF990
	public bool get_IsStopMain() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1980 Offset: 0x2C1A81 VA: 0x2C1980
	// RVA: 0x28BF9A0 Offset: 0x28BFAA1 VA: 0x28BF9A0
	public void set_IsStopMain(bool value) { }

	// RVA: 0x28BF9B0 Offset: 0x28BFAB1 VA: 0x28BF9B0
	public void .ctor(Action<HubUnitController> funcInRange, Action<HubUnitController> funcOutRange) { }

	// RVA: 0x28BFA20 Offset: 0x28BFB21 VA: 0x28BFA20
	public void Reset() { }

	// RVA: 0x28BFA30 Offset: 0x28BFB31 VA: 0x28BFA30
	public void Update(HubUnitController unit) { }
}

