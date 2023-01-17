// Namespace: 
[Serializable]
public class GenericPoser.Map // TypeDefIndex: 14425
{
	// Fields
	public Transform bone; // 0x10
	public Transform target; // 0x18
	private Vector3 defaultLocalPosition; // 0x20
	private Quaternion defaultLocalRotation; // 0x2C

	// Methods

	// RVA: 0x22EC870 Offset: 0x22EC971 VA: 0x22EC870
	public void .ctor(Transform bone, Transform target) { }

	// RVA: 0x22EC900 Offset: 0x22ECA01 VA: 0x22EC900
	public void StoreDefaultState() { }

	// RVA: 0x22EC950 Offset: 0x22ECA51 VA: 0x22EC950
	public void FixTransform() { }

	// RVA: 0x22EC990 Offset: 0x22ECA91 VA: 0x22EC990
	public void Update(float localRotationWeight, float localPositionWeight) { }
}

