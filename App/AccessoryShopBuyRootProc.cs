// Namespace: App
public class AccessoryShopBuyRootProc : ProcInst // TypeDefIndex: 10902
{
	// Fields
	private GameObject m_KeyHelpAllObject; // 0x70
	private Animator m_KeyHelpAllAnimator; // 0x78
	private AccessoryShopBuyRootProc.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0x80
	private AccessoryShopBuyRootProc.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0x88
	private AccessoryShopBuyRootProc.StartWatchingEventHandler m_StartWatchingEventHandler; // 0x90
	private AccessoryShopBuyRootProc.EndWatchingEventHandler m_EndWatchingEventHandler; // 0x98
	private AccessoryShopBuyRootProc.ShowUIEventHandler m_ShowUIEventHandler; // 0xA0
	private AccessoryShopBuyRootProc.HideUIEventHandler m_HideUIEventHandler; // 0xA8
	private bool watching; // 0xB0
	private bool visibleUI; // 0xB1

	// Methods

	// RVA: 0x2B1B600 Offset: 0x2B1B701 VA: 0x2B1B600
	public void .ctor(ProcInst super, GameObject keyHelpAllObject, Animator keyHelpAllAnimator, AccessoryShopBuyRootProc.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, AccessoryShopBuyRootProc.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, AccessoryShopBuyRootProc.StartWatchingEventHandler startWatchingEventHandler, AccessoryShopBuyRootProc.EndWatchingEventHandler endWatchingEventHandler, AccessoryShopBuyRootProc.ShowUIEventHandler showUIEventHandler, AccessoryShopBuyRootProc.HideUIEventHandler hideUIEventHandler) { }

	// RVA: 0x2B1CA30 Offset: 0x2B1CB31 VA: 0x2B1CA30 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x2B1D300 Offset: 0x2B1D401 VA: 0x2B1D300
	private void KeyHelpAllOpen() { }

	// RVA: 0x2B1D430 Offset: 0x2B1D531 VA: 0x2B1D430
	private void KeyHelpAllClose() { }
}

