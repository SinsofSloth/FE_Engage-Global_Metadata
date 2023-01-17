// Namespace: 
public enum Mess.TagGroup // TypeDefIndex: 13847
{
	// Fields
	public int value__; // 0x0
	public const Mess.TagGroup System = 0;
	public const Mess.TagGroup Arg = 1;
	public const Mess.TagGroup TalkType = 2;
	public const Mess.TagGroup Window = 3;
	public const Mess.TagGroup Wait = 4;
	public const Mess.TagGroup Expression = 5;
	public const Mess.TagGroup Name = 6;
	public const Mess.TagGroup Fade = 7;
	public const Mess.TagGroup Icon = 8;
	public const Mess.TagGroup Text = 9;
	public const Mess.TagGroup Localize = 10;
	public const Mess.TagGroup Picture = 11;
}

// Namespace: 
public enum Mess.TagID_Arg // TypeDefIndex: 13848
{
	// Fields
	public int value__; // 0x0
	public const Mess.TagID_Arg Arg0 = 0;
	public const Mess.TagID_Arg Arg1 = 1;
	public const Mess.TagID_Arg Arg2 = 2;
	public const Mess.TagID_Arg Arg3 = 3;
	public const Mess.TagID_Arg Arg4 = 4;
	public const Mess.TagID_Arg Arg5 = 5;
	public const Mess.TagID_Arg Arg6 = 6;
	public const Mess.TagID_Arg Arg7 = 7;
	public const Mess.TagID_Arg ArgB = 8;
	public const Mess.TagID_Arg ArgBs = 9;
	public const Mess.TagID_Arg ArgB_UNCAP = 10;
	public const Mess.TagID_Arg ArgBs_UNCAP = 11;
	public const Mess.TagID_Arg ArgMax = 8;
}

// Namespace: 
public enum Mess.TagID_Name // TypeDefIndex: 13849
{
	// Fields
	public int value__; // 0x0
	public const Mess.TagID_Name Replace = 0;
	public const Mess.TagID_Name Publish = 1;
	public const Mess.TagID_Name Private = 2;
	public const Mess.TagID_Name User = 3;
	public const Mess.TagID_Name Partner = 4;
	public const Mess.TagID_Name Mascot = 5;
}

// Namespace: 
public enum Mess.TagID_Text // TypeDefIndex: 13850
{
	// Fields
	public int value__; // 0x0
	public const Mess.TagID_Text Space = 0;
}

// Namespace: 
public enum Mess.TagID_Localize // TypeDefIndex: 13851
{
	// Fields
	public int value__; // 0x0
	public const Mess.TagID_Localize MFTag = 0;
	public const Mess.TagID_Localize UNCAP = 1;
	public const Mess.TagID_Localize CNthird = 2;
	public const Mess.TagID_Localize TWthird = 3;
	public const Mess.TagID_Localize KRppn01 = 4;
	public const Mess.TagID_Localize KRppn02 = 5;
}

// Namespace: 
public enum Mess.TagID_Picture // TypeDefIndex: 13852
{
	// Fields
	public int value__; // 0x0
	public const Mess.TagID_Picture Show = 0;
	public const Mess.TagID_Picture Hide = 1;
}

// Namespace: 
public struct Mess.LanguageScope : IDisposable // TypeDefIndex: 13853
{
	// Fields
	private int m_Count; // 0x0
	private string m_Name; // 0x8
	private Language.Langs m_Lang; // 0x10

	// Methods

	// RVA: 0x21530A0 Offset: 0x21531A1 VA: 0x21530A0
	public void .ctor(string name, Language.Langs lang) { }

	// RVA: 0x2153370 Offset: 0x2153471 VA: 0x2153370 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private class Mess.ReloadFileInfo // TypeDefIndex: 13854
{
	// Fields
	public string m_fileName; // 0x10
	public int m_refCount; // 0x18

	// Methods

	// RVA: 0x21534B0 Offset: 0x21535B1 VA: 0x21534B0
	public void .ctor(string fileName, int refCount) { }
}

// Namespace: 
public struct Mess.ArgScope : IDisposable // TypeDefIndex: 13855
{
	// Fields
	private string[] current; // 0x0

	// Methods

	// RVA: 0x2152F10 Offset: 0x2153011 VA: 0x2152F10
	public void .ctor(int dummy) { }

	// RVA: 0x2152FD0 Offset: 0x21530D1 VA: 0x2152FD0 Slot: 4
	public void Dispose() { }
}

// Namespace: 
public enum Mess.IconCategory // TypeDefIndex: 13856
{
	// Fields
	public int value__; // 0x0
	public const Mess.IconCategory Item = 0;
	public const Mess.IconCategory Skill = 1;
	public const Mess.IconCategory System = 2;
	public const Mess.IconCategory GodSymbolEngrave = 3;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2792E0 Offset: 0x2793E1 VA: 0x2792E0
private sealed class Mess.<>c__DisplayClass49_0 // TypeDefIndex: 13857
{
	// Fields
	public string spriteAssetName; // 0x10
	public ResourceHandle handle; // 0x18

	// Methods

	// RVA: 0x2152E20 Offset: 0x2152F21 VA: 0x2152E20
	public void .ctor() { }

	// RVA: 0x2152E30 Offset: 0x2152F31 VA: 0x2152E30
	internal void <LoadSpriteAsset>b__0(TMP_SpriteAsset spriteAsset) { }
}

