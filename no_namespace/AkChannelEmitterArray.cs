// Namespace: 
public class AkChannelEmitterArray : IDisposable // TypeDefIndex: 7964
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x27E520 Offset: 0x27E621 VA: 0x27E520
	private uint <Count>k__BackingField; // 0x24

	// Properties
	public uint Count { get; set; }

	// Methods

	// RVA: 0x3168FC0 Offset: 0x31690C1 VA: 0x3168FC0
	public void .ctor(uint in_Count) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A70C0 Offset: 0x2A71C1 VA: 0x2A70C0
	// RVA: 0x3169050 Offset: 0x3169151 VA: 0x3169050
	public uint get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A70D0 Offset: 0x2A71D1 VA: 0x2A70D0
	// RVA: 0x3169060 Offset: 0x3169161 VA: 0x3169060
	private void set_Count(uint value) { }

	// RVA: 0x3169070 Offset: 0x3169171 VA: 0x3169070 Slot: 4
	public void Dispose() { }

	// RVA: 0x3169110 Offset: 0x3169211 VA: 0x3169110 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x31691F0 Offset: 0x31692F1 VA: 0x31691F0
	public void Reset() { }

	// RVA: 0x3169200 Offset: 0x3169301 VA: 0x3169200
	public void Add(Vector3 in_Pos, Vector3 in_Forward, Vector3 in_Top, uint in_ChannelMask) { }
}

