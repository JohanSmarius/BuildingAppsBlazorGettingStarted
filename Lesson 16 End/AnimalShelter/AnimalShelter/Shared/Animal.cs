using System;

namespace AnimalShelter.Shared
{
    public class Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int Age
        {
            get
            {
                if (DateOfBirth.HasValue)
                {
                    var calculatedAge = DateTime.Today.Year - DateOfBirth.Value.Year;

                    if (DateTime.Today.DayOfYear < DateOfBirth.Value.DayOfYear)
                    {
                        calculatedAge -= 1;
                    }

                    return calculatedAge;
                }

                return EstimatedAge.Value;
            }
        }

        public int? EstimatedAge { get; set; }

        public AnimalKind AnimalKind { get; set; }

        public string PictureUrl { get; set; }

        public Gender Gender { get; set; }
    }
}
