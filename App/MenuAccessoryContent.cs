// Namespace: App
public class MenuAccessoryContent : MonoBehaviour // TypeDefIndex: 11785
{
	// Fields
	protected BasicMenu m_MasterMenu; // 0x18
	protected Animator m_winAnimator; // 0x20

	// Methods

	// RVA: 0x2860840 Offset: 0x2860941 VA: 0x2860840
	public BasicMenu GetMenu() { }

	// RVA: 0x2860850 Offset: 0x2860951 VA: 0x2860850
	public void SetMenu(BasicMenu menu) { }

	// RVA: 0x2860860 Offset: 0x2860961 VA: 0x2860860 Slot: 4
	public virtual bool IsOpening() { }

	// RVA: 0x2860910 Offset: 0x2860A11 VA: 0x2860910 Slot: 5
	public virtual bool IsClosing() { }

	// RVA: 0x28609C0 Offset: 0x2860AC1 VA: 0x28609C0 Slot: 6
	public virtual bool IsClosed() { }

	// RVA: 0x2860A70 Offset: 0x2860B71 VA: 0x2860A70 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x2860AE0 Offset: 0x2860BE1 VA: 0x2860AE0 Slot: 8
	public virtual void OpenAnime() { }

	// RVA: 0x2860B50 Offset: 0x2860C51 VA: 0x2860B50 Slot: 9
	public virtual void CloseAnime() { }

	// RVA: 0x2860C30 Offset: 0x2860D31 VA: 0x2860C30 Slot: 10
	protected virtual void Update() { }

	// RVA: 0x2860D10 Offset: 0x2860E11 VA: 0x2860D10
	public void .ctor() { }
}

