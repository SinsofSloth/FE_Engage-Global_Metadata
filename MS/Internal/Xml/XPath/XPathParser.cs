// Namespace: MS.Internal.Xml.XPath
internal class XPathParser // TypeDefIndex: 1615
{
	// Fields
	private XPathScanner scanner; // 0x10
	private int parseDepth; // 0x18
	private static readonly XPathResultType[] temparray1; // 0x0
	private static readonly XPathResultType[] temparray2; // 0x8
	private static readonly XPathResultType[] temparray3; // 0x10
	private static readonly XPathResultType[] temparray4; // 0x18
	private static readonly XPathResultType[] temparray5; // 0x20
	private static readonly XPathResultType[] temparray6; // 0x28
	private static readonly XPathResultType[] temparray7; // 0x30
	private static readonly XPathResultType[] temparray8; // 0x38
	private static readonly XPathResultType[] temparray9; // 0x40
	private static Hashtable functionTable; // 0x48
	private static Hashtable AxesTable; // 0x50

	// Methods

	// RVA: 0x19C0AA0 Offset: 0x19C0BA1 VA: 0x19C0AA0
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x19C0AE0 Offset: 0x19C0BE1 VA: 0x19C0AE0
	public static AstNode ParseXPathExpresion(string xpathExpresion) { }

	// RVA: 0x19C0D00 Offset: 0x19C0E01 VA: 0x19C0D00
	private AstNode ParseExpresion(AstNode qyInput) { }

	// RVA: 0x19C0D70 Offset: 0x19C0E71 VA: 0x19C0D70
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x19C0E80 Offset: 0x19C0F81 VA: 0x19C0E80
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x19C0FD0 Offset: 0x19C10D1 VA: 0x19C0FD0
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x19C10B0 Offset: 0x19C11B1 VA: 0x19C10B0
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x19C11B0 Offset: 0x19C12B1 VA: 0x19C11B0
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x19C12A0 Offset: 0x19C13A1 VA: 0x19C12A0
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x19C1400 Offset: 0x19C1501 VA: 0x19C1400
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x19C1500 Offset: 0x19C1601 VA: 0x19C1500
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x19C18C0 Offset: 0x19C19C1 VA: 0x19C18C0
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x19C1640 Offset: 0x19C1741 VA: 0x19C1640
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x19C1A80 Offset: 0x19C1B81 VA: 0x19C1A80
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x19C1FF0 Offset: 0x19C20F1 VA: 0x19C1FF0
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x19C1C00 Offset: 0x19C1D01 VA: 0x19C1C00
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x19C1B40 Offset: 0x19C1C41 VA: 0x19C1B40
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x19C2170 Offset: 0x19C2271 VA: 0x19C2170
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x19C21C0 Offset: 0x19C22C1 VA: 0x19C21C0
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x19C2460 Offset: 0x19C2561 VA: 0x19C2460
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x19C19C0 Offset: 0x19C1AC1 VA: 0x19C19C0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x19C1D50 Offset: 0x19C1E51 VA: 0x19C1D50
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x19C27E0 Offset: 0x19C28E1 VA: 0x19C27E0
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x19C2780 Offset: 0x19C2881 VA: 0x19C2780
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x19C2110 Offset: 0x19C2211 VA: 0x19C2110
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x19C0FC0 Offset: 0x19C10C1 VA: 0x19C0FC0
	private void NextLex() { }

	// RVA: 0x19C0F90 Offset: 0x19C1091 VA: 0x19C0F90
	private bool TestOp(string op) { }

	// RVA: 0x19C1860 Offset: 0x19C1961 VA: 0x19C1860
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x19C3550 Offset: 0x19C3651 VA: 0x19C3550
	private static Hashtable CreateFunctionTable() { }

	// RVA: 0x19C4030 Offset: 0x19C4131 VA: 0x19C4030
	private static Hashtable CreateAxesTable() { }

	// RVA: 0x19C2360 Offset: 0x19C2461 VA: 0x19C2360
	private Axis.AxisType GetAxis(XPathScanner scaner) { }

	// RVA: 0x19C4440 Offset: 0x19C4541 VA: 0x19C4440
	private static void .cctor() { }
}

