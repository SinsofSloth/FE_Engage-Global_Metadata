// Namespace: App
[FlagsAttribute] // RVA: 0x277C60 Offset: 0x277D61 VA: 0x277C60
public enum MapMoveFlag // TypeDefIndex: 11888
{
	// Fields
	public int value__; // 0x0
	public const MapMoveFlag Focus = 1;
	public const MapMoveFlag Escape = 2;
	public const MapMoveFlag Arrival = 4;
	public const MapMoveFlag FixedDir = 8;
	public const MapMoveFlag FixedSpeed = 16;
	public const MapMoveFlag SkipInvisible = 32;
	public const MapMoveFlag AI = 64;
	public const MapMoveFlag Event = 128;
	public const MapMoveFlag Dispos = 256;
	public const MapMoveFlag Tracking = 512;
	public const MapMoveFlag DoubleOnOff = 1024;
	public const MapMoveFlag Parent = 2048;
	public const MapMoveFlag Child = 4096;
}

