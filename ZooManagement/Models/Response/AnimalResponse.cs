using System;
using ZooManagement.Models.Database;

namespace ZooManagement.Models.Response
{
    public class AnimalResponse
    {
        private readonly Animal _animal;

        public AnimalResponse(Animal animal)
        {
            _animal = animal;
        }

        public int Id => _animal.Id;
        
        public string Name => _animal.Name;
        
        public string Species => _animal.Species;
        
        public ClassificationType Classification => _animal.Classification;
        
        public SexType Sex => _animal.Sex;
        
        public DateTime DateOfBirth => _animal.DateOfBirth;
        
        public DateTime DateAcquired => _animal.DateAcquired;
    }
}