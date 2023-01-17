// Namespace: 
[Serializable]
public class WeaponShopBuyRoot.EquipableWeaponInfo // TypeDefIndex: 11258
{
	// Fields
	public GameObject m_Root; // 0x10
	public Image m_IconImage; // 0x18
	public TextMeshProUGUI m_LevelText; // 0x20

	// Methods

	// RVA: 0x1DBC0F0 Offset: 0x1DBC1F1 VA: 0x1DBC0F0
	public void Set(ItemData.Kinds itemKinds, WeaponLevel.Kind weaponLevel, JobData jobData) { }

	// RVA: 0x1DBC390 Offset: 0x1DBC491 VA: 0x1DBC390
	public void .ctor() { }
}

// Namespace: 
public sealed class WeaponShopBuyRoot.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 11259
{
	// Methods

	// RVA: 0x1DBC3A0 Offset: 0x1DBC4A1 VA: 0x1DBC3A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DBC3C0 Offset: 0x1DBC4C1 VA: 0x1DBC3C0 Slot: 13
	public virtual void Invoke(Unit unit) { }

	// RVA: 0x1DBC720 Offset: 0x1DBC821 VA: 0x1DBC720 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, AsyncCallback callback, object object) { }

	// RVA: 0x1DBC750 Offset: 0x1DBC851 VA: 0x1DBC750 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

