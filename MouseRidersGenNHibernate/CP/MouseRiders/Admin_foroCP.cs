
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
public partial class Admin_foroCP : BasicCP
{
public Admin_foroCP() : base ()
{
}

public Admin_foroCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
