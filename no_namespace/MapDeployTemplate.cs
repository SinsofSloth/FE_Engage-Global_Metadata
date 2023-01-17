// Namespace: 
[FlagsAttribute] // RVA: 0x277CB0 Offset: 0x277DB1 VA: 0x277CB0
public enum MapDeployTemplate.Flag<T> // TypeDefIndex: 11924
{
	// Fields
	public long value__; // 0x0
	public const MapDeployTemplate.Flag<T> FullArea = 1;
	public const MapDeployTemplate.Flag<T> Enemy = 2;
	public const MapDeployTemplate.Flag<T> Appear = 4;
	public const MapDeployTemplate.Flag<T> AppearAiNoMove = 16;
	public const MapDeployTemplate.Flag<T> Route = 32;
	public const MapDeployTemplate.Flag<T> Fixed = 64;
	public const MapDeployTemplate.Flag<T> Idle = 128;
	public const MapDeployTemplate.Flag<T> CostFree = 256;
	public const MapDeployTemplate.Flag<T> DoorFree = 512;
	public const MapDeployTemplate.Flag<T> SightFree = 1024;
	public const MapDeployTemplate.Flag<T> BlockFree = 4096;
	public const MapDeployTemplate.Flag<T> RangeSide = 8192;
	public const MapDeployTemplate.Flag<T> Show = 16384;
	public const MapDeployTemplate.Flag<T> Event = 32768;
	public const MapDeployTemplate.Flag<T> Dispos = 65536;
	public const MapDeployTemplate.Flag<T> CostFreeSkill = 131072;
	public const MapDeployTemplate.Flag<T> EnemyPassSkill = 262144;
	public const MapDeployTemplate.Flag<T> Danger = 1048576;
	public const MapDeployTemplate.Flag<T> Attack = 16777216;
	public const MapDeployTemplate.Flag<T> Rod = 33554432;
	public const MapDeployTemplate.Flag<T> InterferenceRod = 67108864;
	public const MapDeployTemplate.Flag<T> HealRod = 134217728;
	public const MapDeployTemplate.Flag<T> SupportRod = 268435456;
	public const MapDeployTemplate.Flag<T> RewarpRod = 536870912;
	public const MapDeployTemplate.Flag<T> Engage = 1073741824;
	public const MapDeployTemplate.Flag<T> EngageHere = 2147483648;
	public const MapDeployTemplate.Flag<T> Cannon = 4294967296;
	public const MapDeployTemplate.Flag<T> Equip = 8589934592;
	public const MapDeployTemplate.Flag<T> Select = 17179869184;
	public const MapDeployTemplate.Flag<T> BasicRod = 34359738368;
	public const MapDeployTemplate.Flag<T> IgnoreSilent = 68719476736;
	public const MapDeployTemplate.Flag<T> KeepAttackImage = 137438953472;
	public const MapDeployTemplate.Flag<T> KeepRodImage = 274877906944;
	public const MapDeployTemplate.Flag<T> KeepActionImage = 549755813888;
	public const MapDeployTemplate.Flag<T> BeforeMove = 1099511627776;
	public const MapDeployTemplate.Flag<T> ClampArea = 2199023255552;
	public const MapDeployTemplate.Flag<T> IgnoreCannon = 4398046511104;
	public const MapDeployTemplate.Flag<T> FullBullet = 8796093022208;
	public const MapDeployTemplate.Flag<T> MaskFree = 131328;
	public const MapDeployTemplate.Flag<T> MaskWeapon = 4528489365504;
}

// Namespace: 
private enum MapDeployTemplate.ImageType<T> // TypeDefIndex: 11926
{
	// Fields
	public int value__; // 0x0
	public const MapDeployTemplate.ImageType<T> Move = 0;
	public const MapDeployTemplate.ImageType<T> Attack = 1;
	public const MapDeployTemplate.ImageType<T> Rod = 2;
	public const MapDeployTemplate.ImageType<T> Heal = 3;
	public const MapDeployTemplate.ImageType<T> Support = 4;
	public const MapDeployTemplate.ImageType<T> Interference = 5;
	public const MapDeployTemplate.ImageType<T> Engage = 6;
	public const MapDeployTemplate.ImageType<T> Num = 7;
}

// Namespace: 
public struct MapDeployTemplate.Queue.Data<T> // TypeDefIndex: 11928
{
	// Fields
	public byte x; // 0x0
	public byte z; // 0x0
	public byte dir; // 0x0
	public byte cost; // 0x0
}

// Namespace: 
public class MapDeployTemplate.SwapBufferScope<T> : IDisposable // TypeDefIndex: 11930
{
	// Fields
	private IMapDeploy m_Deploy; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IMapDeploy deploy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B19E0 Offset: 0x34B1AE1 VA: 0x34B19E0
	|-MapDeployTemplate.SwapBufferScope<MapDeploy>..ctor
	|-MapDeployTemplate.SwapBufferScope<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B1AC0 Offset: 0x34B1BC1 VA: 0x34B1AC0
	|-MapDeployTemplate.SwapBufferScope<object>.Dispose
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277CD0 Offset: 0x277DD1 VA: 0x277CD0
private sealed class MapDeployTemplate.<>c__DisplayClass194_0<T> // TypeDefIndex: 11932
{
	// Fields
	public MapDeployTemplate<T> <>4__this; // 0x0
	public Unit unit; // 0x0
	public MapSkill.TerrainFunc <>9__3; // 0x0
	public MapSkill.UnitFunc <>9__4; // 0x0
	public MapSkill.TerrainFunc <>9__5; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A230 Offset: 0x2B3A331 VA: 0x2B3A230
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FillRangeImage>b__3(int x, int z, TerrainData terrain) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A240 Offset: 0x2B3A341 VA: 0x2B3A240
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>.<FillRangeImage>b__3
	*/

	// RVA: -1 Offset: -1
	internal void <FillRangeImage>b__0(int x, int z, Unit target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A290 Offset: 0x2B3A391 VA: 0x2B3A290
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>.<FillRangeImage>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <FillRangeImage>b__1(int x, int z, Unit target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A2E0 Offset: 0x2B3A3E1 VA: 0x2B3A2E0
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>.<FillRangeImage>b__1
	*/

	// RVA: -1 Offset: -1
	internal void <FillRangeImage>b__2(int x, int z, TerrainData terrain) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A550 Offset: 0x2B3A651 VA: 0x2B3A550
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>.<FillRangeImage>b__2
	*/

	// RVA: -1 Offset: -1
	internal void <FillRangeImage>b__4(int x, int z, Unit target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A5A0 Offset: 0x2B3A6A1 VA: 0x2B3A5A0
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>.<FillRangeImage>b__4
	*/

	// RVA: -1 Offset: -1
	internal void <FillRangeImage>b__5(int x, int z, TerrainData terrain) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3A5F0 Offset: 0x2B3A6F1 VA: 0x2B3A5F0
	|-MapDeployTemplate.<>c__DisplayClass194_0<object>.<FillRangeImage>b__5
	*/
}

