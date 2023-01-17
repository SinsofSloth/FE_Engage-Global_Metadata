// Namespace: nn.os
public enum UserExceptionType // TypeDefIndex: 14529
{
	// Fields
	public uint value__; // 0x0
	public const UserExceptionType UserExceptionType_None = 0;
	public const UserExceptionType UserExceptionType_InvalidInstructionAccess = 256;
	public const UserExceptionType UserExceptionType_InvalidDataAccess = 257;
	public const UserExceptionType UserExceptionType_UnalignedInstructionAccess = 258;
	public const UserExceptionType UserExceptionType_UnalignedDataAccess = 259;
	public const UserExceptionType UserExceptionType_UndefinedInstruction = 260;
	public const UserExceptionType UserExceptionType_ExceptionalInstruction = 261;
	public const UserExceptionType UserExceptionType_MemorySystemError = 262;
	public const UserExceptionType UserExceptionType_FloatingPointException = 512;
	public const UserExceptionType UserExceptionType_InvalidSystemCall = 769;
}

