// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C530 Offset: 0x43C631 VA: 0x43C530
[StaticAccessorAttribute] // RVA: 0x43C530 Offset: 0x43C631 VA: 0x43C530
[NativeHeaderAttribute] // RVA: 0x43C530 Offset: 0x43C631 VA: 0x43C530
[NativeHeaderAttribute] // RVA: 0x43C530 Offset: 0x43C631 VA: 0x43C530
[NativeHeaderAttribute] // RVA: 0x43C530 Offset: 0x43C631 VA: 0x43C530
public sealed class GL // TypeDefIndex: 3445
{
	// Properties
	public static bool wireframe { get; }
	[NativePropertyAttribute] // RVA: 0x459680 Offset: 0x459781 VA: 0x459680
	public static bool invertCulling { get; set; }

	// Methods

	// RVA: 0x2F21FA0 Offset: 0x2F220A1 VA: 0x2F21FA0
	public static bool get_wireframe() { }

	// RVA: 0x2F21FE0 Offset: 0x2F220E1 VA: 0x2F21FE0
	public static bool get_invertCulling() { }

	// RVA: 0x2F22020 Offset: 0x2F22121 VA: 0x2F22020
	public static void set_invertCulling(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x447870 Offset: 0x447971 VA: 0x447870
	// RVA: 0x2F22070 Offset: 0x2F22171 VA: 0x2F22070
	public static Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture) { }

	// RVA: 0x2F22110 Offset: 0x2F22211 VA: 0x2F22110
	private static void GetGPUProjectionMatrix_Injected(ref Matrix4x4 proj, bool renderIntoTexture, out Matrix4x4 ret) { }
}

