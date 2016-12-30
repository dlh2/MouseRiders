
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using MRModel.Exceptions;
using MRModel.EN;
using MRModel.CAD;
using MRModel.CEN;


namespace MRModel.CP
{
public partial class RedactorCP : BasicCP
{
public RedactorCP() : base ()
{
}

public RedactorCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
