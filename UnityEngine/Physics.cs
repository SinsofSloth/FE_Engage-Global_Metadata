// Namespace: UnityEngine
[StaticAccessorAttribute] // RVA: 0x485CD0 Offset: 0x485DD1 VA: 0x485CD0
[NativeHeaderAttribute] // RVA: 0x485CD0 Offset: 0x485DD1 VA: 0x485CD0
public class Physics // TypeDefIndex: 4211
{
	// Properties
	public static Vector3 gravity { get; }
	[NativePropertyAttribute] // RVA: 0x488BE0 Offset: 0x488CE1 VA: 0x488BE0
	public static PhysicsScene defaultPhysicsScene { get; }
	public static bool autoSimulation { get; set; }

	// Methods

	[ThreadSafeAttribute] // RVA: 0x4865A0 Offset: 0x4866A1 VA: 0x4865A0
	// RVA: 0x3EE4510 Offset: 0x3EE4611 VA: 0x3EE4510
	public static Vector3 get_gravity() { }

	// RVA: 0x3EE45C0 Offset: 0x3EE46C1 VA: 0x3EE45C0
	public static PhysicsScene get_defaultPhysicsScene() { }

	// RVA: 0x3EE4660 Offset: 0x3EE4761 VA: 0x3EE4660
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4865B0 Offset: 0x4866B1 VA: 0x4865B0
	// RVA: 0x3EE46C0 Offset: 0x3EE47C1 VA: 0x3EE46C0
	public static void IgnoreCollision(Collider collider1, Collider collider2) { }

	// RVA: 0x3EE4720 Offset: 0x3EE4821 VA: 0x3EE4720
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4865C0 Offset: 0x4866C1 VA: 0x4865C0
	// RVA: 0x3EE4980 Offset: 0x3EE4A81 VA: 0x3EE4980
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4865D0 Offset: 0x4866D1 VA: 0x4865D0
	// RVA: 0x3EE4AC0 Offset: 0x3EE4BC1 VA: 0x3EE4AC0
	public static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4865E0 Offset: 0x4866E1 VA: 0x4865E0
	// RVA: 0x3EE4C00 Offset: 0x3EE4D01 VA: 0x3EE4C00
	public static bool Raycast(Vector3 origin, Vector3 direction) { }

	// RVA: 0x3EE4D40 Offset: 0x3EE4E41 VA: 0x3EE4D40
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4865F0 Offset: 0x4866F1 VA: 0x4865F0
	[ExcludeFromDocsAttribute] // RVA: 0x4865F0 Offset: 0x4866F1 VA: 0x4865F0
	// RVA: 0x3EE4FC0 Offset: 0x3EE50C1 VA: 0x3EE4FC0
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486630 Offset: 0x486731 VA: 0x486630
	// RVA: 0x3EE5120 Offset: 0x3EE5221 VA: 0x3EE5120
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486640 Offset: 0x486741 VA: 0x486640
	// RVA: 0x3EE5270 Offset: 0x3EE5371 VA: 0x3EE5270
	public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo) { }

	// RVA: 0x3EE53C0 Offset: 0x3EE54C1 VA: 0x3EE53C0
	public static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486650 Offset: 0x486751 VA: 0x486650
	// RVA: 0x3EE5510 Offset: 0x3EE5611 VA: 0x3EE5510
	public static bool Raycast(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486660 Offset: 0x486761 VA: 0x486660
	// RVA: 0x3EE5660 Offset: 0x3EE5761 VA: 0x3EE5660
	public static bool Raycast(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486670 Offset: 0x486771 VA: 0x486670
	// RVA: 0x3EE57A0 Offset: 0x3EE58A1 VA: 0x3EE57A0
	public static bool Raycast(Ray ray) { }

	// RVA: 0x3EE58E0 Offset: 0x3EE59E1 VA: 0x3EE58E0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486680 Offset: 0x486781 VA: 0x486680
	// RVA: 0x3EE5A50 Offset: 0x3EE5B51 VA: 0x3EE5A50
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486690 Offset: 0x486791 VA: 0x486690
	// RVA: 0x3EE5AE0 Offset: 0x3EE5BE1 VA: 0x3EE5AE0
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4866A0 Offset: 0x4867A1 VA: 0x4866A0
	// RVA: 0x3EE5C40 Offset: 0x3EE5D41 VA: 0x3EE5C40
	public static bool Raycast(Ray ray, out RaycastHit hitInfo) { }

	// RVA: 0x3EE5DA0 Offset: 0x3EE5EA1 VA: 0x3EE5DA0
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4866B0 Offset: 0x4867B1 VA: 0x4866B0
	// RVA: 0x3EE5F00 Offset: 0x3EE6001 VA: 0x3EE5F00
	public static bool Linecast(Vector3 start, Vector3 end, int layerMask) { }

	// RVA: 0x3EE5F10 Offset: 0x3EE6011 VA: 0x3EE5F10
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4866C0 Offset: 0x4867C1 VA: 0x4866C0
	// RVA: 0x3EE6090 Offset: 0x3EE6191 VA: 0x3EE6090
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask) { }

	// RVA: 0x3EE60A0 Offset: 0x3EE61A1 VA: 0x3EE60A0
	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE6340 Offset: 0x3EE6441 VA: 0x3EE6340
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4866D0 Offset: 0x4867D1 VA: 0x4866D0
	// RVA: 0x3EE65A0 Offset: 0x3EE66A1 VA: 0x3EE65A0
	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x3EE65B0 Offset: 0x3EE66B1 VA: 0x3EE65B0
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4866E0 Offset: 0x4867E1 VA: 0x4866E0
	// RVA: 0x3EE6650 Offset: 0x3EE6751 VA: 0x3EE6650
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask) { }

	// RVA: 0x3EE6700 Offset: 0x3EE6801 VA: 0x3EE6700
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4866F0 Offset: 0x4867F1 VA: 0x4866F0
	// RVA: 0x3EE6820 Offset: 0x3EE6921 VA: 0x3EE6820
	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x486700 Offset: 0x486801 VA: 0x486700
	[StaticAccessorAttribute] // RVA: 0x486700 Offset: 0x486801 VA: 0x486700
	// RVA: 0x3EE6910 Offset: 0x3EE6A11 VA: 0x3EE6910
	private static RaycastHit[] Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE6A10 Offset: 0x3EE6B11 VA: 0x3EE6A10
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486770 Offset: 0x486871 VA: 0x486770
	// RVA: 0x3EE6B70 Offset: 0x3EE6C71 VA: 0x3EE6B70
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486780 Offset: 0x486881 VA: 0x486780
	// RVA: 0x3EE6B80 Offset: 0x3EE6C81 VA: 0x3EE6B80
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486790 Offset: 0x486891 VA: 0x486790
	// RVA: 0x3EE6B90 Offset: 0x3EE6C91 VA: 0x3EE6B90
	public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction) { }

	// RVA: 0x3EE6BB0 Offset: 0x3EE6CB1 VA: 0x3EE6BB0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x4867A0 Offset: 0x4868A1 VA: 0x4867A0
	[ExcludeFromDocsAttribute] // RVA: 0x4867A0 Offset: 0x4868A1 VA: 0x4867A0
	// RVA: 0x3EE6C40 Offset: 0x3EE6D41 VA: 0x3EE6C40
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4867E0 Offset: 0x4868E1 VA: 0x4867E0
	// RVA: 0x3EE6CC0 Offset: 0x3EE6DC1 VA: 0x3EE6CC0
	public static RaycastHit[] RaycastAll(Ray ray, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4867F0 Offset: 0x4868F1 VA: 0x4867F0
	// RVA: 0x3EE6D40 Offset: 0x3EE6E41 VA: 0x3EE6D40
	public static RaycastHit[] RaycastAll(Ray ray) { }

	// RVA: 0x3EE6DC0 Offset: 0x3EE6EC1 VA: 0x3EE6DC0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486800 Offset: 0x486901 VA: 0x486800
	[RequiredByNativeCodeAttribute] // RVA: 0x486800 Offset: 0x486901 VA: 0x486800
	// RVA: 0x3EE6FB0 Offset: 0x3EE70B1 VA: 0x3EE6FB0
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486840 Offset: 0x486941 VA: 0x486840
	// RVA: 0x3EE7090 Offset: 0x3EE7191 VA: 0x3EE7090
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486850 Offset: 0x486951 VA: 0x486850
	// RVA: 0x3EE7160 Offset: 0x3EE7261 VA: 0x3EE7160
	public static int RaycastNonAlloc(Ray ray, RaycastHit[] results) { }

	// RVA: 0x3EE7230 Offset: 0x3EE7331 VA: 0x3EE7230
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486860 Offset: 0x486961 VA: 0x486860
	// RVA: 0x3EE7310 Offset: 0x3EE7411 VA: 0x3EE7310
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486870 Offset: 0x486971 VA: 0x486870
	// RVA: 0x3EE73F0 Offset: 0x3EE74F1 VA: 0x3EE73F0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results, float maxDistance) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486880 Offset: 0x486981 VA: 0x486880
	// RVA: 0x3EE74C0 Offset: 0x3EE75C1 VA: 0x3EE74C0
	public static int RaycastNonAlloc(Vector3 origin, Vector3 direction, RaycastHit[] results) { }

	[NativeNameAttribute] // RVA: 0x486890 Offset: 0x486991 VA: 0x486890
	[StaticAccessorAttribute] // RVA: 0x486890 Offset: 0x486991 VA: 0x486890
	// RVA: 0x3EE7580 Offset: 0x3EE7681 VA: 0x3EE7580
	private static Collider[] OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE7680 Offset: 0x3EE7781 VA: 0x3EE7680
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486900 Offset: 0x486A01 VA: 0x486900
	// RVA: 0x3EE7750 Offset: 0x3EE7851 VA: 0x3EE7750
	public static Collider[] OverlapSphere(Vector3 position, float radius, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x486910 Offset: 0x486A11 VA: 0x486910
	// RVA: 0x3EE7810 Offset: 0x3EE7911 VA: 0x3EE7810
	internal static void Simulate_Internal(PhysicsScene physicsScene, float step) { }

	// RVA: 0x3EE78C0 Offset: 0x3EE79C1 VA: 0x3EE78C0
	public static void Simulate(float step) { }

	// RVA: 0x3EE7A00 Offset: 0x3EE7B01 VA: 0x3EE7A00
	public static bool get_autoSimulation() { }

	// RVA: 0x3EE7A40 Offset: 0x3EE7B41 VA: 0x3EE7A40
	public static void set_autoSimulation(bool value) { }

	[StaticAccessorAttribute] // RVA: 0x486950 Offset: 0x486A51 VA: 0x486950
	[NativeNameAttribute] // RVA: 0x486950 Offset: 0x486A51 VA: 0x486950
	// RVA: 0x3EE7A90 Offset: 0x3EE7B91 VA: 0x3EE7A90
	private static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x3EE7BF0 Offset: 0x3EE7CF1 VA: 0x3EE7BF0
	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance) { }

	// RVA: 0x3EE7D10 Offset: 0x3EE7E11 VA: 0x3EE7D10
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x4869B0 Offset: 0x486AB1 VA: 0x4869B0
	// RVA: 0x3EE7E70 Offset: 0x3EE7F71 VA: 0x3EE7E70
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x4869C0 Offset: 0x486AC1 VA: 0x4869C0
	[StaticAccessorAttribute] // RVA: 0x4869C0 Offset: 0x486AC1 VA: 0x4869C0
	// RVA: 0x3EE7F40 Offset: 0x3EE8041 VA: 0x3EE7F40
	private static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE8050 Offset: 0x3EE8151 VA: 0x3EE8050
	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486A20 Offset: 0x486B21 VA: 0x486A20
	// RVA: 0x3EE8120 Offset: 0x3EE8221 VA: 0x3EE8120
	public static bool CheckSphere(Vector3 position, float radius, int layerMask) { }

	// RVA: 0x3EE81E0 Offset: 0x3EE82E1 VA: 0x3EE81E0
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486A30 Offset: 0x486B31 VA: 0x486A30
	// RVA: 0x3EE8410 Offset: 0x3EE8511 VA: 0x3EE8410
	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, RaycastHit[] results, float maxDistance, int layerMask) { }

	[NativeNameAttribute] // RVA: 0x486A40 Offset: 0x486B41 VA: 0x486A40
	[StaticAccessorAttribute] // RVA: 0x486A40 Offset: 0x486B41 VA: 0x486A40
	// RVA: 0x3EE8420 Offset: 0x3EE8521 VA: 0x3EE8420
	private static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE8540 Offset: 0x3EE8641 VA: 0x3EE8540
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486AA0 Offset: 0x486BA1 VA: 0x486AA0
	// RVA: 0x3EE8650 Offset: 0x3EE8751 VA: 0x3EE8650
	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask) { }

	// RVA: 0x3EE8750 Offset: 0x3EE8851 VA: 0x3EE8750
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486AB0 Offset: 0x486BB1 VA: 0x486AB0
	// RVA: 0x3EE8900 Offset: 0x3EE8A01 VA: 0x3EE8900
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask) { }

	// RVA: 0x3EE8A10 Offset: 0x3EE8B11 VA: 0x3EE8A10
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	[ExcludeFromDocsAttribute] // RVA: 0x486AC0 Offset: 0x486BC1 VA: 0x486AC0
	// RVA: 0x3EE8C20 Offset: 0x3EE8D21 VA: 0x3EE8C20
	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] results, Quaternion orientation, float maxDistance, int layerMask) { }

	// RVA: 0x3EE4570 Offset: 0x3EE4671 VA: 0x3EE4570
	private static void get_gravity_Injected(out Vector3 ret) { }

	// RVA: 0x3EE4610 Offset: 0x3EE4711 VA: 0x3EE4610
	private static void get_defaultPhysicsScene_Injected(out PhysicsScene ret) { }

	// RVA: 0x3EE6990 Offset: 0x3EE6A91 VA: 0x3EE6990
	private static RaycastHit[] Internal_RaycastAll_Injected(ref PhysicsScene physicsScene, ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE7600 Offset: 0x3EE7701 VA: 0x3EE7600
	private static Collider[] OverlapSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE7870 Offset: 0x3EE7971 VA: 0x3EE7870
	private static void Simulate_Internal_Injected(ref PhysicsScene physicsScene, float step) { }

	// RVA: 0x3EE7B50 Offset: 0x3EE7C51 VA: 0x3EE7B50
	private static bool Query_ComputePenetration_Injected(Collider colliderA, ref Vector3 positionA, ref Quaternion rotationA, Collider colliderB, ref Vector3 positionB, ref Quaternion rotationB, ref Vector3 direction, ref float distance) { }

	// RVA: 0x3EE7FD0 Offset: 0x3EE80D1 VA: 0x3EE7FD0
	private static bool CheckSphere_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction) { }

	// RVA: 0x3EE84C0 Offset: 0x3EE85C1 VA: 0x3EE84C0
	private static bool CheckBox_Internal_Injected(ref PhysicsScene physicsScene, ref Vector3 center, ref Vector3 halfExtents, ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction) { }
}

