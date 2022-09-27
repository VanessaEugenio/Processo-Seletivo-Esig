
using PS_Esig.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class SDBC
{
    public SDBC()
    { }

    public static MConexaoDBcs Instance
    {
        get
        {
            if (HttpContext.Current.Items["MConexaoDBcs"] == null)
                HttpContext.Current.Items["MConexaoDBcs"] = MConexaoDBcs.Instance();
            return (MConexaoDBcs)HttpContext.Current.Items["MConexaoDBcs"];
        }
    }
}