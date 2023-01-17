// Namespace: 
public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 3401
{
	// Methods

	// RVA: 0x38522E0 Offset: 0x38523E1 VA: 0x38522E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x3852300 Offset: 0x3852401 VA: 0x3852300 Slot: 13
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	// RVA: 0x38526A0 Offset: 0x38527A1 VA: 0x38526A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	// RVA: 0x3852750 Offset: 0x3852851 VA: 0x3852750 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

