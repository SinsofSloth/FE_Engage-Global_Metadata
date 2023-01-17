// Namespace: 
[DefaultMemberAttribute] // RVA: 0x271D90 Offset: 0x271E91 VA: 0x271D90
public class AkAuxSendArray : IDisposable // TypeDefIndex: 7962
{
	// Fields
	private const int MAX_COUNT = 4;
	private readonly int SIZE_OF_AKAUXSENDVALUE; // 0x10
	private IntPtr m_Buffer; // 0x18
	private int m_Count; // 0x20

	// Properties
	public AkAuxSendValue Item { get; }
	public bool isFull { get; }

	// Methods

	// RVA: 0x2ED0B60 Offset: 0x2ED0C61 VA: 0x2ED0B60
	public void .ctor() { }

	// RVA: 0x2ED0C20 Offset: 0x2ED0D21 VA: 0x2ED0C20
	public AkAuxSendValue get_Item(int index) { }

	// RVA: 0x2ED0D90 Offset: 0x2ED0E91 VA: 0x2ED0D90
	public bool get_isFull() { }

	// RVA: 0x2ED0E00 Offset: 0x2ED0F01 VA: 0x2ED0E00 Slot: 4
	public void Dispose() { }

	// RVA: 0x2ED0EA0 Offset: 0x2ED0FA1 VA: 0x2ED0EA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ED0F80 Offset: 0x2ED1081 VA: 0x2ED0F80
	public void Reset() { }

	// RVA: 0x2ED0F90 Offset: 0x2ED1091 VA: 0x2ED0F90
	public bool Add(GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue) { }

	// RVA: 0x2ED1110 Offset: 0x2ED1211 VA: 0x2ED1110
	public bool Add(uint in_AuxBusID, float in_fValue) { }

	// RVA: 0x2ED1240 Offset: 0x2ED1341 VA: 0x2ED1240
	public bool Contains(GameObject in_listenerGameObj, uint in_AuxBusID) { }

	// RVA: 0x2ED1390 Offset: 0x2ED1491 VA: 0x2ED1390
	public bool Contains(uint in_AuxBusID) { }

	// RVA: 0x2ED14A0 Offset: 0x2ED15A1 VA: 0x2ED14A0
	public AKRESULT SetValues(GameObject gameObject) { }

	// RVA: 0x2ED1560 Offset: 0x2ED1661 VA: 0x2ED1560
	public AKRESULT GetValues(GameObject gameObject) { }

	// RVA: 0x2ED1640 Offset: 0x2ED1741 VA: 0x2ED1640
	public IntPtr GetBuffer() { }

	// RVA: 0x2ED1650 Offset: 0x2ED1751 VA: 0x2ED1650
	public int Count() { }

	// RVA: 0x2ED0D10 Offset: 0x2ED0E11 VA: 0x2ED0D10
	private IntPtr GetObjectPtr(int index) { }
}

