// Namespace: 
public class AkInitSettings : IDisposable // TypeDefIndex: 7857
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uMaxNumPaths { get; set; }
	public uint uCommandQueueSize { get; set; }
	public bool bEnableGameSyncPreparation { get; set; }
	public uint uContinuousPlaybackLookAhead { get; set; }
	public uint uNumSamplesPerFrame { get; set; }
	public uint uMonitorQueuePoolSize { get; set; }
	public AkOutputSettings settingsMainOutput { get; set; }
	public uint uMaxHardwareTimeoutMs { get; set; }
	public bool bUseSoundBankMgrThread { get; set; }
	public bool bUseLEngineThread { get; set; }
	public string szPluginDLLPath { get; set; }
	public AkFloorPlane eFloorPlane { get; set; }
	public uint uBankReadBufferSize { get; set; }
	public float fDebugOutOfRangeLimit { get; set; }
	public bool bDebugOutOfRangeCheckEnabled { get; set; }

	// Methods

	// RVA: 0x3178650 Offset: 0x3178751 VA: 0x3178650
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3178690 Offset: 0x3178791 VA: 0x3178690
	internal static IntPtr getCPtr(AkInitSettings obj) { }

	// RVA: 0x31786F0 Offset: 0x31787F1 VA: 0x31786F0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3178720 Offset: 0x3178821 VA: 0x3178720 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3178790 Offset: 0x3178891 VA: 0x3178790 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x316CFA0 Offset: 0x316D0A1 VA: 0x316CFA0
	public void set_uMaxNumPaths(uint value) { }

	// RVA: 0x3178920 Offset: 0x3178A21 VA: 0x3178920
	public uint get_uMaxNumPaths() { }

	// RVA: 0x316D020 Offset: 0x316D121 VA: 0x316D020
	public void set_uCommandQueueSize(uint value) { }

	// RVA: 0x3178990 Offset: 0x3178A91 VA: 0x3178990
	public uint get_uCommandQueueSize() { }

	// RVA: 0x3169BB0 Offset: 0x3169CB1 VA: 0x3169BB0
	public void set_bEnableGameSyncPreparation(bool value) { }

	// RVA: 0x3178A00 Offset: 0x3178B01 VA: 0x3178A00
	public bool get_bEnableGameSyncPreparation() { }

	// RVA: 0x3169C30 Offset: 0x3169D31 VA: 0x3169C30
	public void set_uContinuousPlaybackLookAhead(uint value) { }

	// RVA: 0x3178A70 Offset: 0x3178B71 VA: 0x3178A70
	public uint get_uContinuousPlaybackLookAhead() { }

	// RVA: 0x316D0A0 Offset: 0x316D1A1 VA: 0x316D0A0
	public void set_uNumSamplesPerFrame(uint value) { }

	// RVA: 0x3178AE0 Offset: 0x3178BE1 VA: 0x3178AE0
	public uint get_uNumSamplesPerFrame() { }

	// RVA: 0x3169CB0 Offset: 0x3169DB1 VA: 0x3169CB0
	public void set_uMonitorQueuePoolSize(uint value) { }

	// RVA: 0x3178B50 Offset: 0x3178C51 VA: 0x3178B50
	public uint get_uMonitorQueuePoolSize() { }

	// RVA: 0x3178BC0 Offset: 0x3178CC1 VA: 0x3178BC0
	public void set_settingsMainOutput(AkOutputSettings value) { }

	// RVA: 0x316D120 Offset: 0x316D221 VA: 0x316D120
	public AkOutputSettings get_settingsMainOutput() { }

	// RVA: 0x3169D30 Offset: 0x3169E31 VA: 0x3169D30
	public void set_uMaxHardwareTimeoutMs(uint value) { }

	// RVA: 0x3178D20 Offset: 0x3178E21 VA: 0x3178D20
	public uint get_uMaxHardwareTimeoutMs() { }

	// RVA: 0x3178D90 Offset: 0x3178E91 VA: 0x3178D90
	public void set_bUseSoundBankMgrThread(bool value) { }

	// RVA: 0x3178E10 Offset: 0x3178F11 VA: 0x3178E10
	public bool get_bUseSoundBankMgrThread() { }

	// RVA: 0x3178E80 Offset: 0x3178F81 VA: 0x3178E80
	public void set_bUseLEngineThread(bool value) { }

	// RVA: 0x3178F00 Offset: 0x3179001 VA: 0x3178F00
	public bool get_bUseLEngineThread() { }

	// RVA: 0x316D1F0 Offset: 0x316D2F1 VA: 0x316D1F0
	public void set_szPluginDLLPath(string value) { }

	// RVA: 0x316D270 Offset: 0x316D371 VA: 0x316D270
	public string get_szPluginDLLPath() { }

	// RVA: 0x3178F70 Offset: 0x3179071 VA: 0x3178F70
	public void set_eFloorPlane(AkFloorPlane value) { }

	// RVA: 0x3178FF0 Offset: 0x31790F1 VA: 0x3178FF0
	public AkFloorPlane get_eFloorPlane() { }

	// RVA: 0x3179060 Offset: 0x3179161 VA: 0x3179060
	public void set_uBankReadBufferSize(uint value) { }

	// RVA: 0x31790E0 Offset: 0x31791E1 VA: 0x31790E0
	public uint get_uBankReadBufferSize() { }

	// RVA: 0x3169E30 Offset: 0x3169F31 VA: 0x3169E30
	public void set_fDebugOutOfRangeLimit(float value) { }

	// RVA: 0x3179150 Offset: 0x3179251 VA: 0x3179150
	public float get_fDebugOutOfRangeLimit() { }

	// RVA: 0x3169DB0 Offset: 0x3169EB1 VA: 0x3169DB0
	public void set_bDebugOutOfRangeCheckEnabled(bool value) { }

	// RVA: 0x31791C0 Offset: 0x31792C1 VA: 0x31791C0
	public bool get_bDebugOutOfRangeCheckEnabled() { }
}

