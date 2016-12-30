
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
public partial class MensajeCP : BasicCP
{
public MensajeCP() : base ()
{
}

public MensajeCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
