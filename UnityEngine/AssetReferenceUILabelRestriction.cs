// Namespace: UnityEngine
[AttributeUsageAttribute] // RVA: 0x65330 Offset: 0x65431 VA: 0x65330
public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction // TypeDefIndex: 7250
{
	// Fields
	public string[] m_AllowedLabels; // 0x10
	public string m_CachedToString; // 0x18

	// Methods

	// RVA: 0x3095B00 Offset: 0x3095C01 VA: 0x3095B00
	public void .ctor(string[] allowedLabels) { }

	// RVA: 0x3095B50 Offset: 0x3095C51 VA: 0x3095B50 Slot: 4
	public override bool ValidateAsset(Object obj) { }

	// RVA: 0x3095B60 Offset: 0x3095C61 VA: 0x3095B60 Slot: 5
	public override bool ValidateAsset(string path) { }

	// RVA: 0x3095B70 Offset: 0x3095C71 VA: 0x3095B70 Slot: 3
	public override string ToString() { }
}

