// Namespace: UTJ
public class SpringSphereCollider : MonoBehaviour // TypeDefIndex: 6350
{
	// Fields
	public float radius; // 0x18
	public Renderer linkedRenderer; // 0x20

	// Methods

	// RVA: 0x3A75F20 Offset: 0x3A76021 VA: 0x3A75F20
	public SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 headPosition, ref Vector3 tailPosition, float tailRadius, ref Vector3 hitNormal) { }

	// RVA: 0x3A760A0 Offset: 0x3A761A1 VA: 0x3A760A0
	public static SpringBone.CollisionStatus CheckForCollisionAndReact(Vector3 localHeadPosition, ref Vector3 localTailPosition, float localTailRadius, Vector3 sphereLocalOrigin, float sphereRadius) { }

	// RVA: 0x3A76340 Offset: 0x3A76441 VA: 0x3A76340
	public static bool ComputeIntersection(Vector3 originA, float radiusA, Vector3 originB, float radiusB, ref Circle3 intersection) { }

	// RVA: 0x3A76480 Offset: 0x3A76581 VA: 0x3A76480
	public static Vector3 ComputeNewTailPosition(Circle3 intersection, Vector3 tailPosition) { }

	// RVA: 0x3A76530 Offset: 0x3A76631 VA: 0x3A76530
	public void .ctor() { }
}

