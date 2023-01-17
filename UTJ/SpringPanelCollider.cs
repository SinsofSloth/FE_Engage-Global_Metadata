// Namespace: UTJ
public class SpringPanelCollider : MonoBehaviour // TypeDefIndex: 6349
{
	// Fields
	public float width; // 0x18
	public float height; // 0x1C
	public Renderer linkedRenderer; // 0x20

	// Methods

	// RVA: 0x3A754C0 Offset: 0x3A755C1 VA: 0x3A754C0
	public Vector3 GetPlaneNormal() { }

	// RVA: 0x3A754E0 Offset: 0x3A755E1 VA: 0x3A754E0
	public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 headPosition, float length, ref Vector3 tailPosition, float tailRadius, ref Vector3 hitNormal) { }

	// RVA: 0x3A75880 Offset: 0x3A75981 VA: 0x3A75880
	public static SpringBone.CollisionStatus CheckForCollisionWithAlignedPlaneAndReact(Vector3 localHeadPosition, float localLength, ref Vector3 localTailPosition, float localTailRadius, SpringPanelCollider.Axis upAxis) { }

	// RVA: 0x3A75AB0 Offset: 0x3A75BB1 VA: 0x3A75AB0
	public void .ctor() { }
}

