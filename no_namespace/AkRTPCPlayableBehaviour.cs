// Namespace: 
[ObsoleteAttribute] // RVA: 0x272710 Offset: 0x272811 VA: 0x272710
[Serializable]
public class AkRTPCPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 8035
{
	// Fields
	[SerializeField] // RVA: 0x27EDF0 Offset: 0x27EEF1 VA: 0x27EDF0
	private float RTPCValue; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x27EE00 Offset: 0x27EF01 VA: 0x27EE00
	private bool <setRTPCGlobally>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x27EE10 Offset: 0x27EF11 VA: 0x27EE10
	private bool <overrideTrackObject>k__BackingField; // 0x15
	[CompilerGeneratedAttribute] // RVA: 0x27EE20 Offset: 0x27EF21 VA: 0x27EE20
	private GameObject <rtpcObject>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x27EE30 Offset: 0x27EF31 VA: 0x27EE30
	private RTPC <parameter>k__BackingField; // 0x20

	// Properties
	private bool setRTPCGlobally { get; set; }
	private bool overrideTrackObject { get; set; }
	private GameObject rtpcObject { get; set; }
	private RTPC parameter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A7320 Offset: 0x2A7421 VA: 0x2A7320
	// RVA: 0x31878E0 Offset: 0x31879E1 VA: 0x31878E0
	public void set_setRTPCGlobally(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7330 Offset: 0x2A7431 VA: 0x2A7330
	// RVA: 0x31878F0 Offset: 0x31879F1 VA: 0x31878F0
	private bool get_setRTPCGlobally() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7340 Offset: 0x2A7441 VA: 0x2A7340
	// RVA: 0x3187900 Offset: 0x3187A01 VA: 0x3187900
	public void set_overrideTrackObject(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7350 Offset: 0x2A7451 VA: 0x2A7350
	// RVA: 0x3187910 Offset: 0x3187A11 VA: 0x3187910
	private bool get_overrideTrackObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7360 Offset: 0x2A7461 VA: 0x2A7360
	// RVA: 0x3187920 Offset: 0x3187A21 VA: 0x3187920
	public void set_rtpcObject(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7370 Offset: 0x2A7471 VA: 0x2A7370
	// RVA: 0x3187930 Offset: 0x3187A31 VA: 0x3187930
	private GameObject get_rtpcObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7380 Offset: 0x2A7481 VA: 0x2A7380
	// RVA: 0x3187940 Offset: 0x3187A41 VA: 0x3187940
	public void set_parameter(RTPC value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A7390 Offset: 0x2A7491 VA: 0x2A7390
	// RVA: 0x3187950 Offset: 0x3187A51 VA: 0x3187950
	private RTPC get_parameter() { }

	// RVA: 0x3187960 Offset: 0x3187A61 VA: 0x3187960 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x31878D0 Offset: 0x31879D1 VA: 0x31878D0
	public void .ctor() { }
}

