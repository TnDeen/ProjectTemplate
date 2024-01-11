using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Domain.ApplicationForms.ValueObjects
{
    public record Address(string Address1, string Address2, string Poscode, string State, string Country)
    {
    }
}
