// Namespace: UnityEngine
[RequiredByNativeCodeAttribute] // RVA: 0x347D0 Offset: 0x348D1 VA: 0x347D0
[Serializable]
public sealed class AnimationEvent // TypeDefIndex: 4084
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Properties
	public string stringParameter { get; set; }
	public float floatParameter { get; set; }
	public int intParameter { get; set; }
	public Object objectReferenceParameter { get; set; }
	public string functionName { get; set; }
	public float time { get; set; }
	public SendMessageOptions messageOptions { get; set; }

	// Methods

	// RVA: 0x3ED2220 Offset: 0x3ED2321 VA: 0x3ED2220
	public void .ctor() { }

	// RVA: 0x3ED22C0 Offset: 0x3ED23C1 VA: 0x3ED22C0
	public string get_stringParameter() { }

	// RVA: 0x3ED22D0 Offset: 0x3ED23D1 VA: 0x3ED22D0
	public void set_stringParameter(string value) { }

	// RVA: 0x3ED22E0 Offset: 0x3ED23E1 VA: 0x3ED22E0
	public float get_floatParameter() { }

	// RVA: 0x3ED22F0 Offset: 0x3ED23F1 VA: 0x3ED22F0
	public void set_floatParameter(float value) { }

	// RVA: 0x3ED2300 Offset: 0x3ED2401 VA: 0x3ED2300
	public int get_intParameter() { }

	// RVA: 0x3ED2310 Offset: 0x3ED2411 VA: 0x3ED2310
	public void set_intParameter(int value) { }

	// RVA: 0x3ED2320 Offset: 0x3ED2421 VA: 0x3ED2320
	public Object get_objectReferenceParameter() { }

	// RVA: 0x3ED2330 Offset: 0x3ED2431 VA: 0x3ED2330
	public void set_objectReferenceParameter(Object value) { }

	// RVA: 0x3ED2340 Offset: 0x3ED2441 VA: 0x3ED2340
	public string get_functionName() { }

	// RVA: 0x3ED2350 Offset: 0x3ED2451 VA: 0x3ED2350
	public void set_functionName(string value) { }

	// RVA: 0x3ED2360 Offset: 0x3ED2461 VA: 0x3ED2360
	public float get_time() { }

	// RVA: 0x3ED2370 Offset: 0x3ED2471 VA: 0x3ED2370
	public void set_time(float value) { }

	// RVA: 0x3ED2380 Offset: 0x3ED2481 VA: 0x3ED2380
	public SendMessageOptions get_messageOptions() { }

	// RVA: 0x3ED2390 Offset: 0x3ED2491 VA: 0x3ED2390
	public void set_messageOptions(SendMessageOptions value) { }
}

