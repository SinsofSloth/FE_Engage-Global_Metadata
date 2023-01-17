// Namespace: 
public sealed class GameParam.ParamFunction : MulticastDelegate // TypeDefIndex: 9900
{
	// Methods

	// RVA: 0x22E25E0 Offset: 0x22E26E1 VA: 0x22E25E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E2600 Offset: 0x22E2701 VA: 0x22E2600 Slot: 13
	public virtual void Invoke(GameParam param, object[] args) { }

	// RVA: 0x22E2970 Offset: 0x22E2A71 VA: 0x22E2970 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameParam param, object[] args, AsyncCallback callback, object object) { }

	// RVA: 0x22E29A0 Offset: 0x22E2AA1 VA: 0x22E29A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

