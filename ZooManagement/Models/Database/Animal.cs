using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagement.Models.Database
{
    public enum ClassificationType
    {
        Mammal,
        Reptile,
        Bird,
        Insect,
        Fish,
        Invertebrate
    }

    public enum SexType
    {
        Male,
        Female
    }
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Species { get; set; }
        public ClassificationType Classification { get; set; }
        public string Name { get; set; }
        public SexType Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateAcquired { get; set; }
    }
}