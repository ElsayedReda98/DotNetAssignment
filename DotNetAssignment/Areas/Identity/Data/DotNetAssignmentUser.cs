using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAssignment.Areas.Identity.Data;

// Add profile data for application users by adding properties to the DotNetAssignmentUser class
public class DotNetAssignmentUser : IdentityUser
{
    [PersonalData]
    public string Name { get; set; }

    [PersonalData]
    public string PhoneNumber { get; set; }

    [NotMapped]
    public int? PictureId { get; set; }


}

