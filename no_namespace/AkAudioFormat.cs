// Namespace: 
public class AkAudioFormat : IDisposable // TypeDefIndex: 7826
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uSampleRate { get; set; }
	public AkChannelConfig channelConfig { get; set; }
	public uint uBitsPerSample { get; set; }
	public uint uBlockAlign { get; set; }
	public uint uTypeID { get; set; }
	public uint uInterleaveID { get; set; }

	// Methods

	// RVA: 0x2ECDD50 Offset: 0x2ECDE51 VA: 0x2ECDD50
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2ECDD90 Offset: 0x2ECDE91 VA: 0x2ECDD90
	internal static IntPtr getCPtr(AkAudioFormat obj) { }

	// RVA: 0x2ECDDF0 Offset: 0x2ECDEF1 VA: 0x2ECDDF0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x2ECDE20 Offset: 0x2ECDF21 VA: 0x2ECDE20 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ECDE90 Offset: 0x2ECDF91 VA: 0x2ECDE90 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x2ECE020 Offset: 0x2ECE121 VA: 0x2ECE020
	public void set_uSampleRate(uint value) { }

	// RVA: 0x2ECE0A0 Offset: 0x2ECE1A1 VA: 0x2ECE0A0
	public uint get_uSampleRate() { }

	// RVA: 0x2ECE110 Offset: 0x2ECE211 VA: 0x2ECE110
	public void set_channelConfig(AkChannelConfig value) { }

	// RVA: 0x2ECE1A0 Offset: 0x2ECE2A1 VA: 0x2ECE1A0
	public AkChannelConfig get_channelConfig() { }

	// RVA: 0x2ECE280 Offset: 0x2ECE381 VA: 0x2ECE280
	public void set_uBitsPerSample(uint value) { }

	// RVA: 0x2ECE300 Offset: 0x2ECE401 VA: 0x2ECE300
	public uint get_uBitsPerSample() { }

	// RVA: 0x2ECE370 Offset: 0x2ECE471 VA: 0x2ECE370
	public void set_uBlockAlign(uint value) { }

	// RVA: 0x2ECE3F0 Offset: 0x2ECE4F1 VA: 0x2ECE3F0
	public uint get_uBlockAlign() { }

	// RVA: 0x2ECE460 Offset: 0x2ECE561 VA: 0x2ECE460
	public void set_uTypeID(uint value) { }

	// RVA: 0x2ECE4E0 Offset: 0x2ECE5E1 VA: 0x2ECE4E0
	public uint get_uTypeID() { }

	// RVA: 0x2ECE550 Offset: 0x2ECE651 VA: 0x2ECE550
	public void set_uInterleaveID(uint value) { }

	// RVA: 0x2ECE5D0 Offset: 0x2ECE6D1 VA: 0x2ECE5D0
	public uint get_uInterleaveID() { }

	// RVA: 0x2ECE640 Offset: 0x2ECE741 VA: 0x2ECE640
	public uint GetNumChannels() { }

	// RVA: 0x2ECE6B0 Offset: 0x2ECE7B1 VA: 0x2ECE6B0
	public uint GetBitsPerSample() { }

	// RVA: 0x2ECE720 Offset: 0x2ECE821 VA: 0x2ECE720
	public uint GetBlockAlign() { }

	// RVA: 0x2ECE790 Offset: 0x2ECE891 VA: 0x2ECE790
	public uint GetTypeID() { }

	// RVA: 0x2ECE800 Offset: 0x2ECE901 VA: 0x2ECE800
	public uint GetInterleaveID() { }

	// RVA: 0x2ECE870 Offset: 0x2ECE971 VA: 0x2ECE870
	public void SetAll(uint in_uSampleRate, AkChannelConfig in_channelConfig, uint in_uBitsPerSample, uint in_uBlockAlign, uint in_uTypeID, uint in_uInterleaveID) { }

	// RVA: 0x2ECE940 Offset: 0x2ECEA41 VA: 0x2ECE940
	public bool IsChannelConfigSupported() { }

	// RVA: 0x2ECE9B0 Offset: 0x2ECEAB1 VA: 0x2ECE9B0
	public void .ctor() { }
}

