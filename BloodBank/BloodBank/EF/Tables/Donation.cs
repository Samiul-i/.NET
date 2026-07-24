using System;
using System.Collections.Generic;

namespace BloodBank.EF.Tables;

public partial class Donation
{
    public string DonationId { get; set; } = null!;

    public int DonorId { get; set; }

    public DateOnly DonationDate { get; set; }

    public string VolumeMl { get; set; } = null!;

    public string CampName { get; set; } = null!;

    public virtual Donor Donor { get; set; } = null!;
}
