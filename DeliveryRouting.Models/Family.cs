using System;
using System.ComponentModel.DataAnnotations;

namespace DeliveryRouting.Models
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        public string FamilyId { get; set; }
        public string InitialId { get; set; }
        public string Cm { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string NumberAttendingThanksgiving { get; set; }
        public string Notes { get; set; }
        public string InformationUpdateNotes { get; set; }
        public string RouteAssignment { get; set; }
        public string AssignmentNotes { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Route Route { get; set; }
    }
}
