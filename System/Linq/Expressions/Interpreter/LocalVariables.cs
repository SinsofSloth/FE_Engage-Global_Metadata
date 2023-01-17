// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariables // TypeDefIndex: 3121
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x33254B0 Offset: 0x33255B1 VA: 0x33254B0
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x33256F0 Offset: 0x33257F1 VA: 0x33256F0
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x33257C0 Offset: 0x33258C1 VA: 0x33257C0
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x3325930 Offset: 0x3325A31 VA: 0x3325930
	public int get_LocalCount() { }

	// RVA: 0x3325940 Offset: 0x3325A41 VA: 0x3325940
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x3325A20 Offset: 0x3325B21 VA: 0x3325A20
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x3325A30 Offset: 0x3325B31 VA: 0x3325A30
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x3325B50 Offset: 0x3325C51 VA: 0x3325B50
	public void .ctor() { }
}

