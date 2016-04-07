using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.NHibernateHttpModule
{
    public class NHibernateHttpModule
    {
        public static readonly string KEY = "NHibernateSession";
        private static ISession _session;

        private void context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Items[KEY] = OpenSession();
        }

        private void context_EndRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;

            ISession session = context.Items[KEY] as ISession;
            if (session != null)
            {
                try
                {
                    session.Flush();
                    session.Close();
                }
                catch { }
            }
            context.Items[KEY] = null;
        }

        public static ISession CurrentSession
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    if (_session != null)
                    {
                        return _session;
                    }
                    else
                    {
                        _session = OpenSession();
                        return _session;
                    }
                }
                else
                {
                    HttpContext currentContext = HttpContext.Current;
                    ISession session = currentContext.Items[KEY] as ISession;
                    if (session == null)
                    {
                        session = OpenSession();
                        currentContext.Items[KEY] = session;
                    }
                    return session;
                }
            }
        }
    }
}
