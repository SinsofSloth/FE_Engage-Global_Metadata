// Namespace: 
public sealed class UnitSignal.Func : MulticastDelegate // TypeDefIndex: 8986
{
	// Methods

	// RVA: 0x1ED8D80 Offset: 0x1ED8E81 VA: 0x1ED8D80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1ED8DA0 Offset: 0x1ED8EA1 VA: 0x1ED8DA0 Slot: 13
	public virtual void Invoke(UnitSignal signal) { }

	// RVA: 0x1ED9100 Offset: 0x1ED9201 VA: 0x1ED9100 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnitSignal signal, AsyncCallback callback, object object) { }

	// RVA: 0x1ED9130 Offset: 0x1ED9231 VA: 0x1ED9130 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

