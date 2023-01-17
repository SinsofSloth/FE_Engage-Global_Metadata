// Namespace: 
private struct DeferredLights.CullLightsJob : IJob // TypeDefIndex: 5386
{
	// Fields
	public DeferredTiler tiler; // 0x0
	[ReadOnlyAttribute] // RVA: 0x4830D0 Offset: 0x4831D1 VA: 0x4830D0
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x4830D0 Offset: 0x4831D1 VA: 0x4830D0
	public NativeArray<DeferredTiler.PrePunctualLight> prePunctualLights; // 0x78
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x483110 Offset: 0x483211 VA: 0x483110
	[ReadOnlyAttribute] // RVA: 0x483110 Offset: 0x483211 VA: 0x483110
	public NativeArray<ushort> coarseTiles; // 0x88
	[ReadOnlyAttribute] // RVA: 0x483150 Offset: 0x483251 VA: 0x483150
	[NativeDisableContainerSafetyRestrictionAttribute] // RVA: 0x483150 Offset: 0x483251 VA: 0x483150
	public NativeArray<uint> coarseTileHeaders; // 0x98
	public int coarseHeaderOffset; // 0xA8
	public int istart; // 0xAC
	public int iend; // 0xB0
	public int jstart; // 0xB4
	public int jend; // 0xB8

	// Methods

	// RVA: 0x2FA2770 Offset: 0x2FA2871 VA: 0x2FA2770 Slot: 4
	public void Execute() { }
}

// Namespace: 
internal enum DeferredLights.GBufferHandles // TypeDefIndex: 5388
{
	// Fields
	public int value__; // 0x0
	public const DeferredLights.GBufferHandles DepthAsColor = 0;
	public const DeferredLights.GBufferHandles Albedo = 1;
	public const DeferredLights.GBufferHandles SpecularMetallic = 2;
	public const DeferredLights.GBufferHandles NormalSmoothness = 3;
	public const DeferredLights.GBufferHandles Lighting = 4;
	public const DeferredLights.GBufferHandles ShadowMask = 5;
	public const DeferredLights.GBufferHandles Count = 6;
}

