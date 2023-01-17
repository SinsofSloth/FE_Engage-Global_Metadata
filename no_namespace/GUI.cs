// Namespace: 
public abstract class GUI.Scope : IDisposable // TypeDefIndex: 4146
{
	// Fields
	private bool m_Disposed; // 0x10

	// Methods

	// RVA: 0x3C8A590 Offset: 0x3C8A691 VA: 0x3C8A590 Slot: 5
	internal virtual void Dispose(bool disposing) { }

	// RVA: 0x3C8A620 Offset: 0x3C8A721 VA: 0x3C8A620 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3C8A780 Offset: 0x3C8A881 VA: 0x3C8A780 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void CloseScope();

	// RVA: 0x3C8A800 Offset: 0x3C8A901 VA: 0x3C8A800
	protected void .ctor() { }
}

