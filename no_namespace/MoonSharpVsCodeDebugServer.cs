// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF00 Offset: 0xE001 VA: 0xDF00
[Serializable]
private sealed class MoonSharpVsCodeDebugServer.<>c // TypeDefIndex: 6266
{
	// Fields
	public static readonly MoonSharpVsCodeDebugServer.<>c <>9; // 0x0
	public static Func<SourceCode, string> <>9__7_0; // 0x8
	public static Func<SourceCode, string> <>9__8_1; // 0x10
	public static Func<AsyncDebugger, int> <>9__9_0; // 0x18
	public static Func<AsyncDebugger, KeyValuePair<int, string>> <>9__9_1; // 0x20

	// Methods

	// RVA: 0x335DD20 Offset: 0x335DE21 VA: 0x335DD20
	private static void .cctor() { }

	// RVA: 0x335DD90 Offset: 0x335DE91 VA: 0x335DD90
	public void .ctor() { }

	// RVA: 0x335DDA0 Offset: 0x335DEA1 VA: 0x335DDA0
	internal string <.ctor>b__7_0(SourceCode s) { }

	// RVA: 0x335DDB0 Offset: 0x335DEB1 VA: 0x335DDB0
	internal string <AttachToScript>b__8_1(SourceCode s) { }

	// RVA: 0x335DDC0 Offset: 0x335DEC1 VA: 0x335DDC0
	internal int <GetAttachedDebuggersByIdAndName>b__9_0(AsyncDebugger d) { }

	// RVA: 0x335DDD0 Offset: 0x335DED1 VA: 0x335DDD0
	internal KeyValuePair<int, string> <GetAttachedDebuggersByIdAndName>b__9_1(AsyncDebugger d) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF10 Offset: 0xE011 VA: 0xDF10
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass8_0 // TypeDefIndex: 6267
{
	// Fields
	public Script script; // 0x10

	// Methods

	// RVA: 0x335E2A0 Offset: 0x335E3A1 VA: 0x335E2A0
	public void .ctor() { }

	// RVA: 0x335E2B0 Offset: 0x335E3B1 VA: 0x335E2B0
	internal bool <AttachToScript>b__0(AsyncDebugger d) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF20 Offset: 0xE021 VA: 0xDF20
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass12_0 // TypeDefIndex: 6268
{
	// Fields
	public Nullable<int> value; // 0x10

	// Methods

	// RVA: 0x335DE40 Offset: 0x335DF41 VA: 0x335DE40
	public void .ctor() { }

	// RVA: 0x335DE50 Offset: 0x335DF51 VA: 0x335DE50
	internal bool <set_CurrentId>b__0(AsyncDebugger d) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF30 Offset: 0xE031 VA: 0xDF30
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass15_0 // TypeDefIndex: 6269
{
	// Fields
	public Script value; // 0x10

	// Methods

	// RVA: 0x335DEC0 Offset: 0x335DFC1 VA: 0x335DEC0
	public void .ctor() { }

	// RVA: 0x335DED0 Offset: 0x335DFD1 VA: 0x335DED0
	internal bool <set_Current>b__0(AsyncDebugger d) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF40 Offset: 0xE041 VA: 0xDF40
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass16_0 // TypeDefIndex: 6270
{
	// Fields
	public Script script; // 0x10

	// Methods

	// RVA: 0x335DEF0 Offset: 0x335DFF1 VA: 0x335DEF0
	public void .ctor() { }

	// RVA: 0x335DF00 Offset: 0x335E001 VA: 0x335DF00
	internal bool <Detach>b__0(AsyncDebugger d) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF50 Offset: 0xE051 VA: 0xDF50
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass23_0 // TypeDefIndex: 6271
{
	// Fields
	public MoonSharpVsCodeDebugServer <>4__this; // 0x10
	public TcpListener serverSocket; // 0x18

	// Methods

	// RVA: 0x335DF20 Offset: 0x335E021 VA: 0x335DF20
	public void .ctor() { }

	// RVA: 0x335DF30 Offset: 0x335E031 VA: 0x335DF30
	internal void <Start>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF60 Offset: 0xE061 VA: 0xDF60
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass24_0 // TypeDefIndex: 6272
{
	// Fields
	public Socket clientSocket; // 0x10
	public string sessionId; // 0x18
	public MoonSharpVsCodeDebugServer <>4__this; // 0x20

	// Methods

	// RVA: 0x335DF40 Offset: 0x335E041 VA: 0x335DF40
	public void .ctor() { }

	// RVA: 0x335DF50 Offset: 0x335E051 VA: 0x335DF50
	internal void <ListenThread>b__0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDF70 Offset: 0xE071 VA: 0xDF70
private sealed class MoonSharpVsCodeDebugServer.<>c__DisplayClass27_0 // TypeDefIndex: 6273
{
	// Fields
	public Action threadProc; // 0x10

	// Methods

	// RVA: 0x335E280 Offset: 0x335E381 VA: 0x335E280
	public void .ctor() { }

	// RVA: 0x335E290 Offset: 0x335E391 VA: 0x335E290
	internal void <SpawnThread>b__0() { }
}

