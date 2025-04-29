using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repaso2.Models;

    public class DEMO03 : DbContext
    {
        public DEMO03 (DbContextOptions<DEMO03> options)
            : base(options)
        {
        }

        public DbSet<Repaso2.Models.Carrera> Carrera { get; set; } = default!;

public DbSet<Repaso2.Models.Estudiante> Estudiante { get; set; } = default!;

public DbSet<Repaso2.Models.Facultad> Facultad { get; set; } = default!;

public DbSet<Repaso2.Models.Materia> Materia { get; set; } = default!;

public DbSet<Repaso2.Models.Profesor> Profesor { get; set; } = default!;
    }
