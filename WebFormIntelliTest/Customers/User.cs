using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CarsSystem.Data.Models
{
    public class User 
    {
        private ICollection<Car> cars;

        public User()
        {
            this.cars = new HashSet<Car>();
        }
        [Key]
        public string Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string SecondName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        public long EGN { get; set; }

        [Required]
        public int NumberOfIdCard { get; set; }

        [Required]
        public DateTime DateOfIssue { get; set; }

        [Required]
        [MinLength(0)]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        public  string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }

    }
}
