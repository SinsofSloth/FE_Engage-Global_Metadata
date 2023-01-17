// Namespace: System.Collections.Generic
internal sealed class BitHelper // TypeDefIndex: 3284
{
	// Fields
	private readonly int _length; // 0x10
	private readonly int* _arrayPtr; // 0x18
	private readonly int[] _array; // 0x20
	private readonly bool _useStackAlloc; // 0x28

	// Methods

	// RVA: 0x2E508E0 Offset: 0x2E509E1 VA: 0x2E508E0
	internal void .ctor(int* bitArrayPtr, int length) { }

	// RVA: 0x2E50930 Offset: 0x2E50A31 VA: 0x2E50930
	internal void .ctor(int[] bitArray, int length) { }

	// RVA: 0x2E50980 Offset: 0x2E50A81 VA: 0x2E50980
	internal void MarkBit(int bitPosition) { }

	// RVA: 0x2E50A00 Offset: 0x2E50B01 VA: 0x2E50A00
	internal bool IsMarked(int bitPosition) { }

	// RVA: 0x2E50A90 Offset: 0x2E50B91 VA: 0x2E50A90
	internal static int ToIntArrayLength(int n) { }
}

