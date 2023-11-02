using Core;

namespace Core
{
    using System;

    public partial class Scope
    {
        public static void AdvanceLinkedListCollapse(String Item_Onefirst, String Item_TwoSecond, String Item_Threethird, String Item_FourFourth, String Item_Fivefifth, String Item_Sixsixth)
        {
            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[0] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Item_Onefirst;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[1] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Item_TwoSecond;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[2] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Item_Threethird;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[3] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Item_FourFourth;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[4] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Item_Fivefifth;

            ((ScopeDisplayContext.Instance.ScopeDisplayArrayList[5] as ScopeDisplay).Controls[0] as ScopeTextBox).Text = Item_Sixsixth;

            Tuple<String, String, String, String, String, String> tuple;

            tuple = new Tuple<String, String, String, String, String, String>(Item_Onefirst, Item_TwoSecond, Item_Threethird, Item_FourFourth, Item_Fivefifth, Item_Sixsixth);

            AdvanceLinkedList(tuple);

            return;
        }
    }
}
