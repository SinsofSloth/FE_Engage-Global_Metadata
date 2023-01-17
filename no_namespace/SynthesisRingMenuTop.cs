// Namespace: 
public sealed class SynthesisRingMenuTop.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11236
{
	// Methods

	// RVA: 0x2053CE0 Offset: 0x2053DE1 VA: 0x2053CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2053D00 Offset: 0x2053E01 VA: 0x2053D00 Slot: 13
	public virtual void Invoke(SynthesisRingMenuTop.Result result) { }

	// RVA: 0x2054060 Offset: 0x2054161 VA: 0x2054060 Slot: 14
	public virtual IAsyncResult BeginInvoke(SynthesisRingMenuTop.Result result, AsyncCallback callback, object object) { }

	// RVA: 0x2054090 Offset: 0x2054191 VA: 0x2054090 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class SynthesisRingMenuTop.Result // TypeDefIndex: 11237
{
	// Fields
	public string m_Rnid; // 0x10
	public int m_BaseRingCount; // 0x18
	public int m_PieceOfBondsCount; // 0x1C
	public int m_GodUnitIndex; // 0x20
	public BasicMenuSelect m_MenuSelect; // 0x28

	// Methods

	// RVA: 0x20540A0 Offset: 0x20541A1 VA: 0x20540A0
	public void .ctor(string rnid, int baseRingCount, int pieceOfBondsCount, int godUnitIndex, BasicMenuSelect menuSelect) { }
}

