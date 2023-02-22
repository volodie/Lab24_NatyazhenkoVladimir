using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CodeFirst.Models
{
    public class FirstClass
    {
        [Key]
        public int FirstProperty { get; set; }
        [DataMember]
        public string SecondProperty { get; set; }
    }
}
