// Namespace: UnityEngine.Rendering
[AttributeUsageAttribute] // RVA: 0x3B680 Offset: 0x3B781 VA: 0x3B680
public class SurfaceDataAttributes : Attribute // TypeDefIndex: 4598
{
	// Fields
	public string[] displayNames; // 0x10
	public bool isDirection; // 0x18
	public bool sRGBDisplay; // 0x19
	public FieldPrecision precision; // 0x1C
	public bool checkIsNormalized; // 0x20

	// Methods

	// RVA: 0x3546530 Offset: 0x3546631 VA: 0x3546530
	public void .ctor(string displayName = "", bool isDirection = False, bool sRGBDisplay = False, FieldPrecision precision = 2, bool checkIsNormalized = False) { }

	// RVA: 0x3546640 Offset: 0x3546741 VA: 0x3546640
	public void .ctor(string[] displayNames, bool isDirection = False, bool sRGBDisplay = False, bool checkIsNormalized = False, FieldPrecision precision = 2) { }
}

