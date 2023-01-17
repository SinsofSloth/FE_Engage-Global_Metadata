// Namespace: 
public enum InvestmentNationDataSequence.Label2 // TypeDefIndex: 11435
{
	// Fields
	public int value__; // 0x0
	public const InvestmentNationDataSequence.Label2 Entry = 0;
	public const InvestmentNationDataSequence.Label2 End = 1;
}

// Namespace: 
public sealed class InvestmentNationDataSequence.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11436
{
	// Methods

	// RVA: 0x2226040 Offset: 0x2226141 VA: 0x2226040
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22284D0 Offset: 0x22285D1 VA: 0x22284D0 Slot: 13
	public virtual void Invoke(int index) { }

	// RVA: 0x2228700 Offset: 0x2228801 VA: 0x2228700 Slot: 14
	public virtual IAsyncResult BeginInvoke(int index, AsyncCallback callback, object object) { }

	// RVA: 0x2228790 Offset: 0x2228891 VA: 0x2228790 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

