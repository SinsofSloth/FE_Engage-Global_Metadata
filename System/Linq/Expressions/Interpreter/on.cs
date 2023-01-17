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
internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 2895
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

	// RVA: 0x2E464A0 Offset: 0x2E465A1 VA: 0x2E464A0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E464B0 Offset: 0x2E465B1 VA: 0x2E464B0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E464C0 Offset: 0x2E465C1 VA: 0x2E464C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E46510 Offset: 0x2E46611 VA: 0x2E46510
	private void .ctor() { }

	// RVA: 0x2E46520 Offset: 0x2E46621 VA: 0x2E46520
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AndInstruction : Instruction // TypeDefIndex: 2905
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

	// RVA: 0x2E4BAD0 Offset: 0x2E4BBD1 VA: 0x2E4BAD0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E4BAE0 Offset: 0x2E4BBE1 VA: 0x2E4BAE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E4BAF0 Offset: 0x2E4BBF1 VA: 0x2E4BAF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E4BB40 Offset: 0x2E4BC41 VA: 0x2E4BB40
	private void .ctor() { }

	// RVA: 0x2E4BB50 Offset: 0x2E4BC51 VA: 0x2E4BB50
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
internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 2907
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3329BF0 Offset: 0x3329CF1 VA: 0x3329BF0
	internal void .ctor(Type elementType) { }

	// RVA: 0x3329C30 Offset: 0x3329D31 VA: 0x3329C30 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3329C40 Offset: 0x3329D41 VA: 0x3329C40 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3329C50 Offset: 0x3329D51 VA: 0x3329C50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3329CA0 Offset: 0x3329DA1 VA: 0x3329CA0 Slot: 8
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
internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 2909
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31B3AC0 Offset: 0x31B3BC1 VA: 0x31B3AC0
	private void .ctor() { }

	// RVA: 0x31B3AD0 Offset: 0x31B3BD1 VA: 0x31B3AD0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31B3AE0 Offset: 0x31B3BE1 VA: 0x31B3AE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31B3AF0 Offset: 0x31B3BF1 VA: 0x31B3AF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31B3B40 Offset: 0x31B3C41 VA: 0x31B3B40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x31B3D00 Offset: 0x31B3E01 VA: 0x31B3D00
	private static void .cctor() { }
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
internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 2911
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E4C140 Offset: 0x2E4C241 VA: 0x2E4C140 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E4C150 Offset: 0x2E4C251 VA: 0x2E4C150 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E4C160 Offset: 0x2E4C261 VA: 0x2E4C160 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E4C1B0 Offset: 0x2E4C2B1 VA: 0x2E4C1B0
	private void .ctor() { }

	// RVA: 0x2E4C1C0 Offset: 0x2E4C2C1 VA: 0x2E4C1C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E4C260 Offset: 0x2E4C361 VA: 0x2E4C260
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CallInstruction : Instruction // TypeDefIndex: 2915
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_ArgumentCount();

	// RVA: 0x2E53C30 Offset: 0x2E53D31 VA: 0x2E53C30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E53C80 Offset: 0x2E53D81 VA: 0x2E53C80
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x2E53D00 Offset: 0x2E53E01 VA: 0x2E53D00
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x2E53E80 Offset: 0x2E53F81 VA: 0x2E53E80
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x2E543B0 Offset: 0x2E544B1 VA: 0x2E543B0
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x2E543D0 Offset: 0x2E544D1 VA: 0x2E543D0
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x2E543F0 Offset: 0x2E544F1 VA: 0x2E543F0
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x2E54410 Offset: 0x2E54511 VA: 0x2E54410 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E53340 Offset: 0x2E53441 VA: 0x2E53340
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x2E534C0 Offset: 0x2E535C1 VA: 0x2E534C0
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0x2E54420 Offset: 0x2E54521 VA: 0x2E54420
	protected void .ctor() { }
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
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 2917
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x2E52CA0 Offset: 0x2E52DA1 VA: 0x2E52CA0
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x2E52CE0 Offset: 0x2E52DE1 VA: 0x2E52CE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E52DA0 Offset: 0x2E52EA1 VA: 0x2E52DA0 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
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
internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 2919
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x2E52270 Offset: 0x2E52371 VA: 0x2E52270 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x2E52320 Offset: 0x2E52421 VA: 0x2E52320 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E52370 Offset: 0x2E52471 VA: 0x2E52370 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E52380 Offset: 0x2E52481 VA: 0x2E52380 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E52430 Offset: 0x2E52531 VA: 0x2E52430
	public void .ctor() { }
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
internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 2921
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x2E556D0 Offset: 0x2E557D1 VA: 0x2E556D0 Slot: 10
	public override Instruction[] get_Cache() { }

	// RVA: 0x2E55780 Offset: 0x2E55881 VA: 0x2E55780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E557D0 Offset: 0x2E558D1 VA: 0x2E557D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E557E0 Offset: 0x2E558E1 VA: 0x2E557E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E557F0 Offset: 0x2E558F1 VA: 0x2E557F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E55830 Offset: 0x2E55931 VA: 0x2E55830
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
internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 2923
{
	// Fields
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0x31B3F70 Offset: 0x31B4071 VA: 0x31B3F70
	public void .ctor(int labelIndex) { }

	// RVA: 0x31B6330 Offset: 0x31B6431 VA: 0x31B6330
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x31B6380 Offset: 0x31B6481 VA: 0x31B6380 Slot: 3
	public override string ToString() { }
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
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 2925
{
	// Fields
	private readonly bool _hasFinally; // 0x14
	private TryCatchFinallyHandler _tryHandler; // 0x18

	// Properties
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E585B0 Offset: 0x2E586B1 VA: 0x2E585B0
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x2E585C0 Offset: 0x2E586C1 VA: 0x2E585C0 Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x2E585D0 Offset: 0x2E586D1 VA: 0x2E585D0
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x2E58600 Offset: 0x2E58701 VA: 0x2E58600
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x2E58670 Offset: 0x2E58771 VA: 0x2E58670
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x2E586D0 Offset: 0x2E587D1 VA: 0x2E586D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E58B30 Offset: 0x2E58C31 VA: 0x2E58B30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E58BA0 Offset: 0x2E58CA1 VA: 0x2E58BA0 Slot: 3
	public override string ToString() { }
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
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 2927
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0x2E58300 Offset: 0x2E58401 VA: 0x2E58300
	private void .ctor(int labelIndex) { }

	// RVA: 0x2E58310 Offset: 0x2E58411 VA: 0x2E58310 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E58360 Offset: 0x2E58461 VA: 0x2E58360 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E58370 Offset: 0x2E58471 VA: 0x2E58370 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x2E58380 Offset: 0x2E58481 VA: 0x2E58380
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x2E584C0 Offset: 0x2E585C1 VA: 0x2E584C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E58530 Offset: 0x2E58631 VA: 0x2E58530
	private static void .cctor() { }
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
internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 2929
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x2E58080 Offset: 0x2E58181 VA: 0x2E58080
	private void .ctor(int labelIndex) { }

	// RVA: 0x2E58090 Offset: 0x2E58191 VA: 0x2E58090 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E580E0 Offset: 0x2E581E1 VA: 0x2E580E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E580F0 Offset: 0x2E581F1 VA: 0x2E580F0
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x2E58230 Offset: 0x2E58331 VA: 0x2E58230 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E58280 Offset: 0x2E58381 VA: 0x2E58280
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
internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 2931
{
	// Fields
	internal static readonly EnterExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x2E57E40 Offset: 0x2E57F41 VA: 0x2E57E40
	private void .ctor() { }

	// RVA: 0x2E57E50 Offset: 0x2E57F51 VA: 0x2E57E50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E57EA0 Offset: 0x2E57FA1 VA: 0x2E57EA0 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x42080 Offset: 0x42181 VA: 0x42080
	// RVA: 0x2E57EB0 Offset: 0x2E57FB1 VA: 0x2E57EB0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E57EC0 Offset: 0x2E57FC1 VA: 0x2E57EC0
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
internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 2933
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x2E57F30 Offset: 0x2E58031 VA: 0x2E57F30
	private void .ctor(bool hasValue) { }

	// RVA: 0x2E57F60 Offset: 0x2E58061 VA: 0x2E57F60 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E57FB0 Offset: 0x2E580B1 VA: 0x2E57FB0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E57FC0 Offset: 0x2E580C1 VA: 0x2E57FC0 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverageAttribute] // RVA: 0x420A0 Offset: 0x421A1 VA: 0x420A0
	// RVA: 0x2E57FD0 Offset: 0x2E580D1 VA: 0x2E57FD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E57FE0 Offset: 0x2E580E1 VA: 0x2E57FE0
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
internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 2935
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private static ConstructorInfo _runtimeWrappedExceptionCtor; // 0x20
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x3333650 Offset: 0x3333751 VA: 0x3333650
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x33336A0 Offset: 0x33337A1 VA: 0x33336A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x33336F0 Offset: 0x33337F1 VA: 0x33336F0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3333700 Offset: 0x3333801 VA: 0x3333700 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3333710 Offset: 0x3333811 VA: 0x3333710 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3333850 Offset: 0x3333951 VA: 0x3333850
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x3333920 Offset: 0x3333A21 VA: 0x3333920
	private static RuntimeWrappedException RuntimeWrap(object thrown) { }

	// RVA: 0x3333B70 Offset: 0x3333C71 VA: 0x3333B70
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
internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 2937
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x332F5E0 Offset: 0x332F6E1 VA: 0x332F5E0
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x332F630 Offset: 0x332F731 VA: 0x332F630 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332F680 Offset: 0x332F781 VA: 0x332F680 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332F690 Offset: 0x332F791 VA: 0x332F690 Slot: 8
	public override int Run(InterpretedFrame frame) { }
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
internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 2947
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E57100 Offset: 0x2E57201 VA: 0x2E57100
	internal void .ctor(Type type) { }

	// RVA: 0x2E57140 Offset: 0x2E57241 VA: 0x2E57140 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E57150 Offset: 0x2E57251 VA: 0x2E57150 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E571A0 Offset: 0x2E572A1 VA: 0x2E571A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x2E571E0 Offset: 0x2E572E1 VA: 0x2E571E0 Slot: 3
	public override string ToString() { }
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
internal abstract class FieldInstruction : Instruction // TypeDefIndex: 2993
{
	// Fields
	protected readonly FieldInfo _field; // 0x10

	// Methods

	// RVA: 0x31B3810 Offset: 0x31B3911 VA: 0x31B3810
	public void .ctor(FieldInfo field) { }

	// RVA: 0x31B3860 Offset: 0x31B3961 VA: 0x31B3860 Slot: 3
	public override string ToString() { }
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
internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 2995
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3324770 Offset: 0x3324871 VA: 0x3324770
	public void .ctor(FieldInfo field) { }

	// RVA: 0x3324780 Offset: 0x3324881 VA: 0x3324780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x33247D0 Offset: 0x33248D1 VA: 0x33247D0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x33247E0 Offset: 0x33248E1 VA: 0x33247E0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x33247F0 Offset: 0x33248F1 VA: 0x33247F0 Slot: 8
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
internal sealed class StoreStaticFieldInstruction : FieldInstruction // TypeDefIndex: 2997
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x332F530 Offset: 0x332F631 VA: 0x332F530
	public void .ctor(FieldInfo field) { }

	// RVA: 0x332F540 Offset: 0x332F641 VA: 0x332F540 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332F590 Offset: 0x332F691 VA: 0x332F590 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332F5A0 Offset: 0x332F6A1 VA: 0x332F5A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanInstruction : Instruction // TypeDefIndex: 3009
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31B4490 Offset: 0x31B4591 VA: 0x31B4490 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31B44A0 Offset: 0x31B45A1 VA: 0x31B44A0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31B44B0 Offset: 0x31B45B1 VA: 0x31B44B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31B4500 Offset: 0x31B4601 VA: 0x31B4500
	private void .ctor(object nullValue) { }

	// RVA: 0x31B4540 Offset: 0x31B4641 VA: 0x31B4540
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanOrEqualInstruction : Instruction // TypeDefIndex: 3021
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31B4F10 Offset: 0x31B5011 VA: 0x31B4F10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31B4F20 Offset: 0x31B5021 VA: 0x31B4F20 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31B4F30 Offset: 0x31B5031 VA: 0x31B4F30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31B4F80 Offset: 0x31B5081 VA: 0x31B4F80
	private void .ctor(object nullValue) { }

	// RVA: 0x31B4FC0 Offset: 0x31B50C1 VA: 0x31B4FC0
	public static Instruction Create(Type type, bool liftedToNull = False) { }
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
internal abstract class Instruction // TypeDefIndex: 3031
{
	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x31B7240 Offset: 0x31B7341 VA: 0x31B7240 Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x31B7250 Offset: 0x31B7351 VA: 0x31B7250 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x31B7260 Offset: 0x31B7361 VA: 0x31B7260 Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x31B7270 Offset: 0x31B7371 VA: 0x31B7270 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName();

	// RVA: 0x31B7280 Offset: 0x31B7381 VA: 0x31B7280 Slot: 3
	public override string ToString() { }

	// RVA: 0x31B72F0 Offset: 0x31B73F1 VA: 0x31B72F0
	protected static void NullCheck(object o) { }

	// RVA: 0x31B3850 Offset: 0x31B3951 VA: 0x31B3850
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 3051
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

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31C0760 Offset: 0x31C0861 VA: 0x31C0760 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31C0770 Offset: 0x31C0871 VA: 0x31C0770 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31C0780 Offset: 0x31C0881 VA: 0x31C0780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C07D0 Offset: 0x31C08D1 VA: 0x31C07D0
	private void .ctor() { }

	// RVA: 0x31BA0D0 Offset: 0x31BA1D1 VA: 0x31BA0D0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanInstruction : Instruction // TypeDefIndex: 3063
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31C07E0 Offset: 0x31C08E1 VA: 0x31C07E0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31C07F0 Offset: 0x31C08F1 VA: 0x31C07F0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31C0800 Offset: 0x31C0901 VA: 0x31C0800 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C0850 Offset: 0x31C0951 VA: 0x31C0850
	private void .ctor(object nullValue) { }

	// RVA: 0x31BA520 Offset: 0x31BA621 VA: 0x31BA520
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanOrEqualInstruction : Instruction // TypeDefIndex: 3075
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31C0890 Offset: 0x31C0991 VA: 0x31C0890 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x31C08A0 Offset: 0x31C09A1 VA: 0x31C08A0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x31C08B0 Offset: 0x31C09B1 VA: 0x31C08B0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31C0900 Offset: 0x31C0A01 VA: 0x31C0900
	private void .ctor(object nullValue) { }

	// RVA: 0x31BAF30 Offset: 0x31BB031 VA: 0x31BAF30
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LocalAccessInstruction : Instruction // TypeDefIndex: 3097
{
	// Fields
	internal readonly int _index; // 0x10

	// Methods

	// RVA: 0x3324890 Offset: 0x3324991 VA: 0x3324890
	protected void .ctor(int index) { }
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
internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 3099
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3324860 Offset: 0x3324961 VA: 0x3324860
	internal void .ctor(int index) { }

	// RVA: 0x33248C0 Offset: 0x33249C1 VA: 0x33248C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x33248D0 Offset: 0x33249D1 VA: 0x33248D0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3324920 Offset: 0x3324A21 VA: 0x3324920 Slot: 8
	public override int Run(InterpretedFrame frame) { }
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
internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 3101
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3324A90 Offset: 0x3324B91 VA: 0x3324A90
	internal void .ctor(int index) { }

	// RVA: 0x3324AC0 Offset: 0x3324BC1 VA: 0x3324AC0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3324AD0 Offset: 0x3324BD1 VA: 0x3324AD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3324B20 Offset: 0x3324C21 VA: 0x3324B20 Slot: 8
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
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 3103
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332F380 Offset: 0x332F481 VA: 0x332F380
	internal void .ctor(int index) { }

	// RVA: 0x332F3B0 Offset: 0x332F4B1 VA: 0x332F3B0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332F3C0 Offset: 0x332F4C1 VA: 0x332F3C0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332F410 Offset: 0x332F511 VA: 0x332F410 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x332F4A0 Offset: 0x332F5A1 VA: 0x332F4A0 Slot: 10
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
internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 3105
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332F1D0 Offset: 0x332F2D1 VA: 0x332F1D0
	internal void .ctor(int index) { }

	// RVA: 0x332F200 Offset: 0x332F301 VA: 0x332F200 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332F210 Offset: 0x332F311 VA: 0x332F210 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332F260 Offset: 0x332F361 VA: 0x332F260 Slot: 8
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
internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 3107
{
	// Fields
	public static readonly ValueTypeCopyInstruction Instruction; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3339A20 Offset: 0x3339B21 VA: 0x3339A20 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3339A30 Offset: 0x3339B31 VA: 0x3339A30 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3339A40 Offset: 0x3339B41 VA: 0x3339A40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3339A90 Offset: 0x3339B91 VA: 0x3339A90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3339AE0 Offset: 0x3339BE1 VA: 0x3339AE0
	public void .ctor() { }

	// RVA: 0x3339AF0 Offset: 0x3339BF1 VA: 0x3339AF0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class InitializeLocalInstruction : LocalAccessInstruction // TypeDefIndex: 3116
{
	// Methods

	// RVA: 0x31B6560 Offset: 0x31B6661 VA: 0x31B6560
	internal void .ctor(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 3117
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332DA80 Offset: 0x332DB81 VA: 0x332DA80
	public void .ctor(int count) { }

	// RVA: 0x332DAB0 Offset: 0x332DBB1 VA: 0x332DAB0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332DAC0 Offset: 0x332DBC1 VA: 0x332DAC0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332DAD0 Offset: 0x332DBD1 VA: 0x332DAD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332DB20 Offset: 0x332DC21 VA: 0x332DB20 Slot: 8
	public override int Run(InterpretedFrame frame) { }
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
internal abstract class MulInstruction : Instruction // TypeDefIndex: 3139
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

	// RVA: 0x3328610 Offset: 0x3328711 VA: 0x3328610 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3328620 Offset: 0x3328721 VA: 0x3328620 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3328630 Offset: 0x3328731 VA: 0x3328630 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3328680 Offset: 0x3328781 VA: 0x3328680
	private void .ctor() { }

	// RVA: 0x3328690 Offset: 0x3328791 VA: 0x3328690
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
internal class NewInstruction : Instruction // TypeDefIndex: 3157
{
	// Fields
	protected readonly ConstructorInfo _constructor; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3329E00 Offset: 0x3329F01 VA: 0x3329E00
	public void .ctor(ConstructorInfo constructor, int argumentCount) { }

	// RVA: 0x3329E50 Offset: 0x3329F51 VA: 0x3329E50 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3329E60 Offset: 0x3329F61 VA: 0x3329E60 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3329E70 Offset: 0x3329F71 VA: 0x3329E70 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3329EC0 Offset: 0x3329FC1 VA: 0x3329EC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x332A010 Offset: 0x332A111 VA: 0x332A010
	protected object[] GetArgs(InterpretedFrame frame, int first) { }

	// RVA: 0x332A1E0 Offset: 0x332A2E1 VA: 0x332A1E0 Slot: 3
	public override string ToString() { }
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
internal abstract class NotEqualInstruction : Instruction // TypeDefIndex: 3183
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
	private static Instruction s_SByteLiftedToNull; // 0x68
	private static Instruction s_Int16LiftedToNull; // 0x70
	private static Instruction s_CharLiftedToNull; // 0x78
	private static Instruction s_Int32LiftedToNull; // 0x80
	private static Instruction s_Int64LiftedToNull; // 0x88
	private static Instruction s_ByteLiftedToNull; // 0x90
	private static Instruction s_UInt16LiftedToNull; // 0x98
	private static Instruction s_UInt32LiftedToNull; // 0xA0
	private static Instruction s_UInt64LiftedToNull; // 0xA8
	private static Instruction s_SingleLiftedToNull; // 0xB0
	private static Instruction s_DoubleLiftedToNull; // 0xB8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332A3F0 Offset: 0x332A4F1 VA: 0x332A3F0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332A400 Offset: 0x332A501 VA: 0x332A400 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332A410 Offset: 0x332A511 VA: 0x332A410 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332A460 Offset: 0x332A561 VA: 0x332A460
	private void .ctor() { }

	// RVA: 0x332A470 Offset: 0x332A571 VA: 0x332A470
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotInstruction : Instruction // TypeDefIndex: 3193
{
	// Fields
	public static Instruction s_Boolean; // 0x0
	public static Instruction s_Int64; // 0x8
	public static Instruction s_Int32; // 0x10
	public static Instruction s_Int16; // 0x18
	public static Instruction s_UInt64; // 0x20
	public static Instruction s_UInt32; // 0x28
	public static Instruction s_UInt16; // 0x30
	public static Instruction s_Byte; // 0x38
	public static Instruction s_SByte; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332ADC0 Offset: 0x332AEC1 VA: 0x332ADC0
	private void .ctor() { }

	// RVA: 0x332ADD0 Offset: 0x332AED1 VA: 0x332ADD0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332ADE0 Offset: 0x332AEE1 VA: 0x332ADE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332ADF0 Offset: 0x332AEF1 VA: 0x332ADF0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332AE40 Offset: 0x332AF41 VA: 0x332AE40
	public static Instruction Create(Type type) { }
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
internal abstract class RightShiftInstruction : Instruction // TypeDefIndex: 3217
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

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332D440 Offset: 0x332D541 VA: 0x332D440 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332D450 Offset: 0x332D551 VA: 0x332D450 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332D460 Offset: 0x332D561 VA: 0x332D460 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332D4B0 Offset: 0x332D5B1 VA: 0x332D4B0
	private void .ctor() { }

	// RVA: 0x332D4C0 Offset: 0x332D5C1 VA: 0x332D4C0
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 3219
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3324F40 Offset: 0x3325041 VA: 0x3324F40
	internal void .ctor(object value) { }

	// RVA: 0x3324F80 Offset: 0x3325081 VA: 0x3324F80 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3324F90 Offset: 0x3325091 VA: 0x3324F90 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3324FE0 Offset: 0x33250E1 VA: 0x3324FE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3325070 Offset: 0x3325171 VA: 0x3325070 Slot: 3
	public override string ToString() { }
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
internal sealed class PopInstruction : Instruction // TypeDefIndex: 3221
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332CF00 Offset: 0x332D001 VA: 0x332CF00
	private void .ctor() { }

	// RVA: 0x332CF10 Offset: 0x332D011 VA: 0x332CF10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x332CF20 Offset: 0x332D021 VA: 0x332CF20 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332CF70 Offset: 0x332D071 VA: 0x332CF70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x332CF90 Offset: 0x332D091 VA: 0x332CF90
	private static void .cctor() { }
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
internal abstract class SubInstruction : Instruction // TypeDefIndex: 3231
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

	// RVA: 0x3332D40 Offset: 0x3332E41 VA: 0x3332D40 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3332D50 Offset: 0x3332E51 VA: 0x3332D50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3332D60 Offset: 0x3332E61 VA: 0x3332D60 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3332DB0 Offset: 0x3332EB1 VA: 0x3332DB0
	private void .ctor() { }

	// RVA: 0x3332DC0 Offset: 0x3332EC1 VA: 0x3332DC0
	public static Instruction Create(Type type) { }
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
internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 3239
{
	// Fields
	private readonly LightDelegateCreator _creator; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E56540 Offset: 0x2E56641 VA: 0x2E56540
	internal void .ctor(LightDelegateCreator delegateCreator) { }

	// RVA: 0x2E56580 Offset: 0x2E56681 VA: 0x2E56580 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E56590 Offset: 0x2E56691 VA: 0x2E56590 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E565A0 Offset: 0x2E566A1 VA: 0x2E565A0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E565F0 Offset: 0x2E566F1 VA: 0x2E565F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
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
internal sealed class TypeAsInstruction : Instruction // TypeDefIndex: 3241
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x33343A0 Offset: 0x33344A1 VA: 0x33343A0
	internal void .ctor(Type type) { }

	// RVA: 0x33343E0 Offset: 0x33344E1 VA: 0x33343E0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x33343F0 Offset: 0x33344F1 VA: 0x33343F0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3334400 Offset: 0x3334501 VA: 0x3334400 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3334450 Offset: 0x3334551 VA: 0x3334450 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x33344C0 Offset: 0x33345C1 VA: 0x33344C0 Slot: 3
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
internal abstract class CastInstruction : Instruction // TypeDefIndex: 3255
{
	// Fields
	private static CastInstruction s_Boolean; // 0x0
	private static CastInstruction s_Byte; // 0x8
	private static CastInstruction s_Char; // 0x10
	private static CastInstruction s_DateTime; // 0x18
	private static CastInstruction s_Decimal; // 0x20
	private static CastInstruction s_Double; // 0x28
	private static CastInstruction s_Int16; // 0x30
	private static CastInstruction s_Int32; // 0x38
	private static CastInstruction s_Int64; // 0x40
	private static CastInstruction s_SByte; // 0x48
	private static CastInstruction s_Single; // 0x50
	private static CastInstruction s_String; // 0x58
	private static CastInstruction s_UInt16; // 0x60
	private static CastInstruction s_UInt32; // 0x68
	private static CastInstruction s_UInt64; // 0x70

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x2E54430 Offset: 0x2E54531 VA: 0x2E54430 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x2E54440 Offset: 0x2E54541 VA: 0x2E54440 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x2E54450 Offset: 0x2E54551 VA: 0x2E54450 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x2E544A0 Offset: 0x2E545A1 VA: 0x2E544A0
	public static Instruction Create(Type t) { }

	// RVA: 0x2E54B40 Offset: 0x2E54C41 VA: 0x2E54B40
	protected void .ctor() { }
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

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastReferenceToEnumInstruction : CastInstruction // TypeDefIndex: 3257
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x2E54B50 Offset: 0x2E54C51 VA: 0x2E54B50
	public void .ctor(Type t) { }

	// RVA: 0x2E54B90 Offset: 0x2E54C91 VA: 0x2E54B90 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 3259
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x332D280 Offset: 0x332D381 VA: 0x332D280
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x332D2D0 Offset: 0x332D3D1 VA: 0x332D2D0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x332D2E0 Offset: 0x332D3E1 VA: 0x332D2E0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x332D330 Offset: 0x332D431 VA: 0x332D330 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

