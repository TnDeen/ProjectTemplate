using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Application.ApplicationForms.StandardMarginLoans.Queries
{
    public sealed record class SearchStandardMarginLoanApplicationQuery : IRequest<Guid>
    {
    }

    public sealed record class StandardMarginLoanApplicationResponse
    {
    }
}
