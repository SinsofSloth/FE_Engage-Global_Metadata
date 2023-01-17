// Namespace: UnityEngine
[ExtensionAttribute] // RVA: 0x7BDA0 Offset: 0x7BEA1 VA: 0x7BDA0
[NativeHeaderAttribute] // RVA: 0x7BDA0 Offset: 0x7BEA1 VA: 0x7BDA0
public static class ImageConversion // TypeDefIndex: 4746
{
	// Methods

	[NativeMethodAttribute] // RVA: 0x7BDF0 Offset: 0x7BEF1 VA: 0x7BDF0
	[ExtensionAttribute] // RVA: 0x7BDF0 Offset: 0x7BEF1 VA: 0x7BDF0
	// RVA: 0x1C6DDF0 Offset: 0x1C6DEF1 VA: 0x1C6DDF0
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x7BE50 Offset: 0x7BF51 VA: 0x7BE50
	[NativeMethodAttribute] // RVA: 0x7BE50 Offset: 0x7BF51 VA: 0x7BE50
	// RVA: 0x1C6DE40 Offset: 0x1C6DF41 VA: 0x1C6DE40
	public static byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[ExtensionAttribute] // RVA: 0x7BEC0 Offset: 0x7BFC1 VA: 0x7BEC0
	// RVA: 0x1C6DE90 Offset: 0x1C6DF91 VA: 0x1C6DE90
	public static byte[] EncodeToJPG(Texture2D tex) { }

	[ExtensionAttribute] // RVA: 0x7BED0 Offset: 0x7BFD1 VA: 0x7BED0
	[NativeMethodAttribute] // RVA: 0x7BED0 Offset: 0x7BFD1 VA: 0x7BED0
	// RVA: 0x1C6DEE0 Offset: 0x1C6DFE1 VA: 0x1C6DEE0
	public static bool LoadImage(Texture2D tex, byte[] data, bool markNonReadable) { }

	[ExtensionAttribute] // RVA: 0x7BF40 Offset: 0x7C041 VA: 0x7BF40
	// RVA: 0x1C6DF40 Offset: 0x1C6E041 VA: 0x1C6DF40
	public static bool LoadImage(Texture2D tex, byte[] data) { }
}

