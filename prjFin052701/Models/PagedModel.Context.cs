﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjFin052701.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Common;//新增
    using System.Data.Entity.Core.EntityClient;//新增
    using System.Configuration;//新增


    public partial class PagedEntities : DbContext
    {
        public PagedEntities() 
            : base("name=PagedEntities")
        {
            //以下均為新增
            var originalConnectionString = ConfigurationManager.ConnectionStrings["PagedEntities"].ConnectionString;//修改Entities名稱
        var entityBuilder = new EntityConnectionStringBuilder(originalConnectionString);
        var factory = DbProviderFactories.GetFactory(entityBuilder.Provider);
        var providerBuilder = factory.CreateConnectionStringBuilder();

        providerBuilder.ConnectionString = entityBuilder.ProviderConnectionString;

            providerBuilder.Add("Password", "yzuim1102netdbB"); // 加入SQL密碼資料

            entityBuilder.ProviderConnectionString = providerBuilder.ToString();

            this.Database.Connection.ConnectionString = entityBuilder.ProviderConnectionString;

        }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<TablePageds1091711> TablePageds1091711 { get; set; }
    }
}
