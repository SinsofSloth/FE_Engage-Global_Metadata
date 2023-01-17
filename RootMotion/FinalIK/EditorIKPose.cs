// Namespace: RootMotion.FinalIK
[CreateAssetMenuAttribute] // RVA: 0x27A270 Offset: 0x27A371 VA: 0x27A270
public class EditorIKPose : ScriptableObject // TypeDefIndex: 14450
{
	// Fields
	public Vector3[] localPositions; // 0x18
	public Quaternion[] localRotations; // 0x20

	// Properties
	public bool poseStored { get; }

	// Methods

	// RVA: 0x25F08F0 Offset: 0x25F09F1 VA: 0x25F08F0
	public bool get_poseStored() { }

	// RVA: 0x25F0BD0 Offset: 0x25F0CD1 VA: 0x25F0BD0
	public void Store(Transform[] T) { }

	// RVA: 0x25F0910 Offset: 0x25F0A11 VA: 0x25F0910
	public bool Restore(Transform[] T) { }

	// RVA: 0x25F11A0 Offset: 0x25F12A1 VA: 0x25F11A0
	public void .ctor() { }
}

