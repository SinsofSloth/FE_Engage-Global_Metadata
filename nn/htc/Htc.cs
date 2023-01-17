// Namespace: nn.htc
public static class Htc // TypeDefIndex: 14614
{
	// Fields
	public static readonly ErrorRange ResultConnectionFailure; // 0x0
	public static readonly ErrorRange ResultNotFound; // 0xC
	public static readonly ErrorRange ResultNotEnoughBuffer; // 0x18
	public static readonly ErrorRange ResultNotImplemented; // 0x24
	public static readonly ErrorRange ResultUnknown; // 0x30

	// Methods

	// RVA: 0x2668000 Offset: 0x2668101 VA: 0x2668000
	public static void InitializeSystem() { }

	// RVA: 0x2668010 Offset: 0x2668111 VA: 0x2668010
	public static void FinalizeSystem() { }

	// RVA: 0x2668020 Offset: 0x2668121 VA: 0x2668020
	public static Result GetEnvironmentVariableLength(ref long pOutValue, string variableName) { }

	// RVA: 0x2668030 Offset: 0x2668131 VA: 0x2668030
	public static Result GetEnvironmentVariable(ref long pOutSize, byte[] outBuffer, long bufferSize, string variableName) { }

	// RVA: 0x2668040 Offset: 0x2668141 VA: 0x2668040
	private static void .cctor() { }
}

