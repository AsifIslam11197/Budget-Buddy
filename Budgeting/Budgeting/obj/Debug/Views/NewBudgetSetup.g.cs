﻿

#pragma checksum "C:\Users\Asif\Documents\Visual Studio 2013\Projects\Budgeting\Budgeting\Views\NewBudgetSetup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "76960192BC68FA4A2D60FE531D66E52C"
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
    partial class NewBudgetSetup : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 13 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 14 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Complete_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 37 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.RB_Checked;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 38 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.RB_Checked;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 39 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.RB_Checked;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 40 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.RB_Checked;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 31 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.DatePicker_Loaded;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 26 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Unchecked += this.BudgetPwCheckBox_State;
                 #line default
                 #line hidden
                #line 26 "..\..\Views\NewBudgetSetup.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.BudgetPwCheckBox_State;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

