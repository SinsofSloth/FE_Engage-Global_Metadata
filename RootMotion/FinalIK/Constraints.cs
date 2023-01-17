// Namespace: RootMotion.FinalIK
[Serializable]
public class Constraints // TypeDefIndex: 14322
{
	// Fields
	public Transform transform; // 0x10
	public Transform target; // 0x18
	public Vector3 positionOffset; // 0x20
	public Vector3 position; // 0x2C
	[RangeAttribute] // RVA: 0x29EA60 Offset: 0x29EB61 VA: 0x29EA60
	public float positionWeight; // 0x38
	public Vector3 rotationOffset; // 0x3C
	public Vector3 rotation; // 0x48
	[RangeAttribute] // RVA: 0x29EA80 Offset: 0x29EB81 VA: 0x29EA80
	public float rotationWeight; // 0x54

	// Methods

	// RVA: 0x23B8FA0 Offset: 0x23B90A1 VA: 0x23B8FA0
	public bool IsValid() { }

	// RVA: 0x23B9020 Offset: 0x23B9121 VA: 0x23B9020
	public void Initiate(Transform transform) { }

	// RVA: 0x23B9080 Offset: 0x23B9181 VA: 0x23B9080
	public void Update() { }

	// RVA: 0x23B9360 Offset: 0x23B9461 VA: 0x23B9360
	public void .ctor() { }
}

