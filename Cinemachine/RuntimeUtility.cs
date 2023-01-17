// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BA00 Offset: 0x1BB01 VA: 0x1BA00
public static class RuntimeUtility // TypeDefIndex: 5857
{
	// Fields
	private static RaycastHit[] s_HitBuffer; // 0x0
	private static int[] s_PenetrationIndexBuffer; // 0x8
	private static SphereCollider s_ScratchCollider; // 0x10
	private static GameObject s_ScratchColliderGameObject; // 0x18

	// Methods

	// RVA: 0x1A74030 Offset: 0x1A74131 VA: 0x1A74030
	public static void DestroyObject(Object obj) { }

	// RVA: 0x1A7D690 Offset: 0x1A7D791 VA: 0x1A7D690
	public static bool IsPrefab(GameObject gameObject) { }

	// RVA: 0x1A831C0 Offset: 0x1A832C1 VA: 0x1A831C0
	public static bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

	// RVA: 0x1A834C0 Offset: 0x1A835C1 VA: 0x1A834C0
	public static bool SphereCastIgnoreTag(Vector3 rayStart, float radius, Vector3 dir, out RaycastHit hitInfo, float rayLength, int layerMask, in string ignoreTag) { }

	// RVA: 0x1A83C60 Offset: 0x1A83D61 VA: 0x1A83C60
	internal static SphereCollider GetScratchCollider() { }

	// RVA: 0x1A83EA0 Offset: 0x1A83FA1 VA: 0x1A83EA0
	internal static void DestroyScratchCollider() { }

	// RVA: 0x1A84010 Offset: 0x1A84111 VA: 0x1A84010
	private static void .cctor() { }
}

