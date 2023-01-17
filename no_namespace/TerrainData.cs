// Namespace: 
private enum TerrainData.BoundaryValueType // TypeDefIndex: 7548
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.BoundaryValueType MaxHeightmapRes = 0;
	public const TerrainData.BoundaryValueType MinDetailResPerPatch = 1;
	public const TerrainData.BoundaryValueType MaxDetailResPerPatch = 2;
	public const TerrainData.BoundaryValueType MaxDetailPatchCount = 3;
	public const TerrainData.BoundaryValueType MaxDetailsPerRes = 4;
	public const TerrainData.BoundaryValueType MinAlphamapRes = 5;
	public const TerrainData.BoundaryValueType MaxAlphamapRes = 6;
	public const TerrainData.BoundaryValueType MinBaseMapRes = 7;
	public const TerrainData.BoundaryValueType MaxBaseMapRes = 8;
}

// Namespace: 
public enum TerrainData.Commands // TypeDefIndex: 10097
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.Commands None = 0;
	public const TerrainData.Commands TorchOn = 1;
	public const TerrainData.Commands TorchOff = 2;
}

// Namespace: 
public enum TerrainData.Layers // TypeDefIndex: 10098
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.Layers Lower = 0;
	public const TerrainData.Layers Upper = 1;
}

// Namespace: 
public enum TerrainData.Prohibitions // TypeDefIndex: 10099
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.Prohibitions None = 0;
	public const TerrainData.Prohibitions All = 1;
	public const TerrainData.Prohibitions Ground = 2;
	public const TerrainData.Prohibitions Near = 3;
}

// Namespace: 
public enum TerrainData.Destroyers // TypeDefIndex: 10100
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.Destroyers None = 0;
	public const TerrainData.Destroyers Player = 1;
	public const TerrainData.Destroyers Enemy = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x2766D0 Offset: 0x2767D1 VA: 0x2766D0
public enum TerrainData.Flags // TypeDefIndex: 10101
{
	// Fields
	public int value__; // 0x0
	public const TerrainData.Flags Door = 1;
	public const TerrainData.Flags Treasure = 2;
	public const TerrainData.Flags Visit = 4;
	public const TerrainData.Flags BowCannon = 8;
	public const TerrainData.Flags MagicCannon = 16;
	public const TerrainData.Flags FireCannon = 32;
	public const TerrainData.Flags NoShadow = 128;
	public const TerrainData.Flags FootSmoke = 256;
	public const TerrainData.Flags FootPrint = 512;
	public const TerrainData.Flags Roof = 1024;
	public const TerrainData.Flags SightMasking = 2048;
	public const TerrainData.Flags NotStun = 4096;
	public const TerrainData.Flags NotEngageAdd = 8192;
	public const TerrainData.Flags FlyEnable = 16384;
	public const TerrainData.Flags EngageHeal = 32768;
	public const TerrainData.Flags NotTarget = 65536;
	public const TerrainData.Flags NotWarp = 131072;
	public const TerrainData.Flags DamageHalfDisplay = 262144;
	public const TerrainData.Flags HideBreakIcon = 524288;
	public const TerrainData.Flags ShowPhaseIcon = 1048576;
	public const TerrainData.Flags Immobile = 536870912;
	public const TerrainData.Flags Minimap = 1073741824;
	public const TerrainData.Flags HelpSpot = -2147483648;
}

