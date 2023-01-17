// Namespace: System.Diagnostics
[MonoTODOAttribute] // RVA: 0x477D60 Offset: 0x477E61 VA: 0x477D60
[ComVisibleAttribute] // RVA: 0x477D60 Offset: 0x477E61 VA: 0x477D60
[Serializable]
public class StackTrace // TypeDefIndex: 1455
{
	// Fields
	public const int METHODS_TO_SKIP = 0;
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x3830660 Offset: 0x3830761 VA: 0x3830660
	public void .ctor() { }

	// RVA: 0x3830860 Offset: 0x3830961 VA: 0x3830860
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x38308A0 Offset: 0x38309A1 VA: 0x38308A0
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x3830690 Offset: 0x3830791 VA: 0x3830690
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x38308E0 Offset: 0x38309E1 VA: 0x38308E0
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x38308F0 Offset: 0x38309F1 VA: 0x38308F0
	public void .ctor(Exception e) { }

	// RVA: 0x3830A00 Offset: 0x3830B01 VA: 0x3830A00
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x3830900 Offset: 0x3830A01 VA: 0x3830900
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x3830A10 Offset: 0x3830B11 VA: 0x3830A10 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x3830A30 Offset: 0x3830B31 VA: 0x3830A30 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x3830AA0 Offset: 0x3830BA1 VA: 0x3830AA0
	private static string GetAotId() { }

	// RVA: 0x3830BA0 Offset: 0x3830CA1 VA: 0x3830BA0
	private bool AddFrames(StringBuilder sb) { }

	// RVA: 0x3831160 Offset: 0x3831261 VA: 0x3831160
	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	// RVA: 0x3831610 Offset: 0x3831711 VA: 0x3831610 Slot: 3
	public override string ToString() { }

	// RVA: 0x3831740 Offset: 0x3831841 VA: 0x3831740
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

