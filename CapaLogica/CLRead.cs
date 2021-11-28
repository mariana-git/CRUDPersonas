using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using System.Data;

namespace CapaLogica
{
    public class CLRead
    {
        public string Parameter { private get;  set; }
        public string IDPersona { private get; set; }
        public string Table { private get; set; }
        public string Description { private get; set; }
        public string Condition { private get; set; }
        public string Column { private get; set; }

        readonly CDRead cDRead = new CDRead();

        public DataTable Personas_Read()
        {
            if(Parameter == "")
            {
                return cDRead.Personas_ReadAll();
            }
            else
            {
                cDRead.Nombre = Parameter;
                cDRead.Apellido = Parameter;
                if (int.TryParse(Parameter, out int ParamInt))
                {
                    cDRead.Doc = ParamInt;
                    cDRead.IDPersona = ParamInt;
                }                   
                else cDRead.Doc = 0000000000;
                return cDRead.Personas_Search();
            }
        }
        public DataTable PersTel_Read()
        {
            if (int.TryParse(IDPersona, out int idPersona))
            {
                cDRead.IDPersona = idPersona;
                return cDRead.PersTel_Search();
            }
            else return null; 
        }
        public DataTable CMBLoad()
        {
            if (Table == "" || Description == "")
            {
                return null;
            }
            else
            {
                cDRead.Description = Description;
                cDRead.Table = Table;
                if (string.IsNullOrEmpty(Condition) 
                    || !int.TryParse(Condition, out int condition) || string.IsNullOrEmpty(Column))
                {                    
                    return cDRead.CMBLoad_ReadAll();
                }
                else
                {
                    cDRead.Condition = condition;
                    cDRead.Column = Column;
                    return cDRead.CMBLoad_Search();
                }
            }
        }
        public bool CMB_Verify(int idLoc)
        {
            if (cDRead.CMBLoad_Verify(idLoc).Rows.Count > 0) return true;
            else return false;
        }
    }
}
