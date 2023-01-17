// Namespace: 
public sealed class ChallengeDifficultyMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 9771
{
	// Methods

	// RVA: 0x1DFDB60 Offset: 0x1DFDC61 VA: 0x1DFDB60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DFDB80 Offset: 0x1DFDC81 VA: 0x1DFDB80 Slot: 13
	public virtual void Invoke(int difficulty) { }

	// RVA: 0x1DFDDB0 Offset: 0x1DFDEB1 VA: 0x1DFDDB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int difficulty, AsyncCallback callback, object object) { }

	// RVA: 0x1DFDE40 Offset: 0x1DFDF41 VA: 0x1DFDE40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

