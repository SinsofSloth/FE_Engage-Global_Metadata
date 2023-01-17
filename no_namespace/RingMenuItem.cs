// Namespace: 
public sealed class RingMenuItem.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11174
{
	// Methods

	// RVA: 0x1F55450 Offset: 0x1F55551 VA: 0x1F55450
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F55470 Offset: 0x1F55571 VA: 0x1F55470 Slot: 13
	public virtual void Invoke(RingData ringData, int baseRingCount, int pieceOfBondsCount, int godUnitIndex, BasicMenuSelect menuSelect) { }

	// RVA: 0x1F55840 Offset: 0x1F55941 VA: 0x1F55840 Slot: 14
	public virtual IAsyncResult BeginInvoke(RingData ringData, int baseRingCount, int pieceOfBondsCount, int godUnitIndex, BasicMenuSelect menuSelect, AsyncCallback callback, object object) { }

	// RVA: 0x1F55910 Offset: 0x1F55A11 VA: 0x1F55910 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

