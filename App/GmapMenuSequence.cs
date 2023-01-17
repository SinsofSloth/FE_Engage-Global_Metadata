// Namespace: App
public class GmapMenuSequence : SingletonProcInst<GmapMenuSequence> // TypeDefIndex: 10305
{
	// Fields
	private Action m_OpenTopCallback; // 0x78
	private Action m_DecideCallback; // 0x80
	private Action m_CloseCallback; // 0x88

	// Methods

	// RVA: 0x28EDA50 Offset: 0x28EDB51 VA: 0x28EDA50
	private void .ctor(Action openTopCallback, Action decideCallback, Action closeCallback) { }

	// RVA: 0x28ED880 Offset: 0x28ED981 VA: 0x28ED880
	public void OpenTopCallback() { }

	// RVA: 0x28EDB20 Offset: 0x28EDC21 VA: 0x28EDB20
	public static ProcInst CreateBind(ProcInst super, Action openTopCallback, Action decideCallback, Action closeCallback) { }

	// RVA: 0x28EE750 Offset: 0x28EE851 VA: 0x28EE750 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x28EE7C0 Offset: 0x28EE8C1 VA: 0x28EE7C0
	private void Init() { }

	// RVA: 0x28EE840 Offset: 0x28EE941 VA: 0x28EE840
	private void OpenTopMenu() { }

	// RVA: 0x28EE880 Offset: 0x28EE981 VA: 0x28EE880
	private void EnterChapterDialog() { }

	// RVA: 0x28EE970 Offset: 0x28EEA71 VA: 0x28EE970
	private void Final() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD8D0 Offset: 0x2BD9D1 VA: 0x2BD8D0
	// RVA: 0x28EE9F0 Offset: 0x28EEAF1 VA: 0x28EE9F0
	private void <EnterChapterDialog>b__10_0() { }
}

