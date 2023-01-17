// Namespace: App
public class MapImageCoreBit // TypeDefIndex: 12103
{
	// Fields
	private const int MaxCount = 32;
	private uint[] m_Images; // 0x10
	private static readonly uint[] s_Fill; // 0x0

	// Methods

	// RVA: 0x21E1F00 Offset: 0x21E2001 VA: 0x21E1F00
	public void .ctor() { }

	// RVA: 0x21E1F80 Offset: 0x21E2081 VA: 0x21E1F80 Slot: 4
	public virtual void Clear() { }

	// RVA: 0x21E1FA0 Offset: 0x21E20A1 VA: 0x21E1FA0
	public void CopyFrom(MapImageCoreBit src) { }

	// RVA: 0x21E1FC0 Offset: 0x21E20C1 VA: 0x21E1FC0
	public void Fill() { }

	// RVA: 0x21E2040 Offset: 0x21E2141 VA: 0x21E2040
	public void MergeFrom(MapImageCoreBit src) { }

	// RVA: 0x21E2660 Offset: 0x21E2761 VA: 0x21E2660
	public void Set(int x, int z) { }

	// RVA: 0x21E26B0 Offset: 0x21E27B1 VA: 0x21E26B0
	public bool Get(int x, int z) { }

	// RVA: 0x21E26F0 Offset: 0x21E27F1 VA: 0x21E26F0
	public void Clr(int x, int z) { }

	// RVA: 0x21E2740 Offset: 0x21E2841 VA: 0x21E2740
	public bool Get(int x, int z, int size) { }

	// RVA: 0x21E2860 Offset: 0x21E2961 VA: 0x21E2860
	public bool Exists() { }

	// RVA: 0x21E2A50 Offset: 0x21E2B51 VA: 0x21E2A50
	public void Dump() { }

	// RVA: 0x21E2A60 Offset: 0x21E2B61 VA: 0x21E2A60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21E2C10 Offset: 0x21E2D11 VA: 0x21E2C10
	private static void .cctor() { }
}

