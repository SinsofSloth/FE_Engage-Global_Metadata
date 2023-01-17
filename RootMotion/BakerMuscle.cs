// Namespace: RootMotion
[Serializable]
public class BakerMuscle // TypeDefIndex: 14287
{
	// Fields
	public AnimationCurve curve; // 0x10
	private int muscleIndex; // 0x18
	private string propertyName; // 0x20

	// Methods

	// RVA: 0x2616150 Offset: 0x2616251 VA: 0x2616150
	public void .ctor(int muscleIndex) { }

	// RVA: 0x2616210 Offset: 0x2616311 VA: 0x2616210
	private string MuscleNameToPropertyName(string n) { }

	// RVA: 0x2616CD0 Offset: 0x2616DD1 VA: 0x2616CD0
	public void MultiplyLength(AnimationCurve curve, float mlp) { }

	// RVA: 0x2616D80 Offset: 0x2616E81 VA: 0x2616D80
	public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp) { }

	// RVA: 0x2616C60 Offset: 0x2616D61 VA: 0x2616C60
	public void Reset() { }

	// RVA: 0x2616EA0 Offset: 0x2616FA1 VA: 0x2616EA0
	public void SetKeyframe(float time, float[] muscles) { }

	// RVA: 0x2616EE0 Offset: 0x2616FE1 VA: 0x2616EE0
	public void SetLoopFrame(float time) { }
}

