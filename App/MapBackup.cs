// Namespace: App
public class MapBackup : IDisposable // TypeDefIndex: 11905
{
	// Fields
	public string Key; // 0x10
	public int State; // 0x18
	public MapObject.Actions Action; // 0x1C
	public MapMaterial MapMaterial; // 0x20

	// Methods

	// RVA: 0x231A120 Offset: 0x231A221 VA: 0x231A120 Slot: 4
	public void Dispose() { }

	// RVA: 0x231A130 Offset: 0x231A231 VA: 0x231A130
	public void Serialize(Stream stream) { }

	// RVA: 0x231A410 Offset: 0x231A511 VA: 0x231A410
	public void Desrialize(Stream stream) { }

	// RVA: 0x231AF40 Offset: 0x231B041 VA: 0x231AF40
	public void Write(MapObject mapObject) { }

	// RVA: 0x231B0E0 Offset: 0x231B1E1 VA: 0x231B0E0
	public void Read(MapObject mapObject) { }

	// RVA: 0x231B370 Offset: 0x231B471 VA: 0x231B370
	public void .ctor() { }
}

