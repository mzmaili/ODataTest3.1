using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AdminLog.Entities
{
    public class User
    {
        [Key]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string ObjectID { get; set; }
        public DateTimeOffset? deletedDateTime { get; set; }
        public bool? accountEnabled { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string ageGroup { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string city { get; set; }
        public DateTimeOffset? createdDateTime { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string creationType { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string companyName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string consentProvidedForMinor { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string country { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Department { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string displayName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string employeeId { get; set; }
        public DateTimeOffset? employeeHireDate { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string EmployeeOrgData_CostCenter { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string EmployeeOrgData_Division { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string employeeType { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string faxNumber { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string givenName { get; set; }
        public bool? isManagementRestricted { get; set; }
        public bool? isResourceAccount { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string jobTitle { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string legalAgeGroupClassification { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Mail { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string mailNickname { get; set; }
        public int MyProperty { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string mobilePhone { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string onPremisesDistinguishedName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string officeLocation { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string onPremisesDomainName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string onPremisesImmutableId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public DateTimeOffset? onPremisesLastSyncDateTime { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string onPremisesSecurityIdentifier { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string onPremisesSamAccountName { get; set; }
        public bool? onPremisesSyncEnabled { get; set; }
        public string onPremisesUserPrincipalName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string passwordPolicies { get; set; }
        public bool? PasswordProfile_ForceChangePasswordNextSignIn { get; set; }
        public bool? PasswordProfile_ForceChangePasswordNextSignInWithMfa { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string PasswordProfile_Password { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string PasswordProfile_ODataType { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string postalCode { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string preferredDataLocation { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string preferredLanguage { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string preferredName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public DateTimeOffset? refreshTokensValidFromDateTime { get; set; }
        public bool? showInAddressList { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public DateTimeOffset? signInSessionsValidFromDateTime { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string State { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string streetAddress { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Surname { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string usageLocation { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string userPrincipalName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string externalUserState { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string externalUserStateChangeDateTime { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string userType { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute1 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute2 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute3 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute4 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute5 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute6 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute7 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute8 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute9 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute10 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute11 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute12 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute13 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute14 { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string extensionAttribute15 { get; set; }
        public byte photo { get; set; }
        public DateTimeOffset? lastSignInDateTime { get; set; }
        public DateTimeOffset? lastNonInteractiveSignInDateTime { get; set; }
        public DateTimeOffset? lastPasswordChangeDateTime { get; set; }
        [MaxLength(100)]
        public List<string> ImAddresses { get; set; }
        [MaxLength(100)]
        public List<string> otherMails { get; set; }
        [MaxLength(100)]
        public List<string> proxyAddresses { get; set; }
        [MaxLength(100)]
        public List<string> businessPhones { get; set; }
        [MaxLength(100)]
        public List<string> infoCatalogs { get; set; }
        //public virtual ICollection<UserExtension> UserExtension { get; set; }
        public List<UserExtension> UserExtension { get; set; }
        public virtual ICollection<UserAssignedLicense> UserAssignedLicenses { get; set; }
        public virtual ICollection<UserAssignedPlan> UserAssignedPlans { get; set; }
        public virtual ICollection<UserDeviceKey> UserDeviceKeys { get; set; }
        public virtual ICollection<UserIdentity> UserIdentities { get; set; }
        public virtual ICollection<UserOnPremisesProvisioningError> UserOnPremisesProvisioningError { get; set; }
        public virtual ICollection<UserProvisionedPlan> UserProvisionedPlans { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string MFAStatus { get; set; }
    }

    public class UsersCredentialUserRegistrationDetails
    {
        [Key]
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string ObjectID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string userPrincipalName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string userDisplayName { get; set; }
        public bool? isRegistered { get; set; }
        public bool? isEnabled { get; set; }
        public bool? isCapable { get; set; }
        public bool? isMfaRegistered { get; set; }
        public List<string> authMethods { get; set; }
    }


    public class UserExtension
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string ExtensionName { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Extensionvalue { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }
        
        //public virtual User User { get; set; }
    }

    public class UserAssignedLicense
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string skuId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }

        //public virtual User User { get; set; }
        //public virtual ICollection<UserDisabledPlan> UserDisabledPlans { get; set; }
        public List<UserDisabledPlan> UserDisabledPlans { get; set; }

    }

    public class UserDisabledPlan
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string value { get; set; }
        [ForeignKey("UserAssignedLicenseID")]
        public int UserAssignedLicenseID { get; set; }
        //public virtual UserAssignedLicense UserAssignedLicenses { get; set; }
    }

    public class UserAssignedPlan
    {
        [Key]
        public int ID { get; set; }
        public DateTimeOffset? assignedDateTime { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string capabilityStatus { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Service { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string servicePlanId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }

        //public virtual User User { get; set; }
    }

    public class UserDeviceKey
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string keyType { get; set; }
        [MaxLength(500)]
        [Column(TypeName = "varchar(500)")]
        public string keyMaterial { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string deviceId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }

        //public virtual User User { get; set; }
    }

    public class UserIdentity
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string signInType { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Issuer { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string issuerAssignedId { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }

        //public virtual User User { get; set; }
    }

    public class UserOnPremisesProvisioningError
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Category { get; set; }
        public DateTimeOffset? OccurredDateTime { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string PropertyCausingError { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string Value { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }

        //public virtual User User { get; set; }
    }

    public class UserProvisionedPlan
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string capabilityStatus { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string provisioningStatus { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        public string service { get; set; }
        [MaxLength(100)]
        [Column(TypeName = "varchar(100)")]
        [ForeignKey("UserObjectID")]
        public string UserObjectID { get; set; }

        //public virtual User User { get; set; }
    }

}
