// Namespace: UTJ
public class SpringCapsuleCollider : MonoBehaviour // TypeDefIndex: 6347
{
	// Fields
	public float radius; // 0x18
	public float height; // 0x1C
	public Renderer linkedRenderer; // 0x20

	// Methods

	// RVA: 0x310EB10 Offset: 0x310EC11 VA: 0x310EB10
	public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 moverHeadPosition, ref Vector3 moverPosition, float moverRadius, ref Vector3 hitNormal) { }

	// RVA: 0x3115FA0 Offset: 0x31160A1 VA: 0x3115FA0
	private SpringBone.CollisionStatus CheckForCylinderCollisionAndReact(Vector3 localHeadPosition, ref Vector3 worldMoverPosition, float localMoverRadius, Vector3 localSpherePosition, ref Vector3 hitNormal) { }

	// RVA: 0x31160E0 Offset: 0x31161E1 VA: 0x31160E0
	public void .ctor() { }
}

