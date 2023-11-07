﻿using Microsoft.EntityFrameworkCore;
using ProjetoInterdisciplinarConcessionariaDriveTIme.Models;

namespace ProjetoInterdisciplinarConcessionariaDriveTIme.Data
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) 
            :base(options) 
        { 

        }
        
        public DbSet<Usuario> Usuario { get; set; }

        
    }
}
