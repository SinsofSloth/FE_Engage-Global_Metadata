// Namespace: 
public sealed class VersusViolationTypeMenu.DecideCallback : MulticastDelegate // TypeDefIndex: 13737
{
	// Methods

	// RVA: 0x1DB8CA0 Offset: 0x1DB8DA1 VA: 0x1DB8CA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DB8CC0 Offset: 0x1DB8DC1 VA: 0x1DB8CC0 Slot: 13
	public virtual void Invoke(Screening.ReportCategory category) { }

	// RVA: 0x1DB8F20 Offset: 0x1DB9021 VA: 0x1DB8F20 Slot: 14
	public virtual IAsyncResult BeginInvoke(Screening.ReportCategory category, AsyncCallback callback, object object) { }

	// RVA: 0x1DB8FB0 Offset: 0x1DB90B1 VA: 0x1DB8FB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class VersusViolationTypeMenu.VersusViolationTypeMenuItem : BasicMenuItem // TypeDefIndex: 13738
{
	// Fields
	private Screening.ReportCategory m_Category; // 0x64

	// Methods

	// RVA: 0x1DB8FC0 Offset: 0x1DB90C1 VA: 0x1DB8FC0
	public void .ctor(Screening.ReportCategory category) { }

	// RVA: 0x1DB8FF0 Offset: 0x1DB90F1 VA: 0x1DB8FF0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DB9000 Offset: 0x1DB9101 VA: 0x1DB9000
	public Screening.ReportCategory GetCategory() { }
}

