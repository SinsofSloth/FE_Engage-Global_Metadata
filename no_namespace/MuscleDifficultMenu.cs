// Namespace: 
public sealed class MuscleDifficultMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11271
{
	// Methods

	// RVA: 0x26DB060 Offset: 0x26DB161 VA: 0x26DB060
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26DB080 Offset: 0x26DB181 VA: 0x26DB080 Slot: 13
	public virtual void Invoke(Level result) { }

	// RVA: 0x26DB2E0 Offset: 0x26DB3E1 VA: 0x26DB2E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Level result, AsyncCallback callback, object object) { }

	// RVA: 0x26DB370 Offset: 0x26DB471 VA: 0x26DB370 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class MuscleDifficultMenu.MuscleDifficultMenuItem : BasicMenuItem // TypeDefIndex: 11272
{
	// Fields
	private string m_Name; // 0x68
	private MuscleDifficultMenu.DecideEventHandler m_DecideEventHandler; // 0x70
	private bool m_IsEnable; // 0x78

	// Methods

	// RVA: 0x26DB380 Offset: 0x26DB481 VA: 0x26DB380
	public void .ctor(string name, MuscleDifficultMenu.DecideEventHandler eventHandler, bool enable) { }

	// RVA: 0x26DB3E0 Offset: 0x26DB4E1 VA: 0x26DB3E0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DB400 Offset: 0x26DB501 VA: 0x26DB400 Slot: 4
	public override string GetName() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2774B0 Offset: 0x2775B1 VA: 0x2774B0
private struct MuscleDifficultMenu.<>c__DisplayClass5_0 // TypeDefIndex: 11273
{
	// Fields
	public int pastDeside; // 0x0
}

