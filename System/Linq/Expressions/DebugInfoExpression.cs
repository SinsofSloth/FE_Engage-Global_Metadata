// Namespace: System.Linq.Expressions
[DebuggerTypeProxyAttribute] // RVA: 0x3FB30 Offset: 0x3FC31 VA: 0x3FB30
public class DebugInfoExpression : Expression // TypeDefIndex: 2811
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x408B0 Offset: 0x409B1 VA: 0x408B0
	private readonly SymbolDocumentInfo <Document>k__BackingField; // 0x10

	// Properties
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42520 Offset: 0x42621 VA: 0x42520
	public virtual int StartLine { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42530 Offset: 0x42631 VA: 0x42530
	public virtual int EndLine { get; }
	public SymbolDocumentInfo Document { get; }
	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42540 Offset: 0x42641 VA: 0x42540
	public virtual bool IsClear { get; }

	// Methods

	// RVA: 0x2E56BC0 Offset: 0x2E56CC1 VA: 0x2E56BC0 Slot: 10
	public virtual int get_StartLine() { }

	// RVA: 0x2E56BF0 Offset: 0x2E56CF1 VA: 0x2E56BF0 Slot: 11
	public virtual int get_EndLine() { }

	[CompilerGeneratedAttribute] // RVA: 0x41C70 Offset: 0x41D71 VA: 0x41C70
	// RVA: 0x2E56C20 Offset: 0x2E56D21 VA: 0x2E56C20
	public SymbolDocumentInfo get_Document() { }

	// RVA: 0x2E56C30 Offset: 0x2E56D31 VA: 0x2E56C30 Slot: 12
	public virtual bool get_IsClear() { }
}

