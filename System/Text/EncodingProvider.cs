// Namespace: System.Text
[ComVisibleAttribute] // RVA: 0x471410 Offset: 0x471511 VA: 0x471410
public abstract class EncodingProvider // TypeDefIndex: 463
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	private static EncodingProvider[] s_providers; // 0x8

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Encoding GetEncoding(string name);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Encoding GetEncoding(int codepage);

	// RVA: 0x3B4E180 Offset: 0x3B4E281 VA: 0x3B4E180 Slot: 6
	public virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) { }

	// RVA: 0x3B4E280 Offset: 0x3B4E381 VA: 0x3B4E280
	internal static Encoding GetEncodingFromProvider(int codepage) { }

	// RVA: 0x3B4E390 Offset: 0x3B4E491 VA: 0x3B4E390
	internal static Encoding GetEncodingFromProvider(string encodingName) { }

	// RVA: 0x3B4E4A0 Offset: 0x3B4E5A1 VA: 0x3B4E4A0
	internal static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec) { }

	// RVA: 0x3B4E5D0 Offset: 0x3B4E6D1 VA: 0x3B4E5D0
	private static void .cctor() { }
}

