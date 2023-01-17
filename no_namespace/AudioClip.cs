// Namespace: 
public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 4736
{
	// Methods

	// RVA: 0x1C68A80 Offset: 0x1C68B81 VA: 0x1C68A80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C67E90 Offset: 0x1C67F91 VA: 0x1C67E90 Slot: 13
	public virtual void Invoke(int position) { }

	// RVA: 0x1C68AA0 Offset: 0x1C68BA1 VA: 0x1C68AA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

	// RVA: 0x1C68B30 Offset: 0x1C68C31 VA: 0x1C68B30 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

