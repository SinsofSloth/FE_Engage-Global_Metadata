// Namespace: RootMotion
[Serializable]
public class BakerHumanoidQT // TypeDefIndex: 14286
{
	// Fields
	private Transform transform; // 0x10
	private string Qx; // 0x18
	private string Qy; // 0x20
	private string Qz; // 0x28
	private string Qw; // 0x30
	private string Tx; // 0x38
	private string Ty; // 0x40
	private string Tz; // 0x48
	public AnimationCurve rotX; // 0x50
	public AnimationCurve rotY; // 0x58
	public AnimationCurve rotZ; // 0x60
	public AnimationCurve rotW; // 0x68
	public AnimationCurve posX; // 0x70
	public AnimationCurve posY; // 0x78
	public AnimationCurve posZ; // 0x80
	private AvatarIKGoal goal; // 0x88
	private Quaternion lastQ; // 0x8C
	private bool lastQSet; // 0x9C

	// Methods

	// RVA: 0x2614C80 Offset: 0x2614D81 VA: 0x2614C80
	public void .ctor(string name) { }

	// RVA: 0x2614FB0 Offset: 0x26150B1 VA: 0x2614FB0
	public void .ctor(Transform transform, AvatarIKGoal goal, string name) { }

	// RVA: 0x2614E50 Offset: 0x2614F51 VA: 0x2614E50
	public void Reset() { }

	// RVA: 0x26151A0 Offset: 0x26152A1 VA: 0x26151A0
	public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation) { }

	// RVA: 0x2615700 Offset: 0x2615801 VA: 0x2615700
	public void SetKeyframes(float time, Vector3 pos, Quaternion rot) { }

	// RVA: 0x26157E0 Offset: 0x26158E1 VA: 0x26157E0
	public void MoveLastKeyframes(float time) { }

	// RVA: 0x2615A90 Offset: 0x2615B91 VA: 0x2615A90
	public void SetLoopFrame(float time) { }

	// RVA: 0x2615A10 Offset: 0x2615B11 VA: 0x2615A10
	private void MoveLastKeyframe(float time, AnimationCurve curve) { }

	// RVA: 0x2615CD0 Offset: 0x2615DD1 VA: 0x2615CD0
	public void MultiplyLength(AnimationCurve curve, float mlp) { }

	// RVA: 0x2615D80 Offset: 0x2615E81 VA: 0x2615D80
	public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) { }
}

