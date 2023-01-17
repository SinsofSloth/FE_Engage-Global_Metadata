// Namespace: Mono
internal static class RuntimeMarshal // TypeDefIndex: 10
{
	// Methods

	// RVA: 0x322CFB0 Offset: 0x322D0B1 VA: 0x322CFB0
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x322D090 Offset: 0x322D191 VA: 0x322D090
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x322D0C0 Offset: 0x322D1C1 VA: 0x322D0C0
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x322D150 Offset: 0x322D251 VA: 0x322D150
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x322D260 Offset: 0x322D361 VA: 0x322D260
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x322D290 Offset: 0x322D391 VA: 0x322D290
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}

