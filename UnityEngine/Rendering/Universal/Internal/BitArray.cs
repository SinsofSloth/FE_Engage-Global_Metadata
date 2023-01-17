// Namespace: UnityEngine.Rendering.Universal.Internal
internal struct BitArray : IDisposable // TypeDefIndex: 5391
{
	// Fields
	private NativeArray<uint> m_Mem; // 0x0
	private int m_BitCount; // 0x10
	private int m_IntCount; // 0x14

	// Methods

	// RVA: 0x2D28E00 Offset: 0x2D28F01 VA: 0x2D28E00
	public void .ctor(int bitCount, Allocator allocator, NativeArrayOptions options = 1) { }

	// RVA: 0x2D28EA0 Offset: 0x2D28FA1 VA: 0x2D28EA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2D28F00 Offset: 0x2D29001 VA: 0x2D28F00
	public void Clear() { }

	// RVA: 0x2D28F30 Offset: 0x2D29031 VA: 0x2D28F30
	public bool IsSet(int bitIndex) { }

	// RVA: 0x2D28F50 Offset: 0x2D29051 VA: 0x2D28F50
	public void Set(int bitIndex, bool val) { }
}

