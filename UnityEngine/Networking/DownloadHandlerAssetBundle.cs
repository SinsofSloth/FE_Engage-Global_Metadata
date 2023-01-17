// Namespace: UnityEngine.Networking
[NativeHeaderAttribute] // RVA: 0x85FF0 Offset: 0x860F1 VA: 0x85FF0
public sealed class DownloadHandlerAssetBundle : DownloadHandler // TypeDefIndex: 4764
{
	// Properties
	public AssetBundle assetBundle { get; }

	// Methods

	// RVA: 0x1C6C7D0 Offset: 0x1C6C8D1 VA: 0x1C6C7D0
	private static IntPtr Create(DownloadHandlerAssetBundle obj, string url, uint crc) { }

	// RVA: 0x1C6C830 Offset: 0x1C6C931 VA: 0x1C6C830
	private static IntPtr CreateCached(DownloadHandlerAssetBundle obj, string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x1C6C920 Offset: 0x1C6CA21 VA: 0x1C6C920
	private void InternalCreateAssetBundle(string url, uint crc) { }

	// RVA: 0x1C6C980 Offset: 0x1C6CA81 VA: 0x1C6C980
	private void InternalCreateAssetBundleCached(string url, string name, Hash128 hash, uint crc) { }

	// RVA: 0x1C6CA00 Offset: 0x1C6CB01 VA: 0x1C6CA00
	public void .ctor(string url, uint crc) { }

	// RVA: 0x1C6CA70 Offset: 0x1C6CB71 VA: 0x1C6CA70
	public void .ctor(string url, CachedAssetBundle cachedBundle, uint crc) { }

	// RVA: 0x1C6CB20 Offset: 0x1C6CC21 VA: 0x1C6CB20 Slot: 5
	protected override byte[] GetData() { }

	// RVA: 0x1C6CB80 Offset: 0x1C6CC81 VA: 0x1C6CB80 Slot: 6
	protected override string GetText() { }

	// RVA: 0x1C6CBE0 Offset: 0x1C6CCE1 VA: 0x1C6CBE0
	public AssetBundle get_assetBundle() { }

	// RVA: 0x1C6C8B0 Offset: 0x1C6C9B1 VA: 0x1C6C8B0
	private static IntPtr CreateCached_Injected(DownloadHandlerAssetBundle obj, string url, string name, ref Hash128 hash, uint crc) { }
}

