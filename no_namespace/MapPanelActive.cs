// Namespace: 
public enum MapPanelActive.MeshIndex // TypeDefIndex: 9045
{
	// Fields
	public int value__; // 0x0
	public const MapPanelActive.MeshIndex Move = 0;
	public const MapPanelActive.MeshIndex Attack = 1;
	public const MapPanelActive.MeshIndex Heal = 2;
	public const MapPanelActive.MeshIndex Support = 3;
	public const MapPanelActive.MeshIndex Interference = 4;
	public const MapPanelActive.MeshIndex Dance = 5;
	public const MapPanelActive.MeshIndex Action = 6;
	public const MapPanelActive.MeshIndex Range = 7;
	public const MapPanelActive.MeshIndex Overlap = 8;
	public const MapPanelActive.MeshIndex Num = 9;
}

// Namespace: 
public sealed class MapPanelActive.FlagField : BitFieldTemplate64<MapDeployTemplate.Flag<MapDeploy>> // TypeDefIndex: 9046
{
	// Methods

	// RVA: 0x24136C0 Offset: 0x24137C1 VA: 0x24136C0 Slot: 5
	protected override long ToLong(MapDeployTemplate.Flag<MapDeploy> value) { }

	// RVA: 0x24136D0 Offset: 0x24137D1 VA: 0x24136D0
	public void .ctor() { }
}

// Namespace: 
private sealed class MapPanelActive.TargetFunc : MulticastDelegate // TypeDefIndex: 9047
{
	// Methods

	// RVA: 0x2413730 Offset: 0x2413831 VA: 0x2413730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2413470 Offset: 0x2413571 VA: 0x2413470 Slot: 13
	public virtual bool Invoke(int x, int z) { }

	// RVA: 0x2413750 Offset: 0x2413851 VA: 0x2413750 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, AsyncCallback callback, object object) { }

	// RVA: 0x24137F0 Offset: 0x24138F1 VA: 0x24137F0 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x275080 Offset: 0x275181 VA: 0x275080
private sealed class MapPanelActive.<>c__DisplayClass60_0 // TypeDefIndex: 9048
{
	// Fields
	public MapPanelActive <>4__this; // 0x10
	public MapPanelActive.TargetFunc func; // 0x18

	// Methods

	// RVA: 0x24132A0 Offset: 0x24133A1 VA: 0x24132A0
	public void .ctor() { }

	// RVA: 0x24132B0 Offset: 0x24133B1 VA: 0x24132B0
	internal void <EachTargetCell>b__0(int vx, int vz, int range) { }
}

