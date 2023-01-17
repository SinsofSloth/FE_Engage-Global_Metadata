// Namespace: 
public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 4733
{
	// Methods

	// RVA: 0x1C68C10 Offset: 0x1C68D11 VA: 0x1C68C10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C687E0 Offset: 0x1C688E1 VA: 0x1C687E0 Slot: 13
	public virtual void Invoke(bool deviceWasChanged) { }

	// RVA: 0x1C68C30 Offset: 0x1C68D31 VA: 0x1C68C30 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

	// RVA: 0x1C68CD0 Offset: 0x1C68DD1 VA: 0x1C68CD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

