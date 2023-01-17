// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelScopeInfo // TypeDefIndex: 3042
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x31BFF60 Offset: 0x31C0061 VA: 0x31BFF60
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x31BFED0 Offset: 0x31BFFD1 VA: 0x31BFED0
	internal bool get_CanJumpInto() { }

	// RVA: 0x31BF910 Offset: 0x31BFA11 VA: 0x31BF910
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x31BFFB0 Offset: 0x31C00B1 VA: 0x31BFFB0
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x31BFAD0 Offset: 0x31BFBD1 VA: 0x31BFAD0
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}

