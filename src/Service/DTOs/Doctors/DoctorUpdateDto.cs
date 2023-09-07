﻿using Service.DTOs.Attachments;
using Service.DTOs.Hospitals;

namespace Service.DTOs.Doctors;

public class DoctorUpdateDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Score { get; set; }
    public string Specialization { get; set; } // Shifokorning mutaxassisligi
    public string LicenseNumber { get; set; }
    public AttachmentResultDto Attachment { get; set; }
    public HospitalResultDto Hospital { get; set; }
}
