// Namespace: App
public class AccessoryShopChangeRootProc : ProcInst // TypeDefIndex: 10916
{
	// Fields
	private GameObject m_KeyHelpAllObject; // 0x70
	private Animator m_KeyHelpAllAnimator; // 0x78
	private AccessoryShopChangeRootProc.ChangeUnitToPrevEventHandler m_ChangeUnitToPrevEventHandler; // 0x80
	private AccessoryShopChangeRootProc.ChangeUnitToNextEventHandler m_ChangeUnitToNextEventHandler; // 0x88
	private AccessoryShopChangeRootProc.StartWatchingEventHandler m_StartWatchingEventHandler; // 0x90
	private AccessoryShopChangeRootProc.EndWatchingEventHandler m_EndWatchingEventHandler; // 0x98
	private AccessoryShopChangeRootProc.ShowUIEventHandler m_ShowUIEventHandler; // 0xA0
	private AccessoryShopChangeRootProc.HideUIEventHandler m_HideUIEventHandler; // 0xA8
	private bool watching; // 0xB0
	private bool visibleUI; // 0xB1

	// Methods

	// RVA: 0x2B1FFA0 Offset: 0x2B200A1 VA: 0x2B1FFA0
	public void .ctor(ProcInst super, GameObject keyHelpAllObject, Animator keyHelpAllAnimator, AccessoryShopChangeRootProc.ChangeUnitToPrevEventHandler changeUnitToPrevEventHandler, AccessoryShopChangeRootProc.ChangeUnitToNextEventHandler changeUnitToNextEventHandler, AccessoryShopChangeRootProc.StartWatchingEventHandler startWatchingEventHandler, AccessoryShopChangeRootProc.EndWatchingEventHandler endWatchingEventHandler, AccessoryShopChangeRootProc.ShowUIEventHandler showUIEventHandler, AccessoryShopChangeRootProc.HideUIEventHandler hideUIEventHandler) { }

	// RVA: 0x2B21C80 Offset: 0x2B21D81 VA: 0x2B21C80 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x2B22550 Offset: 0x2B22651 VA: 0x2B22550
	private void KeyHelpAllOpen() { }

	// RVA: 0x2B22680 Offset: 0x2B22781 VA: 0x2B22680
	private void KeyHelpAllClose() { }
}

