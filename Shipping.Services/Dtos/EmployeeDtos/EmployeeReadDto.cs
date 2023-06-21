﻿using Shipping.Entities.Domain.Models;
using Shipping.Entities.Migrations;
using System.ComponentModel.DataAnnotations;

namespace Shipping.Services.Dtos
{
    public record EmployeeReadDto
    {
        public long EmployeeId { get; init; }

        [Required]
        [StringLength(70)]
        public  string Name { get; init; } = string.Empty;
        public  string Email { get; init; } = string.Empty;
        public  string UserName { get; init; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public  string Password { get; init; } = string.Empty;
        public  bool IsActive { get; init; }

        [Phone]
        public string? PhoneNumber { get; init; } 

       // public string PrivellgeName { get ; init; } = string.Empty;
       // public string branchName { get; init; } = string.Empty;

        public BranchReadDto? Branch { get; init ; }  
        public PrivellageDto? Privellage { get; init;}

       
    }
}
