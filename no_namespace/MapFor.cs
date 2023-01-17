// Namespace: 
public enum MapFor.Return // TypeDefIndex: 12006
{
	// Fields
	public int value__; // 0x0
	public const MapFor.Return Continue = 0;
	public const MapFor.Return Done = 1;
}

// Namespace: 
public sealed class MapFor.Pos2Function : MulticastDelegate // TypeDefIndex: 12008
{
	// Methods

	// RVA: 0x1D408B0 Offset: 0x1D409B1 VA: 0x1D408B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D408D0 Offset: 0x1D409D1 VA: 0x1D408D0 Slot: 13
	public virtual MapFor.Return Invoke(int x, int z) { }

	// RVA: 0x1D40B10 Offset: 0x1D40C11 VA: 0x1D40B10 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, AsyncCallback callback, object object) { }

	// RVA: 0x1D40BB0 Offset: 0x1D40CB1 VA: 0x1D40BB0 Slot: 15
	public virtual MapFor.Return EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class MapFor.Range2Function : MulticastDelegate // TypeDefIndex: 12010
{
	// Methods

	// RVA: 0x1D40CB0 Offset: 0x1D40DB1 VA: 0x1D40CB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D40CD0 Offset: 0x1D40DD1 VA: 0x1D40CD0 Slot: 13
	public virtual MapFor.Return Invoke(int x, int z, int range) { }

	// RVA: 0x1D40F30 Offset: 0x1D41031 VA: 0x1D40F30 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, int range, AsyncCallback callback, object object) { }

	// RVA: 0x1D40FF0 Offset: 0x1D410F1 VA: 0x1D40FF0 Slot: 15
	public virtual MapFor.Return EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class MapFor.Force2Function : MulticastDelegate // TypeDefIndex: 12012
{
	// Methods

	// RVA: 0x1D3FF10 Offset: 0x1D40011 VA: 0x1D3FF10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D3FF30 Offset: 0x1D40031 VA: 0x1D3FF30 Slot: 13
	public virtual MapFor.Return Invoke(Force.Type forceType) { }

	// RVA: 0x1D40190 Offset: 0x1D40291 VA: 0x1D40190 Slot: 14
	public virtual IAsyncResult BeginInvoke(Force.Type forceType, AsyncCallback callback, object object) { }

	// RVA: 0x1D40220 Offset: 0x1D40321 VA: 0x1D40220 Slot: 15
	public virtual MapFor.Return EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class MapFor.Unit2Function : MulticastDelegate // TypeDefIndex: 12014
{
	// Methods

	// RVA: 0x1D41750 Offset: 0x1D41851 VA: 0x1D41750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D41770 Offset: 0x1D41871 VA: 0x1D41770 Slot: 13
	public virtual MapFor.Return Invoke(Unit unit) { }

	// RVA: 0x1D41AD0 Offset: 0x1D41BD1 VA: 0x1D41AD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, AsyncCallback callback, object object) { }

	// RVA: 0x1D41B00 Offset: 0x1D41C01 VA: 0x1D41B00 Slot: 15
	public virtual MapFor.Return EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class MapFor.TargetFunction : MulticastDelegate // TypeDefIndex: 12016
{
	// Methods

	// RVA: 0x1D41370 Offset: 0x1D41471 VA: 0x1D41370
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D41390 Offset: 0x1D41491 VA: 0x1D41390 Slot: 13
	public virtual void Invoke(int attackX, int attackZ, int targetX, int targetZ, Unit target, uint itemMask, UnitItem specifiedItem) { }

	// RVA: 0x1D41640 Offset: 0x1D41741 VA: 0x1D41640 Slot: 14
	public virtual IAsyncResult BeginInvoke(int attackX, int attackZ, int targetX, int targetZ, Unit target, uint itemMask, UnitItem specifiedItem, AsyncCallback callback, object object) { }

	// RVA: 0x1D41740 Offset: 0x1D41841 VA: 0x1D41740 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class MapFor.DestroyFunction : MulticastDelegate // TypeDefIndex: 12018
{
	// Methods

	// RVA: 0x1D3FB70 Offset: 0x1D3FC71 VA: 0x1D3FB70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D3FB90 Offset: 0x1D3FC91 VA: 0x1D3FB90 Slot: 13
	public virtual void Invoke(int x, int z, int targetX, int targetZ, int itemIndex) { }

	// RVA: 0x1D3FE20 Offset: 0x1D3FF21 VA: 0x1D3FE20 Slot: 14
	public virtual IAsyncResult BeginInvoke(int x, int z, int targetX, int targetZ, int itemIndex, AsyncCallback callback, object object) { }

	// RVA: 0x1D3FF00 Offset: 0x1D40001 VA: 0x1D3FF00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277E00 Offset: 0x277F01 VA: 0x277E00
private sealed class MapFor.<>c__DisplayClass14_0 // TypeDefIndex: 12020
{
	// Fields
	public MapFor.PosFunction func; // 0x10

	// Methods

	// RVA: 0x1D3F910 Offset: 0x1D3FA11 VA: 0x1D3F910
	public void .ctor() { }

	// RVA: 0x1D3F920 Offset: 0x1D3FA21 VA: 0x1D3F920
	internal void <EachPoke>b__0(int x, int z, PokeInspector insp) { }
}

