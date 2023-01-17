// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelInfo // TypeDefIndex: 3040
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x31BF170 Offset: 0x31BF271 VA: 0x31BF170
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x31BF220 Offset: 0x31BF321 VA: 0x31BF220
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x31BF2C0 Offset: 0x31BF3C1 VA: 0x31BF2C0
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x31BF6C0 Offset: 0x31BF7C1 VA: 0x31BF6C0
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x31BF350 Offset: 0x31BF451 VA: 0x31BF350
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x31BFEE0 Offset: 0x31BFFE1 VA: 0x31BFEE0
	internal void ValidateFinish() { }

	// RVA: 0x31BF270 Offset: 0x31BF371 VA: 0x31BF270
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x31BFC20 Offset: 0x31BFD21 VA: 0x31BFC20
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x31BF340 Offset: 0x31BF441 VA: 0x31BF340
	private bool get_HasDefinitions() { }

	// RVA: 0x31BFCF0 Offset: 0x31BFDF1 VA: 0x31BFCF0
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x31BF980 Offset: 0x31BFA81 VA: 0x31BF980
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x31BFB90 Offset: 0x31BFC91 VA: 0x31BFB90
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x295ABF0 Offset: 0x295ACF1 VA: 0x295ABF0
	|-LabelInfo.CommonNode<LabelScopeInfo>
	|-LabelInfo.CommonNode<object>
	*/
}

