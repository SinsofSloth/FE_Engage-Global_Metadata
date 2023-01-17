// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner // TypeDefIndex: 1617
{
	// Fields
	private string xpathExpr; // 0x10
	private int xpathExprIndex; // 0x18
	private XPathScanner.LexKind kind; // 0x1C
	private char currentChar; // 0x20
	private string name; // 0x28
	private string prefix; // 0x30
	private string stringValue; // 0x38
	private double numberValue; // 0x40
	private bool canBeFunction; // 0x48
	private XmlCharType xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurerntChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x19C0C10 Offset: 0x19C0D11 VA: 0x19C0C10
	public void .ctor(string xpathExpr) { }

	// RVA: 0x19C46F0 Offset: 0x19C47F1 VA: 0x19C46F0
	public string get_SourceText() { }

	// RVA: 0x19C4700 Offset: 0x19C4801 VA: 0x19C4700
	private char get_CurerntChar() { }

	// RVA: 0x19C4690 Offset: 0x19C4791 VA: 0x19C4690
	private bool NextChar() { }

	// RVA: 0x19C4710 Offset: 0x19C4811 VA: 0x19C4710
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x19C4720 Offset: 0x19C4821 VA: 0x19C4720
	public string get_Name() { }

	// RVA: 0x19C4730 Offset: 0x19C4831 VA: 0x19C4730
	public string get_Prefix() { }

	// RVA: 0x19C4740 Offset: 0x19C4841 VA: 0x19C4740
	public string get_StringValue() { }

	// RVA: 0x19C4750 Offset: 0x19C4851 VA: 0x19C4750
	public double get_NumberValue() { }

	// RVA: 0x19C4760 Offset: 0x19C4861 VA: 0x19C4760
	public bool get_CanBeFunction() { }

	// RVA: 0x19C4770 Offset: 0x19C4871 VA: 0x19C4770
	private void SkipSpace() { }

	// RVA: 0x19C2DC0 Offset: 0x19C2EC1 VA: 0x19C2DC0
	public bool NextLex() { }

	// RVA: 0x19C49F0 Offset: 0x19C4AF1 VA: 0x19C49F0
	private double ScanNumber() { }

	// RVA: 0x19C47F0 Offset: 0x19C48F1 VA: 0x19C47F0
	private double ScanFraction() { }

	// RVA: 0x19C48D0 Offset: 0x19C49D1 VA: 0x19C48D0
	private string ScanString() { }

	// RVA: 0x19C4B40 Offset: 0x19C4C41 VA: 0x19C4B40
	private string ScanName() { }
}

