﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class johndoeDb : DbContext
    {
        public johndoeDb()
            : base("name=johndoeDb")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<소분류> 소분류 { get; set; }
        public virtual DbSet<제품_테이블> 제품_테이블 { get; set; }
        public virtual DbSet<중분류> 중분류 { get; set; }
        public virtual DbSet<대분류> 대분류 { get; set; }
    }
}
