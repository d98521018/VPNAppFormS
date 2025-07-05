using System.ComponentModel.DataAnnotations;

namespace VPNAppFormS.Models
{
    public class StaffProfile
    {
        [Key]
        public int Id { get; set; }

        public string Department { get; set; }

        public string Number { get; set; }

        public string Title { get; set; }

        public string Name { get; set; }

        public string MainLine { get; set; }

        public string Extension { get; set; }

        public string DirectLine { get; set; }

        public string Fax { get; set; }

        public string Account { get; set; } // 登入帳號

        public string Email { get; set; }

        public string Office { get; set; }

        public string Notes { get; set; }
    }

}
