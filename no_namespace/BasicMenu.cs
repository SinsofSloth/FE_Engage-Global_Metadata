// Namespace: 
[FlagsAttribute] // RVA: 0x2786E0 Offset: 0x2787E1 VA: 0x2786E0
public enum BasicMenu.Result // TypeDefIndex: 12509
{
	// Fields
	public int value__; // 0x0
	public const BasicMenu.Result CloseThis = 1;
	public const BasicMenu.Result CloseParent = 2;
	public const BasicMenu.Result CloseAll = 4;
	public const BasicMenu.Result DeleteThis = 8;
	public const BasicMenu.Result DeleteParent = 16;
	public const BasicMenu.Result DeleteAll = 32;
	public const BasicMenu.Result SeDecide = 128;
	public const BasicMenu.Result SeDecide2 = 256;
	public const BasicMenu.Result SeCancel = 512;
	public const BasicMenu.Result SeMiss = 2048;
	public const BasicMenu.Result SeCursor = 4096;
	public const BasicMenu.Result DoNothing = 8192;
	public const BasicMenu.Result Pass = 0;
	public const BasicMenu.Result CloseDecide = 129;
	public const BasicMenu.Result CloseParentDecide = 130;
	public const BasicMenu.Result CloseAllDecide = 132;
	public const BasicMenu.Result CloseDecide2 = 257;
	public const BasicMenu.Result CloseParentDecide2 = 258;
	public const BasicMenu.Result CloseAllDecide2 = 260;
	public const BasicMenu.Result CloseCancel = 513;
	public const BasicMenu.Result CloseParentCancel = 514;
	public const BasicMenu.Result CloseAllCancel = 516;
	public const BasicMenu.Result DeleteDecide = 136;
	public const BasicMenu.Result DeleteParentDecide = 144;
	public const BasicMenu.Result DeleteAllDecide = 160;
	public const BasicMenu.Result DeleteDecide2 = 264;
	public const BasicMenu.Result DeleteParentDecide2 = 272;
	public const BasicMenu.Result DeleteAllDecide2 = 288;
	public const BasicMenu.Result DeleteCancel = 520;
	public const BasicMenu.Result DeleteParentCancel = 528;
	public const BasicMenu.Result DeleteAllCancel = 544;
	public const BasicMenu.Result Failure = 2048;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x2786F0 Offset: 0x2787F1 VA: 0x2786F0
public enum BasicMenu.Status // TypeDefIndex: 12510
{
	// Fields
	public int value__; // 0x0
	public const BasicMenu.Status CursorHide = 2;
	public const BasicMenu.Status InputDisable = 4;
	public const BasicMenu.Status InputDisableNowFrame = 8;
	public const BasicMenu.Status BindParent = 16;
	public const BasicMenu.Status Rebuild = 32;
	public const BasicMenu.Status CursorMoved = 64;
	public const BasicMenu.Status CloseCalled = 128;
	public const BasicMenu.Status FirstBlankEnable = 256;
	public const BasicMenu.Status SidePageMove = 512;
	public const BasicMenu.Status RebuildKeepIndex = 1024;
}

// Namespace: 
public class BasicMenu.StatusField : BitFieldTemplate32<BasicMenu.Status> // TypeDefIndex: 12511
{
	// Methods

	// RVA: 0x1F718E0 Offset: 0x1F719E1 VA: 0x1F718E0 Slot: 5
	protected override int ToInt(BasicMenu.Status value) { }

	// RVA: 0x1F718F0 Offset: 0x1F719F1 VA: 0x1F718F0
	public void .ctor() { }
}

// Namespace: 
public enum BasicMenu.AnchorType // TypeDefIndex: 12512
{
	// Fields
	public int value__; // 0x0
	public const BasicMenu.AnchorType UnityEditor = 0;
	public const BasicMenu.AnchorType LeftTop = 1;
	public const BasicMenu.AnchorType CenterTop = 2;
	public const BasicMenu.AnchorType RightTop = 3;
	public const BasicMenu.AnchorType Left = 4;
	public const BasicMenu.AnchorType Center = 5;
	public const BasicMenu.AnchorType Right = 6;
	public const BasicMenu.AnchorType LeftBottom = 7;
	public const BasicMenu.AnchorType CenterBottom = 8;
	public const BasicMenu.AnchorType RightBottom = 9;
}

// Namespace: 
public enum BasicMenu.Label0 // TypeDefIndex: 12513
{
	// Fields
	public int value__; // 0x0
	public const BasicMenu.Label0 Build = 0;
	public const BasicMenu.Label0 AfterBuild = 1;
	public const BasicMenu.Label0 Opening = 2;
	public const BasicMenu.Label0 Loop = 3;
	public const BasicMenu.Label0 End = 4;
}

// Namespace: 
public enum BasicMenu.BindTypes // TypeDefIndex: 12514
{
	// Fields
	public int value__; // 0x0
	public const BasicMenu.BindTypes None = 0;
	public const BasicMenu.BindTypes Dark = 1;
	public const BasicMenu.BindTypes Hide = 2;
}

