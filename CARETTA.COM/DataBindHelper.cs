using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CARETTA.COM
{
    public class DataBindHelper
    {
        public static void BindListbox(ref System.Web.UI.WebControls.ListBox ListBoxControl, DataTable dt, string DataTextField, string DataValueField, params string[] SelectedValues)
        {
            ListBoxControl.DataTextField = DataTextField;
            ListBoxControl.DataValueField = DataValueField;
            ListBoxControl.DataSource = dt;
            ListBoxControl.DataBind();
            for (int i = 0; i < SelectedValues.Length; i++)
            {
                for (int j = 0; j < ListBoxControl.Items.Count; j++)
                {
                   ListBoxControl.Items[j].Selected = (ListBoxControl.Items[j].Value == SelectedValues[i].ToString());
                }
            }
        }

        /// <summary>
        /// Checkbox list DataBind
        /// </summary>
        /// <param name="chControl">chList</param>
        /// <param name="dt">Datasource Datatable</param>
        /// <param name="DataTextField">G�r�nt�lenecek H�cre</param>
        /// <param name="DataValueField">Value H�cre</param>
        public static void BindCheckBoxList(ref System.Web.UI.WebControls.CheckBoxList chControl, DataTable dt, string DataTextField, string DataValueField)
        {
            chControl.DataTextField = DataTextField;
            chControl.DataValueField = DataValueField;
            chControl.DataSource = dt;
            chControl.DataBind();
        }

        public static void BindRadioButtonList(ref System.Web.UI.WebControls.RadioButtonList rdControl, DataTable dt, string DataTextField, string DataValueField, string SelectedValue)
        {
            rdControl.DataTextField = DataTextField;
            rdControl.DataValueField = DataValueField;
            rdControl.DataSource = dt;
            rdControl.DataBind();
            if (SelectedValue != String.Empty) {
                rdControl.SelectedValue = SelectedValue;
            }
        }


        /// <summary>
        /// DropDown Bound Ba�lang�� Item YOK
        /// </summary>
        /// <param name="ddlControl">Dropdownlist</param>
        /// <param name="dt">Datasource Datatable</param>
        /// <param name="DataTextField">G�r�nt�lenecek H�cre</param>
        /// <param name="DataValueField">Value H�cre</param>
        /// <param name="SelectedValue">Se�ili H�cre</param>
        public static void BindDDL(ref System.Web.UI.WebControls.DropDownList ddlControl, DataTable dt, string DataTextField, string DataValueField, string SelectedValue)
        {
            BindDDL(ref ddlControl, dt, DataTextField, DataValueField, SelectedValue, "", "");
        }

        /// <summary>
        /// DropDown Bound Ba�lang�� Item VAR
        /// </summary>
        /// <param name="ddlControl">Dropdownlist</param>
        /// <param name="dt">Datasource Datatable</param>
        /// <param name="DataTextField">G�r�nt�lenecek H�cre</param>
        /// <param name="DataValueField">Value H�cre</param>
        /// <param name="SelectedValue">Se�ili H�cre</param>
        /// <param name="InitialValueText">Ba�lang�� Item Text</param>
        /// <param name="InitialValue">Ba�lang�� item value</param>
        public static void BindDDL(ref System.Web.UI.WebControls.DropDownList ddlControl, DataTable dt, string DataTextField, string DataValueField, string SelectedValue, string InitialValueText, string InitialValue)
        {
            ddlControl.DataTextField = DataTextField;
            ddlControl.DataValueField = DataValueField;
            ddlControl.DataSource = dt;
            ddlControl.DataBind();
            if (InitialValueText != "")
            {
                ddlControl.Items.Insert(0, new System.Web.UI.WebControls.ListItem(InitialValueText, InitialValue));
            }
            if (SelectedValue != "")
            {
                ddlControl.SelectedValue = SelectedValue;
            }
        }

        /// <summary>
        /// DROPDOWNLIST I VALUE �LE TEXT AYNI OLACAK �EK�LDE RAKAM �LE DOLDURUR.
        /// </summary>
        /// <param name="ddl">DropDownlList Ref Parametre</param>
        /// <param name="count">Ka�a kadar?</param>
        public static void LoadNumberDDL(ref System.Web.UI.WebControls.DropDownList ddl, int count)
        {
            LoadNumberDDL(ref ddl, count, 1, 1, false);
        }

        /// <summary>
        /// DROPDOWNLIST I VALUE �LE TEXT AYNI OLACAK �EK�LDE RAKAM �LE DOLDURUR.
        /// </summary>
        /// <param name="ddl">DropDownlList Ref Parametre</param>
        /// <param name="count">Ka�a kadar?</param>
        /// <param name="count">Tek Hanelilerin Soluna '0' eklensin mi?</param>
        public static void LoadNumberDDL(ref System.Web.UI.WebControls.DropDownList ddl, int count, bool PadLeft)
        {
            LoadNumberDDL(ref ddl, count, 1, 1, PadLeft);
        }

        /// <summary>
        /// DROPDOWNLIST I VALUE �LE TEXT AYNI OLACAK �EK�LDE RAKAM �LE �STENEN SAYIDA ARTARAK DOLDURUR.
        /// </summary>
        /// <param name="ddl">DropDownlList Ref Parametre</param>
        /// <param name="Count">Ka�a kadar?</param>
        /// <param name="Step">Ka� Ka� Arts�n?</param>
        /// <param name="StartNumber">Ka�tan Ba�las�n?</param>
        public static void LoadNumberDDL(ref System.Web.UI.WebControls.DropDownList ddl, int Count, int Step, int StartNumber)
        {
            LoadNumberDDL(ref ddl, Count, Step, StartNumber, false);
        }
        
        /// <summary>
        /// DROPDOWNLIST I VALUE �LE TEXT AYNI OLACAK �EK�LDE RAKAM �LE �STENEN SAYIDA ARTARAK DOLDURUR.
        /// </summary>
        /// <param name="ddl">DropDownlList Ref Parametre</param>
        /// <param name="Count">Ka�a kadar?</param>
        /// <param name="Step">Ka� Ka� Arts�n?</param>
        /// <param name="StartNumber">Ka�tan Ba�las�n?</param>
        /// <param name="count">Tek Hanelilerin Soluna '0' eklensin mi?</param>
        public static void LoadNumberDDL(ref System.Web.UI.WebControls.DropDownList ddl, int Count, int Step, int StartNumber, bool PadLeft)
        {
            ddl.Items.Clear();
            int Var = 0;
            for (int i = StartNumber; i <= Count; i += Step)
            {
                Var = Math.Abs(i);
                if (!PadLeft)
                {
                    ddl.Items.Add(new System.Web.UI.WebControls.ListItem(Var.ToString(), Var.ToString()));
                }
                else
                {
                    ddl.Items.Add(new System.Web.UI.WebControls.ListItem(Var.ToString().PadLeft(2, '0'), Var.ToString().PadLeft(2, '0')));
                }
            }
        }

        public static void BindRepeater(ref System.Web.UI.WebControls.Repeater Repeater, DataTable dtData) {
            Repeater.DataSource = dtData;
            Repeater.DataBind();
        }
    }
}
