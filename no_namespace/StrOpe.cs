// Namespace: 
public class StrOpe // TypeDefIndex: 7651
{
	// Fields
	private static StrOpe instance; // 0x0
	private static Thread singletonThread; // 0x8
	private StringBuilder sb; // 0x10
	private char[] chars; // 0x18

	// Properties
	public static StrOpe small { get; }
	public static StrOpe medium { get; }
	public static StrOpe large { get; }
	public static StrOpe i { get; }
	public int Capacity { get; set; }
	public int Length { get; set; }

	// Methods

	// RVA: 0x291E2C0 Offset: 0x291E3C1 VA: 0x291E2C0
	private static void .cctor() { }

	// RVA: 0x291E330 Offset: 0x291E431 VA: 0x291E330
	private void .ctor(int capacity) { }

	// RVA: 0x291E3F0 Offset: 0x291E4F1 VA: 0x291E3F0
	public static StrOpe Create(int capacity) { }

	// RVA: 0x291E460 Offset: 0x291E561 VA: 0x291E460
	public static StrOpe get_small() { }

	// RVA: 0x291E500 Offset: 0x291E601 VA: 0x291E500
	public static StrOpe get_medium() { }

	// RVA: 0x291E5A0 Offset: 0x291E6A1 VA: 0x291E5A0
	public static StrOpe get_large() { }

	// RVA: 0x291E640 Offset: 0x291E741 VA: 0x291E640
	public static StrOpe get_i() { }

	// RVA: 0x291E800 Offset: 0x291E901 VA: 0x291E800
	public void set_Capacity(int value) { }

	// RVA: 0x291E810 Offset: 0x291E911 VA: 0x291E810
	public int get_Capacity() { }

	// RVA: 0x291E820 Offset: 0x291E921 VA: 0x291E820
	public void set_Length(int value) { }

	// RVA: 0x291E830 Offset: 0x291E931 VA: 0x291E830
	public int get_Length() { }

	// RVA: 0x291E840 Offset: 0x291E941 VA: 0x291E840
	public StrOpe Remove(int startIndex, int length) { }

	// RVA: 0x291E870 Offset: 0x291E971 VA: 0x291E870
	public StrOpe Replace(string oldValue, string newValue) { }

	// RVA: 0x291E8A0 Offset: 0x291E9A1 VA: 0x291E8A0
	public StrOpe SubString(int startIndex, int length) { }

	// RVA: 0x291E920 Offset: 0x291EA21 VA: 0x291E920
	public StrOpe Append(string str, int length) { }

	// RVA: 0x291E9D0 Offset: 0x291EAD1 VA: 0x291E9D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x291E9E0 Offset: 0x291EAE1 VA: 0x291E9E0
	public void Clear() { }

	// RVA: 0x291EA50 Offset: 0x291EB51 VA: 0x291EA50
	public StrOpe ToLower() { }

	// RVA: 0x291EBA0 Offset: 0x291ECA1 VA: 0x291EBA0
	public StrOpe ToUpper() { }

	// RVA: 0x291ECF0 Offset: 0x291EDF1 VA: 0x291ECF0
	public StrOpe Trim() { }

	// RVA: 0x291EE00 Offset: 0x291EF01 VA: 0x291EE00
	public StrOpe TrimStart() { }

	// RVA: 0x291ED10 Offset: 0x291EE11 VA: 0x291ED10
	public StrOpe TrimEnd() { }

	// RVA: 0x291EEE0 Offset: 0x291EFE1 VA: 0x291EEE0
	public char[] ToChars() { }

	// RVA: 0x291EFC0 Offset: 0x291F0C1 VA: 0x291EFC0
	public static StrOpe Format(string format, object[] args) { }

	// RVA: 0x291F050 Offset: 0x291F151 VA: 0x291F050
	public static StrOpe Format(string format, object arg) { }

	// RVA: 0x291F0E0 Offset: 0x291F1E1 VA: 0x291F0E0
	public static StrOpe Format(string format, object arg0, object arg1) { }

	// RVA: 0x291F180 Offset: 0x291F281 VA: 0x291F180
	public static StrOpe Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x291F230 Offset: 0x291F331 VA: 0x291F230
	public static string op_Implicit(StrOpe t) { }

	// RVA: 0x291F240 Offset: 0x291F341 VA: 0x291F240
	public static StrOpe op_Addition(StrOpe t, bool v) { }

	// RVA: 0x291F270 Offset: 0x291F371 VA: 0x291F270
	public static StrOpe op_Addition(StrOpe t, int v) { }

	// RVA: 0x291F2A0 Offset: 0x291F3A1 VA: 0x291F2A0
	public static StrOpe op_Addition(StrOpe t, short v) { }

	// RVA: 0x291F2D0 Offset: 0x291F3D1 VA: 0x291F2D0
	public static StrOpe op_Addition(StrOpe t, byte v) { }

	// RVA: 0x291F300 Offset: 0x291F401 VA: 0x291F300
	public static StrOpe op_Addition(StrOpe t, long v) { }

	// RVA: 0x291F330 Offset: 0x291F431 VA: 0x291F330
	public static StrOpe op_Addition(StrOpe t, float v) { }

	// RVA: 0x291F360 Offset: 0x291F461 VA: 0x291F360
	public static StrOpe op_Addition(StrOpe t, double v) { }

	// RVA: 0x291F390 Offset: 0x291F491 VA: 0x291F390
	public static StrOpe op_Addition(StrOpe t, char c) { }

	// RVA: 0x291F3C0 Offset: 0x291F4C1 VA: 0x291F3C0
	public static StrOpe op_Addition(StrOpe t, char[] c) { }

	// RVA: 0x291F3F0 Offset: 0x291F4F1 VA: 0x291F3F0
	public static StrOpe op_Addition(StrOpe t, string str) { }

	// RVA: 0x291F420 Offset: 0x291F521 VA: 0x291F420
	public static StrOpe op_Addition(StrOpe t, object obj) { }

	// RVA: 0x291F450 Offset: 0x291F551 VA: 0x291F450
	public static StrOpe op_Addition(StrOpe t, StringBuilder sb) { }
}

