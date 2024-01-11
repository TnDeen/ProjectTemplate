using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Application.ApplicationForms.StandardMarginLoans.Command
{
    public class ProcessStandardMarginLoanApplicationHandler : IRequestHandler<ProcessStandardMarginLoanApplicationCommand, Guid>
    {
        public async Task<Guid> Handle(ProcessStandardMarginLoanApplicationCommand request, CancellationToken cancellationToken)
        {
            return Guid.NewGuid();
        }
    }
}
