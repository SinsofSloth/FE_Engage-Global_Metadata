// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x273960 Offset: 0x273A61 VA: 0x273960
[Serializable]
public class CameraControllerTransition : BaseTransitionCameraController // TypeDefIndex: 8547
{
	// Fields
	[HeaderAttribute] // RVA: 0x2814F0 Offset: 0x2815F1 VA: 0x2814F0
	public AnimationCurve StartCurve; // 0xC0
	[HeaderAttribute] // RVA: 0x281530 Offset: 0x281631 VA: 0x281530
	public AnimationCurve ReturnCurve; // 0xC8
	[HeaderAttribute] // RVA: 0x281570 Offset: 0x281671 VA: 0x281570
	[TooltipAttribute] // RVA: 0x281570 Offset: 0x281671 VA: 0x281570
	[RangeAttribute] // RVA: 0x281570 Offset: 0x281671 VA: 0x281570
	public float RotateStartHeightStart; // 0xD0
	[RangeAttribute] // RVA: 0x2815F0 Offset: 0x2816F1 VA: 0x2815F0
	[HeaderAttribute] // RVA: 0x2815F0 Offset: 0x2816F1 VA: 0x2815F0
	[TooltipAttribute] // RVA: 0x2815F0 Offset: 0x2816F1 VA: 0x2815F0
	public float RotateStartHeightReturn; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x281670 Offset: 0x281771 VA: 0x281670
	private Vector3 <SourceFollow>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x281680 Offset: 0x281781 VA: 0x281680
	private Vector3 <SourceLookAt>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x281690 Offset: 0x281791 VA: 0x281690
	private float <SourceFov>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x2816A0 Offset: 0x2817A1 VA: 0x2816A0
	private float <TargetSSS>k__BackingField; // 0xF4
	[CompilerGeneratedAttribute] // RVA: 0x2816B0 Offset: 0x2817B1 VA: 0x2816B0
	private float <DetourDegree>k__BackingField; // 0xF8
	private bool m_DoRotateTarget; // 0xFC
	private CustomRadialBlur m_RdialBlur; // 0x100
	private float WaitProgress; // 0x108

	// Properties
	protected override float TransitionTimeStart { get; }
	protected override float TransitionTimeReturn { get; }
	private Vector3 SourceFollow { get; set; }
	private Vector3 SourceLookAt { get; set; }
	private float SourceFov { get; set; }
	private float TargetFov { get; }
	private float TargetSSS { get; set; }
	private float DetourDegree { get; set; }

	// Methods

	// RVA: 0x299FC70 Offset: 0x299FD71 VA: 0x299FC70 Slot: 13
	protected override float get_TransitionTimeStart() { }

	// RVA: 0x299FCE0 Offset: 0x299FDE1 VA: 0x299FCE0 Slot: 14
	protected override float get_TransitionTimeReturn() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A97C0 Offset: 0x2A98C1 VA: 0x2A97C0
	// RVA: 0x299FD50 Offset: 0x299FE51 VA: 0x299FD50
	private Vector3 get_SourceFollow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A97D0 Offset: 0x2A98D1 VA: 0x2A97D0
	// RVA: 0x299FD60 Offset: 0x299FE61 VA: 0x299FD60
	private void set_SourceFollow(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A97E0 Offset: 0x2A98E1 VA: 0x2A97E0
	// RVA: 0x299FD70 Offset: 0x299FE71 VA: 0x299FD70
	private Vector3 get_SourceLookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A97F0 Offset: 0x2A98F1 VA: 0x2A97F0
	// RVA: 0x299FD80 Offset: 0x299FE81 VA: 0x299FD80
	private void set_SourceLookAt(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9800 Offset: 0x2A9901 VA: 0x2A9800
	// RVA: 0x299FD90 Offset: 0x299FE91 VA: 0x299FD90
	private float get_SourceFov() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9810 Offset: 0x2A9911 VA: 0x2A9810
	// RVA: 0x299FDA0 Offset: 0x299FEA1 VA: 0x299FDA0
	private void set_SourceFov(float value) { }

	// RVA: 0x299FDB0 Offset: 0x299FEB1 VA: 0x299FDB0
	private float get_TargetFov() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9820 Offset: 0x2A9921 VA: 0x2A9820
	// RVA: 0x299FE30 Offset: 0x299FF31 VA: 0x299FE30
	private float get_TargetSSS() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9830 Offset: 0x2A9931 VA: 0x2A9830
	// RVA: 0x299FE40 Offset: 0x299FF41 VA: 0x299FE40
	private void set_TargetSSS(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9840 Offset: 0x2A9941 VA: 0x2A9840
	// RVA: 0x299FE50 Offset: 0x299FF51 VA: 0x299FE50
	private float get_DetourDegree() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9850 Offset: 0x2A9951 VA: 0x2A9850
	// RVA: 0x299FE60 Offset: 0x299FF61 VA: 0x299FE60
	private void set_DetourDegree(float value) { }

	// RVA: 0x299FE70 Offset: 0x299FF71 VA: 0x299FE70
	private void Start() { }

	// RVA: 0x299FFD0 Offset: 0x29A00D1 VA: 0x299FFD0 Slot: 15
	internal override void StartTransition(BaseCameraController nextCam) { }

	// RVA: 0x29A0400 Offset: 0x29A0501 VA: 0x29A0400 Slot: 16
	internal override void ChangeTaget(BaseCameraController nextCam) { }

	// RVA: 0x29A0650 Offset: 0x29A0751 VA: 0x29A0650 Slot: 17
	internal override void ReturnTransition(BaseCameraController currentCam) { }

	// RVA: 0x29A0850 Offset: 0x29A0951 VA: 0x29A0850 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x29A1100 Offset: 0x29A1201 VA: 0x29A1100 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x29A0A10 Offset: 0x29A0B11 VA: 0x29A0A10
	private ValueTuple<Vector3, Vector3> ZoomInCameraPos() { }

	// RVA: 0x29A0CF0 Offset: 0x29A0DF1 VA: 0x29A0CF0
	private ValueTuple<Vector3, Vector3> WaitCameraPos() { }

	// RVA: 0x29A0E60 Offset: 0x29A0F61 VA: 0x29A0E60
	private ValueTuple<Vector3, Vector3> ChangeCameraPos() { }

	// RVA: 0x29A0F30 Offset: 0x29A1031 VA: 0x29A0F30
	private ValueTuple<Vector3, Vector3> ZoomOutCameraPos() { }

	// RVA: 0x29A1660 Offset: 0x29A1761 VA: 0x29A1660 Slot: 8
	public override void Stabilize() { }

	// RVA: 0x29A16F0 Offset: 0x29A17F1 VA: 0x29A16F0 Slot: 11
	public override void Deactivate() { }

	// RVA: 0x29A0020 Offset: 0x29A0121 VA: 0x29A0020
	private void GetSourceInfo() { }

	// RVA: 0x29A1270 Offset: 0x29A1371 VA: 0x29A1270
	private void SetCameraSetting(float t) { }

	// RVA: 0x29A05A0 Offset: 0x29A06A1 VA: 0x29A05A0
	private void CheckDetour() { }

	// RVA: 0x29A1590 Offset: 0x29A1691 VA: 0x29A1590
	private Vector3 GetFixedSourceFollow(float trans, float rotHeight) { }

	// RVA: 0x29A11B0 Offset: 0x29A12B1 VA: 0x29A11B0
	private void RotateTargetFollow() { }

	// RVA: 0x29A1800 Offset: 0x29A1901 VA: 0x29A1800 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x29A1850 Offset: 0x29A1951 VA: 0x29A1850
	public void .ctor() { }
}

