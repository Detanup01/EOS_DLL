namespace EOS_SDK.Version
{
    /// <summary>
    /// Collection of versions that can or need to be checked against
    /// </summary>
    internal class Versions
    {
        #region Achievements
        public const int AddNotifyAchievementsUnlockedApiLatest = 1;
        public const int AddNotifyAchievementsUnlockedV2ApiLatest = 2;
        public const int CopyAchievementDefinitionV2ByAchievementIdApiLatest = 2;
        public const int CopyAchievementDefinitionV2ByIndexApiLatest = 2;
        public const int CopydefinitionbyachievementidApiLatest = 1;
        public const int CopydefinitionbyindexApiLatest = 1;
        public const int Copydefinitionv2ByachievementidApiLatest = CopyAchievementDefinitionV2ByAchievementIdApiLatest;
        public const int Copydefinitionv2ByindexApiLatest = CopyAchievementDefinitionV2ByIndexApiLatest;
        public const int CopyplayerachievementbyachievementidApiLatest = 2;
        public const int CopyplayerachievementbyindexApiLatest = 2;
        public const int CopyunlockedachievementbyachievementidApiLatest = 1;
        public const int CopyunlockedachievementbyindexApiLatest = 1;
        public const int DefinitionApiLatest_Achievements = 1;
        public const int Definitionv2ApiLatest = 2;
        public const int GetachievementdefinitioncountApiLatest = 1;
        public const int GetplayerachievementcountApiLatest = 1;
        public const int GetunlockedachievementcountApiLatest = 1;
        public const int PlayerachievementApiLatest = 2;
        public const int PlayerstatinfoApiLatest = 1;
        public const int QuerydefinitionsApiLatest = 3;
        public const int QueryplayerachievementsApiLatest = 2;
        public const int StatthresholdApiLatest = StatthresholdsApiLatest;
        public const int StatthresholdsApiLatest = 1;
        public const int UnlockachievementsApiLatest = 1;
        public const int UnlockedachievementApiLatest = 1;
        #endregion
        #region Android
        public const int AndroidInitializeoptionssysteminitializeoptionsApiLatest = 2;
        #endregion
        #region AntiCheatClient
        public const int AddexternalintegritycatalogApiLatest = 1;
        public const int AddnotifyclientintegrityviolatedApiLatest = 1;
        public const int AddnotifymessagetopeerApiLatest = 1;
        public const int AddnotifymessagetoserverApiLatest = 1;
        public const int AddnotifypeeractionrequiredApiLatest = 1;
        public const int AddnotifypeerauthstatuschangedApiLatest = 1;
        public const int BeginsessionApiLatest_AntiCheatClient = 3;
        public const int EndsessionApiLatest_AntiCheatClient = 1;
        public const int GetprotectmessageoutputlengthApiLatest_AntiCheatClient = 1; 
        public const int PollstatusApiLatest = 1;
        public const int ProtectmessageApiLatest_AntiCheatClient = 1;
        public const int ReceivemessagefrompeerApiLatest = 1;
        public const int ReceivemessagefromserverApiLatest = 1;
        public const int RegisterpeerApiLatest = 3;
        public const int UnprotectmessageApiLatest_AntiCheatClient = 1;
        public const int UnregisterpeerApiLatest = 1;
        #endregion
        #region AntiCheatCommon
        public const int LogeventApiLatest = 1;
        public const int LoggameroundendApiLatest = 1;
        public const int LoggameroundstartApiLatest = 1;
        public const int LogplayerdespawnApiLatest = 1;
        public const int LogplayerreviveApiLatest = 1;
        public const int LogplayerspawnApiLatest = 1;
        public const int LogplayertakedamageApiLatest = 3;
        public const int LogplayertickApiLatest = 2;
        public const int LogplayeruseabilityApiLatest = 1;
        public const int LogplayeruseweaponApiLatest = 2;
        public const int RegistereventApiLatest = 1;
        public const int SetclientdetailsApiLatest = 1;
        public const int SetgamesessionidApiLatest = 1;
        #endregion
        #region AntiCheatServer
        public const int AddNotifyClientActionRequiredApiLatest = 1;
        public const int AddnotifyclientauthstatuschangedApiLatest = 1;
        public const int AddnotifymessagetoclientApiLatest = 1;
        public const int BeginsessionApiLatest_AntiCheatServer = 3;
        public const int EndsessionApiLatest_AntiCheatServer = 1;
        public const int GetprotectmessageoutputlengthApiLatest_AntiCheatServer = 1;
        public const int ProtectmessageApiLatest_AntiCheatServer = 1;
        public const int ReceivemessagefromclientApiLatest = 1;
        public const int RegisterclientApiLatest = 2;
        public const int SetclientnetworkstateApiLatest = 1;
        public const int UnprotectmessageApiLatest_AntiCheatServer = 1;
        public const int UnregisterclientApiLatest = 1;
        #endregion
        #region Auth
        public const int AccountfeaturerestrictedinfoApiLatest = 1;
        public const int AddnotifyloginstatuschangedApiLatest_Auth = 1;
        public const int CopyidtokenApiLatest_Auth = 1;
        public const int CopyuserauthtokenApiLatest = 1;
        public const int CredentialsApiLatest_Auth = 4;
        public const int DeletepersistentauthApiLatest = 2;
        public const int IdtokenApiLatest_Auth = 1;
        public const int LinkaccountApiLatest_Auth = 1;
        public const int LoginApiLatest_Auth = 3;
        public const int LogoutApiLatest = 1;
        public const int PingrantinfoApiLatest = 2;
        public const int QueryidtokenApiLatest = 1;
        public const int TokenApiLatest = 2;
        public const int VerifyidtokenApiLatest_Auth = 1;
        public const int VerifyuserauthApiLatest = 1;
        #endregion
        #region Connect
        public const int AddnotifyauthexpirationApiLatest = 1;
        public const int AddnotifyloginstatuschangedApiLatest_Connect = 1;
        public const int CopyidtokenApiLatest_Connect = 1;
        public const int CopyproductuserexternalaccountbyaccountidApiLatest = 1;
        public const int CopyproductuserexternalaccountbyaccounttypeApiLatest = 1;
        public const int CopyproductuserexternalaccountbyindexApiLatest = 1;
        public const int CopyproductuserinfoApiLatest = 1;
        public const int CreatedeviceidApiLatest = 1;
        public const int CreateuserApiLatest_Connect = 1;
        public const int CredentialsApiLatest_Connect = 1;
        public const int DeletedeviceidApiLatest = 1;
        public const int ExternalaccountinfoApiLatest = 1;
        public const int GetexternalaccountmappingApiLatest = 1;
        public const int GetexternalaccountmappingsApiLatest = GetexternalaccountmappingApiLatest;
        public const int GetproductuserexternalaccountcountApiLatest = 1;
        public const int GetproductuseridmappingApiLatest = 1;
        public const int IdtokenApiLatest_Connect = 1;
        public const int LinkaccountApiLatest_Connect = 1;
        public const int LoginApiLatest_Connect = 2;
        public const int OnauthexpirationcallbackApiLatest = 1;
        public const int QueryexternalaccountmappingsApiLatest = 1;
        public const int QueryproductuseridmappingsApiLatest = 2;
        public const int TransferdeviceidaccountApiLatest = 1;
        public const int UnlinkaccountApiLatest = 1;
        public const int UserlogininfoApiLatest = 2;
        public const int VerifyidtokenApiLatest_Connect = 1;
        #endregion
        #region CustomInvites
        public const int AcceptrequesttojoinApiLatest = 1;
        public const int AddnotifycustominviteacceptedApiLatest = 1;
        public const int AddnotifycustominvitereceivedApiLatest = 1;
        public const int AddnotifycustominviterejectedApiLatest = 1;
        public const int AddnotifyrequesttojoinacceptedApiLatest = 1;
        public const int AddnotifyrequesttojoinreceivedApiLatest = 1;
        public const int AddnotifyrequesttojoinrejectedApiLatest = 1;
        public const int AddnotifyrequesttojoinresponsereceivedApiLatest = 1;
        public const int AddnotifysendcustomnativeinviterequestedApiLatest = 1;
        public const int FinalizeinviteApiLatest = 1;
        public const int RejectrequesttojoinApiLatest = 1;
        public const int SendcustominviteApiLatest = 1;
        public const int SendrequesttojoinApiLatest = 1;
        public const int SetcustominviteApiLatest = 1;
        #endregion
        #region Ecom
        public const int CatalogitemApiLatest = 1;
        public const int CatalogofferApiLatest = 5;
        public const int CatalogreleaseApiLatest = 1;
        public const int CheckoutApiLatest = 1;
        public const int CheckoutentryApiLatest = 1;
        public const int CopyentitlementbyidApiLatest = 2;
        public const int CopyentitlementbyindexApiLatest = 1;
        public const int CopyentitlementbynameandindexApiLatest = 1;
        public const int CopyitembyidApiLatest = 1;
        public const int CopyitemimageinfobyindexApiLatest = 1;
        public const int CopyitemreleasebyindexApiLatest = 1;
        public const int CopylastredeemedentitlementbyindexApiLatest = 1;
        public const int CopyofferbyidApiLatest = 3;
        public const int CopyofferbyindexApiLatest = 3;
        public const int CopyofferimageinfobyindexApiLatest = 1;
        public const int CopyofferitembyindexApiLatest = 1;
        public const int CopytransactionbyidApiLatest = 1;
        public const int CopytransactionbyindexApiLatest = 1;
        public const int EntitlementApiLatest = 2;
        public const int GetentitlementsbynamecountApiLatest = 1;
        public const int GetentitlementscountApiLatest = 1;
        public const int GetitemimageinfocountApiLatest = 1;
        public const int GetitemreleasecountApiLatest = 1;
        public const int GetlastredeemedentitlementscountApiLatest = 1;
        public const int GetoffercountApiLatest = 1;
        public const int GetofferimageinfocountApiLatest = 1;
        public const int GetofferitemcountApiLatest = 1;
        public const int GettransactioncountApiLatest = 1;
        public const int ItemownershipApiLatest = 1;
        public const int KeyimageinfoApiLatest = 1;
        public const int QueryentitlementsApiLatest = 2;
        public const int QueryentitlementtokenApiLatest = 1;
        public const int QueryoffersApiLatest = 1;
        public const int QueryownershipApiLatest = 2;
        public const int QueryownershipbysandboxidsoptionsApiLatest = 1;
        public const int QueryownershiptokenApiLatest = 2;
        public const int RedeementitlementsApiLatest = 2;
        #endregion
        #region Friends
        public const int AcceptinviteApiLatest = 1;
        public const int AddnotifyblockedusersupdateApiLatest = 1;
        public const int AddnotifyfriendsupdateApiLatest = 1;
        public const int GetblockeduseratindexApiLatest = 1;
        public const int GetblockeduserscountApiLatest = 1;
        public const int GetfriendatindexApiLatest = 1;
        public const int GetfriendscountApiLatest = 1;
        public const int GetstatusApiLatest = 1;
        public const int QueryfriendsApiLatest = 1;
        public const int RejectinviteApiLatest_Friends = 1;
        public const int SendinviteApiLatest_Friends = 1;
        #endregion
        #region IntegratedPlatform
        public const int AddnotifyuserloginstatuschangedApiLatest = 1;
        public const int ClearuserprelogoutcallbackApiLatest = 1;
        public const int CreateintegratedplatformoptionscontainerApiLatest = 1;
        public const int FinalizedeferreduserlogoutApiLatest = 1;
        public const int OptionsApiLatest_IntegratedPlatform = 1;
        public const int SetuserloginstatusApiLatest = 1;
        public const int SetuserprelogoutcallbackApiLatest = 1;
        public const int SteamOptionsApiLatest = 2;
        #endregion
        #region IOS
        public const int IosCredentialssystemauthcredentialsoptionsApiLatest = 1;
        #endregion
        #region KWS
        public const int AddnotifypermissionsupdatereceivedApiLatest = 1;
        public const int CopypermissionbyindexApiLatest = 1;
        public const int CreateuserApiLatest_KWS = 1;
        public const int GetpermissionbykeyApiLatest = 1;
        public const int GetpermissionscountApiLatest = 1;
        public const int PermissionstatusApiLatest = 1;
        public const int QueryagegateApiLatest = 1;
        public const int QuerypermissionsApiLatest = 1;
        public const int RequestpermissionsApiLatest = 1;
        public const int UpdateparentemailApiLatest = 1;
        #endregion
        #region Leaderboards
        public const int CopyleaderboarddefinitionbyindexApiLatest = 1;
        public const int CopyleaderboarddefinitionbyleaderboardidApiLatest = 1;
        public const int CopyleaderboardrecordbyindexApiLatest = 2;
        public const int CopyleaderboardrecordbyuseridApiLatest = 2;
        public const int CopyleaderboarduserscorebyindexApiLatest = 1;
        public const int CopyleaderboarduserscorebyuseridApiLatest = 1;
        public const int DefinitionApiLatest_Leaderboards = 1;
        public const int GetleaderboarddefinitioncountApiLatest = 1;
        public const int GetleaderboardrecordcountApiLatest = 1;
        public const int GetleaderboarduserscorecountApiLatest = 1;
        public const int LeaderboardrecordApiLatest = 2;
        public const int LeaderboarduserscoreApiLatest = 1;
        public const int QueryleaderboarddefinitionsApiLatest = 2;
        public const int QueryleaderboardranksApiLatest = 2;
        public const int QueryleaderboarduserscoresApiLatest = 2;
        public const int UserscoresquerystatinfoApiLatest = 1;
        #endregion
        #region Lobby
        public const int AddnotifyjoinlobbyacceptedApiLatest = 1;
        public const int AddnotifyleavelobbyrequestedApiLatest = 1;
        public const int AddnotifylobbyinviteacceptedApiLatest = 1;
        public const int AddnotifylobbyinvitereceivedApiLatest = 1;
        public const int AddnotifylobbyinviterejectedApiLatest = 1;
        public const int AddnotifylobbymemberstatusreceivedApiLatest = 1;
        public const int AddnotifylobbymemberupdatereceivedApiLatest = 1;
        public const int AddnotifylobbyupdatereceivedApiLatest = 1;
        public const int AddnotifyrtcroomconnectionchangedApiLatest = 2;
        public const int AddnotifysendlobbynativeinviterequestedApiLatest = 1;
        public const int AttributeApiLatest = 1;
        public const int AttributedataApiLatest_Lobby = 1;
        public const int CopylobbydetailshandleApiLatest = 1;
        public const int CopylobbydetailshandlebyinviteidApiLatest = 1;
        public const int CopylobbydetailshandlebyuieventidApiLatest = 1;
        public const int CreatelobbyApiLatest = 9;
        public const int CreatelobbysearchApiLatest = 1;
        public const int DestroylobbyApiLatest = 1;
        public const int GetconnectstringApiLatest = 1;
        public const int GetinvitecountApiLatest_Lobby = 1;
        public const int GetinviteidbyindexApiLatest_Lobby = 1;
        public const int GetrtcroomnameApiLatest = 1;
        public const int HardmutememberApiLatest = 1;
        public const int IsrtcroomconnectedApiLatest = 1;
        public const int JoinlobbyApiLatest = 4;
        public const int JoinlobbybyidApiLatest = 2;
        public const int KickmemberApiLatest = 1;
        public const int LeavelobbyApiLatest = 1;
        public const int LocalrtcoptionsApiLatest = 1;
        public const int MinLobbyidoverrideLength = 4;
        public const int ParseconnectstringApiLatest = 1;
        public const int PromotememberApiLatest = 1;
        public const int QueryinvitesApiLatest_Lobby = 1;
        public const int RejectinviteApiLatest_Lobby = 1;
        public const int SendinviteApiLatest_Lobby = 1;
        public const int UpdatelobbyApiLatest = 1;
        public const int UpdatelobbymodificationApiLatest = 1;
        #endregion
        #region Metrics
        public const int BeginplayersessionApiLatest = 1;
        public const int EndplayersessionApiLatest = 1;
        #endregion
        #region Mods
        public const int CopymodinfoApiLatest = 1;
        public const int EnumeratemodsApiLatest = 1;
        public const int InstallmodApiLatest = 1;
        public const int ModIdentifierApiLatest = 1;
        public const int ModinfoApiLatest = 1;
        public const int UninstallmodApiLatest = 1;
        public const int UpdatemodApiLatest = 1;
        #endregion
        #region P2P
        public const int AcceptconnectionApiLatest = 1;
        public const int AddnotifyincomingpacketqueuefullApiLatest = 1;
        public const int AddnotifypeerconnectionclosedApiLatest = 1;
        public const int AddnotifypeerconnectionestablishedApiLatest = 1;
        public const int AddnotifypeerconnectioninterruptedApiLatest = 1;
        public const int AddnotifypeerconnectionrequestApiLatest = 1;
        public const int ClearpacketqueueApiLatest = 1;
        public const int CloseconnectionApiLatest = 1;
        public const int CloseconnectionsApiLatest = 1;
        public const int GetnattypeApiLatest = 1;
        public const int GetnextreceivedpacketsizeApiLatest = 2;
        public const int GetpacketqueueinfoApiLatest = 1;
        public const int GetportrangeApiLatest = 1;
        public const int GetrelaycontrolApiLatest = 1;
        public const int QuerynattypeApiLatest = 1;
        public const int ReceivepacketApiLatest = 2;
        public const int SendpacketApiLatest = 3;
        public const int SetpacketqueuesizeApiLatest = 1;
        public const int SetportrangeApiLatest = 1;
        public const int SetrelaycontrolApiLatest = 1;
        public const int SocketidApiLatest = 1;
        #endregion
        #region Platform
        public const int GetDesktopCrossplayStatusApiLatest = 1;
        public const int InitializeApiLatest = 4;
        public const int InitializeThreadAffinityApiLatest = 2;
        public const int OptionsApiLatest_Platform = 13;
        public const int RTCOptionsApiLatest = 2;
        #endregion
        #region PlayerDataStorage
        public const int CopyfilemetadataatindexApiLatest_PlayerDataStorage = 1;
        public const int CopyfilemetadataatindexoptionsApiLatest_PlayerDataStorage = CopyfilemetadataatindexApiLatest_PlayerDataStorage;
        public const int CopyfilemetadatabyfilenameApiLatest_PlayerDataStorage = 1;
        public const int CopyfilemetadatabyfilenameoptionsApiLatest_PlayerDataStorage = CopyfilemetadatabyfilenameApiLatest_PlayerDataStorage;
        public const int DeletecacheApiLatest_PlayerDataStorage = 1;
        public const int DeletecacheoptionsApiLatest_PlayerDataStorage = DeletecacheApiLatest_PlayerDataStorage;
        public const int DeletefileApiLatest_PlayerDataStorage = 1;
        public const int DeletefileoptionsApiLatest_PlayerDataStorage = DeletefileApiLatest_PlayerDataStorage;
        public const int DuplicatefileApiLatest_PlayerDataStorage = 1;
        public const int DuplicatefileoptionsApiLatest_PlayerDataStorage = DuplicatefileApiLatest_PlayerDataStorage;
        public const int FilemetadataApiLatest_PlayerDataStorage = 3;
        public const int GetfilemetadatacountApiLatest_PlayerDataStorage = 1;
        public const int GetfilemetadatacountoptionsApiLatest_PlayerDataStorage = GetfilemetadatacountApiLatest_PlayerDataStorage;
        public const int QueryfileApiLatest_PlayerDataStorage = 1;
        public const int QueryfilelistApiLatest_PlayerDataStorage = 2;
        public const int QueryfilelistoptionsApiLatest_PlayerDataStorage = QueryfilelistApiLatest_PlayerDataStorage;
        public const int QueryfileoptionsApiLatest_PlayerDataStorage = QueryfileApiLatest_PlayerDataStorage;
        public const int ReadfileApiLatest_PlayerDataStorage = 1;
        public const int ReadfileoptionsApiLatest_PlayerDataStorage = ReadfileApiLatest_PlayerDataStorage;
        public const int WritefileApiLatest_PlayerDataStorage = 1;
        public const int WritefileoptionsApiLatest_PlayerDataStorage = WritefileApiLatest_PlayerDataStorage;
        #endregion
        #region Presence
        public const int AddnotifyjoingameacceptedApiLatest = 2;
        public const int AddnotifyonpresencechangedApiLatest = 1;
        public const int CopypresenceApiLatest = 3;
        public const int CreatepresencemodificationApiLatest = 1;
        public const int DatarecordApiLatest = 1;
        public const int DeletedataApiLatest = PresencemodificationDeletedataApiLatest;
        public const int GetjoininfoApiLatest = 1;
        public const int HaspresenceApiLatest = 1;
        public const int InfoApiLatest = 3;
        public const int QuerypresenceApiLatest = 1;
        public const int SetdataApiLatest = PresencemodificationSetdataApiLatest;
        public const int SetpresenceApiLatest = 1;
        public const int SetrawrichtextApiLatest = PresencemodificationSetrawrichtextApiLatest;
        public const int SetstatusApiLatest = PresencemodificationSetstatusApiLatest;
        public const int PresencemodificationDatarecordidApiLatest = 1;
        public const int PresencemodificationDeletedataApiLatest = 1;
        public const int PresencemodificationSetdataApiLatest = 1;
        public const int PresencemodificationSetjoininfoApiLatest = 1;
        public const int PresencemodificationSetrawrichtextApiLatest = 1;
        public const int PresencemodificationSetstatusApiLatest = 1;
        #endregion
        #region ProgressionSnapshot
        public const int AddprogressionApiLatest = 1;
        public const int BeginsnapshotApiLatest = 1;
        public const int DeletesnapshotApiLatest = 1;
        public const int EndsnapshotApiLatest = 1;
        public const int SubmitsnapshotApiLatest = 1;
        #endregion
        #region Reports
        public const int SendplayerbehaviorreportApiLatest = 2;
        #endregion
        #region RTC
        public const int AddnotifydisconnectedApiLatest = 1;
        public const int AddnotifyparticipantstatuschangedApiLatest = 1;
        public const int AddnotifyroomstatisticsupdatedApiLatest = 1;
        public const int BlockparticipantApiLatest = 1;
        public const int JoinroomApiLatest = 1;
        public const int LeaveroomApiLatest = 1;
        public const int OptionApiLatest = 1;
        public const int ParticipantmetadataApiLatest = 1;
        public const int SetroomsettingApiLatest = 1;
        public const int SetsettingApiLatest = 1;
        #endregion
        #region RTCAdmin
        public const int CopyusertokenbyindexApiLatest = 2;
        public const int CopyusertokenbyuseridApiLatest = 2;
        public const int KickApiLatest = 1;
        public const int QueryjoinroomtokenApiLatest = 2;
        public const int SetparticipanthardmuteApiLatest = 1;
        public const int UsertokenApiLatest = 1;
        #endregion
        #region RTCAudio
        public const int AddnotifyaudiobeforerenderApiLatest = 1;
        public const int AddnotifyaudiobeforesendApiLatest = 1;
        public const int AddnotifyaudiodeviceschangedApiLatest = 1;
        public const int AddnotifyaudioinputstateApiLatest = 1;
        public const int AddnotifyaudiooutputstateApiLatest = 1;
        public const int AddnotifyparticipantupdatedApiLatest = 1;
        public const int AudiobufferApiLatest = 1;
        public const int AudioinputdeviceinfoApiLatest = 1;
        public const int AudiooutputdeviceinfoApiLatest = 1;
        public const int CopyinputdeviceinformationbyindexApiLatest = 1;
        public const int CopyoutputdeviceinformationbyindexApiLatest = 1;
        public const int GetaudioinputdevicebyindexApiLatest = 1;
        public const int GetaudioinputdevicescountApiLatest = 1;
        public const int GetaudiooutputdevicebyindexApiLatest = 1;
        public const int GetaudiooutputdevicescountApiLatest = 1;
        public const int GetinputdevicescountApiLatest = 1;
        public const int GetoutputdevicescountApiLatest = 1;
        public const int InputdeviceinformationApiLatest = 1;
        public const int OutputdeviceinformationApiLatest = 1;
        public const int QueryinputdevicesinformationApiLatest = 1;
        public const int QueryoutputdevicesinformationApiLatest = 1;
        public const int RegisterplatformaudiouserApiLatest = 1;
        public const int RegisterplatformuserApiLatest = 1;
        public const int SendaudioApiLatest = 1;
        public const int SetaudioinputsettingsApiLatest = 1;
        public const int SetaudiooutputsettingsApiLatest = 1;
        public const int SetinputdevicesettingsApiLatest = 1;
        public const int SetoutputdevicesettingsApiLatest = 1;
        public const int UnregisterplatformaudiouserApiLatest = 1;
        public const int UnregisterplatformuserApiLatest = 1;
        public const int UpdateparticipantvolumeApiLatest = 1;
        public const int UpdatereceivingApiLatest = 1;
        public const int UpdatereceivingvolumeApiLatest = 1;
        public const int UpdatesendingApiLatest = 1;
        public const int UpdatesendingvolumeApiLatest = 1;
        #endregion
        #region Sanctions
        public const int CopyplayersanctionbyindexApiLatest = 1;
        public const int GetplayersanctioncountApiLatest = 1;
        public const int PlayersanctionApiLatest = 2;
        public const int QueryactiveplayersanctionsApiLatest = 2;
        #endregion
        #region Sessions
        public const int AddnotifyjoinsessionacceptedApiLatest = 1;
        public const int AddnotifyleavesessionrequestedApiLatest = 1;
        public const int AddnotifysendsessionnativeinviterequestedApiLatest = 1;
        public const int AddnotifysessioninviteacceptedApiLatest = 1;
        public const int AddnotifysessioninvitereceivedApiLatest = 1;
        public const int AddnotifysessioninviterejectedApiLatest = 1;
        public const int AttributedataApiLatest_Sessions = 1;
        public const int CopyactivesessionhandleApiLatest = 1;
        public const int CopysessionhandlebyinviteidApiLatest = 1;
        public const int CopysessionhandlebyuieventidApiLatest = 1;
        public const int CopysessionhandleforpresenceApiLatest = 1;
        public const int CreatesessionmodificationApiLatest = 5;
        public const int CreatesessionsearchApiLatest = 1;
        public const int DestroysessionApiLatest = 1;
        public const int DumpsessionstateApiLatest = 1;
        public const int EndsessionApiLatest = 1;
        public const int GetinvitecountApiLatest_Sessions = 1;
        public const int GetinviteidbyindexApiLatest_Sessions = 1;
        public const int IsuserinsessionApiLatest = 1;
        public const int JoinsessionApiLatest = 2;
        public const int QueryinvitesApiLatest_Sessions = 1;
        public const int RegisterplayersApiLatest = 3;
        public const int RejectinviteApiLatest = 1;
        public const int SendinviteApiLatest = 1;
        public const int SessionattributeApiLatest = SessiondetailsAttributeApiLatest;
        public const int SessionattributedataApiLatest = AttributedataApiLatest_Sessions;
        public const int StartsessionApiLatest = 1;
        public const int UnregisterplayersApiLatest = 2;
        public const int UpdatesessionApiLatest = 1;
        public const int UpdatesessionmodificationApiLatest = 1;
        public const int SessionsearchCopysearchresultbyindexApiLatest = 1;
        public const int SessionsearchFindApiLatest = 2;
        public const int SessionsearchGetsearchresultcountApiLatest = 1;
        public const int SessionsearchRemoveparameterApiLatest = 1;
        public const int SessionsearchSetmaxsearchresultsApiLatest = 1;
        public const int SessionsearchSetparameterApiLatest = 1;
        public const int SessionsearchSetsessionidApiLatest = 1;
        public const int SessionsearchSettargetuseridApiLatest = 1;
        public const int SessionmodificationAddattributeApiLatest = 2;
        public const int SessionmodificationRemoveattributeApiLatest = 1;
        public const int SessionmodificationSetallowedplatformidsApiLatest = 1;
        public const int SessionmodificationSetbucketidApiLatest = 1;
        public const int SessionmodificationSethostaddressApiLatest = 1;
        public const int SessionmodificationSetinvitesallowedApiLatest = 1;
        public const int SessionmodificationSetjoininprogressallowedApiLatest = 1;
        public const int SessionmodificationSetmaxplayersApiLatest = 1;
        public const int SessionmodificationSetpermissionlevelApiLatest = 1;
        public const int SessiondetailsAttributeApiLatest = 1;
        public const int SessiondetailsCopyinfoApiLatest = 1;
        public const int SessiondetailsCopysessionattributebyindexApiLatest = 1;
        public const int SessiondetailsCopysessionattributebykeyApiLatest = 1;
        public const int SessiondetailsGetsessionattributecountApiLatest = 1;
        public const int SessiondetailsInfoApiLatest = 2;
        public const int SessiondetailsSettingsApiLatest = 4;
        public const int ActivesessionCopyinfoApiLatest = 1;
        public const int ActivesessionGetregisteredplayerbyindexApiLatest = 1;
        public const int ActivesessionGetregisteredplayercountApiLatest = 1;
        public const int ActivesessionInfoApiLatest = 1;
        #endregion
        #region Stats
        public const int CopystatbyindexApiLatest = 1;
        public const int CopystatbynameApiLatest = 1;
        public const int GetstatcountApiLatest = GetstatscountApiLatest;
        public const int GetstatscountApiLatest = 1;
        public const int IngestdataApiLatest = 1;
        public const int IngeststatApiLatest = 3;
        public const int QuerystatsApiLatest = 3;
        public const int StatApiLatest = 1;
        #endregion
        #region TitleStorage
        public const int CopyfilemetadataatindexApiLatest_TitleStorage = 1;
        public const int CopyfilemetadataatindexoptionsApiLatest_TitleStorage = CopyfilemetadataatindexApiLatest_TitleStorage;
        public const int CopyfilemetadatabyfilenameApiLatest_TitleStorage = 1;
        public const int CopyfilemetadatabyfilenameoptionsApiLatest_TitleStorage = CopyfilemetadatabyfilenameApiLatest_TitleStorage;
        public const int DeletecacheApiLatest_TitleStorage = 1;
        public const int DeletecacheoptionsApiLatest_TitleStorage = DeletecacheApiLatest_TitleStorage;
        public const int FilemetadataApiLatest_TitleStorage = 2;
        public const int GetfilemetadatacountApiLatest_TitleStorage = 1;
        public const int GetfilemetadatacountoptionsApiLatest_TitleStorage = GetfilemetadatacountApiLatest_TitleStorage;
        public const int QueryfileApiLatest_TitleStorage = 1;
        public const int QueryfilelistApiLatest_TitleStorage = 1;
        public const int QueryfilelistoptionsApiLatest_TitleStorage = QueryfilelistApiLatest_TitleStorage;
        public const int QueryfileoptionsApiLatest_TitleStorage = QueryfileApiLatest_TitleStorage;
        public const int ReadfileApiLatest_TitleStorage = 1;
        public const int ReadfileoptionsApiLatest_TitleStorage = ReadfileApiLatest_TitleStorage;
        #endregion
        #region UI
        public const int AcknowledgecorrelationidApiLatest = AcknowledgeeventidApiLatest;
        public const int AcknowledgeeventidApiLatest = 1;
        public const int AddnotifydisplaysettingsupdatedApiLatest = 1;
        public const int AddnotifymemorymonitorApiLatest = 1;
        public const int AddnotifymemorymonitoroptionsApiLatest = AddnotifymemorymonitorApiLatest;
        public const int GetfriendsexclusiveinputApiLatest = 1;
        public const int GetfriendsvisibleApiLatest = 1;
        public const int GettogglefriendsbuttonApiLatest = 1;
        public const int GettogglefriendskeyApiLatest = 1;
        public const int HidefriendsApiLatest = 1;
        public const int IssocialoverlaypausedApiLatest = 1;
        public const int MemorymonitorcallbackinfoApiLatest = 1;
        public const int PausesocialoverlayApiLatest = 1;
        public const int PrepresentApiLatest = 1;
        public const int RectApiLatest = 1;
        public const int ReportinputstateApiLatest = 2;
        public const int SetdisplaypreferenceApiLatest = 1;
        public const int SettogglefriendsbuttonApiLatest = 1;
        public const int SettogglefriendskeyApiLatest = 1;
        public const int ShowblockplayerApiLatest = 1;
        public const int ShowfriendsApiLatest = 1;
        public const int ShownativeprofileApiLatest = 1;
        public const int ShowreportplayerApiLatest = 1;
        #endregion
        #region UserInfo
        public const int BestdisplaynameApiLatest = 1;
        public const int CopybestdisplaynameApiLatest = 1;
        public const int CopybestdisplaynamewithplatformApiLatest = 1;
        public const int CopyexternaluserinfobyaccountidApiLatest = 1;
        public const int CopyexternaluserinfobyaccounttypeApiLatest = 1;
        public const int CopyexternaluserinfobyindexApiLatest = 1;
        public const int CopyuserinfoApiLatest = 3;
        public const int ExternaluserinfoApiLatest = 2;
        public const int GetexternaluserinfocountApiLatest = 1;
        public const int GetlocalplatformtypeApiLatest = 1;
        public const int QueryuserinfoApiLatest = 1;
        public const int QueryuserinfobydisplaynameApiLatest = 1;
        public const int QueryuserinfobyexternalaccountApiLatest = 1;
        #endregion
        #region Version
        public const int MajorVersion = 1;
        public const int MinorVersion = 16;
        public const int PatchVersion = 1;
        #endregion
        #region Windows
        public const int WindowsRtcoptionsplatformspecificoptionsApiLatest = 1;
        #endregion
        #region Common
        public const int PagequeryApiLatest = 1;
        public const int PaginationApiLatest = PagequeryApiLatest;
        #endregion
    }
}
