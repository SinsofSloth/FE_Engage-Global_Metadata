// Namespace: 
public enum MiniMapController.Mode // TypeDefIndex: 12346
{
	// Fields
	public int value__; // 0x0
	public const MiniMapController.Mode Hide = 0;
	public const MiniMapController.Mode Show = 1;
	public const MiniMapController.Mode Menu = 2;
}

// Namespace: 
public enum MiniMapController.Alignment // TypeDefIndex: 12347
{
	// Fields
	public int value__; // 0x0
	public const MiniMapController.Alignment LeftUp = 0;
	public const MiniMapController.Alignment LeftCenter = 1;
	public const MiniMapController.Alignment LeftBottom = 2;
	public const MiniMapController.Alignment CenterUp = 3;
	public const MiniMapController.Alignment Center = 4;
	public const MiniMapController.Alignment CenterBottom = 5;
	public const MiniMapController.Alignment RightUp = 6;
	public const MiniMapController.Alignment RightCenter = 7;
	public const MiniMapController.Alignment RightBottom = 8;
}

// Namespace: 
private enum MiniMapController.DisplayPosSize // TypeDefIndex: 12348
{
	// Fields
	public int value__; // 0x0
	public const MiniMapController.DisplayPosSize Small = 0;
	public const MiniMapController.DisplayPosSize Large = 1;
	public const MiniMapController.DisplayPosSize Menu = 2;
	public const MiniMapController.DisplayPosSize None = 3;
}

// Namespace: 
private class MiniMapController.TImage<T> // TypeDefIndex: 12349
{
	// Fields
	public T image; // 0x0
	public GameObject gameObject; // 0x0
	public RectTransform transform; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T image) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B35D0 Offset: 0x34B36D1 VA: 0x34B35D0
	|-MiniMapController.TImage<Image>..ctor
	|-MiniMapController.TImage<object>..ctor
	|-MiniMapController.TImage<UnitIcon>..ctor
	*/
}

// Namespace: 
private enum MiniMapController.IconIndex // TypeDefIndex: 12350
{
	// Fields
	public int value__; // 0x0
	public const MiniMapController.IconIndex NormalUnit = 0;
	public const MiniMapController.IconIndex BossUnit = 1;
	public const MiniMapController.IconIndex Tbox = 2;
	public const MiniMapController.IconIndex Door = 3;
	public const MiniMapController.IconIndex Torch = 4;
	public const MiniMapController.IconIndex TorchOff = 5;
	public const MiniMapController.IconIndex Visit = 6;
	public const MiniMapController.IconIndex Escape = 7;
	public const MiniMapController.IconIndex Destroy = 8;
	public const MiniMapController.IconIndex BreakdownEnemy = 9;
	public const MiniMapController.IconIndex Cannon = 10;
	public const MiniMapController.IconIndex Crystal = 11;
	public const MiniMapController.IconIndex DragonStone = 12;
	public const MiniMapController.IconIndex Ring = 13;
	public const MiniMapController.IconIndex Num = 14;
	public const MiniMapController.IconIndex Invalid = 15;
}

// Namespace: 
private enum MiniMapController.FadeMode // TypeDefIndex: 12351
{
	// Fields
	public int value__; // 0x0
	public const MiniMapController.FadeMode None = 0;
	public const MiniMapController.FadeMode FadeIn = 1;
	public const MiniMapController.FadeMode FadeOut = 2;
}

