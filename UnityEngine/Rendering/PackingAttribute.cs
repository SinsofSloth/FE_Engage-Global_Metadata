// Namespace: UnityEngine.Rendering
[AttributeUsageAttribute] // RVA: 0x3B6C0 Offset: 0x3B7C1 VA: 0x3B6C0
public class PackingAttribute : Attribute // TypeDefIndex: 4600
{
	// Fields
	public string[] displayNames; // 0x10
	public float[] range; // 0x18
	public FieldPacking packingScheme; // 0x20
	public int offsetInSource; // 0x24
	public int sizeInBits; // 0x28
	public bool isDirection; // 0x2C
	public bool sRGBDisplay; // 0x2D
	public bool checkIsNormalized; // 0x2E

	// Methods

	// RVA: 0x1A12B00 Offset: 0x1A12C01 VA: 0x1A12B00
	public void .ctor(string[] displayNames, FieldPacking packingScheme = 0, int bitSize = 32, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False) { }

	// RVA: 0x1A12C10 Offset: 0x1A12D11 VA: 0x1A12C10
	public void .ctor(string displayName = "", FieldPacking packingScheme = 0, int bitSize = 0, int offsetInSource = 0, float minValue = 0, float maxValue = 1, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False) { }
}

