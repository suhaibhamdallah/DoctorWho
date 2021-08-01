using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new DoctorWhoCoreDbContext())
            {
                
            }
        }
    }
}
