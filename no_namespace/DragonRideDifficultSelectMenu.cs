// Namespace: 
public enum DragonRideDifficultSelectMenu.Result2 // TypeDefIndex: 10501
{
	// Fields
	public int value__; // 0x0
	public const DragonRideDifficultSelectMenu.Result2 Cancel = 0;
	public const DragonRideDifficultSelectMenu.Result2 Normal = 1;
	public const DragonRideDifficultSelectMenu.Result2 Hard = 2;
	public const DragonRideDifficultSelectMenu.Result2 Expert = 3;
}

// Namespace: 
public sealed class DragonRideDifficultSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10502
{
	// Methods

	// RVA: 0x1F00000 Offset: 0x1F00101 VA: 0x1F00000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F00020 Offset: 0x1F00121 VA: 0x1F00020 Slot: 13
	public virtual void Invoke(DragonRideDifficultSelectMenu.Result2 result) { }

	// RVA: 0x1F00280 Offset: 0x1F00381 VA: 0x1F00280 Slot: 14
	public virtual IAsyncResult BeginInvoke(DragonRideDifficultSelectMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F00310 Offset: 0x1F00411 VA: 0x1F00310 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class DragonRideDifficultSelectMenu.DifficultyItem : BasicMenuItem // TypeDefIndex: 10503
{
	// Fields
	private string m_DifficultID; // 0x68
	private bool m_IsEnable; // 0x70
	private bool m_IsExpert; // 0x71

	// Methods

	// RVA: 0x1F00320 Offset: 0x1F00421 VA: 0x1F00320
	public void .ctor(string difficultID, bool enable, bool isExpert = False) { }

	// RVA: 0x1F003C0 Offset: 0x1F004C1 VA: 0x1F003C0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F00490 Offset: 0x1F00591 VA: 0x1F00490 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x276C50 Offset: 0x276D51 VA: 0x276C50
private struct DragonRideDifficultSelectMenu.<>c__DisplayClass10_0 // TypeDefIndex: 10504
{
	// Fields
	public string[] RankStr; // 0x0
}

