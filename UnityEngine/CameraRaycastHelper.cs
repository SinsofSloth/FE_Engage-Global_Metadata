// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x77800 Offset: 0x77901 VA: 0x77800
internal class CameraRaycastHelper // TypeDefIndex: 4041
{
	// Methods

	[FreeFunctionAttribute] // RVA: 0x77880 Offset: 0x77981 VA: 0x77880
	// RVA: 0x1C61DE0 Offset: 0x1C61EE1 VA: 0x1C61DE0
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0x778C0 Offset: 0x779C1 VA: 0x778C0
	// RVA: 0x1C61EC0 Offset: 0x1C61FC1 VA: 0x1C61EC0
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1C61E50 Offset: 0x1C61F51 VA: 0x1C61E50
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x1C61F30 Offset: 0x1C62031 VA: 0x1C61F30
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }
}

