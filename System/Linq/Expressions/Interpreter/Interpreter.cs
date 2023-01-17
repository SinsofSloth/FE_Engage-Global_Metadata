// Namespace: System.Linq.Expressions.Interpreter
internal sealed class Interpreter // TypeDefIndex: 3038
{
	// Fields
	internal static readonly object NoValue; // 0x0
	private readonly InstructionArray _instructions; // 0x10
	internal readonly object[] _objects; // 0x38
	internal readonly RuntimeLabel[] _labels; // 0x40
	internal readonly DebugInfo[] _debugInfos; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x40C40 Offset: 0x40D41 VA: 0x40C40
	private readonly string <Name>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x40C50 Offset: 0x40D51 VA: 0x40C50
	private readonly int <LocalCount>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x40C60 Offset: 0x40D61 VA: 0x40C60
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; // 0x60

	// Properties
	internal string Name { get; }
	internal int LocalCount { get; }
	internal int ClosureSize { get; }
	internal InstructionArray Instructions { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x31BEA40 Offset: 0x31BEB41 VA: 0x31BEA40
	internal void .ctor(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CompilerGeneratedAttribute] // RVA: 0x42190 Offset: 0x42291 VA: 0x42190
	// RVA: 0x31BEB00 Offset: 0x31BEC01 VA: 0x31BEB00
	internal string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x421A0 Offset: 0x422A1 VA: 0x421A0
	// RVA: 0x31BEB10 Offset: 0x31BEC11 VA: 0x31BEB10
	internal int get_LocalCount() { }

	// RVA: 0x31BEB20 Offset: 0x31BEC21 VA: 0x31BEB20
	internal int get_ClosureSize() { }

	// RVA: 0x31BEB80 Offset: 0x31BEC81 VA: 0x31BEB80
	internal InstructionArray get_Instructions() { }

	[CompilerGeneratedAttribute] // RVA: 0x421B0 Offset: 0x422B1 VA: 0x421B0
	// RVA: 0x31BEBA0 Offset: 0x31BECA1 VA: 0x31BEBA0
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x31BEBB0 Offset: 0x31BECB1 VA: 0x31BEBB0
	public void Run(InterpretedFrame frame) { }

	// RVA: 0x31BEC30 Offset: 0x31BED31 VA: 0x31BEC30
	private static void .cctor() { }
}

