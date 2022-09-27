using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace App_Data
{
    public class PS_PagCrystal : System.Web.UI.Page
    {     
        public void showRpt(System.Web.UI.Page objPage, String strPath)
        {
            System.Text.StringBuilder strScript = new System.Text.StringBuilder();

            strScript.Append("<script language='javascript'>");            
            strScript.Append("window.open('" + strPath + "', 'Relatorios');");
            strScript.Append("</script>");
            
            ClientScript.RegisterStartupScript(objPage.GetType(),"showRpt", strScript.ToString());            
        }

        
    }
}