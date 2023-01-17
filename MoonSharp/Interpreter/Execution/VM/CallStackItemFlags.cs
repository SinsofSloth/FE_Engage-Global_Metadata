// Namespace: MoonSharp.Interpreter.Execution.VM
[FlagsAttribute] // RVA: 0xD9E0 Offset: 0xDAE1 VA: 0xD9E0
internal enum CallStackItemFlags // TypeDefIndex: 6188
{
	// Fields
	public int value__; // 0x0
	public const CallStackItemFlags None = 0;
	public const CallStackItemFlags EntryPoint = 1;
	public const CallStackItemFlags ResumeEntryPoint = 3;
	public const CallStackItemFlags CallEntryPoint = 5;
	public const CallStackItemFlags TailCall = 16;
	public const CallStackItemFlags MethodCall = 32;
}

