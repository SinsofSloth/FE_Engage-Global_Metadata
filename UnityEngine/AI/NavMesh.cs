// Namespace: UnityEngine.AI
[MovedFromAttribute] // RVA: 0x70CC0 Offset: 0x70DC1 VA: 0x70CC0
[StaticAccessorAttribute] // RVA: 0x70CC0 Offset: 0x70DC1 VA: 0x70CC0
[NativeHeaderAttribute] // RVA: 0x70CC0 Offset: 0x70DC1 VA: 0x70CC0
[NativeHeaderAttribute] // RVA: 0x70CC0 Offset: 0x70DC1 VA: 0x70CC0
public static class NavMesh // TypeDefIndex: 7506
{
	// Fields
	public static NavMesh.OnNavMeshPreUpdate onPreUpdate; // 0x0

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x70F30 Offset: 0x71031 VA: 0x70F30
	// RVA: 0x1C6A5C0 Offset: 0x1C6A6C1 VA: 0x1C6A5C0
	private static void Internal_CallOnNavMeshPreUpdate() { }

	// RVA: 0x1C6A830 Offset: 0x1C6A931 VA: 0x1C6A830
	public static bool CalculatePath(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x1C6A960 Offset: 0x1C6AA61 VA: 0x1C6A960
	private static bool CalculatePathInternal(Vector3 sourcePosition, Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x1C6AA50 Offset: 0x1C6AB51 VA: 0x1C6AA50
	public static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }

	// RVA: 0x1C6A9E0 Offset: 0x1C6AAE1 VA: 0x1C6A9E0
	private static bool CalculatePathInternal_Injected(ref Vector3 sourcePosition, ref Vector3 targetPosition, int areaMask, NavMeshPath path) { }

	// RVA: 0x1C6AAD0 Offset: 0x1C6ABD1 VA: 0x1C6AAD0
	private static bool SamplePosition_Injected(ref Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask) { }
}

