// Namespace: 
public sealed class CharacterFactoryAsync.onLoad : MulticastDelegate // TypeDefIndex: 14115
{
	// Methods

	// RVA: 0x1E00A20 Offset: 0x1E00B21 VA: 0x1E00A20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E00A40 Offset: 0x1E00B41 VA: 0x1E00A40 Slot: 13
	public virtual void Invoke(Character chara) { }

	// RVA: 0x1E00DA0 Offset: 0x1E00EA1 VA: 0x1E00DA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Character chara, AsyncCallback callback, object object) { }

	// RVA: 0x1E00DD0 Offset: 0x1E00ED1 VA: 0x1E00DD0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private struct CharacterFactoryAsync.UnitStatusScope : IDisposable // TypeDefIndex: 14116
{
	// Fields
	private Unit m_Unit; // 0x0
	private long m_Value; // 0x8

	// Methods

	// RVA: 0x1E009D0 Offset: 0x1E00AD1 VA: 0x1E009D0
	public void .ctor(Unit unit) { }

	// RVA: 0x1E00A10 Offset: 0x1E00B11 VA: 0x1E00A10 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279770 Offset: 0x279871 VA: 0x279770
private sealed class CharacterFactoryAsync.<>c__DisplayClass11_0 // TypeDefIndex: 14117
{
	// Fields
	public GameObject locator; // 0x10
	public bool isEngage; // 0x18
	public Character chara; // 0x20

	// Methods

	// RVA: 0x1E00870 Offset: 0x1E00971 VA: 0x1E00870
	public void .ctor() { }

	// RVA: 0x1E00880 Offset: 0x1E00981 VA: 0x1E00880
	internal void <CreateCommon>b__0() { }
}

