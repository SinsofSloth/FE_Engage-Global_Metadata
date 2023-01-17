// Namespace: App
public class BasicDialog : BasicMenu // TypeDefIndex: 12498
{
	// Fields
	protected BasicDialogContent m_dialogContent; // 0xC8
	private bool m_bBindBg; // 0xD0
	private bool m_IsNotBindBg; // 0xD1

	// Methods

	// RVA: 0x28F0530 Offset: 0x28F0631 VA: 0x28F0530
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent) { }

	// RVA: 0x28F0760 Offset: 0x28F0861 VA: 0x28F0760 Slot: 18
	public override ProcDesc[] CreateDefaultDesc() { }

	// RVA: 0x28F0C50 Offset: 0x28F0D51 VA: 0x28F0C50
	private void BindBg() { }

	// RVA: 0x28F0CE0 Offset: 0x28F0DE1 VA: 0x28F0CE0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x28F0DE0 Offset: 0x28F0EE1 VA: 0x28F0DE0 Slot: 64
	protected virtual string GetOpenSoundEvent() { }

	// RVA: 0x28F0E30 Offset: 0x28F0F31 VA: 0x28F0E30 Slot: 26
	public override void OnClose() { }

	// RVA: 0x28F0F00 Offset: 0x28F1001 VA: 0x28F0F00
	public void SetText(string text) { }

	// RVA: 0x28F0FE0 Offset: 0x28F10E1 VA: 0x28F0FE0
	public void SetShadowOff() { }

	// RVA: 0x28F1120 Offset: 0x28F1221 VA: 0x28F1120
	public void SetPos(float x, float y) { }

	// RVA: 0x28F1280 Offset: 0x28F1381 VA: 0x28F1280
	public void SetBackgroundBlurOff() { }

	// RVA: 0x28F1290 Offset: 0x28F1391 VA: 0x28F1290
	public static BasicDialog CreateBasicDialogBind(ProcInst super, List<BasicMenuItem> menuItemList) { }
}

