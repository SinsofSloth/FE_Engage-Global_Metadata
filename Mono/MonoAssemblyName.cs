// Namespace: Mono
internal struct MonoAssemblyName // TypeDefIndex: 19
{
	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBufferAttribute] // RVA: 0x477E30 Offset: 0x477F31 VA: 0x477E30
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48
}

