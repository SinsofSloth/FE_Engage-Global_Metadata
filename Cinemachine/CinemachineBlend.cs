// Namespace: Cinemachine
public class CinemachineBlend // TypeDefIndex: 5815
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x214F0 Offset: 0x215F1 VA: 0x214F0
	private ICinemachineCamera <CamA>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x21500 Offset: 0x21601 VA: 0x21500
	private ICinemachineCamera <CamB>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x21510 Offset: 0x21611 VA: 0x21510
	private AnimationCurve <BlendCurve>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x21520 Offset: 0x21621 VA: 0x21520
	private float <TimeInBlend>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x21530 Offset: 0x21631 VA: 0x21530
	private float <Duration>k__BackingField; // 0x2C

	// Properties
	public ICinemachineCamera CamA { get; set; }
	public ICinemachineCamera CamB { get; set; }
	public AnimationCurve BlendCurve { get; set; }
	public float TimeInBlend { get; set; }
	public float BlendWeight { get; }
	public bool IsValid { get; }
	public float Duration { get; set; }
	public bool IsComplete { get; }
	public string Description { get; }
	public CameraState State { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x23C40 Offset: 0x23D41 VA: 0x23C40
	// RVA: 0x1B86BF0 Offset: 0x1B86CF1 VA: 0x1B86BF0
	public ICinemachineCamera get_CamA() { }

	[CompilerGeneratedAttribute] // RVA: 0x23C50 Offset: 0x23D51 VA: 0x23C50
	// RVA: 0x1B86C00 Offset: 0x1B86D01 VA: 0x1B86C00
	public void set_CamA(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23C60 Offset: 0x23D61 VA: 0x23C60
	// RVA: 0x1B86C10 Offset: 0x1B86D11 VA: 0x1B86C10
	public ICinemachineCamera get_CamB() { }

	[CompilerGeneratedAttribute] // RVA: 0x23C70 Offset: 0x23D71 VA: 0x23C70
	// RVA: 0x1B86C20 Offset: 0x1B86D21 VA: 0x1B86C20
	public void set_CamB(ICinemachineCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23C80 Offset: 0x23D81 VA: 0x23C80
	// RVA: 0x1B86C30 Offset: 0x1B86D31 VA: 0x1B86C30
	public AnimationCurve get_BlendCurve() { }

	[CompilerGeneratedAttribute] // RVA: 0x23C90 Offset: 0x23D91 VA: 0x23C90
	// RVA: 0x1B86C40 Offset: 0x1B86D41 VA: 0x1B86C40
	public void set_BlendCurve(AnimationCurve value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23CA0 Offset: 0x23DA1 VA: 0x23CA0
	// RVA: 0x1B86C50 Offset: 0x1B86D51 VA: 0x1B86C50
	public float get_TimeInBlend() { }

	[CompilerGeneratedAttribute] // RVA: 0x23CB0 Offset: 0x23DB1 VA: 0x23CB0
	// RVA: 0x1B86C60 Offset: 0x1B86D61 VA: 0x1B86C60
	public void set_TimeInBlend(float value) { }

	// RVA: 0x1B86C70 Offset: 0x1B86D71 VA: 0x1B86C70
	public float get_BlendWeight() { }

	// RVA: 0x1B81E70 Offset: 0x1B81F71 VA: 0x1B81E70
	public bool get_IsValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x23CC0 Offset: 0x23DC1 VA: 0x23CC0
	// RVA: 0x1B86D30 Offset: 0x1B86E31 VA: 0x1B86D30
	public float get_Duration() { }

	[CompilerGeneratedAttribute] // RVA: 0x23CD0 Offset: 0x23DD1 VA: 0x23CD0
	// RVA: 0x1B86D40 Offset: 0x1B86E41 VA: 0x1B86D40
	public void set_Duration(float value) { }

	// RVA: 0x1B86CF0 Offset: 0x1B86DF1 VA: 0x1B86CF0
	public bool get_IsComplete() { }

	// RVA: 0x1B819F0 Offset: 0x1B81AF1 VA: 0x1B819F0
	public string get_Description() { }

	// RVA: 0x1B86D50 Offset: 0x1B86E51 VA: 0x1B86D50
	public bool Uses(ICinemachineCamera cam) { }

	// RVA: 0x1B86E60 Offset: 0x1B86F61 VA: 0x1B86E60
	public void .ctor(ICinemachineCamera a, ICinemachineCamera b, AnimationCurve curve, float duration, float t) { }

	// RVA: 0x1B820A0 Offset: 0x1B821A1 VA: 0x1B820A0
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B82300 Offset: 0x1B82401 VA: 0x1B82300
	public CameraState get_State() { }
}

