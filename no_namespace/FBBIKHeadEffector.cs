// Namespace: 
[Serializable]
public class FBBIKHeadEffector.BendBone // TypeDefIndex: 14355
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A0730 Offset: 0x2A0831 VA: 0x2A0730
	public Transform transform; // 0x10
	[RangeAttribute] // RVA: 0x2A0770 Offset: 0x2A0871 VA: 0x2A0770
	[TooltipAttribute] // RVA: 0x2A0770 Offset: 0x2A0871 VA: 0x2A0770
	public float weight; // 0x18
	private Quaternion defaultLocalRotation; // 0x1C

	// Methods

	// RVA: 0x1F09950 Offset: 0x1F09A51 VA: 0x1F09950
	public void .ctor() { }

	// RVA: 0x1F099A0 Offset: 0x1F09AA1 VA: 0x1F099A0
	public void .ctor(Transform transform, float weight) { }

	// RVA: 0x1F09A10 Offset: 0x1F09B11 VA: 0x1F09A10
	public void StoreDefaultLocalState() { }

	// RVA: 0x1F09A50 Offset: 0x1F09B51 VA: 0x1F09A50
	public void FixTransforms() { }
}

