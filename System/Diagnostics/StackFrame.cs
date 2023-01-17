// Namespace: System.Diagnostics
[ComVisibleAttribute] // RVA: 0x477D10 Offset: 0x477E11 VA: 0x477D10
[MonoTODOAttribute] // RVA: 0x477D10 Offset: 0x477E11 VA: 0x477D10
[Serializable]
public class StackFrame // TypeDefIndex: 1453
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x38300B0 Offset: 0x38301B1 VA: 0x38300B0
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x38300C0 Offset: 0x38301C1 VA: 0x38300C0
	public void .ctor() { }

	// RVA: 0x3830120 Offset: 0x3830221 VA: 0x3830120
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x3830190 Offset: 0x3830291 VA: 0x3830190 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x38301A0 Offset: 0x38302A1 VA: 0x38301A0 Slot: 5
	public virtual string GetFileName() { }

	// RVA: 0x38301B0 Offset: 0x38302B1 VA: 0x38301B0
	internal string GetSecureFileName() { }

	// RVA: 0x3830290 Offset: 0x3830391 VA: 0x3830290 Slot: 6
	public virtual int GetILOffset() { }

	// RVA: 0x38302A0 Offset: 0x38303A1 VA: 0x38302A0 Slot: 7
	public virtual MethodBase GetMethod() { }

	// RVA: 0x38302B0 Offset: 0x38303B1 VA: 0x38302B0 Slot: 8
	public virtual int GetNativeOffset() { }

	// RVA: 0x38302C0 Offset: 0x38303C1 VA: 0x38302C0
	internal long GetMethodAddress() { }

	// RVA: 0x38302D0 Offset: 0x38303D1 VA: 0x38302D0
	internal uint GetMethodIndex() { }

	// RVA: 0x38302E0 Offset: 0x38303E1 VA: 0x38302E0
	internal string GetInternalMethodName() { }

	// RVA: 0x38302F0 Offset: 0x38303F1 VA: 0x38302F0 Slot: 3
	public override string ToString() { }
}

