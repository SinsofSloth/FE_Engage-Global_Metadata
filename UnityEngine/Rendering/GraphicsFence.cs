// Namespace: UnityEngine.Rendering
[UsedByNativeCodeAttribute] // RVA: 0x440920 Offset: 0x440A21 VA: 0x440920
[NativeHeaderAttribute] // RVA: 0x440920 Offset: 0x440A21 VA: 0x440920
public struct GraphicsFence // TypeDefIndex: 3917
{
	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8
	internal GraphicsFenceType m_FenceType; // 0xC

	// Methods

	// RVA: 0x2F19610 Offset: 0x2F19711 VA: 0x2F19610
	internal static SynchronisationStageFlags TranslateSynchronizationStageToFlags(SynchronisationStage s) { }

	// RVA: 0x2F19470 Offset: 0x2F19571 VA: 0x2F19470
	internal void InitPostAllocation() { }

	// RVA: 0x2F197B0 Offset: 0x2F198B1 VA: 0x2F197B0
	internal bool IsFencePending() { }

	// RVA: 0x2F19560 Offset: 0x2F19661 VA: 0x2F19560
	internal void Validate() { }

	// RVA: 0x2F24A20 Offset: 0x2F24B21 VA: 0x2F24A20
	private int GetPlatformNotSupportedVersion() { }

	[NativeThrowsAttribute] // RVA: 0x4531E0 Offset: 0x4532E1 VA: 0x4531E0
	[FreeFunctionAttribute] // RVA: 0x4531E0 Offset: 0x4532E1 VA: 0x4531E0
	// RVA: 0x2F24A30 Offset: 0x2F24B31 VA: 0x2F24A30
	private static int GetVersionNumber(IntPtr fencePtr) { }
}

