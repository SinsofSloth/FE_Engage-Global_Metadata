// Namespace: System.Linq.Expressions.Interpreter
internal sealed class InterpretedFrame // TypeDefIndex: 3037
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x40C30 Offset: 0x40D31 VA: 0x40C30
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x31BD9C0 Offset: 0x31BDAC1 VA: 0x31BD9C0
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x31BDB00 Offset: 0x31BDC01 VA: 0x31BDB00
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x31BDB80 Offset: 0x31BDC81 VA: 0x31BDB80
	public string get_Name() { }

	// RVA: 0x31B3C80 Offset: 0x31B3D81 VA: 0x31B3C80
	public void Push(object value) { }

	// RVA: 0x31BDB90 Offset: 0x31BDC91 VA: 0x31BDB90
	public void Push(bool value) { }

	// RVA: 0x31BDCA0 Offset: 0x31BDDA1 VA: 0x31BDCA0
	public void Push(int value) { }

	// RVA: 0x31BDD30 Offset: 0x31BDE31 VA: 0x31BDD30
	public void Push(byte value) { }

	// RVA: 0x31BDE00 Offset: 0x31BDF01 VA: 0x31BDE00
	public void Push(sbyte value) { }

	// RVA: 0x31BDED0 Offset: 0x31BDFD1 VA: 0x31BDED0
	public void Push(short value) { }

	// RVA: 0x31BDFA0 Offset: 0x31BE0A1 VA: 0x31BDFA0
	public void Push(ushort value) { }

	// RVA: 0x31B3C40 Offset: 0x31B3D41 VA: 0x31B3C40
	public object Pop() { }

	// RVA: 0x31BE070 Offset: 0x31BE171 VA: 0x31BE070
	internal void SetStackDepth(int depth) { }

	// RVA: 0x31BE090 Offset: 0x31BE191 VA: 0x31BE090
	public object Peek() { }

	// RVA: 0x31BE0D0 Offset: 0x31BE1D1 VA: 0x31BE0D0
	public void Dup() { }

	// RVA: 0x31BE170 Offset: 0x31BE271 VA: 0x31BE170
	public InterpretedFrame get_Parent() { }

	[IteratorStateMachineAttribute] // RVA: 0x420B0 Offset: 0x421B1 VA: 0x420B0
	// RVA: 0x31BE180 Offset: 0x31BE281 VA: 0x31BE180
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x31BE200 Offset: 0x31BE301 VA: 0x31BE200
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x31BE4A0 Offset: 0x31BE5A1 VA: 0x31BE4A0
	internal InterpretedFrame Enter() { }

	// RVA: 0x31BE520 Offset: 0x31BE621 VA: 0x31BE520
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x31BE580 Offset: 0x31BE681 VA: 0x31BE580
	internal bool IsJumpHappened() { }

	// RVA: 0x31BE590 Offset: 0x31BE691 VA: 0x31BE590
	public void RemoveContinuation() { }

	// RVA: 0x31BE5A0 Offset: 0x31BE6A1 VA: 0x31BE5A0
	public void PushContinuation(int continuation) { }

	// RVA: 0x31BE5E0 Offset: 0x31BE6E1 VA: 0x31BE5E0
	public int YieldToCurrentContinuation() { }

	// RVA: 0x31BE650 Offset: 0x31BE751 VA: 0x31BE650
	public int YieldToPendingContinuation() { }

	// RVA: 0x31BE820 Offset: 0x31BE921 VA: 0x31BE820
	internal void PushPendingContinuation() { }

	// RVA: 0x31BE8C0 Offset: 0x31BE9C1 VA: 0x31BE8C0
	internal void PopPendingContinuation() { }

	// RVA: 0x31B4260 Offset: 0x31B4361 VA: 0x31B4260
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}

