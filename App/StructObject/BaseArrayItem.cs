// Namespace: App.StructObject
[Serializable]
public class BaseArrayItem<T_Piece> : BaseItem // TypeDefIndex: 14277
{
	// Fields
	[SerializeField] // RVA: 0x29E450 Offset: 0x29E551 VA: 0x29E450
	private List<T_Piece> _Pieces; // 0x0

	// Properties
	public List<T_Piece> Pieces { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public List<T_Piece> get_Pieces() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6F20 Offset: 0x1DF7021 VA: 0x1DF6F20
	|-BaseArrayItem<object>.get_Pieces
	*/

	// RVA: -1 Offset: -1
	private void set_Pieces(List<T_Piece> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6F30 Offset: 0x1DF7031 VA: 0x1DF6F30
	|-BaseArrayItem<object>.set_Pieces
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override void AddPiece(object piece) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6F40 Offset: 0x1DF7041 VA: 0x1DF6F40
	|-BaseArrayItem<object>.AddPiece
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1DF6FF0 Offset: 0x1DF70F1 VA: 0x1DF6FF0
	|-BaseArrayItem<object>..ctor
	*/
}

