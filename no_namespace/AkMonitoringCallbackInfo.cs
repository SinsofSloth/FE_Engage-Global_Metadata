// Namespace: 
public class AkMonitoringCallbackInfo : IDisposable // TypeDefIndex: 7876
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkMonitorErrorCode errorCode { get; }
	public AkMonitorErrorLevel errorLevel { get; }
	public uint playingID { get; }
	public ulong gameObjID { get; }
	public string message { get; }

	// Methods

	// RVA: 0x317F3B0 Offset: 0x317F4B1 VA: 0x317F3B0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x317F3F0 Offset: 0x317F4F1 VA: 0x317F3F0
	internal static IntPtr getCPtr(AkMonitoringCallbackInfo obj) { }

	// RVA: 0x317F450 Offset: 0x317F551 VA: 0x317F450 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x317F480 Offset: 0x317F581 VA: 0x317F480 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x317F4F0 Offset: 0x317F5F1 VA: 0x317F4F0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x317F680 Offset: 0x317F781 VA: 0x317F680
	public AkMonitorErrorCode get_errorCode() { }

	// RVA: 0x317F6F0 Offset: 0x317F7F1 VA: 0x317F6F0
	public AkMonitorErrorLevel get_errorLevel() { }

	// RVA: 0x317F760 Offset: 0x317F861 VA: 0x317F760
	public uint get_playingID() { }

	// RVA: 0x317F7D0 Offset: 0x317F8D1 VA: 0x317F7D0
	public ulong get_gameObjID() { }

	// RVA: 0x317F840 Offset: 0x317F941 VA: 0x317F840
	public string get_message() { }

	// RVA: 0x317F8F0 Offset: 0x317F9F1 VA: 0x317F8F0
	public void .ctor() { }
}

