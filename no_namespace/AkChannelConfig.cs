// Namespace: 
public class AkChannelConfig : IDisposable // TypeDefIndex: 7837
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint uNumChannels { get; set; }
	public uint eConfigType { get; set; }
	public uint uChannelMask { get; set; }

	// Methods

	// RVA: 0x3167E10 Offset: 0x3167F11 VA: 0x3167E10
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x3167E50 Offset: 0x3167F51 VA: 0x3167E50
	internal static IntPtr getCPtr(AkChannelConfig obj) { }

	// RVA: 0x3167EB0 Offset: 0x3167FB1 VA: 0x3167EB0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x3167EE0 Offset: 0x3167FE1 VA: 0x3167EE0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3167F50 Offset: 0x3168051 VA: 0x3167F50 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x31680E0 Offset: 0x31681E1 VA: 0x31680E0
	public void set_uNumChannels(uint value) { }

	// RVA: 0x3168160 Offset: 0x3168261 VA: 0x3168160
	public uint get_uNumChannels() { }

	// RVA: 0x31681D0 Offset: 0x31682D1 VA: 0x31681D0
	public void set_eConfigType(uint value) { }

	// RVA: 0x3168250 Offset: 0x3168351 VA: 0x3168250
	public uint get_eConfigType() { }

	// RVA: 0x31682C0 Offset: 0x31683C1 VA: 0x31682C0
	public void set_uChannelMask(uint value) { }

	// RVA: 0x3168340 Offset: 0x3168441 VA: 0x3168340
	public uint get_uChannelMask() { }

	// RVA: 0x31683B0 Offset: 0x31684B1 VA: 0x31683B0
	public void .ctor() { }

	// RVA: 0x3168440 Offset: 0x3168541 VA: 0x3168440
	public void .ctor(uint in_uNumChannels, uint in_uChannelMask) { }

	// RVA: 0x31684E0 Offset: 0x31685E1 VA: 0x31684E0
	public void Clear() { }

	// RVA: 0x3168550 Offset: 0x3168651 VA: 0x3168550
	public void SetStandard(uint in_uChannelMask) { }

	// RVA: 0x31685D0 Offset: 0x31686D1 VA: 0x31685D0
	public void SetStandardOrAnonymous(uint in_uNumChannels, uint in_uChannelMask) { }

	// RVA: 0x3168660 Offset: 0x3168761 VA: 0x3168660
	public void SetAnonymous(uint in_uNumChannels) { }

	// RVA: 0x31686E0 Offset: 0x31687E1 VA: 0x31686E0
	public void SetAmbisonic(uint in_uNumChannels) { }

	// RVA: 0x3168760 Offset: 0x3168861 VA: 0x3168760
	public bool IsValid() { }

	// RVA: 0x31687D0 Offset: 0x31688D1 VA: 0x31687D0
	public uint Serialize() { }

	// RVA: 0x3168840 Offset: 0x3168941 VA: 0x3168840
	public void Deserialize(uint in_uChannelConfig) { }

	// RVA: 0x31688C0 Offset: 0x31689C1 VA: 0x31688C0
	public AkChannelConfig RemoveLFE() { }

	// RVA: 0x3168970 Offset: 0x3168A71 VA: 0x3168970
	public AkChannelConfig RemoveCenter() { }

	// RVA: 0x3168A20 Offset: 0x3168B21 VA: 0x3168A20
	public bool IsChannelConfigSupported() { }
}

