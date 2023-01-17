// Namespace: System.Text.RegularExpressions
[EditorBrowsableAttribute] // RVA: 0x2FD10 Offset: 0x2FE11 VA: 0x2FD10
public abstract class RegexRunner // TypeDefIndex: 2273
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int timeout; // 0x70
	private bool ignoreTimeout; // 0x74
	private int timeoutOccursAt; // 0x78
	private int timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x2D00C20 Offset: 0x2D00D21 VA: 0x2D00C20
	protected internal void .ctor() { }

	// RVA: 0x2D00C30 Offset: 0x2D00D31 VA: 0x2D00C30
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x2D01000 Offset: 0x2D01101 VA: 0x2D01000
	private void StartTimeoutWatch() { }

	// RVA: 0x2D01050 Offset: 0x2D01151 VA: 0x2D01050
	protected void CheckTimeout() { }

	// RVA: 0x2D01320 Offset: 0x2D01421 VA: 0x2D01320
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x2D01080 Offset: 0x2D01181 VA: 0x2D01080
	private void InitMatch() { }

	// RVA: 0x2D012B0 Offset: 0x2D013B1 VA: 0x2D012B0
	private Match TidyMatch(bool quick) { }

	// RVA: 0x2D01400 Offset: 0x2D01501 VA: 0x2D01400
	protected void EnsureStorage() { }

	// RVA: 0x2D016A0 Offset: 0x2D017A1 VA: 0x2D016A0
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x2D017B0 Offset: 0x2D018B1 VA: 0x2D017B0
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x2D01600 Offset: 0x2D01701 VA: 0x2D01600
	protected void DoubleTrack() { }

	// RVA: 0x2D01560 Offset: 0x2D01661 VA: 0x2D01560
	protected void DoubleStack() { }

	// RVA: 0x2D018C0 Offset: 0x2D019C1 VA: 0x2D018C0
	protected void DoubleCrawl() { }

	// RVA: 0x2D01960 Offset: 0x2D01A61 VA: 0x2D01960
	protected void Crawl(int i) { }

	// RVA: 0x2D01A50 Offset: 0x2D01B51 VA: 0x2D01A50
	protected int Popcrawl() { }

	// RVA: 0x2D01A90 Offset: 0x2D01B91 VA: 0x2D01A90
	protected int Crawlpos() { }

	// RVA: 0x2D01AB0 Offset: 0x2D01BB1 VA: 0x2D01AB0
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x2D01B00 Offset: 0x2D01C01 VA: 0x2D01B00
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x2D01C20 Offset: 0x2D01D21 VA: 0x2D01C20
	protected void Uncapture() { }

	// RVA: 0x2D01C70 Offset: 0x2D01D71 VA: 0x2D01C70
	protected bool IsMatched(int cap) { }

	// RVA: 0x2D01C00 Offset: 0x2D01D01 VA: 0x2D01C00
	protected int MatchIndex(int cap) { }

	// RVA: 0x2D01C10 Offset: 0x2D01D11 VA: 0x2D01C10
	protected int MatchLength(int cap) { }
}

