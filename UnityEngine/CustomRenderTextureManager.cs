// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43C2A0 Offset: 0x43C3A1 VA: 0x43C2A0
public static class CustomRenderTextureManager // TypeDefIndex: 3437
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x442810 Offset: 0x442911 VA: 0x442810
	[CompilerGeneratedAttribute] // RVA: 0x442810 Offset: 0x442911 VA: 0x442810
	private static Action<CustomRenderTexture> textureLoaded; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x442850 Offset: 0x442951 VA: 0x442850
	[CompilerGeneratedAttribute] // RVA: 0x442850 Offset: 0x442951 VA: 0x442850
	private static Action<CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x447400 Offset: 0x447501 VA: 0x447400
	// RVA: 0x2F1E540 Offset: 0x2F1E641 VA: 0x2F1E540
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x447410 Offset: 0x447511 VA: 0x447410
	// RVA: 0x2F1E5D0 Offset: 0x2F1E6D1 VA: 0x2F1E5D0
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }
}

