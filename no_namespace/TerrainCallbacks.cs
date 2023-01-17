// Namespace: 
public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 7550
{
	// Methods

	// RVA: 0x3F07360 Offset: 0x3F07461 VA: 0x3F07360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3F04BD0 Offset: 0x3F04CD1 VA: 0x3F04BD0 Slot: 13
	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	// RVA: 0x3F07380 Offset: 0x3F07481 VA: 0x3F07380 Slot: 14
	public virtual IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, bool synched, AsyncCallback callback, object object) { }

	// RVA: 0x3F07450 Offset: 0x3F07551 VA: 0x3F07450 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 7551
{
	// Methods

	// RVA: 0x3F07460 Offset: 0x3F07561 VA: 0x3F07460
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3F050A0 Offset: 0x3F051A1 VA: 0x3F050A0 Slot: 13
	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	// RVA: 0x3F07480 Offset: 0x3F07581 VA: 0x3F07480 Slot: 14
	public virtual IAsyncResult BeginInvoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched, AsyncCallback callback, object object) { }

	// RVA: 0x3F07550 Offset: 0x3F07651 VA: 0x3F07550 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

