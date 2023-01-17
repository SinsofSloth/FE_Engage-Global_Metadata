// Namespace: 
public sealed class MuscleStartMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11276
{
	// Methods

	// RVA: 0x26DC7D0 Offset: 0x26DC8D1 VA: 0x26DC7D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x26DC7F0 Offset: 0x26DC8F1 VA: 0x26DC7F0 Slot: 13
	public virtual void Invoke(Type result) { }

	// RVA: 0x26DCA50 Offset: 0x26DCB51 VA: 0x26DCA50 Slot: 14
	public virtual IAsyncResult BeginInvoke(Type result, AsyncCallback callback, object object) { }

	// RVA: 0x26DCAE0 Offset: 0x26DCBE1 VA: 0x26DCAE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class MuscleStartMenu.MuscleStartMenuItem : BasicMenuItem // TypeDefIndex: 11277
{
	// Fields
	private TextMeshProUGUI m_TitleText; // 0x68
	private TextMeshProUGUI m_CommentText; // 0x70
	private TextMeshProUGUI m_RuleText; // 0x78
	private TextMeshProUGUI m_EffectText; // 0x80
	private string m_ID; // 0x88
	private string m_ItemName; // 0x90
	private string m_Title; // 0x98
	private string m_Comment; // 0xA0
	private string m_Rule; // 0xA8
	private string m_Effect; // 0xB0

	// Methods

	// RVA: 0x26DCAF0 Offset: 0x26DCBF1 VA: 0x26DCAF0
	public void .ctor(GameObject setMenu, string ID) { }

	// RVA: 0x26DD020 Offset: 0x26DD121 VA: 0x26DD020 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x26DD030 Offset: 0x26DD131 VA: 0x26DD030 Slot: 4
	public override string GetName() { }

	// RVA: 0x26DD040 Offset: 0x26DD141 VA: 0x26DD040 Slot: 12
	public override void OnSelect() { }
}

