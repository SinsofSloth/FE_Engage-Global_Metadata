// Namespace: System.Linq.Expressions
internal class ScopeExpression : BlockExpression // TypeDefIndex: 2796
{
	// Fields
	private IReadOnlyList<ParameterExpression> _variables; // 0x10

	// Properties
	protected IReadOnlyList<ParameterExpression> VariablesList { get; }

	// Methods

	// RVA: 0x332DF40 Offset: 0x332E041 VA: 0x332DF40
	internal void .ctor(IReadOnlyList<ParameterExpression> variables) { }

	// RVA: 0x332E280 Offset: 0x332E381 VA: 0x332E280 Slot: 13
	internal override ReadOnlyCollection<ParameterExpression> GetOrMakeVariables() { }

	// RVA: 0x332E2E0 Offset: 0x332E3E1 VA: 0x332E2E0
	protected IReadOnlyList<ParameterExpression> get_VariablesList() { }

	// RVA: 0x332E1E0 Offset: 0x332E2E1 VA: 0x332E1E0
	internal IReadOnlyList<ParameterExpression> ReuseOrValidateVariables(ReadOnlyCollection<ParameterExpression> variables) { }
}

