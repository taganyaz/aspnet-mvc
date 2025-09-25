using SocialAssistanceProgram.Core.Application.DTOs;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SocialAssistanceProgram.ViewModels;

public class CreateApplicantViewModel
{
    [DataType(DataType.Date)]
    [DisplayName("Application Date")]
    public DateOnly ApplicationDate { get; set; }

    [StringLength(100)]
    [Required]
    [DisplayName("First Name")]
    public string FirstName { get; set; } = string.Empty;

    [StringLength(100)]
    [Required]
    [DisplayName("Middle Name")]
    public string MiddleName { get; set; } = string.Empty;


    [StringLength(100)]
    [Required]
    [DisplayName("Last Name")]
    public string LastName { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    [DisplayName("Date of Birth")]
    public DateOnly DateOfBirth { get; set; }

    [DisplayName("Gender")]
    public int GenderId { get; set; }

    [DisplayName("Marital Status")]
    public int MaritalStatusId { get; set; }

    [StringLength(50)]
    [DisplayName("ID Number")]
    [Required]
    public string IdNumber { get; set; } = string.Empty;

    [StringLength(200)]
    [DisplayName("Postal Address")]
    public string PostalAddress { get; set; } = string.Empty;

    [StringLength(200)]
    [DisplayName("Physical Address")]
    public string PhysicalAddress { get; set; } = string.Empty;

    [DisplayName("Social Program")]
    public int SocialProgramId { get; set; }

    public readonly List<PhoneContactDto> PhoneContacts = new();

    [DisplayName("County")]
    public int? CountyId { get; set; }

    [DisplayName("Sub County")]
    public int? SubCountyId { get; set; }

    [DisplayName("Location")]
    public int? LocationId { get; set; }

    [DisplayName("Sub Location")]
    public int? SubLocationId { get; set; }

    [DisplayName("Village")]
    public int VillageId { get; set; }

    [DisplayName("Officer")]
    public int OfficerId { get; set; }

    [DataType(DataType.Date)]
    [DisplayName("Signed Date")]
    public DateOnly SignedDate { get; set; }

    public string FullName => $"{FirstName} {MiddleName} {LastName}".Replace("  ", " ").Trim();
}
