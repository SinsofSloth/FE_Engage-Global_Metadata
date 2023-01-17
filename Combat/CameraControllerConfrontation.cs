// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x2738D0 Offset: 0x2739D1 VA: 0x2738D0
[Serializable]
public class CameraControllerConfrontation : BaseTransitionCameraController // TypeDefIndex: 8535
{
	// Fields
	[HeaderAttribute] // RVA: 0x280CC0 Offset: 0x280DC1 VA: 0x280CC0
	public AnimationCurve FollowCurve; // 0xC0
	[HeaderAttribute] // RVA: 0x280D00 Offset: 0x280E01 VA: 0x280D00
	public AnimationCurve LookatCurve; // 0xC8
	public Vector3 FollowPosition; // 0xD0
	public Vector3 LookatPosition; // 0xDC

	// Properties
	private float CurveLength { get; }
	protected override float TransitionTimeStart { get; }
	protected override float TransitionTimeReturn { get; }
	public override bool IsActiveVCam { get; }

	// Methods

	// RVA: 0x299BB70 Offset: 0x299BC71 VA: 0x299BB70
	private float get_CurveLength() { }

	// RVA: 0x299BBE0 Offset: 0x299BCE1 VA: 0x299BBE0 Slot: 13
	protected override float get_TransitionTimeStart() { }

	// RVA: 0x299BC50 Offset: 0x299BD51 VA: 0x299BC50 Slot: 14
	protected override float get_TransitionTimeReturn() { }

	// RVA: 0x299BC60 Offset: 0x299BD61 VA: 0x299BC60 Slot: 7
	public override bool get_IsActiveVCam() { }

	// RVA: 0x299BC70 Offset: 0x299BD71 VA: 0x299BC70 Slot: 9
	public override void CheckUsable(bool isRoutine) { }

	// RVA: 0x299BE90 Offset: 0x299BF91 VA: 0x299BE90
	private void Start() { }

	// RVA: 0x299BEA0 Offset: 0x299BFA1 VA: 0x299BEA0 Slot: 15
	internal override void StartTransition(BaseCameraController nextCam) { }

	// RVA: 0x299BEE0 Offset: 0x299BFE1 VA: 0x299BEE0 Slot: 16
	internal override void ChangeTaget(BaseCameraController nextCam) { }

	// RVA: 0x299BEF0 Offset: 0x299BFF1 VA: 0x299BEF0 Slot: 17
	internal override void ReturnTransition(BaseCameraController currentCam) { }

	// RVA: 0x299BF00 Offset: 0x299C001 VA: 0x299BF00 Slot: 4
	internal override ValueTuple<Vector3, Vector3> GetPositionInfo() { }

	// RVA: 0x299C150 Offset: 0x299C251 VA: 0x299C150
	private ValueTuple<Vector3, Vector3> ZoomInCameraPos() { }

	// RVA: 0x299C3C0 Offset: 0x299C4C1 VA: 0x299C3C0
	private ValueTuple<Vector3, Vector3> ZoomupPlayer(float t) { }

	// RVA: 0x299C530 Offset: 0x299C631 VA: 0x299C530
	private ValueTuple<Vector3, Vector3> ZoomupEnemy(float t) { }

	// RVA: 0x299C310 Offset: 0x299C411 VA: 0x299C310
	private ValueTuple<Vector3, Vector3> WaitCameraPos() { }

	// RVA: 0x299C260 Offset: 0x299C361 VA: 0x299C260
	private ValueTuple<Vector3, Vector3> ZoomOutCameraPos() { }

	// RVA: 0x299C6B0 Offset: 0x299C7B1 VA: 0x299C6B0 Slot: 12
	public override int[] GetCameraTargets() { }

	// RVA: 0x299C750 Offset: 0x299C851 VA: 0x299C750
	public void .ctor() { }
}

