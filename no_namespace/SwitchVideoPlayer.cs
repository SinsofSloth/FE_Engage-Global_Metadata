// Namespace: 
public sealed class SwitchVideoPlayer.MovieEventDelegate : MulticastDelegate // TypeDefIndex: 7544
{
	// Methods

	// RVA: 0x3F0CAE0 Offset: 0x3F0CBE1 VA: 0x3F0CAE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3F0C720 Offset: 0x3F0C821 VA: 0x3F0C720 Slot: 13
	public virtual void Invoke(SwitchVideoPlayer.Event eventtype) { }

	// RVA: 0x3F0CB00 Offset: 0x3F0CC01 VA: 0x3F0CB00 Slot: 14
	public virtual IAsyncResult BeginInvoke(SwitchVideoPlayer.Event eventtype, AsyncCallback callback, object object) { }

	// RVA: 0x3F0CB90 Offset: 0x3F0CC91 VA: 0x3F0CB90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

