#region License
///////////////////////////////////////////////////////////////////////////////
//               Commercial Product Licence from CODEFACTORY Inc.
//               ===============================================
// 
// Copyright(c) 2022. Il Hwan, Jeong. All rights reserved.  (WWW.VS3CODEFACTORY.COM)
//
// Use and redistribution of CODE FACTORY products requires approval from
// CODEFACTORY. Authorization for use and redistribution must be attested
// with license information purchased from CODEFACTORY.
// 
// EXCEPTION NOTICE
//
// If CODEFACTORY uses and redistributes open software binaries and libraries,
// CODEFACTORY will display license rules and exceptions related to open
// software binaries and libraries at the top of the "License.txt" file, and
// comply with the license rules and exceptions.
///////////////////////////////////////////////////////////////////////////////
// File: Enumerations.cs 
// Date: 2022, 10, 2, 오전 12:27
// Project: ModernClasses
// Namespace: ModernClasses.Social
// Author: Marcus - IL HWAN, JEONG (master@vs3codefactory.com)
///////////////////////////////////////////////////////////////////////////////
#endregion
#region Imports
using System;
using System.IO;
using System.Runtime.ConstrainedExecution;
#endregion
#region Program
namespace ModernClasses.Social
{
    #region Residence type
    public enum ResidenceType : int
    {
        Unknown,
        Home,
        Company,
        Office,
        Factory,
        Misc
    }
    #endregion
    #region Classification
    public enum Classification : int
    {
        Unknown = -1,
        ResidenceArea,
        CommericalArea,
        IndustrialArea,
        PublicEntertainmentFacilities,
        PublicInstitution,
        Misc
    }
    #endregion
    #region Gender type
    public enum GenderType
    {
        Unknown = -1,
        Female,
        Male
    }
    #endregion
    #region Contact type
    public enum ContactType
    {
        None = -1,
        InstantMessenger,
        SocialNetworkService,
        Mail,
        MobilePhone,
        HomeTelephone,
        OfficeTelephone,
        Fax,
        PostalService
    }
    #endregion
    #region Case conversion type
    public enum CaseConversionType
    {
        None = -1,
        ToLower,
        ToUpper
    }
    #endregion
    #region PrivacyLevel
    public enum PrivacyLevel : int
    {
        HideAll,
        OpenToPeer,
        OpenToFriend,
        OpenToFamily,
        OpenToDesignatedPersons,
        OpenAll,
    }
    #endregion
    #region Notification mode
    public enum NotificationMode : int
    {
        BeforeAYear,
        BeforeAMonth,
        BeforeAWeek,
        BeforeADay,
        BeforeAHour,
        BeforeTenMinitures,
        BeforeOneMiniture,
        BeforeTenSecond,
        BeforeFiveSecond,
        BeforeOneSecond,
        JustInTime,
        AfterOneSecond,
        AfterFiveSecond,
        AfterTenSecond,
        AfterOneMiniture,
        AfterTenMinitures,
        AfterAHour,
        AfterADay,
        AfterAWeek,
        AfterAMonth,
        AfterAYear
    }
    #endregion
    #region Notification way
    public enum NotificationWay : int
    {
        Buzzer,
        Lighting,
        Vibration,
        Bell,
        Music,
        Video,
        Mail,
        Memo,
        Messenger,
        Call,
        ShortMessageService,
        MultimediaMessageService,
        Push,
        Fax
    }
    #endregion
    #region Notification repeat mode
    public enum NotificationRepeatMode : int
    {
        EveryOneMiniture,
        EveryThreeMinitures,
        EveryFiveMinitures,
        EveryTenMinitures,
        EveryHalfHourMinitures,
        EveryHourMinitures,
        EveryWorkDays,
        EveryWeekend,
        EveryPublicHoliday,
        EveryMemorialDay,
        EverySpecificEventDay,
        EveryDay,
    }
    #endregion
    #region Marriage state
    public enum MarriageState : int
    {
        Single,
        Cohabitation,
        Married
    }
    #endregion 
    #region Job type
    public enum JobType : int
    {
        None = -1,
        Student,
        EducationWorker,
        PrivateCompanyEmployee,
        PrivateCompanyEmploer,
        Capitalist,
        PublicOfficer,
        PoliticalWorker,
        LawWorker,
        HealthCareWorker,
    }
    #endregion
    #region Title type
    public enum TitleType : int
    {
        Intern,                     // 인턴 조수
        Trainee,                    // 인턴/연수생
        Assistant,                  // 어시스턴트 보좌
        PartTime,                   // 아르바이트
        TemporaryEmployee,          // 파견 사원/계약직, NonRegularStaff,
        Staff,                      // 일반 사원, Employee, Member
        AdministrativeManager,      // 주임
        AssistantManager,           // 대리
        GeneralManager,             // 과장, Manager
        TeamManager,                // 팀장, TeamLeader, SectionChief, OfficeManager, HeadOfTeam
        DeputyGeneralManager,       // 차장
        DepartmentManager,          // 부장, ExecutiveManager, DepartmentHead
        HeadManager,                // 본부장, TheDirectorOfTheHeadquarters, DivisionDirector 
        Director,                   // 이사
        ManagingDirector,           // 상무
        SeniorManagingDirector,     // 전무, CFO
        ExecutiveVicePresident,     // 부사장, SeniorVicePresident, DeputyChair, VicePresident
        BranchChief,                // 지점장, BranchManager, BranchOfficeManager, StoreManager
        DeputyBranchManager,        // 부지점장, 지점장 대리
        FactoryDirector,            // 공장장, FactoryManager, PlantManager
        Advisor,                    // 고문
        Engineer,                   // 기사
        Auditor,                    // 감사
        CorporateLawyer,            // 고문 변호사, LegalAdviser, 
        HonoraryChairman,           // 명예 회장
        Secretary,                  // 비서, ExecutiveAssistant
        President,                  // 사장, 대표이사
        Chairman,                   // 회장, ChairmanOfTheBoard, ExecutiveDirector
        ChiefExecutiveOfficer,      // 최고 경영 책임자
        ChiefOperatingOfficer,      // 최고 업무집행 책임자
        ChiefFinancialOfficer,      // 최고 재무 책임자
        ChiefJudicialOfficer,       // 최고 법무 책임자
        ChiefMarketingOfficer,      // 최고 마케팅 책임자
        ChiefInformationOfficer,    // 최고 정보 책임자
        ChiefTechnicalOfficer,      // 최고 기술 책임자, ChiefTechnologyOfficer
    }
    #endregion
    #region Student grade
    public enum StudentGradeType : int
    {
        Unknown = -1,
        Kindergarten,
        Elementary,
        MiddleSchool,
        HighSchool,
        College,
        University,
        GraduateSchool
    }
    #endregion
    #region Student grade
    public enum StudentAcademicAchievementLevel
    {
        Unknown = -1,
        BelowGrade,
        Achieved,
        AboveGrade,
        UpperGrade,
        Highest,
        Genius
    }
    #endregion
}
#endregion