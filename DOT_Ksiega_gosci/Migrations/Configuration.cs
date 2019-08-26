namespace DOT_Ksiega_gosci.Migrations
{
    using DOT_Ksiega_gosci.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DOT_Ksiega_gosci.Models.RegistrationDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DOT_Ksiega_gosci.Models.RegistrationDBContext context)
        {
            context.Registrations.AddOrUpdate(i => i.FirstName,
                new Registration
                {
                    FirstName = "Marry",
                    LastName = "Koks",
                    Gender = "Female",
                    ReleaseDate = DateTime.Parse("1999-6-11"),
                    Contents = "Ekstra obsluga, pozdrawiam pana z baru."
                },

                new Registration
                {
                    FirstName = "Wiliam",
                    LastName = "Mops",
                    Gender = "Male",
                    ReleaseDate = DateTime.Parse("1979-7-19"),
                    Contents = "DO bani!"
                },

                new Registration
                {
                    FirstName = "Jola",
                    LastName = "Dorczak",
                    Gender = "Female",
                    ReleaseDate = DateTime.Parse("2012-3-16"),
                    Contents = "Fajny hotel"
                },

                new Registration
                {
                    FirstName = "Jan",
                    LastName = "Zamojski",
                    Gender = "Male",
                    ReleaseDate = DateTime.Parse("1999-7-11"),
                    Contents = "Najlepszy kawalerski ever!"
                }
           );
        }
    }
}