// Namespace: 
internal struct DeferredTiler.PrePunctualLight // TypeDefIndex: 5392
{
	// Fields
	public float3 posVS; // 0x0
	public float radius; // 0xC
	public float minDist; // 0x10
	public float2 screenPos; // 0x14
	public ushort visLightIndex; // 0x1C
}

// Namespace: 
private enum DeferredTiler.ClipResult // TypeDefIndex: 5393
{
	// Fields
	public int value__; // 0x0
	public const DeferredTiler.ClipResult Unknown = 0;
	public const DeferredTiler.ClipResult In = 1;
	public const DeferredTiler.ClipResult Out = 2;
}

