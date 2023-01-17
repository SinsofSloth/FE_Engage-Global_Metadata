// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52B90 Offset: 0x52C91 VA: 0x52B90
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 4165
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativePropertyAttribute] // RVA: 0x544B0 Offset: 0x545B1 VA: 0x544B0
	public Color textColor { set; }

	// Methods

	// RVA: 0x3C85700 Offset: 0x3C85801 VA: 0x3C85700
	public void set_textColor(Color value) { }

	[FreeFunctionAttribute] // RVA: 0x53AA0 Offset: 0x53BA1 VA: 0x53AA0
	// RVA: 0x3C86DC0 Offset: 0x3C86EC1 VA: 0x3C86DC0
	private static IntPtr Init() { }

	[FreeFunctionAttribute] // RVA: 0x53AF0 Offset: 0x53BF1 VA: 0x53AF0
	// RVA: 0x3C86E00 Offset: 0x3C86F01 VA: 0x3C86E00
	private void Cleanup() { }

	// RVA: 0x3C86E50 Offset: 0x3C86F51 VA: 0x3C86E50
	public void .ctor() { }

	// RVA: 0x3C86EA0 Offset: 0x3C86FA1 VA: 0x3C86EA0
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x3C86830 Offset: 0x3C86931 VA: 0x3C86830
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x3C86EF0 Offset: 0x3C86FF1 VA: 0x3C86EF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3C86D70 Offset: 0x3C86E71 VA: 0x3C86D70
	private void set_textColor_Injected(ref Color value) { }
}

