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
public sealed class MapDeployTemplate.FlagField<T> : BitFieldTemplate64<MapDeployTemplate.Flag<T>> // TypeDefIndex: 11925
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected override long ToLong(MapDeployTemplate.Flag<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DD620 Offset: 0x33DD721 VA: 0x33DD620
	|-MapDeployTemplate.FlagField<object>.ToLong
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33DD630 Offset: 0x33DD731 VA: 0x33DD630
	|-MapDeployTemplate.FlagField<object>..ctor
	*/
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
public enum MapDeployTemplate.DisplayType<T> // TypeDefIndex: 11927
{
	// Fields
	public int value__; // 0x0
	public const MapDeployTemplate.DisplayType<T> None = 0;
	public const MapDeployTemplate.DisplayType<T> Always = 1;
	public const MapDeployTemplate.DisplayType<T> Order = 2;
	public const MapDeployTemplate.DisplayType<T> Num = 3;
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
private class MapDeployTemplate.Queue<T> // TypeDefIndex: 11929
{
	// Fields
	private const int QueueSize = 256;
	private MapDeployTemplate.Queue.Data<T>[] m_Datas; // 0x0
	private int m_Index; // 0x0

	// Properties
	public MapDeployTemplate.Queue.Data<T> Current { get; set; }
	public int CurrentX { get; set; }
	public int CurrentZ { get; set; }
	public Dir.Type CurrentDir { get; set; }
	public int CurrentCost { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void Set(int x, int z, Dir.Type dir, int cost) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A873C0 Offset: 0x2A874C1 VA: 0x2A873C0
	|-MapDeployTemplate.Queue<object>.Set
	*/

	// RVA: -1 Offset: -1
	public void Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87450 Offset: 0x2A87551 VA: 0x2A87450
	|-MapDeployTemplate.Queue<object>.Next
	*/

	// RVA: -1 Offset: -1
	public void ResetIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87460 Offset: 0x2A87561 VA: 0x2A87460
	|-MapDeployTemplate.Queue<object>.ResetIndex
	*/

	// RVA: -1 Offset: -1
	public MapDeployTemplate.Queue.Data<T> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87470 Offset: 0x2A87571 VA: 0x2A87470
	|-MapDeployTemplate.Queue<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	public void set_Current(MapDeployTemplate.Queue.Data<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A874B0 Offset: 0x2A875B1 VA: 0x2A874B0
	|-MapDeployTemplate.Queue<object>.set_Current
	*/

	// RVA: -1 Offset: -1
	public int get_CurrentX() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A874F0 Offset: 0x2A875F1 VA: 0x2A874F0
	|-MapDeployTemplate.Queue<object>.get_CurrentX
	*/

	// RVA: -1 Offset: -1
	public void set_CurrentX(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87530 Offset: 0x2A87631 VA: 0x2A87530
	|-MapDeployTemplate.Queue<object>.set_CurrentX
	*/

	// RVA: -1 Offset: -1
	public int get_CurrentZ() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87570 Offset: 0x2A87671 VA: 0x2A87570
	|-MapDeployTemplate.Queue<object>.get_CurrentZ
	*/

	// RVA: -1 Offset: -1
	public void set_CurrentZ(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A875B0 Offset: 0x2A876B1 VA: 0x2A875B0
	|-MapDeployTemplate.Queue<object>.set_CurrentZ
	*/

	// RVA: -1 Offset: -1
	public Dir.Type get_CurrentDir() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A875F0 Offset: 0x2A876F1 VA: 0x2A875F0
	|-MapDeployTemplate.Queue<object>.get_CurrentDir
	*/

	// RVA: -1 Offset: -1
	public void set_CurrentDir(Dir.Type value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87630 Offset: 0x2A87731 VA: 0x2A87630
	|-MapDeployTemplate.Queue<object>.set_CurrentDir
	*/

	// RVA: -1 Offset: -1
	public int get_CurrentCost() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A87670 Offset: 0x2A87771 VA: 0x2A87670
	|-MapDeployTemplate.Queue<object>.get_CurrentCost
	*/

	// RVA: -1 Offset: -1
	public void set_CurrentCost(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A876B0 Offset: 0x2A877B1 VA: 0x2A876B0
	|-MapDeployTemplate.Queue<object>.set_CurrentCost
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A876F0 Offset: 0x2A877F1 VA: 0x2A876F0
	|-MapDeployTemplate.Queue<object>..ctor
	*/
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
[CompilerGeneratedAttribute] // RVA: 0x277CC0 Offset: 0x277DC1 VA: 0x277CC0
private sealed class MapDeployTemplate.<>c__DisplayClass95_0<T> // TypeDefIndex: 11931
{
	// Fields
	public Unit unit; // 0x0
	public MapDeployTemplate<T> <>4__this; // 0x0
	public MapSkill.UnitFunc <>9__0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42150 Offset: 0x2B42251 VA: 0x2B42150
	|-MapDeployTemplate.<>c__DisplayClass95_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <UnitFillEngage>b__0(int x, int z, Unit target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B42160 Offset: 0x2B42261 VA: 0x2B42160
	|-MapDeployTemplate.<>c__DisplayClass95_0<object>.<UnitFillEngage>b__0
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

