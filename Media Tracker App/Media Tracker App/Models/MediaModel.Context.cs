﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Media_Tracker_App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Media_ListsEntities : DbContext
    {
        public Media_ListsEntities()
            : base("name=Media_ListsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anime___Cartoons> Anime___Cartoons { get; set; }
        public virtual DbSet<Completed_Manga___Manwah> Completed_Manga___Manwah { get; set; }
        public virtual DbSet<Live_Action_TV_Shows> Live_Action_TV_Shows { get; set; }
        public virtual DbSet<Manga___Manwah> Manga___Manwah { get; set; }
        public virtual DbSet<Movies> Movies { get; set; }
        public virtual DbSet<Video_Games> Video_Games { get; set; }
    }
}