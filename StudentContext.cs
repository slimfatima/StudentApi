﻿using Microsoft.EntityFrameworkCore;
using StudentApi.Model;

namespace StudentApi
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
