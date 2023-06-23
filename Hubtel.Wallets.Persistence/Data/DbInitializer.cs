using Hubtel.Wallets.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hubtel.Wallets.Persistence.Data
{
    public class DbInitializer
    {
        public static void Initialize(HubtelDbContext context)
        {
            context.Database.EnsureCreated(); // Automatically create db

            // Look for any wallets
            if (context.Wallets.Any())
            {
                return; // Db has been seeded
            }

            var wallets = new Wallet[]
            {
                new Wallet { Name="Jo_Wallet", PymtTypeIdfk=1, AccSchemeIdfk=1, AccountNumber="211095474836832", PhoneNumber="0548003576", CreationDate=DateTime.Parse("2022-04-28")},
                new Wallet { Name="Eugenia_Wallet", PymtTypeIdfk=2, AccSchemeIdfk=4, AccountNumber="432660317441328", PhoneNumber="0577927224", CreationDate=DateTime.Parse("2022-11-20")},
            };

            foreach(Wallet wallet in wallets)
            {
                context.Wallets.Add(wallet);
            }
            context.SaveChanges();



            var paymentTypes = new PaymentType[]
            {
                new PaymentType{ Name="Mobile Money", CreationDate=DateTime.Parse("2022-04-28")},
                new PaymentType{ Name="Card", CreationDate=DateTime.Parse("2022-11-20")},
            };
            foreach (PaymentType paymentType in paymentTypes)
            {
                context.PaymentTypes.Add(paymentType);
            }
            context.SaveChanges();



            var accountSchemes = new AccountScheme[]
            {
                new AccountScheme{ Name="mtn", CreationDate=DateTime.Parse("2022-04-28") },
                new AccountScheme{ Name="visa", CreationDate=DateTime.Parse("2022-11-20") },
            };
            foreach (PaymentType paymentType in paymentTypes)
            {
                context.PaymentTypes.Add(paymentType);
            }
            context.SaveChanges();
        }
    }
}
