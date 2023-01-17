// Namespace: MS.Internal.Xml.XPath
internal class Axis : AstNode // TypeDefIndex: 1604
{
	// Fields
	private Axis.AxisType axisType; // 0x10
	private AstNode input; // 0x18
	private string prefix; // 0x20
	private string name; // 0x28
	private XPathNodeType nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x1A233A0 Offset: 0x1A234A1 VA: 0x1A233A0
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x1A23470 Offset: 0x1A23571 VA: 0x1A23470
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x1A23560 Offset: 0x1A23661 VA: 0x1A23560 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1A23570 Offset: 0x1A23671 VA: 0x1A23570 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1A23580 Offset: 0x1A23681 VA: 0x1A23580
	public AstNode get_Input() { }

	// RVA: 0x1A23590 Offset: 0x1A23691 VA: 0x1A23590
	public void set_Input(AstNode value) { }

	// RVA: 0x1A235A0 Offset: 0x1A236A1 VA: 0x1A235A0
	public string get_Prefix() { }

	// RVA: 0x1A235B0 Offset: 0x1A236B1 VA: 0x1A235B0
	public string get_Name() { }

	// RVA: 0x1A235C0 Offset: 0x1A236C1 VA: 0x1A235C0
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1A235D0 Offset: 0x1A236D1 VA: 0x1A235D0
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0x1A235E0 Offset: 0x1A236E1 VA: 0x1A235E0
	public bool get_AbbrAxis() { }

	// RVA: 0x1A235F0 Offset: 0x1A236F1 VA: 0x1A235F0
	public string get_Urn() { }

	// RVA: 0x1A23600 Offset: 0x1A23701 VA: 0x1A23600
	public void set_Urn(string value) { }
}

