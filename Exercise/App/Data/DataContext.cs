using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App.Data;


public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<ExerciseModel> Exercises { get; set; }
}