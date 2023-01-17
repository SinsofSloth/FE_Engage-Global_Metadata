// Namespace: 
public sealed class ChallengeDifficultyManager.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 9768
{
	// Methods

	// RVA: 0x1DFD800 Offset: 0x1DFD901 VA: 0x1DFD800
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DFD820 Offset: 0x1DFD921 VA: 0x1DFD820 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, int difficulty) { }

	// RVA: 0x1DFDA90 Offset: 0x1DFDB91 VA: 0x1DFDA90 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, int difficulty, AsyncCallback callback, object object) { }

	// RVA: 0x1DFDB50 Offset: 0x1DFDC51 VA: 0x1DFDB50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

