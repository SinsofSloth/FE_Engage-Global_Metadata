// Namespace: 
public enum Matchmake.MatchmakeGeoIpResult // TypeDefIndex: 14956
{
	// Fields
	public int value__; // 0x0
	public const Matchmake.MatchmakeGeoIpResult MATCHMAKE_GEO_IP_RESULT_INVALID = 0;
	public const Matchmake.MatchmakeGeoIpResult MATCHMAKE_GEO_IP_RESULT_FOUND = 1;
	public const Matchmake.MatchmakeGeoIpResult MATCHMAKE_GEO_IP_RESULT_NOT_FOUND = 2;
	public const Matchmake.MatchmakeGeoIpResult MATCHMAKE_GEO_IP_RESULT_UNUSED = 3;
}

// Namespace: 
public enum Matchmake.MatchmakeSelectionMethod // TypeDefIndex: 14958
{
	// Fields
	public int value__; // 0x0
	public const Matchmake.MatchmakeSelectionMethod MATCHMAKE_SELECTION_METHOD_RANDOM = 0;
	public const Matchmake.MatchmakeSelectionMethod MATCHMAKE_SELECTION_METHOD_NEAREST_NEIGHBOR = 1;
	public const Matchmake.MatchmakeSelectionMethod MATCHMAKE_SELECTION_METHOD_BROADEN_RANGE = 2;
	public const Matchmake.MatchmakeSelectionMethod MATCHMAKE_SELECTION_METHOD_PROGRESS_SCORE = 3;
	public const Matchmake.MatchmakeSelectionMethod MATCHMAKE_SELECTION_METHOD_BROADEN_RANGE_WITH_PROGRESS_SCORE = 4;
	public const Matchmake.MatchmakeSelectionMethod MATCHMAKE_SELECTION_METHOD_SCORE_BASED = 5;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27AD20 Offset: 0x27AE21 VA: 0x27AD20
public enum Matchmake.MatchmakeSessionOption0 // TypeDefIndex: 14960
{
	// Fields
	public long value__; // 0x0
	public const Matchmake.MatchmakeSessionOption0 MATCHMAKE_SESSION_OPTION0_NONE = 0;
	public const Matchmake.MatchmakeSessionOption0 MATCHMAKE_SESSION_OPTION0_FORCE_AUTOMATCH_DELAY = 1;
	public const Matchmake.MatchmakeSessionOption0 MATCHMAKE_SESSION_OPTION0_FORCE_AUTOMATCH_NODELAY = 2;
}

// Namespace: 
public enum Matchmake.AutoMatchmakeOption // TypeDefIndex: 14962
{
	// Fields
	public int value__; // 0x0
	public const Matchmake.AutoMatchmakeOption AUTO_MATCHMAKE_OPTION_NONE = 0;
	public const Matchmake.AutoMatchmakeOption AUTO_MATCHMAKE_OPTION_RECORD_LAST_GID_FOR_PARTICIPATION_CHECK = 1;
	public const Matchmake.AutoMatchmakeOption AUTO_MATCHMAKE_OPTION_UNIQUE_GATHERING_BY_CODEWORD = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27AD30 Offset: 0x27AE31 VA: 0x27AD30
public enum Matchmake.FindMatchmakeSessionResultOption // TypeDefIndex: 14964
{
	// Fields
	public int value__; // 0x0
	public const Matchmake.FindMatchmakeSessionResultOption FIND_MATCHMAKESESSION_RESULT_OPTION_NONE = 0;
	public const Matchmake.FindMatchmakeSessionResultOption FIND_MATCHMAKESESSION_RESULT_OPTION_APPLICATION_BUFFER = 1;
	public const Matchmake.FindMatchmakeSessionResultOption FIND_MATCHMAKESESSION_RESULT_OPTION_MATCHMAKE_PARAM = 2;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x27AD40 Offset: 0x27AE41 VA: 0x27AD40
public enum Matchmake.MatchmakeSessionModificationFlag // TypeDefIndex: 14966
{
	// Fields
	public int value__; // 0x0
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_NONE = 0;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_ATTRIBUTES = 1;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_OPEN_PARTICIPATION = 2;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_APPLICATION_BUFFER = 4;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_PROGRESS_SCORE = 8;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_OPTION0 = 16;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_MATCHMAKE_PARAM = 32;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_MATCHMAKE_PARAM_OVERRIDE = 64;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_STARTED_TIME = 128;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_USER_PASSWORD = 256;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_GAME_MODE = 512;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_DESCRIPTION = 1024;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_MIN_PARTICIPANTS = 2048;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_MAX_PARTICIPANTS = 4096;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_MATCHMAKE_SYSTEM_TYPE = 8192;
	public const Matchmake.MatchmakeSessionModificationFlag MATCHMAKE_SESSION_MODIFICATION_FLAG_CODEWORD = 16384;
}

