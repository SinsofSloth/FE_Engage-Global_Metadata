// Namespace: UnityEngine.Rendering
[ExtensionAttribute] // RVA: 0x3B4C0 Offset: 0x3B5C1 VA: 0x3B4C0
public static class CoreUnsafeUtils // TypeDefIndex: 4520
{
	// Methods

	[ExtensionAttribute] // RVA: 0x3D5B0 Offset: 0x3D6B1 VA: 0x3D5B0
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(List<T> list, void* dest, int count) { }

	[ExtensionAttribute] // RVA: 0x3D5C0 Offset: 0x3D6C1 VA: 0x3D5C0
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(T[] list, void* dest, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229CAC0 Offset: 0x229CBC1 VA: 0x229CAC0
	|-CoreUnsafeUtils.CopyTo<int>
	*/

	// RVA: 0x1B2DBE0 Offset: 0x1B2DCE1 VA: 0x1B2DBE0
	public static void QuickSort(uint[] arr, int left, int right) { }

	// RVA: -1 Offset: -1
	public static void QuickSort<T>(int count, void* data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229CFE0 Offset: 0x229D0E1 VA: 0x229CFE0
	|-CoreUnsafeUtils.QuickSort<int>
	*/

	// RVA: -1 Offset: -1
	public static void QuickSort<TValue, TKey, TGetter>(int count, void* data) { }

	// RVA: -1 Offset: -1
	public static void QuickSort<TValue, TKey, TGetter>(void* data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D000 Offset: 0x229D101 VA: 0x229D000
	|-CoreUnsafeUtils.QuickSort<int, int, CoreUnsafeUtils.DefaultKeyGetter<int>>
	|
	|-RVA: 0x229D0B0 Offset: 0x229D1B1 VA: 0x229D0B0
	|-CoreUnsafeUtils.QuickSort<uint, uint, CoreUnsafeUtils.UintKeyGetter>
	*/

	// RVA: -1 Offset: -1
	public static int IndexOf<T>(void* data, int count, T v) { }

	// RVA: -1 Offset: -1
	public static int CompareHashes<TOldValue, TOldGetter, TNewValue, TNewGetter>(int oldHashCount, void* oldHashes, int newHashCount, void* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229C400 Offset: 0x229C501 VA: 0x229C400
	|-CoreUnsafeUtils.CompareHashes<Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>, Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	*/

	// RVA: 0x1B2DC60 Offset: 0x1B2DD61 VA: 0x1B2DC60
	public static int CompareHashes(int oldHashCount, Hash128* oldHashes, int newHashCount, Hash128* newHashes, int* addIndices, int* removeIndices, out int addCount, out int remCount) { }

	// RVA: -1 Offset: -1
	public static void CombineHashes<TValue, TGetter>(int count, void* hashes, Hash128* outHash) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229C2B0 Offset: 0x229C3B1 VA: 0x229C2B0
	|-CoreUnsafeUtils.CombineHashes<Hash128, CoreUnsafeUtils.DefaultKeyGetter<Hash128>>
	*/

	// RVA: 0x1B2DD10 Offset: 0x1B2DE11 VA: 0x1B2DD10
	public static void CombineHashes(int count, Hash128* hashes, Hash128* outHash) { }

	// RVA: -1 Offset: -1
	private static int Partition<TValue, TKey, TGetter>(void* data, int left, int right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229CB60 Offset: 0x229CC61 VA: 0x229CB60
	|-CoreUnsafeUtils.Partition<int, int, CoreUnsafeUtils.DefaultKeyGetter<int>>
	|
	|-RVA: 0x229CE70 Offset: 0x229CF71 VA: 0x229CE70
	|-CoreUnsafeUtils.Partition<uint, uint, CoreUnsafeUtils.UintKeyGetter>
	*/

	// RVA: 0x1B2DD80 Offset: 0x1B2DE81 VA: 0x1B2DD80
	public static bool HaveDuplicates(int[] arr) { }
}

