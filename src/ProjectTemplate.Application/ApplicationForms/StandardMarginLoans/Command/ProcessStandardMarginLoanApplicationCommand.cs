using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectTemplate.Application.ApplicationForms.StandardMarginLoans.Command
{
    public sealed record ProcessStandardMarginLoanApplicationCommand(string Email, string IdentityNumber, string Advisorcode) : IRequest<Guid>
    {
    }
}
