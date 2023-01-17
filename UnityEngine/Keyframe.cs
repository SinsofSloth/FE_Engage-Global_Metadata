// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x43B900 Offset: 0x43BA01 VA: 0x43B900
public struct Keyframe // TypeDefIndex: 3397
{
	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18

	// Properties
	public float time { get; set; }
	public float value { get; set; }
	public float inTangent { get; set; }
	public float outTangent { get; set; }

	// Methods

	// RVA: 0x2F09770 Offset: 0x2F09871 VA: 0x2F09770
	public void .ctor(float time, float value) { }

	// RVA: 0x2F097F0 Offset: 0x2F098F1 VA: 0x2F097F0
	public void .ctor(float time, float value, float inTangent, float outTangent) { }

	// RVA: 0x2F26D00 Offset: 0x2F26E01 VA: 0x2F26D00
	public float get_time() { }

	// RVA: 0x2F26D10 Offset: 0x2F26E11 VA: 0x2F26D10
	public void set_time(float value) { }

	// RVA: 0x2F26D20 Offset: 0x2F26E21 VA: 0x2F26D20
	public float get_value() { }

	// RVA: 0x2F26D30 Offset: 0x2F26E31 VA: 0x2F26D30
	public void set_value(float value) { }

	// RVA: 0x2F26D40 Offset: 0x2F26E41 VA: 0x2F26D40
	public float get_inTangent() { }

	// RVA: 0x2F26D50 Offset: 0x2F26E51 VA: 0x2F26D50
	public void set_inTangent(float value) { }

	// RVA: 0x2F26D60 Offset: 0x2F26E61 VA: 0x2F26D60
	public float get_outTangent() { }

	// RVA: 0x2F26D70 Offset: 0x2F26E71 VA: 0x2F26D70
	public void set_outTangent(float value) { }
}

