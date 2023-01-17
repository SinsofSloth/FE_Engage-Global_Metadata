// Namespace: UnityEngine.Rendering
[AttributeUsageAttribute] // RVA: 0x3B660 Offset: 0x3B761 VA: 0x3B660
public class GenerateHLSL : Attribute // TypeDefIndex: 4597
{
	// Fields
	public PackingRules packingRules; // 0x10
	public bool containsPackedFields; // 0x14
	public bool needAccessors; // 0x15
	public bool needSetters; // 0x16
	public bool needParamDebug; // 0x17
	public int paramDefinesStart; // 0x18
	public bool omitStructDeclaration; // 0x1C
	public bool generateCBuffer; // 0x1D
	public int constantRegister; // 0x20

	// Methods

	// RVA: 0x1A107C0 Offset: 0x1A108C1 VA: 0x1A107C0
	public void .ctor(PackingRules rules = 0, bool needAccessors = True, bool needSetters = False, bool needParamDebug = False, int paramDefinesStart = 1, bool omitStructDeclaration = False, bool containsPackedFields = False, bool generateCBuffer = False, int constantRegister = -1) { }
}

