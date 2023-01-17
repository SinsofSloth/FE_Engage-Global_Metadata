// Namespace: UnityEngine.UI
internal static class ListPool<T> // TypeDefIndex: 4358
{
	// Fields
	private static readonly ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void Clear(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B071A0 Offset: 0x3B072A1 VA: 0x3B071A0
	|-ListPool<Color32>.Clear
	|
	|-RVA: 0x3B076E0 Offset: 0x3B077E1 VA: 0x3B076E0
	|-ListPool<int>.Clear
	|
	|-RVA: 0x3B07C20 Offset: 0x3B07D21 VA: 0x3B07C20
	|-ListPool<object>.Clear
	|
	|-RVA: 0x3B08160 Offset: 0x3B08261 VA: 0x3B08160
	|-ListPool<UIVertex>.Clear
	|
	|-RVA: 0x3B086A0 Offset: 0x3B087A1 VA: 0x3B086A0
	|-ListPool<Vector3>.Clear
	|
	|-RVA: 0x3B08BE0 Offset: 0x3B08CE1 VA: 0x3B08BE0
	|-ListPool<Vector4>.Clear
	*/

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B07CA0 Offset: 0x3B07DA1 VA: 0x3B07CA0
	|-ListPool<Canvas>.Get
	|-ListPool<Component>.Get
	|-ListPool<Mask>.Get
	|-ListPool<object>.Get
	|-ListPool<RectMask2D>.Get
	|
	|-RVA: 0x3B07220 Offset: 0x3B07321 VA: 0x3B07220
	|-ListPool<Color32>.Get
	|
	|-RVA: 0x3B07760 Offset: 0x3B07861 VA: 0x3B07760
	|-ListPool<int>.Get
	|
	|-RVA: 0x3B081E0 Offset: 0x3B082E1 VA: 0x3B081E0
	|-ListPool<UIVertex>.Get
	|
	|-RVA: 0x3B08720 Offset: 0x3B08821 VA: 0x3B08720
	|-ListPool<Vector3>.Get
	|
	|-RVA: 0x3B08C60 Offset: 0x3B08D61 VA: 0x3B08C60
	|-ListPool<Vector4>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B07E30 Offset: 0x3B07F31 VA: 0x3B07E30
	|-ListPool<Canvas>.Release
	|-ListPool<Component>.Release
	|-ListPool<Mask>.Release
	|-ListPool<object>.Release
	|-ListPool<RectMask2D>.Release
	|
	|-RVA: 0x3B073B0 Offset: 0x3B074B1 VA: 0x3B073B0
	|-ListPool<Color32>.Release
	|
	|-RVA: 0x3B078F0 Offset: 0x3B079F1 VA: 0x3B078F0
	|-ListPool<int>.Release
	|
	|-RVA: 0x3B08370 Offset: 0x3B08471 VA: 0x3B08370
	|-ListPool<UIVertex>.Release
	|
	|-RVA: 0x3B088B0 Offset: 0x3B089B1 VA: 0x3B088B0
	|-ListPool<Vector3>.Release
	|
	|-RVA: 0x3B08DF0 Offset: 0x3B08EF1 VA: 0x3B08DF0
	|-ListPool<Vector4>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3B07540 Offset: 0x3B07641 VA: 0x3B07540
	|-ListPool<Color32>..cctor
	|
	|-RVA: 0x3B07A80 Offset: 0x3B07B81 VA: 0x3B07A80
	|-ListPool<int>..cctor
	|
	|-RVA: 0x3B07FC0 Offset: 0x3B080C1 VA: 0x3B07FC0
	|-ListPool<object>..cctor
	|
	|-RVA: 0x3B08500 Offset: 0x3B08601 VA: 0x3B08500
	|-ListPool<UIVertex>..cctor
	|
	|-RVA: 0x3B08A40 Offset: 0x3B08B41 VA: 0x3B08A40
	|-ListPool<Vector3>..cctor
	|
	|-RVA: 0x3B08F80 Offset: 0x3B09081 VA: 0x3B08F80
	|-ListPool<Vector4>..cctor
	*/
}

