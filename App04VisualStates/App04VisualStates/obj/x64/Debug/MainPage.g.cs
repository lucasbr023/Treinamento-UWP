﻿#pragma checksum "C:\Users\lmc3\Documents\GitHub\Treinamento-UWP\App04VisualStates\App04VisualStates\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ED7A5865B6D518D916047F2BA50E622F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App04VisualStates
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 22
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3: // MainPage.xaml line 23
                {
                    this.Normal = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // MainPage.xaml line 31
                {
                    this.StateNoContent = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // MainPage.xaml line 38
                {
                    this.StateLoading = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6: // MainPage.xaml line 53
                {
                    this.textBlockContent = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // MainPage.xaml line 54
                {
                    this.loading = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 8: // MainPage.xaml line 48
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element8 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element8).Checked += this.GoToNormalState;
                }
                break;
            case 9: // MainPage.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element9 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element9).Checked += this.GoToNoContentState;
                }
                break;
            case 10: // MainPage.xaml line 50
                {
                    global::Windows.UI.Xaml.Controls.RadioButton element10 = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)element10).Checked += this.GoToLoadingState;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

