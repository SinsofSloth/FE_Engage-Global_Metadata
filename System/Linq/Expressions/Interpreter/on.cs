// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddInstruction : Instruction // TypeDefIndex: 2888
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E46040 Offset: 0x2E46141 VA: 0x2E46040 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E46050 Offset: 0x2E46151 VA: 0x2E46050 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E46060 Offset: 0x2E46161 VA: 0x2E46060 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E460B0 Offset: 0x2E461B1 VA: 0x2E460B0
	private void .ctor() { }

	// RVA: 0x2E460C0 Offset: 0x2E461C1 VA: 0x2E460C0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 2906
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3329AA0 Offset: 0x3329BA1 VA: 0x3329AA0
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x3329AF0 Offset: 0x3329BF1 VA: 0x3329AF0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3329B00 Offset: 0x3329C01 VA: 0x3329B00 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3329B10 Offset: 0x3329C11 VA: 0x3329B10 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3329B60 Offset: 0x3329C61 VA: 0x3329B60 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 2908
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _rank; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3329550 Offset: 0x3329651 VA: 0x3329550
	internal void .ctor(Type elementType, int rank) { }

	// RVA: 0x33295A0 Offset: 0x33296A1 VA: 0x33295A0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x33295B0 Offset: 0x33296B1 VA: 0x33295B0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x33295C0 Offset: 0x33296C1 VA: 0x33295C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3329610 Offset: 0x3329711 VA: 0x3329610 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class SetArrayItemInstruction : Instruction // TypeDefIndex: 2910
{
	// Fields
	internal static readonly SetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332EE90 Offset: 0x332EF91 VA: 0x332EE90
	private void .ctor() { }

	// RVA: 0x332EEA0 Offset: 0x332EFA1 VA: 0x332EEA0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332EEB0 Offset: 0x332EFB1 VA: 0x332EEB0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332EF00 Offset: 0x332F001 VA: 0x332EF00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x332EFD0 Offset: 0x332F0D1 VA: 0x332EFD0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 2916
{
	// Fields
	protected readonly MethodInfo _target; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ArgumentCount { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3327A80 Offset: 0x3327B81 VA: 0x3327A80 Slot: 10
	public override int get_ArgumentCount() { }

	// RVA: 0x3327A90 Offset: 0x3327B91 VA: 0x3327A90
	internal void .ctor(MethodInfo target, int argumentCount) { }

	// RVA: 0x3327AE0 Offset: 0x3327BE1 VA: 0x3327AE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3327BA0 Offset: 0x3327CA1 VA: 0x3327BA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3327EA0 Offset: 0x3327FA1 VA: 0x3327EA0
	protected object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	// RVA: 0x3328080 Offset: 0x3328181 VA: 0x3328080 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 2918
{
	// Fields
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Instruction[] get_Cache();

	// RVA: 0x332BC70 Offset: 0x332BD71 VA: 0x332BC70
	public Instruction Fixup(int offset) { }

	// RVA: 0x332BD30 Offset: 0x332BE31 VA: 0x332BD30 Slot: 3
	public override string ToString() { }

	// RVA: 0x332BE20 Offset: 0x332BF21 VA: 0x332BE20
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 2920
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x2E52AD0 Offset: 0x2E52BD1 VA: 0x2E52AD0 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x2E52B80 Offset: 0x2E52C81 VA: 0x2E52B80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E52BD0 Offset: 0x2E52CD1 VA: 0x2E52BD0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E52BE0 Offset: 0x2E52CE1 VA: 0x2E52BE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E52C90 Offset: 0x2E52D91 VA: 0x2E52C90
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 2922
{
	// Fields
	private static Instruction[][][] s_caches; // 0x0
	internal readonly bool _hasResult; // 0x14
	internal readonly bool _hasValue; // 0x15

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x2E52440 Offset: 0x2E52541 VA: 0x2E52440 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x2E52690 Offset: 0x2E52791 VA: 0x2E52690
	internal void .ctor() { }

	// RVA: 0x2E526C0 Offset: 0x2E527C1 VA: 0x2E526C0
	public void .ctor(bool hasResult, bool hasValue) { }

	// RVA: 0x2E52710 Offset: 0x2E52811 VA: 0x2E52710 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E52760 Offset: 0x2E52861 VA: 0x2E52760 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E52770 Offset: 0x2E52871 VA: 0x2E52770 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E52780 Offset: 0x2E52881 VA: 0x2E52780 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 2924
{
	// Fields
	private static readonly GotoInstruction[] s_cache; // 0x0
	private readonly bool _hasResult; // 0x14
	private readonly bool _hasValue; // 0x15
	private readonly bool _labelTargetGetsValue; // 0x16

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x31B3EA0 Offset: 0x31B3FA1 VA: 0x31B3EA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31B3EF0 Offset: 0x31B3FF1 VA: 0x31B3EF0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31B3F00 Offset: 0x31B4001 VA: 0x31B3F00 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31B3F10 Offset: 0x31B4011 VA: 0x31B3F10
	private void .ctor(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x31B3FA0 Offset: 0x31B40A1 VA: 0x31B3FA0
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x31B4150 Offset: 0x31B4251 VA: 0x31B4150 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31B4410 Offset: 0x31B4511 VA: 0x31B4410
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 2926
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }

	// Methods

	// RVA: 0x2E58C70 Offset: 0x2E58D71 VA: 0x2E58C70
	internal void .ctor(int targetIndex) { }

	// RVA: 0x2E58C80 Offset: 0x2E58D81 VA: 0x2E58C80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E58CD0 Offset: 0x2E58DD1 VA: 0x2E58CD0 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x2E58CE0 Offset: 0x2E58DE1 VA: 0x2E58CE0
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x2E58CF0 Offset: 0x2E58DF1 VA: 0x2E58CF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFinallyInstruction : Instruction // TypeDefIndex: 2928
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31C0640 Offset: 0x31C0741 VA: 0x31C0640
	private void .ctor() { }

	// RVA: 0x31C0650 Offset: 0x31C0751 VA: 0x31C0650 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31C0660 Offset: 0x31C0761 VA: 0x31C0660 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C06B0 Offset: 0x31C07B1 VA: 0x31C06B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31C06F0 Offset: 0x31C07F1 VA: 0x31C06F0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 2930
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31C0530 Offset: 0x31C0631 VA: 0x31C0530
	private void .ctor() { }

	// RVA: 0x31C0540 Offset: 0x31C0641 VA: 0x31C0540 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31C0550 Offset: 0x31C0651 VA: 0x31C0550 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x31C0560 Offset: 0x31C0661 VA: 0x31C0560 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C05B0 Offset: 0x31C06B1 VA: 0x31C05B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31C05D0 Offset: 0x31C06D1 VA: 0x31C05D0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 2932
{
	// Fields
	internal static readonly LeaveExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x31C02C0 Offset: 0x31C03C1 VA: 0x31C02C0
	private void .ctor() { }

	// RVA: 0x31C02D0 Offset: 0x31C03D1 VA: 0x31C02D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C0320 Offset: 0x31C0421 VA: 0x31C0320 Slot: 4
	public override int get_ConsumedStack() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42090 Offset: 0x42191 VA: 0x42090
	// RVA: 0x31C0330 Offset: 0x31C0431 VA: 0x31C0330 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31C0340 Offset: 0x31C0441 VA: 0x31C0340
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 2934
{
	// Fields
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x0
	private readonly bool _hasValue; // 0x14

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x31C03B0 Offset: 0x31C04B1 VA: 0x31C03B0
	private void .ctor(int labelIndex, bool hasValue) { }

	// RVA: 0x31C03F0 Offset: 0x31C04F1 VA: 0x31C03F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C0440 Offset: 0x31C0541 VA: 0x31C0440 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31C0450 Offset: 0x31C0551 VA: 0x31C0450 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31BD620 Offset: 0x31BD721 VA: 0x31BD620
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	// RVA: 0x31C0460 Offset: 0x31C0561 VA: 0x31C0460 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31C04B0 Offset: 0x31C05B1 VA: 0x31C04B0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 2936
{
	// Fields
	private readonly Dictionary<T, int> _cases; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB32F0 Offset: 0x1EB33F1 VA: 0x1EB32F0
	|-IntSwitchInstruction<int>..ctor
	|
	|-RVA: 0x1EB3450 Offset: 0x1EB3551 VA: 0x1EB3450
	|-IntSwitchInstruction<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override string get_InstructionName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3330 Offset: 0x1EB3431 VA: 0x1EB3330
	|-IntSwitchInstruction<int>.get_InstructionName
	|
	|-RVA: 0x1EB3490 Offset: 0x1EB3591 VA: 0x1EB3490
	|-IntSwitchInstruction<object>.get_InstructionName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_ConsumedStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3380 Offset: 0x1EB3481 VA: 0x1EB3380
	|-IntSwitchInstruction<int>.get_ConsumedStack
	|
	|-RVA: 0x1EB34E0 Offset: 0x1EB35E1 VA: 0x1EB34E0
	|-IntSwitchInstruction<object>.get_ConsumedStack
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3390 Offset: 0x1EB3491 VA: 0x1EB3390
	|-IntSwitchInstruction<int>.Run
	|
	|-RVA: 0x1EB34F0 Offset: 0x1EB35F1 VA: 0x1EB34F0
	|-IntSwitchInstruction<object>.Run
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DecrementInstruction : Instruction // TypeDefIndex: 2946
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E56C60 Offset: 0x2E56D61 VA: 0x2E56C60 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E56C70 Offset: 0x2E56D71 VA: 0x2E56C70 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E56C80 Offset: 0x2E56D81 VA: 0x2E56C80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E56CD0 Offset: 0x2E56DD1 VA: 0x2E56CD0
	private void .ctor() { }

	// RVA: 0x2E56CE0 Offset: 0x2E56DE1 VA: 0x2E56CE0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DivInstruction : Instruction // TypeDefIndex: 2956
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E57880 Offset: 0x2E57981 VA: 0x2E57880 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E57890 Offset: 0x2E57991 VA: 0x2E57890 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E578A0 Offset: 0x2E579A1 VA: 0x2E578A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E578F0 Offset: 0x2E579F1 VA: 0x2E578F0
	private void .ctor() { }

	// RVA: 0x2E57900 Offset: 0x2E57A01 VA: 0x2E57900
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class EqualInstruction : Instruction // TypeDefIndex: 2982
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_BooleanLiftedToNull; // 0x68
	private static Instruction s_SByteLiftedToNull; // 0x70
	private static Instruction s_Int16LiftedToNull; // 0x78
	private static Instruction s_CharLiftedToNull; // 0x80
	private static Instruction s_Int32LiftedToNull; // 0x88
	private static Instruction s_Int64LiftedToNull; // 0x90
	private static Instruction s_ByteLiftedToNull; // 0x98
	private static Instruction s_UInt16LiftedToNull; // 0xA0
	private static Instruction s_UInt32LiftedToNull; // 0xA8
	private static Instruction s_UInt64LiftedToNull; // 0xB0
	private static Instruction s_SingleLiftedToNull; // 0xB8
	private static Instruction s_DoubleLiftedToNull; // 0xC0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E59710 Offset: 0x2E59811 VA: 0x2E59710 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E59720 Offset: 0x2E59821 VA: 0x2E59720 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E59730 Offset: 0x2E59831 VA: 0x2E59730 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E59780 Offset: 0x2E59881 VA: 0x2E59780
	private void .ctor() { }

	// RVA: 0x2E59790 Offset: 0x2E59891 VA: 0x2E59790
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 2992
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E5E1D0 Offset: 0x2E5E2D1 VA: 0x2E5E1D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E5E1E0 Offset: 0x2E5E2E1 VA: 0x2E5E1E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E5E1F0 Offset: 0x2E5E2F1 VA: 0x2E5E1F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E5E240 Offset: 0x2E5E341 VA: 0x2E5E240
	private void .ctor() { }

	// RVA: 0x2E5E250 Offset: 0x2E5E351 VA: 0x2E5E250
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadStaticFieldInstruction : FieldInstruction // TypeDefIndex: 2994
{
	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3325110 Offset: 0x3325211 VA: 0x3325110
	public void .ctor(FieldInfo field) { }

	// RVA: 0x3325120 Offset: 0x3325221 VA: 0x3325120 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3325170 Offset: 0x3325271 VA: 0x3325170 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3325180 Offset: 0x3325281 VA: 0x3325180 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreFieldInstruction : FieldInstruction // TypeDefIndex: 2996
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x332F0F0 Offset: 0x332F1F1 VA: 0x332F0F0
	public void .ctor(FieldInfo field) { }

	// RVA: 0x332F100 Offset: 0x332F201 VA: 0x332F100 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332F150 Offset: 0x332F251 VA: 0x332F150 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332F160 Offset: 0x332F261 VA: 0x332F160 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 3030
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31B5990 Offset: 0x31B5A91 VA: 0x31B5990 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31B59A0 Offset: 0x31B5AA1 VA: 0x31B59A0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31B59B0 Offset: 0x31B5AB1 VA: 0x31B59B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31B5A00 Offset: 0x31B5B01 VA: 0x31B5A00
	private void .ctor() { }

	// RVA: 0x31B5A10 Offset: 0x31B5B11 VA: 0x31B5A10
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 3098
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3324D80 Offset: 0x3324E81 VA: 0x3324D80
	internal void .ctor(int index) { }

	// RVA: 0x3324DB0 Offset: 0x3324EB1 VA: 0x3324DB0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3324DC0 Offset: 0x3324EC1 VA: 0x3324DC0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3324E10 Offset: 0x3324F11 VA: 0x3324E10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3324EB0 Offset: 0x3324FB1 VA: 0x3324EB0 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction // TypeDefIndex: 3100
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3324BC0 Offset: 0x3324CC1 VA: 0x3324BC0
	internal void .ctor(int index) { }

	// RVA: 0x3324BF0 Offset: 0x3324CF1 VA: 0x3324BF0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3324C00 Offset: 0x3324D01 VA: 0x3324C00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3324C50 Offset: 0x3324D51 VA: 0x3324C50 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 3102
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E4C5C0 Offset: 0x2E4C6C1 VA: 0x2E4C5C0
	internal void .ctor(int index) { }

	// RVA: 0x2E4C5D0 Offset: 0x2E4C6D1 VA: 0x2E4C5D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E4C5E0 Offset: 0x2E4C6E1 VA: 0x2E4C5E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E4C5F0 Offset: 0x2E4C6F1 VA: 0x2E4C5F0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E4C640 Offset: 0x2E4C741 VA: 0x2E4C640 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E4C6D0 Offset: 0x2E4C7D1 VA: 0x2E4C6D0 Slot: 10
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 3104
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E4C430 Offset: 0x2E4C531 VA: 0x2E4C430
	internal void .ctor(int index) { }

	// RVA: 0x2E4C440 Offset: 0x2E4C541 VA: 0x2E4C440 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E4C450 Offset: 0x2E4C551 VA: 0x2E4C450 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E4C460 Offset: 0x2E4C561 VA: 0x2E4C460 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E4C4B0 Offset: 0x2E4C5B1 VA: 0x2E4C4B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 3106
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E4C760 Offset: 0x2E4C861 VA: 0x2E4C760
	internal void .ctor(int index) { }

	// RVA: 0x2E4C770 Offset: 0x2E4C871 VA: 0x2E4C770 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E4C780 Offset: 0x2E4C881 VA: 0x2E4C780 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E4C790 Offset: 0x2E4C891 VA: 0x2E4C790 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E4C7E0 Offset: 0x2E4C8E1 VA: 0x2E4C7E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class InitializeLocalInstruction : LocalAccessInstruction // TypeDefIndex: 3116
{
	// Methods

	// RVA: 0x31B6560 Offset: 0x31B6661 VA: 0x31B6560
	internal void .ctor(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ModuloInstruction : Instruction // TypeDefIndex: 3130
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x33280F0 Offset: 0x33281F1 VA: 0x33280F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3328100 Offset: 0x3328201 VA: 0x3328100 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3328110 Offset: 0x3328211 VA: 0x3328110 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3328160 Offset: 0x3328261 VA: 0x3328160
	private void .ctor() { }

	// RVA: 0x3328170 Offset: 0x3328271 VA: 0x3328170
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 3146
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3328A60 Offset: 0x3328B61 VA: 0x3328A60 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3328A70 Offset: 0x3328B71 VA: 0x3328A70 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3328A80 Offset: 0x3328B81 VA: 0x3328A80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3328AD0 Offset: 0x3328BD1 VA: 0x3328AD0
	private void .ctor() { }

	// RVA: 0x3328AE0 Offset: 0x3328BE1 VA: 0x3328AE0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateInstruction : Instruction // TypeDefIndex: 3152
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3329380 Offset: 0x3329481 VA: 0x3329380 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3329390 Offset: 0x3329491 VA: 0x3329390 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x33293A0 Offset: 0x33294A1 VA: 0x33293A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x33293F0 Offset: 0x33294F1 VA: 0x33293F0
	private void .ctor() { }

	// RVA: 0x33290A0 Offset: 0x33291A1 VA: 0x33290A0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateCheckedInstruction : Instruction // TypeDefIndex: 3156
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3328E00 Offset: 0x3328F01 VA: 0x3328E00 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3328E10 Offset: 0x3328F11 VA: 0x3328E10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3328E20 Offset: 0x3328F21 VA: 0x3328E20 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3328E70 Offset: 0x3328F71 VA: 0x3328E70
	private void .ctor() { }

	// RVA: 0x3328E80 Offset: 0x3328F81 VA: 0x3328E80
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 3158
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E53520 Offset: 0x2E53621 VA: 0x2E53520
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x2E53560 Offset: 0x2E53661 VA: 0x2E53560 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E535B0 Offset: 0x2E536B1 VA: 0x2E535B0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 3194
{
	// Fields
	public static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332B260 Offset: 0x332B361 VA: 0x332B260
	private void .ctor() { }

	// RVA: 0x332B270 Offset: 0x332B371 VA: 0x332B270 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332B280 Offset: 0x332B381 VA: 0x332B280 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332B290 Offset: 0x332B391 VA: 0x332B290 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332B2E0 Offset: 0x332B3E1 VA: 0x332B2E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x332B340 Offset: 0x332B441 VA: 0x332B340
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 3198
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x332B840 Offset: 0x332B941 VA: 0x332B840
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x332B890 Offset: 0x332B991 VA: 0x332B890 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract object Convert(object obj);

	// RVA: 0x332B970 Offset: 0x332BA71 VA: 0x332B970 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332B9C0 Offset: 0x332BAC1 VA: 0x332B9C0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332B9D0 Offset: 0x332BAD1 VA: 0x332B9D0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332B9E0 Offset: 0x332BAE1 VA: 0x332B9E0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OrInstruction : Instruction // TypeDefIndex: 3208
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332BEC0 Offset: 0x332BFC1 VA: 0x332BEC0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332BED0 Offset: 0x332BFD1 VA: 0x332BED0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332BEE0 Offset: 0x332BFE1 VA: 0x332BEE0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332BF30 Offset: 0x332C031 VA: 0x332BF30
	private void .ctor() { }

	// RVA: 0x332BF40 Offset: 0x332C041 VA: 0x332BF40
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 3220
{
	// Fields
	private readonly uint _index; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3324590 Offset: 0x3324691 VA: 0x3324590
	internal void .ctor(uint index) { }

	// RVA: 0x33245C0 Offset: 0x33246C1 VA: 0x33245C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x33245D0 Offset: 0x33246D1 VA: 0x33245D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3324620 Offset: 0x3324721 VA: 0x3324620 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x33246C0 Offset: 0x33247C1 VA: 0x33246C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DupInstruction : Instruction // TypeDefIndex: 3222
{
	// Fields
	internal static readonly DupInstruction Instance; // 0x0

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E57C60 Offset: 0x2E57D61 VA: 0x2E57C60
	private void .ctor() { }

	// RVA: 0x2E57C70 Offset: 0x2E57D71 VA: 0x2E57C70 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E57C80 Offset: 0x2E57D81 VA: 0x2E57C80 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E57CD0 Offset: 0x2E57DD1 VA: 0x2E57CD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E57CF0 Offset: 0x2E57DF1 VA: 0x2E57CF0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 3238
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3333190 Offset: 0x3333291 VA: 0x3333190 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x33331A0 Offset: 0x33332A1 VA: 0x33331A0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x33331B0 Offset: 0x33332B1 VA: 0x33331B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3333200 Offset: 0x3333301 VA: 0x3333200
	private void .ctor() { }

	// RVA: 0x3333210 Offset: 0x3333311 VA: 0x3333210
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 3240
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3334AE0 Offset: 0x3334BE1 VA: 0x3334AE0
	internal void .ctor(Type type) { }

	// RVA: 0x3334B20 Offset: 0x3334C21 VA: 0x3334B20 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3334B30 Offset: 0x3334C31 VA: 0x3334B30 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3334B40 Offset: 0x3334C41 VA: 0x3334B40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3334B90 Offset: 0x3334C91 VA: 0x3334B90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3334BF0 Offset: 0x3334CF1 VA: 0x3334BF0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeEqualsInstruction : Instruction // TypeDefIndex: 3242
{
	// Fields
	public static readonly TypeEqualsInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3334550 Offset: 0x3334651 VA: 0x3334550 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3334560 Offset: 0x3334661 VA: 0x3334560 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3334570 Offset: 0x3334671 VA: 0x3334570 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x33345C0 Offset: 0x33346C1 VA: 0x33345C0
	private void .ctor() { }

	// RVA: 0x33345D0 Offset: 0x33346D1 VA: 0x33345D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3334630 Offset: 0x3334731 VA: 0x3334630
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 3250
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332B3B0 Offset: 0x332B4B1 VA: 0x332B3B0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332B3C0 Offset: 0x332B4C1 VA: 0x332B3C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332B3D0 Offset: 0x332B4D1 VA: 0x332B3D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332B420 Offset: 0x332B521 VA: 0x332B420
	private void .ctor() { }

	// RVA: 0x332B430 Offset: 0x332B531 VA: 0x332B430
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x332B790 Offset: 0x332B891 VA: 0x332B790
	public static Instruction CreateGetValue() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastToEnumInstruction : CastInstruction // TypeDefIndex: 3256
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x2E550C0 Offset: 0x2E551C1 VA: 0x2E550C0
	public void .ctor(Type t) { }

	// RVA: 0x2E55100 Offset: 0x2E55201 VA: 0x2E55100 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

