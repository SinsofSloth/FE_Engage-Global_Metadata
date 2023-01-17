// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FE50 Offset: 0x46FF51 VA: 0x46FE50
public static class Buffer // TypeDefIndex: 179
{
	// Methods

	// RVA: 0x35078C0 Offset: 0x35079C1 VA: 0x35078C0
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x350CAC0 Offset: 0x350CBC1 VA: 0x350CAC0
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x350CC70 Offset: 0x350CD71 VA: 0x350CC70
	private static int _ByteLength(Array array) { }

	// RVA: 0x350CC80 Offset: 0x350CD81 VA: 0x350CC80
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContractAttribute] // RVA: 0x479690 Offset: 0x479791 VA: 0x479690
	// RVA: 0x350CCB0 Offset: 0x350CDB1 VA: 0x350CCB0
	internal static void Memcpy(byte[] dest, int destIndex, byte* src, int srcIndex, int len) { }

	[ReliabilityContractAttribute] // RVA: 0x4796B0 Offset: 0x4797B1 VA: 0x4796B0
	// RVA: 0x350CF00 Offset: 0x350D001 VA: 0x350CF00
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x350CF40 Offset: 0x350D041 VA: 0x350CF40
	public static int ByteLength(Array array) { }

	// RVA: 0x35019C0 Offset: 0x3501AC1 VA: 0x35019C0
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	// RVA: 0x350D000 Offset: 0x350D101 VA: 0x350D000
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x350D0A0 Offset: 0x350D1A1 VA: 0x350D0A0
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x350D130 Offset: 0x350D231 VA: 0x350D130
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x350CCF0 Offset: 0x350CDF1 VA: 0x350CCF0
	internal static void Memcpy(byte* dest, byte* src, int size) { }
}

