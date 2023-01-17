// Namespace: MoonSharp.Interpreter.Interop.LuaStateInterop
public class LuaBase // TypeDefIndex: 6147
{
	// Fields
	protected const int LUA_TNONE = -1;
	protected const int LUA_TNIL = 0;
	protected const int LUA_TBOOLEAN = 1;
	protected const int LUA_TLIGHTUSERDATA = 2;
	protected const int LUA_TNUMBER = 3;
	protected const int LUA_TSTRING = 4;
	protected const int LUA_TTABLE = 5;
	protected const int LUA_TFUNCTION = 6;
	protected const int LUA_TUSERDATA = 7;
	protected const int LUA_TTHREAD = 8;
	protected const int LUA_MULTRET = -1;
	protected const string LUA_INTFRMLEN = "l";

	// Methods

	// RVA: 0x2BAF100 Offset: 0x2BAF201 VA: 0x2BAF100
	protected static DynValue GetArgument(LuaState L, int pos) { }

	// RVA: 0x2BAF240 Offset: 0x2BAF341 VA: 0x2BAF240
	protected static DynValue ArgAsType(LuaState L, int pos, DataType type, bool allowNil = False) { }

	// RVA: 0x2BAF290 Offset: 0x2BAF391 VA: 0x2BAF290
	protected static int LuaType(LuaState L, int p) { }

	// RVA: 0x2BAF320 Offset: 0x2BAF421 VA: 0x2BAF320
	protected static string LuaLCheckLString(LuaState L, int argNum, out uint l) { }

	// RVA: 0x2BAF380 Offset: 0x2BAF481 VA: 0x2BAF380
	protected static void LuaPushInteger(LuaState L, int val) { }

	// RVA: 0x2BAF490 Offset: 0x2BAF591 VA: 0x2BAF490
	protected static int LuaToBoolean(LuaState L, int p) { }

	// RVA: 0x2BAF4B0 Offset: 0x2BAF5B1 VA: 0x2BAF4B0
	protected static string LuaToLString(LuaState luaState, int p, out uint l) { }

	// RVA: 0x2BAF510 Offset: 0x2BAF611 VA: 0x2BAF510
	protected static string LuaToString(LuaState luaState, int p) { }

	// RVA: 0x2BAF550 Offset: 0x2BAF651 VA: 0x2BAF550
	protected static void LuaLAddValue(LuaLBuffer b) { }

	// RVA: 0x2BAF660 Offset: 0x2BAF761 VA: 0x2BAF660
	protected static void LuaLAddLString(LuaLBuffer b, CharPtr s, uint p) { }

	// RVA: 0x2BAF6A0 Offset: 0x2BAF7A1 VA: 0x2BAF6A0
	protected static void LuaLAddString(LuaLBuffer b, string s) { }

	// RVA: 0x2BAF6E0 Offset: 0x2BAF7E1 VA: 0x2BAF6E0
	protected static int LuaLOptInteger(LuaState L, int pos, int def) { }

	// RVA: 0x2BAF760 Offset: 0x2BAF861 VA: 0x2BAF760
	protected static int LuaLCheckInteger(LuaState L, int pos) { }

	// RVA: 0x2BAF7C0 Offset: 0x2BAF8C1 VA: 0x2BAF7C0
	protected static void LuaLArgCheck(LuaState L, bool condition, int argNum, string message) { }

	// RVA: 0x2BAF820 Offset: 0x2BAF921 VA: 0x2BAF820
	protected static int LuaLCheckInt(LuaState L, int argNum) { }

	// RVA: 0x2BAF880 Offset: 0x2BAF981 VA: 0x2BAF880
	protected static int LuaGetTop(LuaState L) { }

	// RVA: 0x2BAF920 Offset: 0x2BAFA21 VA: 0x2BAF920
	protected static int LuaLError(LuaState luaState, string message, object[] args) { }

	// RVA: 0x2BAF980 Offset: 0x2BAFA81 VA: 0x2BAF980
	protected static void LuaLAddChar(LuaLBuffer b, char p) { }

	// RVA: 0x2BAF990 Offset: 0x2BAFA91 VA: 0x2BAF990
	protected static void LuaLBuffInit(LuaState L, LuaLBuffer b) { }

	// RVA: 0x2BAF9A0 Offset: 0x2BAFAA1 VA: 0x2BAF9A0
	protected static void LuaPushLiteral(LuaState L, string literalString) { }

	// RVA: 0x2BAFA50 Offset: 0x2BAFB51 VA: 0x2BAFA50
	protected static void LuaLPushResult(LuaLBuffer b) { }

	// RVA: 0x2BAFB10 Offset: 0x2BAFC11 VA: 0x2BAFB10
	protected static void LuaPushLString(LuaState L, CharPtr s, uint len) { }

	// RVA: 0x2BAFBE0 Offset: 0x2BAFCE1 VA: 0x2BAFBE0
	protected static void LuaLCheckStack(LuaState L, int n, string message) { }

	// RVA: 0x2BAFBF0 Offset: 0x2BAFCF1 VA: 0x2BAFBF0
	protected static string LUA_QL(string p) { }

	// RVA: 0x2BAFC50 Offset: 0x2BAFD51 VA: 0x2BAFC50
	protected static void LuaPushNil(LuaState L) { }

	// RVA: 0x2BAFD50 Offset: 0x2BAFE51 VA: 0x2BAFD50
	protected static void LuaAssert(bool p) { }

	// RVA: 0x2BAFD60 Offset: 0x2BAFE61 VA: 0x2BAFD60
	protected static string LuaLTypeName(LuaState L, int p) { }

	// RVA: 0x2BAFF60 Offset: 0x2BB0061 VA: 0x2BAFF60
	protected static int LuaIsString(LuaState L, int p) { }

	// RVA: 0x2BAFF90 Offset: 0x2BB0091 VA: 0x2BAFF90
	protected static void LuaPop(LuaState L, int p) { }

	// RVA: 0x2BAFFD0 Offset: 0x2BB00D1 VA: 0x2BAFFD0
	protected static void LuaGetTable(LuaState L, int p) { }

	// RVA: 0x2BB00A0 Offset: 0x2BB01A1 VA: 0x2BB00A0
	protected static int LuaLOptInt(LuaState L, int pos, int def) { }

	// RVA: 0x2BB0120 Offset: 0x2BB0221 VA: 0x2BB0120
	protected static CharPtr LuaLCheckString(LuaState L, int p) { }

	// RVA: 0x2BB0170 Offset: 0x2BB0271 VA: 0x2BB0170
	protected static string LuaLCheckStringStr(LuaState L, int p) { }

	// RVA: 0x2BAF7E0 Offset: 0x2BAF8E1 VA: 0x2BAF7E0
	protected static void LuaLArgError(LuaState L, int arg, string p) { }

	// RVA: 0x2BB01B0 Offset: 0x2BB02B1 VA: 0x2BB01B0
	protected static double LuaLCheckNumber(LuaState L, int pos) { }

	// RVA: 0x2BB01F0 Offset: 0x2BB02F1 VA: 0x2BB01F0
	protected static void LuaPushValue(LuaState L, int arg) { }

	// RVA: 0x2BB0250 Offset: 0x2BB0351 VA: 0x2BB0250
	protected static void LuaCall(LuaState L, int nargs, int nresults = -1) { }

	// RVA: 0x2BB0730 Offset: 0x2BB0831 VA: 0x2BB0730
	protected static int memcmp(CharPtr ptr1, CharPtr ptr2, uint size) { }

	// RVA: 0x2BB07E0 Offset: 0x2BB08E1 VA: 0x2BB07E0
	protected static int memcmp(CharPtr ptr1, CharPtr ptr2, int size) { }

	// RVA: 0x2BB0890 Offset: 0x2BB0991 VA: 0x2BB0890
	protected static CharPtr memchr(CharPtr ptr, char c, uint count) { }

	// RVA: 0x2BB0950 Offset: 0x2BB0A51 VA: 0x2BB0950
	protected static CharPtr strpbrk(CharPtr str, CharPtr charset) { }

	// RVA: 0x2BB0A80 Offset: 0x2BB0B81 VA: 0x2BB0A80
	protected static bool isalpha(char c) { }

	// RVA: 0x2BB0AF0 Offset: 0x2BB0BF1 VA: 0x2BB0AF0
	protected static bool iscntrl(char c) { }

	// RVA: 0x2BB0B60 Offset: 0x2BB0C61 VA: 0x2BB0B60
	protected static bool isdigit(char c) { }

	// RVA: 0x2BB0BD0 Offset: 0x2BB0CD1 VA: 0x2BB0BD0
	protected static bool islower(char c) { }

	// RVA: 0x2BB0C40 Offset: 0x2BB0D41 VA: 0x2BB0C40
	protected static bool ispunct(char c) { }

	// RVA: 0x2BB0CB0 Offset: 0x2BB0DB1 VA: 0x2BB0CB0
	protected static bool isspace(char c) { }

	// RVA: 0x2BB0CE0 Offset: 0x2BB0DE1 VA: 0x2BB0CE0
	protected static bool isupper(char c) { }

	// RVA: 0x2BB0D50 Offset: 0x2BB0E51 VA: 0x2BB0D50
	protected static bool isalnum(char c) { }

	// RVA: 0x2BB0DC0 Offset: 0x2BB0EC1 VA: 0x2BB0DC0
	protected static bool isxdigit(char c) { }

	// RVA: 0x2BB0E30 Offset: 0x2BB0F31 VA: 0x2BB0E30
	protected static bool isgraph(char c) { }

	// RVA: 0x2BB0EF0 Offset: 0x2BB0FF1 VA: 0x2BB0EF0
	protected static bool isalpha(int c) { }

	// RVA: 0x2BB0F60 Offset: 0x2BB1061 VA: 0x2BB0F60
	protected static bool iscntrl(int c) { }

	// RVA: 0x2BB0FD0 Offset: 0x2BB10D1 VA: 0x2BB0FD0
	protected static bool isdigit(int c) { }

	// RVA: 0x2BB1040 Offset: 0x2BB1141 VA: 0x2BB1040
	protected static bool islower(int c) { }

	// RVA: 0x2BB10B0 Offset: 0x2BB11B1 VA: 0x2BB10B0
	protected static bool ispunct(int c) { }

	// RVA: 0x2BB1140 Offset: 0x2BB1241 VA: 0x2BB1140
	protected static bool isspace(int c) { }

	// RVA: 0x2BB1170 Offset: 0x2BB1271 VA: 0x2BB1170
	protected static bool isupper(int c) { }

	// RVA: 0x2BB11E0 Offset: 0x2BB12E1 VA: 0x2BB11E0
	protected static bool isalnum(int c) { }

	// RVA: 0x2BB1250 Offset: 0x2BB1351 VA: 0x2BB1250
	protected static bool isgraph(int c) { }

	// RVA: 0x2BB1310 Offset: 0x2BB1411 VA: 0x2BB1310
	protected static char tolower(char c) { }

	// RVA: 0x2BB1380 Offset: 0x2BB1481 VA: 0x2BB1380
	protected static char toupper(char c) { }

	// RVA: 0x2BB13F0 Offset: 0x2BB14F1 VA: 0x2BB13F0
	protected static char tolower(int c) { }

	// RVA: 0x2BB1460 Offset: 0x2BB1561 VA: 0x2BB1460
	protected static char toupper(int c) { }

	// RVA: 0x2BB14D0 Offset: 0x2BB15D1 VA: 0x2BB14D0
	protected static CharPtr strchr(CharPtr str, char c) { }

	// RVA: 0x2BB15A0 Offset: 0x2BB16A1 VA: 0x2BB15A0
	protected static CharPtr strcpy(CharPtr dst, CharPtr src) { }

	// RVA: 0x2BB1650 Offset: 0x2BB1751 VA: 0x2BB1650
	protected static CharPtr strncpy(CharPtr dst, CharPtr src, int length) { }

	// RVA: 0x2BB1720 Offset: 0x2BB1821 VA: 0x2BB1720
	protected static int strlen(CharPtr str) { }

	// RVA: 0x2BB1760 Offset: 0x2BB1861 VA: 0x2BB1760
	public static void sprintf(CharPtr buffer, CharPtr str, object[] argv) { }

	// RVA: 0x2BB1880 Offset: 0x2BB1981 VA: 0x2BB1880
	public void .ctor() { }
}

