// Namespace: 
[FlagsAttribute] // RVA: 0x277CA0 Offset: 0x277DA1 VA: 0x277CA0
private enum MapCursor.Flag // TypeDefIndex: 11916
{
	// Fields
	public int value__; // 0x0
	public const MapCursor.Flag Hide = 1;
	public const MapCursor.Flag Auto = 2;
}

// Namespace: 
private class MapCursor.FlagField : BitFieldTemplate32<MapCursor.Flag> // TypeDefIndex: 11917
{
	// Methods

	// RVA: 0x1D37E30 Offset: 0x1D37F31 VA: 0x1D37E30 Slot: 5
	protected override int ToInt(MapCursor.Flag value) { }

	// RVA: 0x1D37E40 Offset: 0x1D37F41 VA: 0x1D37E40
	public void .ctor() { }
}

// Namespace: 
public enum MapCursor.DistanceMode // TypeDefIndex: 11918
{
	// Fields
	public int value__; // 0x0
	public const MapCursor.DistanceMode Near = 0;
	public const MapCursor.DistanceMode Middle = 1;
	public const MapCursor.DistanceMode Far = 2;
}

// Namespace: 
public enum MapCursor.CursorTopType // TypeDefIndex: 11919
{
	// Fields
	public int value__; // 0x0
	public const MapCursor.CursorTopType Pointer = 0;
	public const MapCursor.CursorTopType Attack = 1;
	public const MapCursor.CursorTopType Talk = 2;
	public const MapCursor.CursorTopType Rod = 3;
	public const MapCursor.CursorTopType Dance = 4;
	public const MapCursor.CursorTopType Cannon = 5;
	public const MapCursor.CursorTopType Num = 6;
}

// Namespace: 
public enum MapCursor.AnimType // TypeDefIndex: 11920
{
	// Fields
	public int value__; // 0x0
	public const MapCursor.AnimType None = 1;
	public const MapCursor.AnimType In = 2;
	public const MapCursor.AnimType Out = 4;
}

