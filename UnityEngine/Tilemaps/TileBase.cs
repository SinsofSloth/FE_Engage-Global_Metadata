// Namespace: UnityEngine.Tilemaps
[RequiredByNativeCodeAttribute] // RVA: 0x6F170 Offset: 0x6F271 VA: 0x6F170
public abstract class TileBase : ScriptableObject // TypeDefIndex: 4218
{
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F520 Offset: 0x6F621 VA: 0x6F520
	// RVA: 0x1C6A220 Offset: 0x1C6A321 VA: 0x1C6A220 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F530 Offset: 0x6F631 VA: 0x6F530
	// RVA: 0x1C6A280 Offset: 0x1C6A381 VA: 0x1C6A280 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x1C6A290 Offset: 0x1C6A391 VA: 0x1C6A290
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F540 Offset: 0x6F641 VA: 0x6F540
	// RVA: 0x1C6A320 Offset: 0x1C6A421 VA: 0x1C6A320 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x1C6A330 Offset: 0x1C6A431 VA: 0x1C6A330
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F550 Offset: 0x6F651 VA: 0x6F550
	// RVA: 0x1C6A370 Offset: 0x1C6A471 VA: 0x1C6A370 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	// RVA: 0x1C6A210 Offset: 0x1C6A311 VA: 0x1C6A210
	protected void .ctor() { }
}

