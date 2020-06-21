using IdentityModel;
using IdentityServer4;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class TestUsers
    {
        public static List<TestUser> Users = new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "818727", Username = "navaneeswar", Password = "manam",
                Claims=new List<Claim>
                {
                    new Claim(JwtClaimTypes.Name,"Manam Navaneeswar"),
                    new Claim(JwtClaimTypes.GivenName,"Navaneeswar"),
                    new Claim(JwtClaimTypes.FamilyName,"Manam"),
                    new Claim(JwtClaimTypes.Email, "eswarbe2009@gmail.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'pulabavi Street', 'locality': 'Badvel', 'postal_code': 516227, 'country': 'IndiaS' }", IdentityServerConstants.ClaimValueTypes.Json)
                }
            },
            new TestUser{SubjectId = "88421113", Username = "ram", Password = "raj",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "ram raj"),
                    new Claim(JwtClaimTypes.GivenName, "ram"),
                    new Claim(JwtClaimTypes.FamilyName, "raj"),
                    new Claim(JwtClaimTypes.Email, "ramraj@gmail.com"),
                    new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                    new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'YousafGuda', 'locality': 'Hyderabad', 'postal_code': 500001, 'country': 'India' }", IdentityServerConstants.ClaimValueTypes.Json),
                    new Claim("location", "Hyderabad")
                }
            }
        };
    }
}
