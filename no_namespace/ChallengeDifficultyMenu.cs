// Namespace: 
public sealed class ChallengeDifficultyMenu.RequestCloseEventHandler : MulticastDelegate // TypeDefIndex: 9772
{
	// Methods

	// RVA: 0x1DFDE50 Offset: 0x1DFDF51 VA: 0x1DFDE50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DFDE70 Offset: 0x1DFDF71 VA: 0x1DFDE70 Slot: 13
	public virtual void Invoke(int difficulty) { }

	// RVA: 0x1DFE0A0 Offset: 0x1DFE1A1 VA: 0x1DFE0A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int difficulty, AsyncCallback callback, object object) { }

	// RVA: 0x1DFE130 Offset: 0x1DFE231 VA: 0x1DFE130 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

