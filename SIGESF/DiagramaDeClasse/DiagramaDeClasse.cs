using SIGESF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace SIGESF.DiagramaDeClasse
{
    public static class DiagramaDeClasse
    {
        public static void GerarDiagrama()
        {
            using (var ctx = new ContextoEF())
            {
                using (var writer = new XmlTextWriter(@"C:\Users\Roberto\Source\Repos\SIGESF_V4\SIGESF\DiagramaDeClasse\Model.edmx", Encoding.Default))
                {
                    EdmxWriter.WriteEdmx(ctx, writer);
                }
            }
        }
    }
}