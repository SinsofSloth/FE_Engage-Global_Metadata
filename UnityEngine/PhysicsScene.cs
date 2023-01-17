// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x5C620 Offset: 0x5C721 VA: 0x5C620
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 4046
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x1C5CD90 Offset: 0x1C5CE91 VA: 0x1C5CD90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C5CE90 Offset: 0x1C5CF91 VA: 0x1C5CE90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C5CEA0 Offset: 0x1C5CFA1 VA: 0x1C5CEA0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1C5CF30 Offset: 0x1C5D031 VA: 0x1C5CF30 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x1C5B770 Offset: 0x1C5B871 VA: 0x1C5B770
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x1C5BBA0 Offset: 0x1C5BCA1 VA: 0x1C5BBA0
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethodAttribute] // RVA: 0x5D2B0 Offset: 0x5D3B1 VA: 0x5D2B0
	[StaticAccessorAttribute] // RVA: 0x5D2B0 Offset: 0x5D3B1 VA: 0x5D2B0
	// RVA: 0x1C5CF40 Offset: 0x1C5D041 VA: 0x1C5CF40
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x1C5C090 Offset: 0x1C5C191 VA: 0x1C5C090
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[NativeMethodAttribute] // RVA: 0x5D320 Offset: 0x5D421 VA: 0x5D320
	[StaticAccessorAttribute] // RVA: 0x5D320 Offset: 0x5D421 VA: 0x5D320
	// RVA: 0x1C5D070 Offset: 0x1C5D171 VA: 0x1C5D070
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x1C5C330 Offset: 0x1C5C431 VA: 0x1C5C330
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessorAttribute] // RVA: 0x5D390 Offset: 0x5D491 VA: 0x5D390
	[NativeMethodAttribute] // RVA: 0x5D390 Offset: 0x5D491 VA: 0x5D390
	// RVA: 0x1C5D180 Offset: 0x1C5D281 VA: 0x1C5D180
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x1C5CA00 Offset: 0x1C5CB01 VA: 0x1C5CA00
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[StaticAccessorAttribute] // RVA: 0x5D400 Offset: 0x5D501 VA: 0x5D400
	[NativeMethodAttribute] // RVA: 0x5D400 Offset: 0x5D501 VA: 0x5D400
	// RVA: 0x1C5D290 Offset: 0x1C5D391 VA: 0x1C5D290
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x1C5CFF0 Offset: 0x1C5D0F1 VA: 0x1C5CFF0
	private static void Raycast_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x1C5D100 Offset: 0x1C5D201 VA: 0x1C5D100
	private static int RaycastArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x1C5D210 Offset: 0x1C5D311 VA: 0x1C5D210
	private static int RaycastList_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector2 origin, ref Vector2 direction, float distance, ref ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x1C5D320 Offset: 0x1C5D421 VA: 0x1C5D320
	private static int GetRayIntersectionArray_Internal_Injected(ref PhysicsScene2D physicsScene, ref Vector3 origin, ref Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }
}

// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x485C90 Offset: 0x485D91 VA: 0x485C90
public struct PhysicsScene : IEquatable<PhysicsScene> // TypeDefIndex: 4210
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x3EE8D10 Offset: 0x3EE8E11 VA: 0x3EE8D10 Slot: 3
	public override string ToString() { }

	// RVA: 0x3EE8E10 Offset: 0x3EE8F11 VA: 0x3EE8E10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3EE8E20 Offset: 0x3EE8F21 VA: 0x3EE8E20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x3EE8EB0 Offset: 0x3EE8FB1 VA: 0x3EE8EB0 Slot: 4
	public bool Equals(PhysicsScene other) { }

	// RVA: 0x3EE4870 Offset: 0x3EE4971 VA: 0x3EE4870
	public bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x486190 Offset: 0x486291 VA: 0x486190
	[NativeNameAttribute] // RVA: 0x486190 Offset: 0x486291 VA: 0x486190
	// RVA: 0x3EE8EC0 Offset: 0x3EE8FC1 VA: 0x3EE8EC0
	private static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE4EA0 Offset: 0x3EE4FA1 VA: 0x3EE4EA0
	public bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x486200 Offset: 0x486301 VA: 0x486200
	[NativeNameAttribute] // RVA: 0x486200 Offset: 0x486301 VA: 0x486200
	// RVA: 0x3EE8FC0 Offset: 0x3EE90C1 VA: 0x3EE8FC0
	private static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE6EA0 Offset: 0x3EE6FA1 VA: 0x3EE6EA0
	public int Raycast(Vector3 origin, Vector3 direction, RaycastHit[] raycastHits, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x486270 Offset: 0x486371 VA: 0x486270
	[StaticAccessorAttribute] // RVA: 0x486270 Offset: 0x486371 VA: 0x486270
	// RVA: 0x3EE90D0 Offset: 0x3EE91D1 VA: 0x3EE90D0
	private static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[StaticAccessorAttribute] // RVA: 0x4862D0 Offset: 0x4863D1 VA: 0x4862D0
	[NativeNameAttribute] // RVA: 0x4862D0 Offset: 0x4863D1 VA: 0x4862D0
	// RVA: 0x3EE91E0 Offset: 0x3EE92E1 VA: 0x3EE91E0
	private static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9340 Offset: 0x3EE9441 VA: 0x3EE9340
	private static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE6200 Offset: 0x3EE6301 VA: 0x3EE6200
	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x486340 Offset: 0x486441 VA: 0x486340
	[NativeNameAttribute] // RVA: 0x486340 Offset: 0x486441 VA: 0x486340
	// RVA: 0x3EE9480 Offset: 0x3EE9581 VA: 0x3EE9480
	private static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE95C0 Offset: 0x3EE96C1 VA: 0x3EE95C0
	private static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE6490 Offset: 0x3EE6591 VA: 0x3EE6490
	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x4863B0 Offset: 0x4864B1 VA: 0x4863B0
	[StaticAccessorAttribute] // RVA: 0x4863B0 Offset: 0x4864B1 VA: 0x4863B0
	// RVA: 0x3EE96D0 Offset: 0x3EE97D1 VA: 0x3EE96D0
	private static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE8310 Offset: 0x3EE8411 VA: 0x3EE8310
	public int SphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[NativeNameAttribute] // RVA: 0x486410 Offset: 0x486511 VA: 0x486410
	[StaticAccessorAttribute] // RVA: 0x486410 Offset: 0x486511 VA: 0x486410
	// RVA: 0x3EE9810 Offset: 0x3EE9911 VA: 0x3EE9810
	private static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE7DE0 Offset: 0x3EE7EE1 VA: 0x3EE7DE0
	public int OverlapSphere(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[NativeNameAttribute] // RVA: 0x486470 Offset: 0x486571 VA: 0x486470
	[StaticAccessorAttribute] // RVA: 0x486470 Offset: 0x486571 VA: 0x486470
	// RVA: 0x3EE9920 Offset: 0x3EE9A21 VA: 0x3EE9920
	private static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9A90 Offset: 0x3EE9B91 VA: 0x3EE9A90
	private static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE67F0 Offset: 0x3EE68F1 VA: 0x3EE67F0
	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x4864E0 Offset: 0x4865E1 VA: 0x4864E0
	[NativeNameAttribute] // RVA: 0x4864E0 Offset: 0x4865E1 VA: 0x4864E0
	// RVA: 0x3EE9BD0 Offset: 0x3EE9CD1 VA: 0x3EE9BD0
	private static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE8860 Offset: 0x3EE8961 VA: 0x3EE8860
	public int OverlapBox(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	[StaticAccessorAttribute] // RVA: 0x486540 Offset: 0x486641 VA: 0x486540
	[NativeNameAttribute] // RVA: 0x486540 Offset: 0x486641 VA: 0x486540
	// RVA: 0x3EE9D00 Offset: 0x3EE9E01 VA: 0x3EE9D00
	private static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE8B00 Offset: 0x3EE8C01 VA: 0x3EE8B00
	public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance = ∞, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = 0) { }

	// RVA: 0x3EE8F40 Offset: 0x3EE9041 VA: 0x3EE8F40
	private static bool Internal_RaycastTest_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9050 Offset: 0x3EE9151 VA: 0x3EE9050
	private static bool Internal_Raycast_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9160 Offset: 0x3EE9261 VA: 0x3EE9160
	private static int Internal_RaycastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Ray ray, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE92A0 Offset: 0x3EE93A1 VA: 0x3EE92A0
	private static bool Query_CapsuleCast_Injected(ref PhysicsScene physicsScene, ref Vector3 point1, ref Vector3 point2, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9520 Offset: 0x3EE9621 VA: 0x3EE9520
	private static bool Query_SphereCast_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9770 Offset: 0x3EE9871 VA: 0x3EE9770
	private static int Internal_SphereCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 origin, float radius, ref Vector3 direction, RaycastHit[] raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE98A0 Offset: 0x3EE99A1 VA: 0x3EE98A0
	private static int OverlapSphereNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE99E0 Offset: 0x3EE9AE1 VA: 0x3EE99E0
	private static bool Query_BoxCast_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9C70 Offset: 0x3EE9D71 VA: 0x3EE9C70
	private static int OverlapBoxNonAlloc_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, Collider[] results, ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE9DC0 Offset: 0x3EE9EC1 VA: 0x3EE9DC0
	private static int Internal_BoxCastNonAlloc_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Vector3 direction, RaycastHit[] raycastHits, ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }
}

