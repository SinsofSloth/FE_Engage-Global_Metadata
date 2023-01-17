// Namespace: 
public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 7592
{
	// Methods

	// RVA: 0x1C60ED0 Offset: 0x1C60FD1 VA: 0x1C60ED0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C5FFD0 Offset: 0x1C600D1 VA: 0x1C5FFD0 Slot: 13
	public virtual void Invoke(VideoPlayer source) { }

	// RVA: 0x1C60EF0 Offset: 0x1C60FF1 VA: 0x1C60EF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, object object) { }

	// RVA: 0x1C60F20 Offset: 0x1C61021 VA: 0x1C60F20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 7593
{
	// Methods

	// RVA: 0x1C60E70 Offset: 0x1C60F71 VA: 0x1C60E70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C60740 Offset: 0x1C60841 VA: 0x1C60740 Slot: 13
	public virtual void Invoke(VideoPlayer source, string message) { }

	// RVA: 0x1C60E90 Offset: 0x1C60F91 VA: 0x1C60E90 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	// RVA: 0x1C60EC0 Offset: 0x1C60FC1 VA: 0x1C60EC0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 7594
{
	// Methods

	// RVA: 0x1C60F30 Offset: 0x1C61031 VA: 0x1C60F30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C60350 Offset: 0x1C60451 VA: 0x1C60350 Slot: 13
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	// RVA: 0x1C60F50 Offset: 0x1C61051 VA: 0x1C60F50 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	// RVA: 0x1C60FF0 Offset: 0x1C610F1 VA: 0x1C60FF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

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

