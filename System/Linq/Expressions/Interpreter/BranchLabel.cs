// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchLabel // TypeDefIndex: 2914
{
	// Fields
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x40C20 Offset: 0x40D21 VA: 0x40C20
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x42060 Offset: 0x42161 VA: 0x42060
	// RVA: 0x2E52790 Offset: 0x2E52891 VA: 0x2E52790
	internal int get_LabelIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x42070 Offset: 0x42171 VA: 0x42070
	// RVA: 0x2E527A0 Offset: 0x2E528A1 VA: 0x2E527A0
	internal void set_LabelIndex(int value) { }

	// RVA: 0x2E527B0 Offset: 0x2E528B1 VA: 0x2E527B0
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x2E527D0 Offset: 0x2E528D1 VA: 0x2E527D0
	internal int get_TargetIndex() { }

	// RVA: 0x2E527E0 Offset: 0x2E528E1 VA: 0x2E527E0
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x2E52820 Offset: 0x2E52921 VA: 0x2E52820
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x2E529B0 Offset: 0x2E52AB1 VA: 0x2E529B0
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x2E52990 Offset: 0x2E52A91 VA: 0x2E52990
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x2E52AB0 Offset: 0x2E52BB1 VA: 0x2E52AB0
	public void .ctor() { }
}

