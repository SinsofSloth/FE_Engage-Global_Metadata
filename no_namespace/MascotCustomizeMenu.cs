// Namespace: 
public enum MascotCustomizeMenu.MenuResult // TypeDefIndex: 10865
{
	// Fields
	public int value__; // 0x0
	public const MascotCustomizeMenu.MenuResult Parts = 0;
	public const MascotCustomizeMenu.MenuResult Color = 1;
	public const MascotCustomizeMenu.MenuResult End = 2;
}

// Namespace: 
public sealed class MascotCustomizeMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10866
{
	// Methods

	// RVA: 0x2150750 Offset: 0x2150851 VA: 0x2150750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21504E0 Offset: 0x21505E1 VA: 0x21504E0 Slot: 13
	public virtual void Invoke(MascotCustomizeMenu.MenuResult result) { }

	// RVA: 0x2150770 Offset: 0x2150871 VA: 0x2150770 Slot: 14
	public virtual IAsyncResult BeginInvoke(MascotCustomizeMenu.MenuResult result, AsyncCallback callback, object object) { }

	// RVA: 0x2150800 Offset: 0x2150901 VA: 0x2150800 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class MascotCustomizeMenu.PartsMenuItem : BasicMenuItem // TypeDefIndex: 10867
{
	// Fields
	private MascotCustomizeMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x2150810 Offset: 0x2150911 VA: 0x2150810
	public void .ctor(MascotCustomizeMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x2150850 Offset: 0x2150951 VA: 0x2150850 Slot: 4
	public override string GetName() { }

	// RVA: 0x21508D0 Offset: 0x21509D1 VA: 0x21508D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21508E0 Offset: 0x21509E1 VA: 0x21508E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2150A60 Offset: 0x2150B61 VA: 0x2150A60 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MascotCustomizeMenu.ColorMenuItem : BasicMenuItem // TypeDefIndex: 10868
{
	// Fields
	private MascotCustomizeMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x2150290 Offset: 0x2150391 VA: 0x2150290
	public void .ctor(MascotCustomizeMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x21502D0 Offset: 0x21503D1 VA: 0x21502D0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2150350 Offset: 0x2150451 VA: 0x2150350 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2150360 Offset: 0x2150461 VA: 0x2150360 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2150740 Offset: 0x2150841 VA: 0x2150740 Slot: 19
	public override BasicMenu.Result BCall() { }
}

