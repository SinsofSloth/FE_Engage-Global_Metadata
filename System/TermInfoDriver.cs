// Namespace: System
internal class TermInfoDriver : IConsoleDriver // TypeDefIndex: 395
{
	// Fields
	private static int* native_terminal_size; // 0x0
	private static int terminal_size; // 0x8
	private static readonly string[] locations; // 0x10
	private TermInfoReader reader; // 0x10
	private int cursorLeft; // 0x18
	private int cursorTop; // 0x1C
	private string title; // 0x20
	private string titleFormat; // 0x28
	private bool cursorVisible; // 0x30
	private string csrVisible; // 0x38
	private string csrInvisible; // 0x40
	private string clear; // 0x48
	private string bell; // 0x50
	private string term; // 0x58
	private StreamReader stdin; // 0x60
	private CStreamWriter stdout; // 0x68
	private int windowWidth; // 0x70
	private int windowHeight; // 0x74
	private int bufferHeight; // 0x78
	private int bufferWidth; // 0x7C
	private char[] buffer; // 0x80
	private int readpos; // 0x88
	private int writepos; // 0x8C
	private string keypadXmit; // 0x90
	private string keypadLocal; // 0x98
	private bool inited; // 0xA0
	private object initLock; // 0xA8
	private bool initKeys; // 0xB0
	private string origPair; // 0xB8
	private string origColors; // 0xC0
	private string cursorAddress; // 0xC8
	private ConsoleColor fgcolor; // 0xD0
	private string setfgcolor; // 0xD8
	private string setbgcolor; // 0xE0
	private int maxColors; // 0xE8
	private bool noGetPosition; // 0xEC
	private Hashtable keymap; // 0xF0
	private ByteMatcher rootmap; // 0xF8
	private int rl_startx; // 0x100
	private int rl_starty; // 0x104
	private byte[] control_characters; // 0x108
	private static readonly int[] _consoleColorToAnsiCode; // 0x18
	private char[] echobuf; // 0x110
	private int echon; // 0x118

	// Properties
	public bool Initialized { get; }
	public int WindowHeight { get; }
	public int WindowWidth { get; }

	// Methods

	// RVA: 0x366B130 Offset: 0x366B231 VA: 0x366B130
	private static string TryTermInfoDir(string dir, string term) { }

	// RVA: 0x366B260 Offset: 0x366B361 VA: 0x366B260
	private static string SearchTerminfo(string term) { }

	// RVA: 0x366B400 Offset: 0x366B501 VA: 0x366B400
	private void WriteConsole(string str) { }

	// RVA: 0x366B420 Offset: 0x366B521 VA: 0x366B420
	public void .ctor(string term) { }

	// RVA: 0x366B820 Offset: 0x366B921 VA: 0x366B820 Slot: 5
	public bool get_Initialized() { }

	// RVA: 0x366B830 Offset: 0x366B931 VA: 0x366B830 Slot: 6
	public void Init() { }

	// RVA: 0x366C320 Offset: 0x366C421 VA: 0x366C320
	private void IncrementX() { }

	// RVA: 0x366C440 Offset: 0x366C541 VA: 0x366C440
	public void WriteSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x366C7A0 Offset: 0x366C8A1 VA: 0x366C7A0
	public void WriteSpecialKey(char c) { }

	// RVA: 0x366C970 Offset: 0x366CA71 VA: 0x366C970
	public bool IsSpecialKey(ConsoleKeyInfo key) { }

	// RVA: 0x366CA10 Offset: 0x366CB11 VA: 0x366CA10
	public bool IsSpecialKey(char c) { }

	// RVA: 0x366C080 Offset: 0x366C181 VA: 0x366C080
	private void GetCursorPosition() { }

	// RVA: 0x366CBB0 Offset: 0x366CCB1 VA: 0x366CBB0
	private void CheckWindowDimensions() { }

	// RVA: 0x366C400 Offset: 0x366C501 VA: 0x366C400 Slot: 7
	public int get_WindowHeight() { }

	// RVA: 0x366C3C0 Offset: 0x366C4C1 VA: 0x366C3C0 Slot: 8
	public int get_WindowWidth() { }

	// RVA: 0x366CAB0 Offset: 0x366CBB1 VA: 0x366CAB0
	private void AddToBuffer(int b) { }

	// RVA: 0x366CD40 Offset: 0x366CE41 VA: 0x366CD40
	private void AdjustBuffer() { }

	// RVA: 0x366C7E0 Offset: 0x366C8E1 VA: 0x366C7E0
	private ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt) { }

	// RVA: 0x366CD60 Offset: 0x366CE61 VA: 0x366CD60
	private object GetKeyFromBuffer(bool cooked) { }

	// RVA: 0x366D040 Offset: 0x366D141 VA: 0x366D040
	private ConsoleKeyInfo ReadKeyInternal(out bool fresh) { }

	// RVA: 0x366D3D0 Offset: 0x366D4D1 VA: 0x366D3D0
	private bool InputPending() { }

	// RVA: 0x366D3F0 Offset: 0x366D4F1 VA: 0x366D3F0
	private void QueueEcho(char c) { }

	// RVA: 0x366D4F0 Offset: 0x366D5F1 VA: 0x366D4F0
	private void Echo(ConsoleKeyInfo key) { }

	// RVA: 0x366D5C0 Offset: 0x366D6C1 VA: 0x366D5C0
	private void EchoFlush() { }

	// RVA: 0x366D600 Offset: 0x366D701 VA: 0x366D600
	public int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x366DA00 Offset: 0x366DB01 VA: 0x366DA00 Slot: 4
	public ConsoleKeyInfo ReadKey(bool intercept) { }

	// RVA: 0x366DA80 Offset: 0x366DB81 VA: 0x366DA80 Slot: 9
	public string ReadLine() { }

	// RVA: 0x366DE30 Offset: 0x366DF31 VA: 0x366DE30
	public string ReadToEnd() { }

	// RVA: 0x366DA90 Offset: 0x366DB91 VA: 0x366DA90
	private string ReadUntilConditionInternal(bool haltOnNewLine) { }

	// RVA: 0x366C590 Offset: 0x366C691 VA: 0x366C590 Slot: 10
	public void SetCursorPosition(int left, int top) { }

	// RVA: 0x366DE40 Offset: 0x366DF41 VA: 0x366DE40
	private void CreateKeyMap() { }

	// RVA: 0x366D220 Offset: 0x366D321 VA: 0x366D220
	private void InitKeys() { }

	// RVA: 0x366FC40 Offset: 0x366FD41 VA: 0x366FC40
	private void AddStringMapping(TermInfoStrings s) { }

	// RVA: 0x366FC90 Offset: 0x366FD91 VA: 0x366FC90
	private static void .cctor() { }
}

