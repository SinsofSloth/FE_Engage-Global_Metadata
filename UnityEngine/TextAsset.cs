// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43EAE0 Offset: 0x43EBE1 VA: 0x43EAE0
public class TextAsset : Object // TypeDefIndex: 3610
{
	// Properties
	public byte[] bytes { get; }
	public string text { get; }

	// Methods

	// RVA: 0x3840270 Offset: 0x3840371 VA: 0x3840270
	public byte[] get_bytes() { }

	// RVA: 0x38402C0 Offset: 0x38403C1 VA: 0x38402C0
	private byte[] GetPreviewBytes(int maxByteCount) { }

	// RVA: 0x3840310 Offset: 0x3840411 VA: 0x3840310
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	// RVA: 0x3840360 Offset: 0x3840461 VA: 0x3840360
	public string get_text() { }

	// RVA: 0x3840690 Offset: 0x3840791 VA: 0x3840690 Slot: 3
	public override string ToString() { }

	// RVA: 0x38406E0 Offset: 0x38407E1 VA: 0x38406E0
	public void .ctor() { }

	// RVA: 0x3840850 Offset: 0x3840951 VA: 0x3840850
	public void .ctor(string text) { }

	// RVA: 0x3840780 Offset: 0x3840881 VA: 0x3840780
	internal void .ctor(TextAsset.CreateOptions options, string text) { }

	// RVA: 0x38408F0 Offset: 0x38409F1 VA: 0x38408F0
	internal string GetPreview(int maxChars) { }

	// RVA: 0x38403B0 Offset: 0x38404B1 VA: 0x38403B0
	internal static string DecodeString(byte[] bytes) { }
}

