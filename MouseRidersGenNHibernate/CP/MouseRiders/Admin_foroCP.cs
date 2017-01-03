
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using MouseRidersGenNHibernate.Exceptions;
using MouseRidersGenNHibernate.EN.MouseRiders;
using MouseRidersGenNHibernate.CAD.MouseRiders;
using MouseRidersGenNHibernate.CEN.MouseRiders;


namespace MouseRidersGenNHibernate.CP.MouseRiders
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
