using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDExample.Models
{
    public class Member
    {
        [Key]
        [MinLength(8)]
        public string Account { get; set; }

        [Required]
        public string Sex { get; set; }

        [MinLength(8)]
        [Required]
        public string Password { get; set; }

        [MinLength(8)]
        public string Email { get; set; }

        [MinLength(8)]
        [Required]
        public string Addres { get; set; }

        [MinLength(10)]
        [Required]
        public int Phone { get; set; }
        /*public enum AddresFlags
        {
            /// <summary>
            /// 正常
            /// </summary>
            Normal,
            /// <summary>
            /// 警示
            /// </summary>
            Warn,
            /// <summary>
            /// 異常
            /// </summary>
            Error
        }*/
    }
}
