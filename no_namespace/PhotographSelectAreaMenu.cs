// Namespace: 
public sealed class PhotographSelectAreaMenu.SelectHandler : MulticastDelegate // TypeDefIndex: 11491
{
	// Methods

	// RVA: 0x1F1F7D0 Offset: 0x1F1F8D1 VA: 0x1F1F7D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F1F350 Offset: 0x1F1F451 VA: 0x1F1F350 Slot: 13
	public virtual void Invoke(PhotographSpotData areaData) { }

	// RVA: 0x1F1F7F0 Offset: 0x1F1F8F1 VA: 0x1F1F7F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(PhotographSpotData areaData, AsyncCallback callback, object object) { }

	// RVA: 0x1F1F820 Offset: 0x1F1F921 VA: 0x1F1F820 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class PhotographSelectAreaMenu.MenuItem : BasicMenuItem // TypeDefIndex: 11492
{
	// Fields
	private PhotographSpotData m_AreaData; // 0x68
	private PhotographSelectAreaMenu.SelectHandler m_SelectHandler; // 0x70

	// Properties
	public PhotographSpotData AreaData { get; }

	// Methods

	// RVA: 0x1F1F290 Offset: 0x1F1F391 VA: 0x1F1F290
	public PhotographSpotData get_AreaData() { }

	// RVA: 0x1F1F240 Offset: 0x1F1F341 VA: 0x1F1F240
	public void .ctor(PhotographSpotData areaData, PhotographSelectAreaMenu.SelectHandler selectHandler) { }

	// RVA: 0x1F1F2A0 Offset: 0x1F1F3A1 VA: 0x1F1F2A0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F1F320 Offset: 0x1F1F421 VA: 0x1F1F320 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F1F6B0 Offset: 0x1F1F7B1 VA: 0x1F1F6B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F1F750 Offset: 0x1F1F851 VA: 0x1F1F750 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277930 Offset: 0x277A31 VA: 0x277930
private sealed class PhotographSelectAreaMenu.<>c__DisplayClass1_0 // TypeDefIndex: 11493
{
	// Fields
	public List<BasicMenuItem> menuItemList; // 0x10
	public PhotographSelectAreaMenu.SelectHandler selectHandler; // 0x18
	public int selectIdx; // 0x20

	// Methods

	// RVA: 0x1F1EFF0 Offset: 0x1F1F0F1 VA: 0x1F1EFF0
	public void .ctor() { }

	// RVA: 0x1F1F000 Offset: 0x1F1F101 VA: 0x1F1F000
	internal void <CreateBind>b__0(PhotographSpotData areaData) { }
}

