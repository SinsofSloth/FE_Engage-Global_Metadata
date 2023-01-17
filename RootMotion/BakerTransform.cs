// Namespace: RootMotion
[Serializable]
public class BakerTransform // TypeDefIndex: 14288
{
	// Fields
	public Transform transform; // 0x10
	public AnimationCurve posX; // 0x18
	public AnimationCurve posY; // 0x20
	public AnimationCurve posZ; // 0x28
	public AnimationCurve rotX; // 0x30
	public AnimationCurve rotY; // 0x38
	public AnimationCurve rotZ; // 0x40
	public AnimationCurve rotW; // 0x48
	private string relativePath; // 0x50
	private bool recordPosition; // 0x58
	private Vector3 relativePosition; // 0x5C
	private bool isRootNode; // 0x68
	private Quaternion relativeRotation; // 0x6C

	// Methods

	// RVA: 0x2616EF0 Offset: 0x2616FF1 VA: 0x2616EF0
	public void .ctor(Transform transform, Transform root, bool recordPosition, bool isRootNode) { }

	// RVA: 0x26170F0 Offset: 0x26171F1 VA: 0x26170F0
	public void SetRelativeSpace(Vector3 position, Quaternion rotation) { }

	// RVA: 0x2617110 Offset: 0x2617211 VA: 0x2617110
	public void SetCurves(ref AnimationClip clip) { }

	// RVA: 0x26173D0 Offset: 0x26174D1 VA: 0x26173D0
	private void AddRootMotionCurves(ref AnimationClip clip) { }

	// RVA: 0x2616FA0 Offset: 0x26170A1 VA: 0x2616FA0
	public void Reset() { }

	// RVA: 0x2617660 Offset: 0x2617761 VA: 0x2617660
	public void ReduceKeyframes(float maxError) { }

	// RVA: 0x2617770 Offset: 0x2617871 VA: 0x2617770
	public void SetKeyframes(float time) { }

	// RVA: 0x2617900 Offset: 0x2617A01 VA: 0x2617900
	public void AddLoopFrame(float time) { }
}

