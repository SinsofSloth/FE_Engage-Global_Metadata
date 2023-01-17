// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryArray // TypeDefIndex: 1045
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x35032F0 Offset: 0x35033F1 VA: 0x35032F0
	internal void .ctor() { }

	// RVA: 0x3503300 Offset: 0x3503401 VA: 0x3503300
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x3503330 Offset: 0x3503431 VA: 0x3503330
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x35033F0 Offset: 0x35034F1 VA: 0x35033F0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3503810 Offset: 0x3503911 VA: 0x3503810 Slot: 5
	public void Read(__BinaryParser input) { }
}

