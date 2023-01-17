// Namespace: 
public enum GameParam.Kind // TypeDefIndex: 9899
{
	// Fields
	public int value__; // 0x0
	public const GameParam.Kind None = 0;
	public const GameParam.Kind Value = 1;
	public const GameParam.Kind Open = 2;
	public const GameParam.Kind Close = 3;
}

// Namespace: 
public sealed class GameParam.ParamFunction : MulticastDelegate // TypeDefIndex: 9900
{
	// Methods

	// RVA: 0x22E25E0 Offset: 0x22E26E1 VA: 0x22E25E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22E2600 Offset: 0x22E2701 VA: 0x22E2600 Slot: 13
	public virtual void Invoke(GameParam param, object[] args) { }

	// RVA: 0x22E2970 Offset: 0x22E2A71 VA: 0x22E2970 Slot: 14
	public virtual IAsyncResult BeginInvoke(GameParam param, object[] args, AsyncCallback callback, object object) { }

	// RVA: 0x22E29A0 Offset: 0x22E2AA1 VA: 0x22E29A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class GameParam.Holder // TypeDefIndex: 9901
{
	// Fields
	private string m_Name; // 0x10
	private GameParam m_Param; // 0x18

	// Methods

	// RVA: 0x22E2260 Offset: 0x22E2361 VA: 0x22E2260
	public void .ctor(string name) { }

	// RVA: 0x22E22B0 Offset: 0x22E23B1 VA: 0x22E22B0
	public GameParam GetParam() { }

	// RVA: 0x22E2370 Offset: 0x22E2471 VA: 0x22E2370
	public void Clear() { }

	// RVA: 0x22E2380 Offset: 0x22E2481 VA: 0x22E2380
	public int GetInt() { }

	// RVA: 0x22E2460 Offset: 0x22E2561 VA: 0x22E2460
	public float GetFloat() { }

	// RVA: 0x22E2520 Offset: 0x22E2621 VA: 0x22E2520
	public bool GetBool() { }
}

