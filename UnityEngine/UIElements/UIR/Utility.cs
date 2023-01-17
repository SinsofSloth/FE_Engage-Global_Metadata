// Namespace: UnityEngine.UIElements.UIR
[VisibleToOtherModulesAttribute] // RVA: 0x74930 Offset: 0x74A31 VA: 0x74930
[NativeHeaderAttribute] // RVA: 0x74930 Offset: 0x74A31 VA: 0x74930
internal class Utility // TypeDefIndex: 7571
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x749E0 Offset: 0x74AE1 VA: 0x749E0
	[DebuggerBrowsableAttribute] // RVA: 0x749E0 Offset: 0x74AE1 VA: 0x749E0
	private static Action<bool> GraphicsResourcesRecreate; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x74A20 Offset: 0x74B21 VA: 0x74A20
	[DebuggerBrowsableAttribute] // RVA: 0x74A20 Offset: 0x74B21 VA: 0x74A20
	private static Action EngineUpdate; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x74A60 Offset: 0x74B61 VA: 0x74A60
	[CompilerGeneratedAttribute] // RVA: 0x74A60 Offset: 0x74B61 VA: 0x74A60
	private static Action FlushPendingResources; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x74AA0 Offset: 0x74BA1 VA: 0x74AA0
	[DebuggerBrowsableAttribute] // RVA: 0x74AA0 Offset: 0x74BA1 VA: 0x74AA0
	private static Action<Camera> RegisterIntermediateRenderers; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x74AE0 Offset: 0x74BE1 VA: 0x74AE0
	[CompilerGeneratedAttribute] // RVA: 0x74AE0 Offset: 0x74BE1 VA: 0x74AE0
	private static Action<IntPtr> RenderNodeAdd; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x74B20 Offset: 0x74C21 VA: 0x74B20
	[DebuggerBrowsableAttribute] // RVA: 0x74B20 Offset: 0x74C21 VA: 0x74B20
	private static Action<IntPtr> RenderNodeExecute; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x74B60 Offset: 0x74C61 VA: 0x74B60
	[CompilerGeneratedAttribute] // RVA: 0x74B60 Offset: 0x74C61 VA: 0x74B60
	private static Action<IntPtr> RenderNodeCleanup; // 0x30
	private static ProfilerMarker s_MarkerRaiseEngineUpdate; // 0x38

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x74BE0 Offset: 0x74CE1 VA: 0x74BE0
	// RVA: 0x1C69910 Offset: 0x1C69A11 VA: 0x1C69910
	internal static void RaiseGraphicsResourcesRecreate(bool recreate) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x74BF0 Offset: 0x74CF1 VA: 0x74BF0
	// RVA: 0x1C699C0 Offset: 0x1C69AC1 VA: 0x1C699C0
	internal static void RaiseEngineUpdate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x74C00 Offset: 0x74D01 VA: 0x74C00
	// RVA: 0x1C69A70 Offset: 0x1C69B71 VA: 0x1C69A70
	internal static void RaiseFlushPendingResources() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x74C10 Offset: 0x74D11 VA: 0x74C10
	// RVA: 0x1C69B00 Offset: 0x1C69C01 VA: 0x1C69B00
	internal static void RaiseRegisterIntermediateRenderers(Camera camera) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x74C20 Offset: 0x74D21 VA: 0x74C20
	// RVA: 0x1C69BB0 Offset: 0x1C69CB1 VA: 0x1C69BB0
	internal static void RaiseRenderNodeAdd(IntPtr userData) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x74C30 Offset: 0x74D31 VA: 0x74C30
	// RVA: 0x1C69C60 Offset: 0x1C69D61 VA: 0x1C69C60
	internal static void RaiseRenderNodeExecute(IntPtr userData) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x74C40 Offset: 0x74D41 VA: 0x74C40
	// RVA: 0x1C69D10 Offset: 0x1C69E11 VA: 0x1C69D10
	internal static void RaiseRenderNodeCleanup(IntPtr userData) { }

	// RVA: 0x1C69DC0 Offset: 0x1C69EC1 VA: 0x1C69DC0
	private static void .cctor() { }
}

