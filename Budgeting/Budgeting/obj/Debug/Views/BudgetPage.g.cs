﻿

#pragma checksum "C:\Users\Asif\Documents\Visual Studio 2013\Projects\Budgeting\Budgeting\Views\BudgetPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9AB6C7D50F57045896067B5C40B5A549"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Budgeting.Views
{
    partial class BudgetPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 20 "..\..\Views\BudgetPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.AddBudget_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 31 "..\..\Views\BudgetPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 28 "..\..\Views\BudgetPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListPickerFlyout)(target)).ItemsPicked += this.DeletingBudgetChosen;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 23 "..\..\Views\BudgetPage.xaml"
                ((global::Windows.UI.Xaml.Controls.ListPickerFlyout)(target)).ItemsPicked += this.EditingBudgetChosen;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 55 "..\..\Views\BudgetPage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).LostFocus += this.SubmitPassword;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 50 "..\..\Views\BudgetPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.NavigateToHome;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


