using Elsa.Persistence.Specifications;
using Elsa.Secrets.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Elsa.Secrets.Persistence.Specifications
{
    public class SecretsIdSpecification : Specification<Secret>
    {
        public string Id { get; set; }

        public SecretsIdSpecification(string id)
        {
            Id = id;
        }

        public override Expression<Func<Secret, bool>> ToExpression() => x => x.Id == Id;
    }
}
