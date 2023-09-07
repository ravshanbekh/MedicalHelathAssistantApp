﻿using Domain.Enums;

namespace Service.DTOs.Analyses;

public class AnalyseCreationDto
{
    public long UserId { get; set; }
    public long DoctorId { get; set; }
    public long MedicalRecordId { get; set; }
    public AnalyseType AnalyseType { get; set; }
    public string Description { get; set; }
    public long AttachmetId { get; set; }
}
