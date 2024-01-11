using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Domain.ApplicationForms.Aggregates
{
    public class StandardMarginLoanForm : BaseForm
    {
        public StandardMarginLoanForm(Guid id, string email, string advisorCode) : base(id)
        {
            Email = email;
            AdvisorCode = advisorCode;
        }

        public string Email { get; }
        public string AdvisorCode { get; }

        public static StandardMarginLoanForm Create(Guid id, string email, string advisorCode)
        {
            //validate
            if(Guid.Empty == id)
                id = Guid.NewGuid();

            var form = new StandardMarginLoanForm(id, email, advisorCode);

            return form;
        }
    }
}
