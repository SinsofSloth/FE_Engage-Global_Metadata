// Namespace: 
public class AkPlatformInitSettings : IDisposable // TypeDefIndex: 7908
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkThreadProperties threadLEngine { get; set; }
	public AkThreadProperties threadOutputMgr { get; set; }
	public AkThreadProperties threadBankManager { get; set; }
	public AkThreadProperties threadMonitor { get; set; }
	public AkThreadProperties threadOpusDecoder { get; set; }
	public uint uSampleRate { get; set; }
	public ushort uNumRefillsInVoice { get; set; }
	public bool bAutoPanningRule { get; set; }
	public bool bAcquireAudioDeviceNotification { get; set; }

	// Methods

	// RVA: 0x31798C0 Offset: 0x31799C1 VA: 0x31798C0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3179860 Offset: 0x3179961 VA: 0x3179860
	internal static IntPtr getCPtr(AkPlatformInitSettings obj) { }

	// RVA: 0x3183020 Offset: 0x3183121 VA: 0x3183020 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3183050 Offset: 0x3183151 VA: 0x3183050 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31830C0 Offset: 0x31831C1 VA: 0x31830C0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x316C280 Offset: 0x316C381 VA: 0x316C280
	public void set_threadLEngine(AkThreadProperties value) { }

	// RVA: 0x316BC70 Offset: 0x316BD71 VA: 0x316BC70
	public AkThreadProperties get_threadLEngine() { }

	// RVA: 0x316C310 Offset: 0x316C411 VA: 0x316C310
	public void set_threadOutputMgr(AkThreadProperties value) { }

	// RVA: 0x316BD50 Offset: 0x316BE51 VA: 0x316BD50
	public AkThreadProperties get_threadOutputMgr() { }

	// RVA: 0x316C3A0 Offset: 0x316C4A1 VA: 0x316C3A0
	public void set_threadBankManager(AkThreadProperties value) { }

	// RVA: 0x316BE30 Offset: 0x316BF31 VA: 0x316BE30
	public AkThreadProperties get_threadBankManager() { }

	// RVA: 0x316C430 Offset: 0x316C531 VA: 0x316C430
	public void set_threadMonitor(AkThreadProperties value) { }

	// RVA: 0x316BF10 Offset: 0x316C011 VA: 0x316BF10
	public AkThreadProperties get_threadMonitor() { }

	// RVA: 0x316C4C0 Offset: 0x316C5C1 VA: 0x316C4C0
	public void set_threadOpusDecoder(AkThreadProperties value) { }

	// RVA: 0x316BFF0 Offset: 0x316C0F1 VA: 0x316BFF0
	public AkThreadProperties get_threadOpusDecoder() { }

	// RVA: 0x316D430 Offset: 0x316D531 VA: 0x316D430
	public void set_uSampleRate(uint value) { }

	// RVA: 0x3183250 Offset: 0x3183351 VA: 0x3183250
	public uint get_uSampleRate() { }

	// RVA: 0x316D590 Offset: 0x316D691 VA: 0x316D590
	public void set_uNumRefillsInVoice(ushort value) { }

	// RVA: 0x31832C0 Offset: 0x31833C1 VA: 0x31832C0
	public ushort get_uNumRefillsInVoice() { }

	// RVA: 0x3183330 Offset: 0x3183431 VA: 0x3183330
	public void set_bAutoPanningRule(bool value) { }

	// RVA: 0x31833B0 Offset: 0x31834B1 VA: 0x31833B0
	public bool get_bAutoPanningRule() { }

	// RVA: 0x3183420 Offset: 0x3183521 VA: 0x3183420
	public void set_bAcquireAudioDeviceNotification(bool value) { }

	// RVA: 0x31834A0 Offset: 0x31835A1 VA: 0x31834A0
	public bool get_bAcquireAudioDeviceNotification() { }
}

