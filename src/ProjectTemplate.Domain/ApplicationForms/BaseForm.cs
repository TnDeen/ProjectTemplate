using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTemplate.Domain.ApplicationForms
{
    public abstract class BaseForm
    {
        public BaseForm(Guid id)
        {
            Id = id;
        }
        public Guid Id { get;}
    }
}
