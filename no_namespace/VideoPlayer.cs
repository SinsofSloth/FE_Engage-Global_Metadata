// Namespace: 
public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 7595
{
	// Methods

	// RVA: 0x1C61000 Offset: 0x1C61101 VA: 0x1C61000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C60AF0 Offset: 0x1C60BF1 VA: 0x1C60AF0 Slot: 13
	public virtual void Invoke(VideoPlayer source, double seconds) { }

	// RVA: 0x1C61020 Offset: 0x1C61121 VA: 0x1C61020 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	// RVA: 0x1C610C0 Offset: 0x1C611C1 VA: 0x1C610C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

