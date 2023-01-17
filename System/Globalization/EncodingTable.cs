// Namespace: System.Globalization
internal static class EncodingTable // TypeDefIndex: 718
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Hashtable hashByName; // 0x18
	private static Hashtable hashByCodePage; // 0x20

	// Methods

	// RVA: 0x3B4E650 Offset: 0x3B4E751 VA: 0x3B4E650
	private static int GetNumEncodingItems() { }

	// RVA: 0x3B4E6C0 Offset: 0x3B4E7C1 VA: 0x3B4E6C0
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x3B4E700 Offset: 0x3B4E801 VA: 0x3B4E700
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x3B4E740 Offset: 0x3B4E841 VA: 0x3B4E740
	private static void .cctor() { }

	// RVA: 0x3B584D0 Offset: 0x3B585D1 VA: 0x3B584D0
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x3B587B0 Offset: 0x3B588B1 VA: 0x3B587B0
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x3B58930 Offset: 0x3B58A31 VA: 0x3B58930
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}

