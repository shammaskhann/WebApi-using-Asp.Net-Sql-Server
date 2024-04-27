using System.ComponentModel.DataAnnotations;

namespace FlutterXsql.Models
{
    public class Users
    {
        [Key]
        public int usedId { get; set; }
        public String name { get; set; }

        public String email { get; set; }   

    }
}
