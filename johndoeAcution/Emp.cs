//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace johndoeAcution
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Emp()
        {
            this.Certificates = new HashSet<Certificate>();
        }
    
        public int Id { get; set; }
        public string EmpNo { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public System.DateTime HireDate { get; set; }
        public int Salary { get; set; }
        public Nullable<int> Bonus { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<int> DeptId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual Dept Dept { get; set; }
    }
}