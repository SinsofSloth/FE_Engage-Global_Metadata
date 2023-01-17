// Namespace: System.Runtime.Serialization.Formatters.Binary
[FlagsAttribute] // RVA: 0x4748A0 Offset: 0x4749A1 VA: 0x4748A0
[Serializable]
internal enum MessageEnum // TypeDefIndex: 1064
{
	// Fields
	public int value__; // 0x0
	public const MessageEnum NoArgs = 1;
	public const MessageEnum ArgsInline = 2;
	public const MessageEnum ArgsIsArray = 4;
	public const MessageEnum ArgsInArray = 8;
	public const MessageEnum NoContext = 16;
	public const MessageEnum ContextInline = 32;
	public const MessageEnum ContextInArray = 64;
	public const MessageEnum MethodSignatureInArray = 128;
	public const MessageEnum PropertyInArray = 256;
	public const MessageEnum NoReturnValue = 512;
	public const MessageEnum ReturnValueVoid = 1024;
	public const MessageEnum ReturnValueInline = 2048;
	public const MessageEnum ReturnValueInArray = 4096;
	public const MessageEnum ExceptionInArray = 8192;
	public const MessageEnum GenericMethod = 32768;
}

