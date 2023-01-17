// Namespace: Combat
public abstract class BaseTransitionCameraController : BaseCameraController // TypeDefIndex: 8546
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2814C0 Offset: 0x2815C1 VA: 0x2814C0
	private TransitonPhase <Phase>k__BackingField; // 0xA8
	protected float ProgressTime; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x2814D0 Offset: 0x2815D1 VA: 0x2814D0
	private BaseCameraController <TargetCamera>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x2814E0 Offset: 0x2815E1 VA: 0x2814E0
	private Camera <SourceCamera>k__BackingField; // 0xB8

	// Properties
	public TransitonPhase Phase { get; set; }
	protected abstract float TransitionTimeStart { get; }
	protected abstract float TransitionTimeReturn { get; }
	public float Progress { get; set; }
	public BaseCameraController TargetCamera { get; set; }
	public Camera SourceCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9760 Offset: 0x2A9861 VA: 0x2A9760
	// RVA: 0x28F0010 Offset: 0x28F0111 VA: 0x28F0010
	public TransitonPhase get_Phase() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9770 Offset: 0x2A9871 VA: 0x2A9770
	// RVA: 0x28F0020 Offset: 0x28F0121 VA: 0x28F0020
	public void set_Phase(TransitonPhase value) { }

	// RVA: -1 Offset: -1 Slot: 13
	protected abstract float get_TransitionTimeStart();

	// RVA: -1 Offset: -1 Slot: 14
	protected abstract float get_TransitionTimeReturn();

	// RVA: 0x28F0030 Offset: 0x28F0131 VA: 0x28F0030
	public float get_Progress() { }

	// RVA: 0x28F00C0 Offset: 0x28F01C1 VA: 0x28F00C0
	public void set_Progress(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9780 Offset: 0x2A9881 VA: 0x2A9780
	// RVA: 0x28F0140 Offset: 0x28F0241 VA: 0x28F0140
	public BaseCameraController get_TargetCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9790 Offset: 0x2A9891 VA: 0x2A9790
	// RVA: 0x28F0150 Offset: 0x28F0251 VA: 0x28F0150
	public void set_TargetCamera(BaseCameraController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A97A0 Offset: 0x2A98A1 VA: 0x2A97A0
	// RVA: 0x28F0160 Offset: 0x28F0261 VA: 0x28F0160
	public Camera get_SourceCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A97B0 Offset: 0x2A98B1 VA: 0x2A97B0
	// RVA: 0x28F0170 Offset: 0x28F0271 VA: 0x28F0170
	public void set_SourceCamera(Camera value) { }

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void StartTransition(BaseCameraController nextCam);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void ChangeTaget(BaseCameraController nextCam);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void ReturnTransition(BaseCameraController nextCam);

	// RVA: 0x28F0180 Offset: 0x28F0281 VA: 0x28F0180
	protected void .ctor() { }
}

