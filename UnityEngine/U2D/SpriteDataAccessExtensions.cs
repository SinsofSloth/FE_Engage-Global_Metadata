// Namespace: UnityEngine.U2D
[ExtensionAttribute] // RVA: 0x43F390 Offset: 0x43F491 VA: 0x43F390
[NativeHeaderAttribute] // RVA: 0x43F390 Offset: 0x43F491 VA: 0x43F390
[NativeHeaderAttribute] // RVA: 0x43F390 Offset: 0x43F491 VA: 0x43F390
public static class SpriteDataAccessExtensions // TypeDefIndex: 3663
{
	// Methods

	// RVA: -1 Offset: -1
	private static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201E600 Offset: 0x201E701 VA: 0x201E600
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<object>
	|
	|-RVA: 0x201E900 Offset: 0x201EA01 VA: 0x201E900
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<Vector2>
	|
	|-RVA: 0x201EC00 Offset: 0x201ED01 VA: 0x201EC00
	|-SpriteDataAccessExtensions.CheckAttributeTypeMatchesAndThrow<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x452100 Offset: 0x452201 VA: 0x452100
	// RVA: -1 Offset: -1
	public static NativeSlice<T> GetVertexAttribute<T>(Sprite sprite, VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201EF00 Offset: 0x201F001 VA: 0x201EF00
	|-SpriteDataAccessExtensions.GetVertexAttribute<Vector2>
	|
	|-RVA: 0x201EFD0 Offset: 0x201F0D1 VA: 0x201EFD0
	|-SpriteDataAccessExtensions.GetVertexAttribute<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x452110 Offset: 0x452211 VA: 0x452110
	// RVA: 0x31F1360 Offset: 0x31F1461 VA: 0x31F1360
	public static NativeArray<ushort> GetIndices(Sprite sprite) { }

	// RVA: 0x31F1410 Offset: 0x31F1511 VA: 0x31F1410
	private static SpriteChannelInfo GetIndicesInfo(Sprite sprite) { }

	// RVA: 0x31F14E0 Offset: 0x31F15E1 VA: 0x31F14E0
	private static SpriteChannelInfo GetChannelInfo(Sprite sprite, VertexAttribute channel) { }

	// RVA: 0x31F1490 Offset: 0x31F1591 VA: 0x31F1490
	private static void GetIndicesInfo_Injected(Sprite sprite, out SpriteChannelInfo ret) { }

	// RVA: 0x31F1560 Offset: 0x31F1661 VA: 0x31F1560
	private static void GetChannelInfo_Injected(Sprite sprite, VertexAttribute channel, out SpriteChannelInfo ret) { }
}

