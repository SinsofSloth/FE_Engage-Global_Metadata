// Namespace: 
[FlagsAttribute] // RVA: 0x278000 Offset: 0x278101 VA: 0x278000
public enum MapRoute.Flag // TypeDefIndex: 12207
{
	// Fields
	public int value__; // 0x0
	public const MapRoute.Flag Attack = 1;
	public const MapRoute.Flag Rod = 2;
	public const MapRoute.Flag Destroy = 4;
	public const MapRoute.Flag Talk = 8;
	public const MapRoute.Flag Dance = 16;
	public const MapRoute.Flag Informal = 64;
	public const MapRoute.Flag NoUpdate = 128;
	public const MapRoute.Flag Resume = 256;
	public const MapRoute.Flag MaskMind = 95;
}

// Namespace: 
public sealed class MapRoute.Func : MulticastDelegate // TypeDefIndex: 12208
{
	// Methods

	// RVA: 0x2413B70 Offset: 0x2413C71 VA: 0x2413B70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2413B90 Offset: 0x2413C91 VA: 0x2413B90 Slot: 13
	public virtual void Invoke(int x, int z) { }

	// RVA: 0x2413DD0 Offset: 0x2413ED1 VA: 0x2413DD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, AsyncCallback callback, object object) { }

	// RVA: 0x2413E70 Offset: 0x2413F71 VA: 0x2413E70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

