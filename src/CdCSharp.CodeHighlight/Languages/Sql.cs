using CdCSharp.SyntaxHighlight.Patterns;
using System.Drawing;

namespace CdCSharp.SyntaxHighlight.Languages;

public partial class Definitions
{
    public static Definition SqlDefinition = new(
        name: "Sql",
        caseSensitive: false,
        style: new Style(
            new ColorPair(
                foreColor: Color.FromName("black"),
                backColor: Color.FromName("transparent")
            ),
            new Font(
                name: "monospace",
                size: 16f,
                style: FontStyle.Regular
            )
        ),
        patterns: new Dictionary<string, Pattern>()
    {
{
    "SysTable", new WordPattern(
            name: "SysTable",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("lawngreen"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "sysaltfiles",
                "syslockinfo",
                "syscacheobjects",
                "syslogins",
                "sysxlogins",
                "syscharsets",
                "sysmessages",
                "sysconfigures",
                "sysoledbusers",
                "syscurconfigs",
                "sysperfinfo",
                "sysdatabases",
                "sysprocesses",
                "sysdevices",
                "sysremotelogins",
                "syslanguages",
                "sysservers",
                "syscolumns",
                "sysindexkeys",
                "syscomments",
                "sysmembers",
                "sysconstraints",
                "sysremote_column_privileges",
                "sysobjects",
                "sysdepends",
                "syspermissions",
                "sysfilegroups",
                "sysprotects",
                "sysfiles",
                "sysreferences",
                "sysforeignkeys",
                "sysTypes",
                "sysfulltextcatalogs",
                "sysusers",
                "sysindexes",
                "sysalerts",
                "sysjobsteps",
                "syscategories",
                "sysnotifications",
                "sysdownloadlist",
                "sysoperators",
                "sysjobhistory",
                "systargetservergroupmembers",
                "sysjobs",
                "systargetservergroups",
                "sysjobschedules",
                "systargetservers",
                "sysjobservers",
                "systaskids",
            ]
        )
},
{
    "SysProc", new WordPattern(
            name: "SysProc",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("brown"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "sp_bindsession",
                "sp_column_privileges_ex",
                "sp_createorphan",
                "sp_cursor",
                "sp_cursorclose",
                "sp_cursorexecute",
                "sp_cursorfetch",
                "sp_cursoropen",
                "sp_cursoroption",
                "sp_cursorprepare",
                "sp_cursorprepexec",
                "sp_cursorunprepare",
                "sp_droporphans",
                "sp_execute",
                "sp_executesql",
                "sp_fulltext_getdata",
                "sp_getbindtoken",
                "sp_GetMBCSCharLen",
                "sp_getschemalock",
                "sp_IsMBCSLeadByte",
                "sp_MSgetversion",
                "sp_OACreate",
                "sp_OADestroy",
                "sp_OAGetErrorInfo",
                "sp_OAGetProperty",
                "sp_OAMethod",
                "sp_OASetProperty",
                "sp_OAStop",
                "sp_prepare",
                "sp_prepexec",
                "sp_prepexecrpc",
                "sp_refreshview",
                "sp_releaseschemalock",
                "sp_replcmds",
                "sp_replcounters",
                "sp_repldone",
                "sp_replflush",
                "sp_replincrementlsn",
                "sp_replpostcmd",
                "sp_replpostschema",
                "sp_replpostsyncstatus",
                "sp_replsendtoqueue",
                "sp_replsetoriginator",
                "sp_replsetsyncstatus",
                "sp_repltrans",
                "sp_replupdateschema",
                "sp_replwritetovarbin",
                "sp_reset_connection",
                "sp_resyncexecute",
                "sp_resyncexecutesql",
                "sp_resyncprepare",
                "sp_resyncuniquetable",
                "sp_sdidebug",
                "sp_trace_create",
                "sp_trace_generateevent",
                "sp_trace_setevent",
                "sp_trace_setfilter",
                "sp_trace_setstatus",
                "sp_unprepare",
                "sp_xml_preparedocument",
                "sp_xml_removedocument",
                "xp_adsirequest",
                "xp_availablemedia",
                "xp_cleanupwebtask",
                "xp_cmdshell",
                "xp_controlqueueservice",
                "xp_convertwebtask",
                "xp_createprivatequeue",
                "xp_createqueue",
                "xp_decodequeuecmd",
                "xp_deletemail",
                "xp_deleteprivatequeue",
                "xp_deletequeue",
                "xp_dirtree",
                "xp_displayparamstmt",
                "xp_displayqueuemesgs",
                "xp_dropwebtask",
                "xp_dsninfo",
                "xp_enum_activescriptengines",
                "xp_enum_oledb_providers",
                "xp_enumcodepages",
                "xp_enumdsn",
                "xp_enumerrorlogs",
                "xp_enumgroups",
                "xp_eventlog",
                "xp_execresultset",
                "xp_fileexist",
                "xp_findnextmsg",
                "xp_fixeddrives",
                "xp_get_mapi_default_profile",
                "xp_get_mapi_profiles",
                "xp_get_tape_devices",
                "xp_GetAdminGroupName",
                "xp_getfiledetails",
                "xp_getnetname",
                "xp_getprotocoldllinfo",
                "xp_instance_regaddmultistring",
                "xp_instance_regdeletekey",
                "xp_instance_regdeletevalue",
                "xp_instance_regenumkeys",
                "xp_instance_regenumvalues",
                "xp_instance_regread",
                "xp_instance_regremovemultistring",
                "xp_instance_regwrite",
                "xp_intersectbitmaps",
                "xp_IsNTAdmin",
                "xp_logevent",
                "xp_loginconfig",
                "xp_makecab",
                "xp_makewebtask",
                "xp_mapdown_bitmap",
                "xp_mergelineages",
                "xp_mergexpusage",
                "xp_MSADEnabled",
                "xp_MSADSIObjReg",
                "xp_MSADSIObjRegDB",
                "xp_MSADSIReg",
                "xp_MSFullText",
                "xp_MSLocalSystem",
                "xp_MSnt2000",
                "xp_MSplatform",
                "xp_msver",
                "xp_msx_enlist",
                "xp_ntsec_enumdomains",
                "xp_oledbinfo",
                "xp_ORbitmap",
                "xp_peekqueue",
                "xp_printstatements",
                "xp_prop_oledb_provider",
                "xp_proxiedmetadata",
                "xp_qv",
                "xp_readerrorlog",
                "xp_readmail",
                "xp_readpkfromqueue",
                "xp_readpkfromvarbin",
                "xp_readwebtask",
                "xp_regaddmultistring",
                "xp_regdeletekey",
                "xp_regdeletevalue",
                "xp_regenumkeys",
                "xp_regenumvalues",
                "xp_regread",
                "xp_regremovemultistring",
                "xp_regwrite",
                "xp_repl_convert_encrypt",
                "xp_repl_encrypt",
                "xp_repl_help_connect",
                "xp_replproberemsrv",
                "xp_resetqueue",
                "xp_runwebtask",
                "xp_sendmail",
                "xp_servicecontrol",
                "xp_SetSQLSecurity",
                "xp_showcolv",
                "xp_showlineage",
                "xp_sprintf",
                "xp_sqlagent_enum_jobs",
                "xp_sqlagent_is_starting",
                "xp_sqlagent_monitor",
                "xp_sqlagent_notify",
                "xp_sqlagent_param",
                "xp_sqlagent_proxy_account",
                "xp_sqlmaint",
                "xp_sscanf",
                "xp_startmail",
                "xp_stopmail",
                "xp_subdirs",
                "xp_terminate_process",
                "xp_test_mapi_profile",
                "xp_unc_to_drive",
                "xp_unpackcab",
                "xp_updateFTSSQLAccount",
                "xp_userlock",
                "xp_varbintohexstr",
            ]
        )
},
{
    "GlobalVariable", new WordPattern(
            name: "GlobalVariable",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("fuchsia"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "@@DATEFIRST",
                "@@OPTIONS",
                "@@DBTS",
                "@@REMSERVER",
                "@@LANGID",
                "@@SERVERName",
                "@@LANGUAGE",
                "@@SERVICEName",
                "@@LOCK_TIMEOUT",
                "@@SPID",
                "@@MAX_CONNECTIONS",
                "@@TEXTSIZE",
                "@@MAX_PRECISION",
                "@@VERSION",
                "@@NESTLEVEL",
                "@@CURSOR_ROWS",
                "@@FETCH_STATUS",
                "@@PROCID",
                "@@IDENTITY",
                "@@ROWCOUNT",
                "@@ERROR",
                "@@TRANCOUNT",
                "@@CONNECTIONS",
                "@@PACK_RECEIVED",
                "@@CPU_BUSY",
                "@@PACK_SENT",
                "@@TIMETICKS",
                "@@IDLE",
                "@@TOTAL_ERRORS",
                "@@IO_BUSY",
                "@@TOTAL_READ",
                "@@PACKET_ERRORS",
                "@@TOTAL_WRITE",
            ]
        )
},
{
    "ReservedKeyword", new WordPattern(
            name: "ReservedKeyword",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("blue"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "sysname",
                "ADD",
                "EXCEPT",
                "PERCENT",
                "EXEC",
                "PLAN",
                "ALTER",
                "EXECUTE",
                "PRECISION",
                "PRIMARY",
                "EXIT",
                "PRINT",
                "AS",
                "FETCH",
                "NOCOUNT",
                "PROC",
                "ASC",
                "FILE",
                "PROCEDURE",
                "AUTHORIZATION",
                "FILLFACTOR",
                "PUBLIC",
                "BACKUP",
                "FOR",
                "RAISE",
                "RAISERROR",
                "BEGIN",
                "FOREIGN",
                "READ",
                "FREETEXT",
                "READTEXT",
                "BREAK",
                "FREETEXTTABLE",
                "RECONFIGURE",
                "BROWSE",
                "FROM",
                "REFERENCES",
                "BULK",
                "FULL",
                "REPLICATION",
                "BY",
                "FUNCTION",
                "RESTORE",
                "CASCADE",
                "GOTO",
                "RESTRICT",
                "GRANT",
                "RETURN",
                "CHECK",
                "GROUP",
                "REVOKE",
                "CHECKPOINT",
                "HAVING",
                "CLOSE",
                "HOLDLOCK",
                "ROLLBACK",
                "CLUSTERED",
                "IDENTITY",
                "IDENTITY_INSERT",
                "ROWGUIDCOL",
                "COLLATE",
                "IDENTITYCOL",
                "RULE",
                "COLUMN",
                "IF",
                "SAVE",
                "COMMIT",
                "SCHEMA",
                "COMPUTE",
                "INDEX",
                "SELECT",
                "CONSTRAINT",
                "INNER",
                "CONTAINS",
                "INSERT",
                "SET",
                "CONTAINSTABLE",
                "INTERSECT",
                "SETUSER",
                "CONTINUE",
                "INTO",
                "SHUTDOWN",
                "IS",
                "CREATE",
                "STATISTICS",
                "KEY",
                "CURRENT",
                "KILL",
                "TABLE",
                "CURRENT_DATE",
                "TEXTSIZE",
                "CURRENT_TIME",
                "THEN",
                "LINENO",
                "TO",
                "LOAD",
                "TOP",
                "CURSOR",
                "NATIONAL",
                "TRAN",
                "DATABASE",
                "NOCHECK",
                "TRANSACTION",
                "DBCC",
                "NONCLUSTERED",
                "TRIGGER",
                "DEALLOCATE",
                "TRUNCATE",
                "DECLARE",
                "TSEQUAL",
                "DEFAULT",
                "UNION",
                "DELETE",
                "OF",
                "UNIQUE",
                "DENY",
                "OFF",
                "UPDATE",
                "DESC",
                "OFFSETS",
                "UPDATETEXT",
                "DISK",
                "ON",
                "USE",
                "DISTINCT",
                "OPEN",
                "DISTRIBUTED",
                "OPENDATASOURCE",
                "VALUES",
                "DOUBLE",
                "OPENQUERY",
                "VARYING",
                "DROP",
                "OPENROWSET",
                "VIEW",
                "DUMMY",
                "OPENXML",
                "WAITFOR",
                "DUMP",
                "OPTION",
                "WHEN",
                "ELSE",
                "WHERE",
                "END",
                "ORDER",
                "WHILE",
                "ERRLVL",
                "WITH",
                "ESCAPE",
                "OVER",
                "WRITETEXT",
                "QUOTED_IDENTIFIER",
                "ANSI_NULLS",
                "OUTPUT",
                "OUT",
            ]
        )
},
{
    "Function", new WordPattern(
            name: "Function",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("fuchsia"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "AVG",
                "MAX",
                "BINARY_CHECKSUM",
                "MIN",
                "CHECKSUM",
                "SUM",
                "CHECKSUM_AGG",
                "STDEV",
                "COUNT",
                "STDEVP",
                "COUNT_BIG",
                "VAR",
                "GROUPING",
                "VARP",
                "CURSOR_STATUS",
                "DATEADD",
                "DATEDIFF",
                "DATEName",
                "DATEPART",
                "DAY",
                "GETDATE",
                "GETUTCDATE",
                "MONTH",
                "YEAR",
                "ABS",
                "DEGREES",
                "RAND",
                "ACOS",
                "EXP",
                "ROUND",
                "ASIN",
                "FLOOR",
                "SIGN",
                "ATAN",
                "LOG",
                "SIN",
                "ATN2",
                "LOG10",
                "SQUARE",
                "CEILING",
                "PI",
                "SQRT",
                "COS",
                "POWER",
                "TAN",
                "COT",
                "RADIANS",
                "COL_LENGTH",
                "COL_Name",
                "FULLTEXTCATALOGPROPERTY",
                "COLUMNPROPERTY",
                "FULLTEXTSERVICEPROPERTY",
                "DATABASEPROPERTY",
                "INDEX_COL",
                "DATABASEPROPERTYEX",
                "INDEXKEY_PROPERTY",
                "DB_ID",
                "INDEXPROPERTY",
                "DB_Name",
                "OBJECT_ID",
                "FILE_ID",
                "OBJECT_Name",
                "FILE_Name",
                "OBJECTPROPERTY",
                "FILEGROUP_ID",
                "FILEGROUP_Name",
                "SQL_VARIANT_PROPERTY",
                "FILEGROUPPROPERTY",
                "TypePROPERTY",
                "FILEPROPERTY",
                "IS_SRVROLEMEMBER",
                "SUSER_SID",
                "SUSER_SName",
                "USER_ID",
                "HAS_DBACCESS",
                "USER",
                "IS_MEMBER",
                "ASCII",
                "NCHAR",
                "SOUNDEX",
                "CHAR",
                "PATINDEX",
                "SPACE",
                "CHARINDEX",
                "REPLACE",
                "STR",
                "DIFFERENCE",
                "QUOTEName",
                "STUFF",
                "LEFT",
                "REPLICATE",
                "SUBSTRING",
                "LEN",
                "REVERSE",
                "UNICODE",
                "LOWER",
                "RIGHT",
                "UPPER",
                "LTRIM",
                "RTRIM",
                "APP_Name",
                "CASE",
                "CAST",
                "CONVERT",
                "COALESCE",
                "COLLATIONPROPERTY",
                "CURRENT_TIMESTAMP",
                "CURRENT_USER",
                "DATALENGTH",
                "FORMATMESSAGE",
                "GETANSINULL",
                "HOST_ID",
                "HOST_Name",
                "IDENT_CURRENT",
                "IDENT_INCRIDENT_SEED",
                "IDENTITY",
                "ISDATE",
                "ISNULL",
                "ISNUMERIC",
                "NEWID",
                "NULLIF",
                "PARSEName",
                "PERMISSIONS",
                "ROWCOUNT_BIG",
                "SCOPE_IDENTITY",
                "SERVERPROPERTY",
                "SESSIONPROPERTY",
                "SESSION_USER",
                "STATS_DATE",
                "SYSTEM_USER",
                "USER_Name",
                "PATINDEX",
                "TEXTPTR",
                "TEXTVALID",
                "CASE",
                "RIGHT",
                "COALESCE",
                "SESSION_USER",
                "CONVERT",
                "SYSTEM_USER",
                "LEFT",
                "CURRENT_TIMESTAMP",
                "CURRENT_USER",
                "NULLIF",
                "USER",
            ]
        )
},
{
    "DataType", new WordPattern(
            name: "DataType",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("blue"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "bigint",
                "int",
                "smallint",
                "tinyint",
                "bit",
                "decimal",
                "numeric",
                "money",
                "smallmoney",
                "float",
                "real",
                "datetime",
                "smalldatetime",
                "char",
                "varchar",
                "text",
                "nchar",
                "nvarchar",
                "ntext",
                "binary",
                "varbinary",
                "image",
                "cursor",
                "sql_variant",
                "table",
                "timestamp",
                "uniqueidentifier",
            ]
        )
},
{
    "Operator", new WordPattern(
            name: "Operator",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("silver"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "ALL",
                "AND",
                "EXISTS",
                "ANY",
                "BETWEEN",
                "IN",
                "SOME",
                "JOIN",
                "CROSS",
                "LIKE",
                "NOT",
                "NULL",
                "OR",
                "OUTER",
            ]
        )
},
{
    "SystemFunction", new WordPattern(
            name: "SystemFunction",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("brown"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            words:
            [
                "fn_listextendedproperty",
                "fn_trace_getinfo",
                "fn_trace_gettable",
                "fn_trace_geteventinfo",
                "fn_trace_getfilterinfo",
                "fn_helpcollations",
                "fn_servershareddrives",
                "fn_virtualfilestats",
                "fn_virtualfilestats",
            ]
        )
},
{
    "Comment", new BlockPattern(
            name: "Comment",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("teal"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            beginsWith: "--",
            endsWith: "\n",
            escapesWith: ""
        )
},
{
    "BlockComment", new BlockPattern(
            name: "BlockComment",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("teal"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            beginsWith: "/*",
            endsWith: "*/",
            escapesWith: ""
        )
},
{
    "String", new BlockPattern(
            name: "String",
            style: new Style(
                new ColorPair(
                    foreColor: Color.FromName("red"),
                    backColor: Color.FromName("transparent")
                ),
                new Font(
                    name: "monospace",
                    size: 16f,
                    style: FontStyle.Regular
                )
            ),
            beginsWith: "'",
            endsWith: "'",
            escapesWith: ""
        )
},
    });
}