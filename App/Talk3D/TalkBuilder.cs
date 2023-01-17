// Namespace: App.Talk3D
public class TalkBuilder // TypeDefIndex: 14111
{
	// Fields
	private const int BufSize = 256;
	private TalkPtr m_TalkPtr; // 0x10
	private IntPtr m_IntPtr; // 0x18

	// Methods

	// RVA: 0x2933670 Offset: 0x2933771 VA: 0x2933670
	public void .ctor() { }

	// RVA: 0x29337E0 Offset: 0x29338E1 VA: 0x29337E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x29336C0 Offset: 0x29337C1 VA: 0x29336C0
	public void Reset() { }

	// RVA: 0x29338C0 Offset: 0x29339C1 VA: 0x29338C0
	private void Release() { }

	// RVA: 0x2933950 Offset: 0x2933A51 VA: 0x2933950
	public void AddTalkType(Talk.TalkType type, string positionsRootName) { }

	// RVA: 0x2933A10 Offset: 0x2933B11 VA: 0x2933A10
	public void AddKeyWait() { }

	// RVA: 0x2933A70 Offset: 0x2933B71 VA: 0x2933A70
	public void AddKeyNextPage() { }

	// RVA: 0x2933AD0 Offset: 0x2933BD1 VA: 0x2933AD0
	public void AddKeyWaitAndNextPage() { }

	// RVA: 0x2933B60 Offset: 0x2933C61 VA: 0x2933B60
	public void AddWindowMake(string pid, string location) { }

	// RVA: 0x2933C20 Offset: 0x2933D21 VA: 0x2933C20
	public void AddWindowDelete(string pid) { }

	// RVA: 0x2933CB0 Offset: 0x2933DB1 VA: 0x2933CB0
	public void AddWindowActive(string pid) { }

	// RVA: 0x2933D40 Offset: 0x2933E41 VA: 0x2933D40
	public void AddString(string str) { }

	// RVA: 0x2933D50 Offset: 0x2933E51 VA: 0x2933D50
	public void Terminate() { }

	// RVA: 0x2933D60 Offset: 0x2933E61 VA: 0x2933D60
	public IntPtr GetPtr() { }
}

