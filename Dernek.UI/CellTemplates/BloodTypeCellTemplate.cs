using Dernek.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dernek.UI.CellTemplates
{
    public class BloodTypeCellTemplate : DataGridViewTextBoxCell
    {
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context)
        {
            BloodTypes r = (BloodTypes)value;
            return Enum.GetName(typeof(BloodTypes), r);
        }
    }
}
