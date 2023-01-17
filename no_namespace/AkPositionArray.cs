// Namespace: 
public class AkPositionArray : IDisposable // TypeDefIndex: 7972
{
	// Fields
	public IntPtr m_Buffer; // 0x10
	private IntPtr m_Current; // 0x18
	private uint m_MaxCount; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x27E530 Offset: 0x27E631 VA: 0x27E530
	private uint <Count>k__BackingField; // 0x24
	private static AkPositionArray.FloatInt32Union FloatToInt; // 0x0

	// Properties
	public uint Count { get; set; }

	// Methods

	// RVA: 0x3185C40 Offset: 0x3185D41 VA: 0x3185C40
	public void .ctor(uint in_Count) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A70E0 Offset: 0x2A71E1 VA: 0x2A70E0
	// RVA: 0x3185CD0 Offset: 0x3185DD1 VA: 0x3185CD0
	public uint get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A70F0 Offset: 0x2A71F1 VA: 0x2A70F0
	// RVA: 0x3185CE0 Offset: 0x3185DE1 VA: 0x3185CE0
	private void set_Count(uint value) { }

	// RVA: 0x3185CF0 Offset: 0x3185DF1 VA: 0x3185CF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3185D90 Offset: 0x3185E91 VA: 0x3185D90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3185E70 Offset: 0x3185F71 VA: 0x3185E70
	public void Reset() { }

	// RVA: 0x3185E80 Offset: 0x3185F81 VA: 0x3185E80
	public void Add(Vector3 in_Pos, Vector3 in_Forward, Vector3 in_Top) { }

	// RVA: 0x3186210 Offset: 0x3186311 VA: 0x3186210
	private static void .cctor() { }
}

