// Namespace: App
public abstract class CommonRelianceTalkSequence : ProcInst // TypeDefIndex: 12975
{
	// Fields
	private string m_MessFileName; // 0x70
	private bool m_IsLoadedMessFile; // 0x78

	// Properties
	protected string MessFileName { get; }
	protected bool IsLoadedMessFile { get; }

	// Methods

	// RVA: 0x257AA10 Offset: 0x257AB11 VA: 0x257AA10
	public ProcDesc[] CreateDescs() { }

	// RVA: 0x257ACE0 Offset: 0x257ADE1 VA: 0x257ACE0
	protected void .ctor() { }

	// RVA: 0x257AD10 Offset: 0x257AE11 VA: 0x257AD10 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x257AD20 Offset: 0x257AE21 VA: 0x257AD20
	protected void Setup() { }

	// RVA: 0x257AE80 Offset: 0x257AF81 VA: 0x257AE80
	protected void Start() { }

	// RVA: 0x257AED0 Offset: 0x257AFD1 VA: 0x257AED0
	protected void Cleanup() { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract string CreateMessFileName(bool isReverse);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract string CreateMid();

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void LevelUp();

	// RVA: 0x257AF50 Offset: 0x257B051 VA: 0x257AF50
	protected string get_MessFileName() { }

	// RVA: 0x257AF60 Offset: 0x257B061 VA: 0x257AF60
	protected bool get_IsLoadedMessFile() { }
}

