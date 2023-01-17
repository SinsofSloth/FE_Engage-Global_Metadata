// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[ExcludeFromPresetAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
[NativeHeaderAttribute] // RVA: 0x48FA70 Offset: 0x48FB71 VA: 0x48FA70
public class AssetBundle : Object // TypeDefIndex: 4236
{
	// Methods

	// RVA: 0x3F0CBA0 Offset: 0x3F0CCA1 VA: 0x3F0CBA0
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0x48FD20 Offset: 0x48FE21 VA: 0x48FD20
	// RVA: 0x3F0CC10 Offset: 0x3F0CD11 VA: 0x3F0CC10
	internal static AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x3F0CC70 Offset: 0x3F0CD71 VA: 0x3F0CC70
	public static AssetBundleCreateRequest LoadFromFileAsync(string path) { }

	// RVA: 0x3F0CCC0 Offset: 0x3F0CDC1 VA: 0x3F0CCC0
	public static AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc) { }

	[FreeFunctionAttribute] // RVA: 0x48FD60 Offset: 0x48FE61 VA: 0x48FD60
	// RVA: 0x3F0CD20 Offset: 0x3F0CE21 VA: 0x3F0CD20
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x3F0CD80 Offset: 0x3F0CE81 VA: 0x3F0CD80
	public static AssetBundle LoadFromFile(string path, uint crc) { }

	[FreeFunctionAttribute] // RVA: 0x48FDA0 Offset: 0x48FEA1 VA: 0x48FDA0
	// RVA: 0x3F0CDE0 Offset: 0x3F0CEE1 VA: 0x3F0CDE0
	internal static AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc) { }

	// RVA: 0x3F0CE30 Offset: 0x3F0CF31 VA: 0x3F0CE30
	public static AssetBundle LoadFromMemory(byte[] binary) { }

	[TypeInferenceRuleAttribute] // RVA: 0x48FDE0 Offset: 0x48FEE1 VA: 0x48FDE0
	// RVA: 0x3F0CE80 Offset: 0x3F0CF81 VA: 0x3F0CE80
	public Object LoadAsset(string name, Type type) { }

	[TypeInferenceRuleAttribute] // RVA: 0x48FE00 Offset: 0x48FF01 VA: 0x48FE00
	[NativeMethodAttribute] // RVA: 0x48FE00 Offset: 0x48FF01 VA: 0x48FE00
	[NativeThrowsAttribute] // RVA: 0x48FE00 Offset: 0x48FF01 VA: 0x48FE00
	// RVA: 0x3F0CF90 Offset: 0x3F0D091 VA: 0x3F0CF90
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x3F0CFF0 Offset: 0x3F0D0F1 VA: 0x3F0CFF0
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x3F0D160 Offset: 0x3F0D261 VA: 0x3F0D160
	public Object[] LoadAssetWithSubAssets(string name, Type type) { }

	// RVA: 0x3F0D2D0 Offset: 0x3F0D3D1 VA: 0x3F0D2D0
	public AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, Type type) { }

	// RVA: -1 Offset: -1
	public AssetBundleRequest LoadAllAssetsAsync<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2734C80 Offset: 0x2734D81 VA: 0x2734C80
	|-AssetBundle.LoadAllAssetsAsync<object>
	|-AssetBundle.LoadAllAssetsAsync<TextAsset>
	*/

	// RVA: 0x3F0D440 Offset: 0x3F0D541 VA: 0x3F0D440
	public AssetBundleRequest LoadAllAssetsAsync(Type type) { }

	[NativeMethodAttribute] // RVA: 0x48FE60 Offset: 0x48FF61 VA: 0x48FE60
	[NativeThrowsAttribute] // RVA: 0x48FE60 Offset: 0x48FF61 VA: 0x48FE60
	// RVA: 0x3F0D100 Offset: 0x3F0D201 VA: 0x3F0D100
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeMethodAttribute] // RVA: 0x48FEB0 Offset: 0x48FFB1 VA: 0x48FEB0
	// RVA: 0x3F0D510 Offset: 0x3F0D611 VA: 0x3F0D510
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeThrowsAttribute] // RVA: 0x48FEF0 Offset: 0x48FFF1 VA: 0x48FEF0
	[NativeMethodAttribute] // RVA: 0x48FEF0 Offset: 0x48FFF1 VA: 0x48FEF0
	// RVA: 0x3F0D270 Offset: 0x3F0D371 VA: 0x3F0D270
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }

	[NativeThrowsAttribute] // RVA: 0x48FF40 Offset: 0x490041 VA: 0x48FF40
	[NativeMethodAttribute] // RVA: 0x48FF40 Offset: 0x490041 VA: 0x48FF40
	// RVA: 0x3F0D3E0 Offset: 0x3F0D4E1 VA: 0x3F0D3E0
	private AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, Type type) { }
}

