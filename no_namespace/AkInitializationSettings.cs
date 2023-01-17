// Namespace: 
public class AkInitializationSettings : IDisposable // TypeDefIndex: 7858
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public AkStreamMgrSettings streamMgrSettings { get; set; }
	public AkDeviceSettings deviceSettings { get; set; }
	public AkInitSettings initSettings { get; set; }
	public AkPlatformInitSettings platformSettings { get; set; }
	public AkMusicSettings musicSettings { get; set; }
	public AkUnityPlatformSpecificSettings unityPlatformSpecificSettings { get; set; }
	public bool useAsyncOpen { get; set; }

	// Methods

	// RVA: 0x3179230 Offset: 0x3179331 VA: 0x3179230
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3179270 Offset: 0x3179371 VA: 0x3179270
	internal static IntPtr getCPtr(AkInitializationSettings obj) { }

	// RVA: 0x31792D0 Offset: 0x31793D1 VA: 0x31792D0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3179300 Offset: 0x3179401 VA: 0x3179300 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3179370 Offset: 0x3179471 VA: 0x3179370 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x3179500 Offset: 0x3179601 VA: 0x3179500
	public void .ctor() { }

	// RVA: 0x3179590 Offset: 0x3179691 VA: 0x3179590
	public void set_streamMgrSettings(AkStreamMgrSettings value) { }

	// RVA: 0x316C5E0 Offset: 0x316C6E1 VA: 0x316C5E0
	public AkStreamMgrSettings get_streamMgrSettings() { }

	// RVA: 0x3179620 Offset: 0x3179721 VA: 0x3179620
	public void set_deviceSettings(AkDeviceSettings value) { }

	// RVA: 0x316C0D0 Offset: 0x316C1D1 VA: 0x316C0D0
	public AkDeviceSettings get_deviceSettings() { }

	// RVA: 0x31796E0 Offset: 0x31797E1 VA: 0x31796E0
	public void set_initSettings(AkInitSettings value) { }

	// RVA: 0x316C6D0 Offset: 0x316C7D1 VA: 0x316C6D0
	public AkInitSettings get_initSettings() { }

	// RVA: 0x31797A0 Offset: 0x31798A1 VA: 0x31797A0
	public void set_platformSettings(AkPlatformInitSettings value) { }

	// RVA: 0x316BBA0 Offset: 0x316BCA1 VA: 0x316BBA0
	public AkPlatformInitSettings get_platformSettings() { }

	// RVA: 0x3179900 Offset: 0x3179A01 VA: 0x3179900
	public void set_musicSettings(AkMusicSettings value) { }

	// RVA: 0x316C7A0 Offset: 0x316C8A1 VA: 0x316C7A0
	public AkMusicSettings get_musicSettings() { }

	// RVA: 0x3179A60 Offset: 0x3179B61 VA: 0x3179A60
	public void set_unityPlatformSpecificSettings(AkUnityPlatformSpecificSettings value) { }

	// RVA: 0x316C8F0 Offset: 0x316C9F1 VA: 0x316C8F0
	public AkUnityPlatformSpecificSettings get_unityPlatformSpecificSettings() { }

	// RVA: 0x316C9D0 Offset: 0x316CAD1 VA: 0x316C9D0
	public void set_useAsyncOpen(bool value) { }

	// RVA: 0x3179AF0 Offset: 0x3179BF1 VA: 0x3179AF0
	public bool get_useAsyncOpen() { }
}

