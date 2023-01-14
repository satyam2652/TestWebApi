using System;

namespace Test.Models.Models
{
    internal class DepartmentsModel
    {
    }
    public class DepartmentsMst
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

    }
}
