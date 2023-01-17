// Namespace: MoonSharp.Interpreter.Execution.VM
internal enum OpCode // TypeDefIndex: 6192
{
	// Fields
	public int value__; // 0x0
	public const OpCode Nop = 0;
	public const OpCode Debug = 1;
	public const OpCode Pop = 2;
	public const OpCode Copy = 3;
	public const OpCode Swap = 4;
	public const OpCode Literal = 5;
	public const OpCode Closure = 6;
	public const OpCode NewTable = 7;
	public const OpCode TblInitN = 8;
	public const OpCode TblInitI = 9;
	public const OpCode StoreLcl = 10;
	public const OpCode Local = 11;
	public const OpCode StoreUpv = 12;
	public const OpCode Upvalue = 13;
	public const OpCode IndexSet = 14;
	public const OpCode Index = 15;
	public const OpCode IndexSetN = 16;
	public const OpCode IndexN = 17;
	public const OpCode IndexSetL = 18;
	public const OpCode IndexL = 19;
	public const OpCode Clean = 20;
	public const OpCode Meta = 21;
	public const OpCode BeginFn = 22;
	public const OpCode Args = 23;
	public const OpCode Call = 24;
	public const OpCode ThisCall = 25;
	public const OpCode Ret = 26;
	public const OpCode Jump = 27;
	public const OpCode Jf = 28;
	public const OpCode JNil = 29;
	public const OpCode JFor = 30;
	public const OpCode JtOrPop = 31;
	public const OpCode JfOrPop = 32;
	public const OpCode Concat = 33;
	public const OpCode LessEq = 34;
	public const OpCode Less = 35;
	public const OpCode Eq = 36;
	public const OpCode Add = 37;
	public const OpCode Sub = 38;
	public const OpCode Mul = 39;
	public const OpCode Div = 40;
	public const OpCode Mod = 41;
	public const OpCode Not = 42;
	public const OpCode Len = 43;
	public const OpCode Neg = 44;
	public const OpCode Power = 45;
	public const OpCode CNot = 46;
	public const OpCode MkTuple = 47;
	public const OpCode Scalar = 48;
	public const OpCode Incr = 49;
	public const OpCode ToNum = 50;
	public const OpCode ToBool = 51;
	public const OpCode ExpTuple = 52;
	public const OpCode IterPrep = 53;
	public const OpCode IterUpd = 54;
	public const OpCode Invalid = 55;
}

